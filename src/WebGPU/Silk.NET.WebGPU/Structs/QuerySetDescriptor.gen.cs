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
    [NativeName("Name", "WGPUQuerySetDescriptor")]
    public unsafe partial struct QuerySetDescriptor
    {
        public QuerySetDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            QueryType? type = null,
            uint? count = null,
            PipelineStatisticName* pipelineStatistics = null,
            uint? pipelineStatisticsCount = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (pipelineStatistics is not null)
            {
                PipelineStatistics = pipelineStatistics;
            }

            if (pipelineStatisticsCount is not null)
            {
                PipelineStatisticsCount = pipelineStatisticsCount.Value;
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

        [NativeName("Type", "WGPUQueryType")]
        [NativeName("Type.Name", "WGPUQueryType")]
        [NativeName("Name", "type")]
        public QueryType Type;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "count")]
        public uint Count;

        [NativeName("Type", "const WGPUPipelineStatisticName *")]
        [NativeName("Type.Name", "const WGPUPipelineStatisticName *")]
        [NativeName("Name", "pipelineStatistics")]
        public PipelineStatisticName* PipelineStatistics;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineStatisticsCount")]
        public uint PipelineStatisticsCount;
    }
}
