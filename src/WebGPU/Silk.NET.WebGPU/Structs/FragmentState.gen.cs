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
    [NativeName("Name", "WGPUFragmentState")]
    public unsafe partial struct FragmentState
    {
        public FragmentState
        (
            ChainedStruct* nextInChain = null,
            ShaderModule* module = null,
            byte* entryPoint = null,
            uint? constantCount = null,
            ConstantEntry* constants = null,
            uint? targetCount = null,
            ColorTargetState* targets = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (module is not null)
            {
                Module = module;
            }

            if (entryPoint is not null)
            {
                EntryPoint = entryPoint;
            }

            if (constantCount is not null)
            {
                ConstantCount = constantCount.Value;
            }

            if (constants is not null)
            {
                Constants = constants;
            }

            if (targetCount is not null)
            {
                TargetCount = targetCount.Value;
            }

            if (targets is not null)
            {
                Targets = targets;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUShaderModule")]
        [NativeName("Type.Name", "WGPUShaderModule")]
        [NativeName("Name", "module")]
        public ShaderModule* Module;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "entryPoint")]
        public byte* EntryPoint;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constantCount")]
        public uint ConstantCount;

        [NativeName("Type", "const WGPUConstantEntry *")]
        [NativeName("Type.Name", "const WGPUConstantEntry *")]
        [NativeName("Name", "constants")]
        public ConstantEntry* Constants;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "targetCount")]
        public uint TargetCount;

        [NativeName("Type", "const WGPUColorTargetState *")]
        [NativeName("Type.Name", "const WGPUColorTargetState *")]
        [NativeName("Name", "targets")]
        public ColorTargetState* Targets;
    }
}
