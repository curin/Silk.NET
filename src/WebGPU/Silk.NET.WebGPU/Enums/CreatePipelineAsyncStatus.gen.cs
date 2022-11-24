// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUCreatePipelineAsyncStatus")]
    public enum CreatePipelineAsyncStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_DeviceLost")]
        DeviceLost = 0x2,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_DeviceDestroyed")]
        DeviceDestroyed = 0x3,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Unknown")]
        Unknown = 0x4,
        [NativeName("Name", "WGPUCreatePipelineAsyncStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
