// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBindGroupLayoutDescriptor")]
    public unsafe partial struct BindGroupLayoutDescriptor
    {
        public BindGroupLayoutDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            uint? entryCount = null,
            BindGroupLayoutEntry* entries = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (entryCount is not null)
            {
                EntryCount = entryCount.Value;
            }

            if (entries is not null)
            {
                Entries = entries;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entryCount")]
        public uint EntryCount;

        [NativeName("Type", "const WGPUBindGroupLayoutEntry *")]
        [NativeName("Type.Name", "const WGPUBindGroupLayoutEntry *")]
        [NativeName("Name", "entries")]
        public BindGroupLayoutEntry* Entries;
    }
}
