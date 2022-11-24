// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUBufferMapAsyncStatus")]
    public enum BufferMapAsyncStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Unknown")]
        Unknown = 0x2,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DeviceLost")]
        DeviceLost = 0x3,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DestroyedBeforeCallback")]
        DestroyedBeforeCallback = 0x4,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_UnmappedBeforeCallback")]
        UnmappedBeforeCallback = 0x5,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
