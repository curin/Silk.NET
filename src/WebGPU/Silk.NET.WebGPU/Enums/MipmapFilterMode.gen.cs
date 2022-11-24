// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUMipmapFilterMode")]
    public enum MipmapFilterMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUMipmapFilterMode_Nearest")]
        Nearest = 0x0,
        [NativeName("Name", "WGPUMipmapFilterMode_Linear")]
        Linear = 0x1,
        [NativeName("Name", "WGPUMipmapFilterMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
