// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE"]/*'/>
public enum D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE
{
    /// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE"]/*'/>
    D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE = 0,
    /// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY"]/*'/>
    D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY = (D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_NONE + 1),
    /// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION"]/*'/>
    D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION = (D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_STATE_TRACKING_ONLY + 1),
    /// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION"]/*'/>
    D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION = (D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_UNGUARDED_VALIDATION + 1),
    /// <include file='D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE.NUM_D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODES"]/*'/>
    NUM_D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODES = (D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE_GUARDED_VALIDATION + 1),
}