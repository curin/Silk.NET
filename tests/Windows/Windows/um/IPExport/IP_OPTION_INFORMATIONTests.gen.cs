// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IP_OPTION_INFORMATION"/> struct.</summary>
public static unsafe partial class IP_OPTION_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "IP_OPTION_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_OPTION_INFORMATION>(), Is.EqualTo(sizeof(IP_OPTION_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "IP_OPTION_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_OPTION_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IP_OPTION_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IP_OPTION_INFORMATION), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(IP_OPTION_INFORMATION), Is.EqualTo(8));
        }
    }
}