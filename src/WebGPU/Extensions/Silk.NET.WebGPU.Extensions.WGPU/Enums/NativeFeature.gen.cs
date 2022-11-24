// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeFeature")]
    public enum NativeFeature : int
    {
        [NativeName("Name", "WGPUNativeFeature_PUSH_CONSTANTS")]
        PushConstants = 0x60000001,
        [NativeName("Name", "WGPUNativeFeature_TEXTURE_ADAPTER_SPECIFIC_FORMAT_FEATURES")]
        TextureAdapterSpecificFormatFeatures = 0x60000002,
        [NativeName("Name", "WGPUNativeFeature_MULTI_DRAW_INDIRECT")]
        MultiDrawIndirect = 0x60000003,
        [NativeName("Name", "WGPUNativeFeature_MULTI_DRAW_INDIRECT_COUNT")]
        MultiDrawIndirectCount = 0x60000004,
        [NativeName("Name", "WGPUNativeFeature_VERTEX_WRITABLE_STORAGE")]
        VertexWritableStorage = 0x60000005,
    }
}
