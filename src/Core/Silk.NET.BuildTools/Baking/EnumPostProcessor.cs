﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Attribute = Silk.NET.BuildTools.Common.Attribute;

namespace Silk.NET.BuildTools.Baking;

public static class EnumPostProcessor
{
    private static readonly HashSet<string> _forbiddenTrimmings = new() { "unsigned", "per" };

    public static void Process(Profile profile, BindTask task)
    {
        StripCommonPrefix(profile, task);
        AddNoneFlags(profile);
    }

    private static void AddNoneFlags(Profile profile)
    {
        foreach (var @enum in from project in profile.Projects.Values
                 from @enum in project.Enums
                 where @enum.Attributes.Any(x => x.Name is "System.Flags" or "Flags") &&
                       @enum.Tokens.All(x => x.Name is not "None")
                 select @enum)
        {
            @enum.Tokens.Insert(0, new Token { Name = "None", Value = "0" });
        }
    }

    private static void StripCommonPrefix(Profile profile, BindTask task)
    {
        if (profile.Name == "OpenCL")
        {
            // done at the convert/construct level
            return;
        }
        
        foreach (var @enum in profile.Projects.Values.SelectMany(x => x.Enums))
        {
            if (@enum.Tokens.Count == 0)
            {
                continue;
            }

            var testName = @enum.NativeName;
            if (!testName.Contains('_'))
            {
                testName = testName.Underscore();
            }
            
            var prefix = @enum.Tokens.Count == 1
                ? Utilities.FindCommonPrefix
                    (new List<string> { @enum.Tokens[0].NativeName, testName }, true, false)
                : Utilities.FindCommonPrefix(@enum.Tokens.Select(x => x.NativeName).ToList(), false, false);

            if (@enum.Tokens.Any(x => x.NativeName.Length <= prefix.Length))
            {
                // Second pass, put the enum name in the loop to see if it makes a difference
                prefix = Utilities.FindCommonPrefix
                (
                    @enum.Tokens.Select(x => x.NativeName).Concat(Enumerable.Repeat(testName, 1)).ToList(),
                    false, false
                );
            }

            if (@enum.Tokens.Any(x => x.NativeName.Length <= prefix.Length))
            {
                // Skip
                continue;
            }

            foreach (var word in _forbiddenTrimmings)
            {
                if (prefix.StartsWith($"{word}_"))
                {
                    prefix = string.Empty; // skip it
                }

                var idx = prefix.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
                if (idx != -1)
                {
                    prefix = prefix[..idx];
                }
            }

            if (prefix.Length > 0)
            {
                var newEnums = @enum.Tokens.Select
                (
                    x =>
                    {
                        var newName = Naming.Translate(x.NativeName[prefix.Length..], task.FunctionPrefix);
                        if (newName == x.Name)
                        {
                            return null;
                        }

                        var attrs = x.Attributes.ToList();
                        if (!x.Attributes.Any(y => y.Name is "Obsolete" or "System.Obsolete"))
                        {
                            x.Attributes.Add
                            (
                                new Attribute
                                {
                                    Name = "Obsolete",
                                    Arguments = new List<string>
                                    {
                                        $"\"Deprecated in favour of \\\"{newName}\\\"\""
                                    }
                                }
                            );
                        }

                        return new Token
                        {
                            Attributes = attrs,
                            Doc = x.Doc,
                            Name = newName,
                            NativeName = x.NativeName,
                            Value = x.Value
                        };
                    }
                )
                .Where(x => x is not null)
                .ToList();

                if (task.Controls.Contains("no-obsolete-enum")) 
                {
                    @enum.Tokens = newEnums;
                }
                else 
                {
                    @enum.Tokens.AddRange(newEnums);
                }
            }
        }
    }
}
