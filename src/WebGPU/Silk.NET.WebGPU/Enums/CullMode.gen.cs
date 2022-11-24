// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUCullMode")]
    public enum CullMode : int
    {
        [NativeName("Name", "WGPUCullMode_None")]
        None = 0x0,
        [NativeName("Name", "WGPUCullMode_Front")]
        Front = 0x1,
        [NativeName("Name", "WGPUCullMode_Back")]
        Back = 0x2,
        [NativeName("Name", "WGPUCullMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
