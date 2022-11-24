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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUPipelineLayoutExtras")]
    public unsafe partial struct PipelineLayoutExtras
    {
        public PipelineLayoutExtras
        (
            ChainedStruct? chain = null,
            uint? pushConstantRangeCount = null,
            PushConstantRange* pushConstantRanges = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (pushConstantRangeCount is not null)
            {
                PushConstantRangeCount = pushConstantRangeCount.Value;
            }

            if (pushConstantRanges is not null)
            {
                PushConstantRanges = pushConstantRanges;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushConstantRangeCount")]
        public uint PushConstantRangeCount;

        [NativeName("Type", "WGPUPushConstantRange *")]
        [NativeName("Type.Name", "WGPUPushConstantRange *")]
        [NativeName("Name", "pushConstantRanges")]
        public PushConstantRange* PushConstantRanges;
    }
}
