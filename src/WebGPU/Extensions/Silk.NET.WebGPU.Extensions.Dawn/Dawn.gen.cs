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
using Silk.NET.WebGPU;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Extension("dawn-webgpu.h")]
    public unsafe partial class Dawn : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "dawn-webgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(ref Adapter adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(ref Adapter adapter, [Flow(FlowDirection.In)] in DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterReference")]
        public unsafe partial void AdapterReference(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterReference")]
        public partial void AdapterReference(ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRelease")]
        public unsafe partial void AdapterRelease(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRelease")]
        public partial void AdapterRelease(ref Adapter adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupReference")]
        public unsafe partial void BindGroupReference(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupReference")]
        public partial void BindGroupReference(ref BindGroup bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupRelease")]
        public unsafe partial void BindGroupRelease(BindGroup* bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupRelease")]
        public partial void BindGroupRelease(ref BindGroup bindGroup);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutReference")]
        public unsafe partial void BindGroupLayoutReference(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutReference")]
        public partial void BindGroupLayoutReference(ref BindGroupLayout bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutRelease")]
        public unsafe partial void BindGroupLayoutRelease(BindGroupLayout* bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutRelease")]
        public partial void BindGroupLayoutRelease(ref BindGroupLayout bindGroupLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReference")]
        public unsafe partial void BufferReference(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferReference")]
        public partial void BufferReference(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferRelease")]
        public unsafe partial void BufferRelease(Buffer* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferRelease")]
        public partial void BufferRelease(ref Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferReference")]
        public unsafe partial void CommandBufferReference(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferReference")]
        public partial void CommandBufferReference(ref CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferRelease")]
        public unsafe partial void CommandBufferRelease(CommandBuffer* commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferRelease")]
        public partial void CommandBufferRelease(ref CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public unsafe partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTextureInternal")]
        public partial void CommandEncoderCopyTextureToTextureInternal(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public partial void CommandEncoderInjectValidationError(ref CommandEncoder commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In)] in byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public partial void CommandEncoderWriteBuffer(ref CommandEncoder commandEncoder, ref Buffer buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderReference")]
        public unsafe partial void CommandEncoderReference(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderReference")]
        public partial void CommandEncoderReference(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderRelease")]
        public unsafe partial void CommandEncoderRelease(CommandEncoder* commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderRelease")]
        public partial void CommandEncoderRelease(ref CommandEncoder commandEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatch")]
        public unsafe partial void ComputePassEncoderDispatch(ComputePassEncoder* computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatch")]
        public partial void ComputePassEncoderDispatch(ref ComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ComputePassEncoder* computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ComputePassEncoder* computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public unsafe partial void ComputePassEncoderDispatchIndirect(ref ComputePassEncoder computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderDispatchIndirect")]
        public partial void ComputePassEncoderDispatchIndirect(ref ComputePassEncoder computePassEncoder, ref Buffer indirectBuffer, ulong indirectOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPass")]
        public unsafe partial void ComputePassEncoderEndPass(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderEndPass")]
        public partial void ComputePassEncoderEndPass(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ref ComputePassEncoder computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public partial void ComputePassEncoderWriteTimestamp(ref ComputePassEncoder computePassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderReference")]
        public unsafe partial void ComputePassEncoderReference(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderReference")]
        public partial void ComputePassEncoderReference(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderRelease")]
        public unsafe partial void ComputePassEncoderRelease(ComputePassEncoder* computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderRelease")]
        public partial void ComputePassEncoderRelease(ref ComputePassEncoder computePassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineReference")]
        public unsafe partial void ComputePipelineReference(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineReference")]
        public partial void ComputePipelineReference(ref ComputePipeline computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineRelease")]
        public unsafe partial void ComputePipelineRelease(ComputePipeline* computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineRelease")]
        public partial void ComputePipelineRelease(ref ComputePipeline computePipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(FlowDirection.In)] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(ref Device device, [Flow(FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(ref Device device, [Flow(FlowDirection.In)] in TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(FlowDirection.In)] in ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(ref Device device, [Flow(FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(ref Device device, [Flow(FlowDirection.In)] in ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(ref Device device, DeviceLostReason type, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public partial void DeviceForceLoss(ref Device device, DeviceLostReason type, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public partial void DeviceForceLoss(ref Device device, DeviceLostReason type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(ref Device device, ErrorType type, [Flow(FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public partial void DeviceInjectError(ref Device device, ErrorType type, [Flow(FlowDirection.In)] in byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public partial void DeviceInjectError(ref Device device, ErrorType type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(Device* device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback<T0>(Device* device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(ref Device device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public partial void DeviceSetLoggingCallback<T0>(ref Device device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public unsafe partial void DeviceTick(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public partial void DeviceTick(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceReference")]
        public unsafe partial void DeviceReference(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceReference")]
        public partial void DeviceReference(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceRelease")]
        public unsafe partial void DeviceRelease(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceRelease")]
        public partial void DeviceRelease(ref Device device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public unsafe partial void ExternalTextureDestroy(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public partial void ExternalTextureDestroy(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, [Flow(FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, [Flow(FlowDirection.In)] in byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public partial void ExternalTextureSetLabel(ref ExternalTextureImpl externalTexture, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public unsafe partial void ExternalTextureReference(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureReference")]
        public partial void ExternalTextureReference(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public partial void ExternalTextureRelease(ref ExternalTextureImpl externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceReference")]
        public unsafe partial void InstanceReference(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceReference")]
        public partial void InstanceReference(ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRelease")]
        public unsafe partial void InstanceRelease(Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRelease")]
        public partial void InstanceRelease(ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutReference")]
        public unsafe partial void PipelineLayoutReference(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutReference")]
        public partial void PipelineLayoutReference(ref PipelineLayout pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutRelease")]
        public unsafe partial void PipelineLayoutRelease(PipelineLayout* pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutRelease")]
        public partial void PipelineLayoutRelease(ref PipelineLayout pipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetReference")]
        public unsafe partial void QuerySetReference(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetReference")]
        public partial void QuerySetReference(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetRelease")]
        public unsafe partial void QuerySetRelease(QuerySet* querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetRelease")]
        public partial void QuerySetRelease(ref QuerySet querySet);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public partial void QueueCopyExternalTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyExternalTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public partial void QueueCopyTextureForBrowser(ref Queue queue, [Flow(FlowDirection.In)] in ImageCopyTexture source, [Flow(FlowDirection.In)] in ImageCopyTexture destination, [Flow(FlowDirection.In)] in Extent3D copySize, [Flow(FlowDirection.In)] in CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueReference")]
        public unsafe partial void QueueReference(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueReference")]
        public partial void QueueReference(ref Queue queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueRelease")]
        public unsafe partial void QueueRelease(Queue* queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueRelease")]
        public partial void QueueRelease(ref Queue queue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleReference")]
        public unsafe partial void RenderBundleReference(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleReference")]
        public partial void RenderBundleReference(ref RenderBundle renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleRelease")]
        public unsafe partial void RenderBundleRelease(RenderBundle* renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleRelease")]
        public partial void RenderBundleRelease(ref RenderBundle renderBundle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderReference")]
        public unsafe partial void RenderBundleEncoderReference(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderReference")]
        public partial void RenderBundleEncoderReference(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderRelease")]
        public unsafe partial void RenderBundleEncoderRelease(RenderBundleEncoder* renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderRelease")]
        public partial void RenderBundleEncoderRelease(ref RenderBundleEncoder renderBundleEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPass")]
        public unsafe partial void RenderPassEncoderEndPass(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderEndPass")]
        public partial void RenderPassEncoderEndPass(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(ref RenderPassEncoder renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public partial void RenderPassEncoderWriteTimestamp(ref RenderPassEncoder renderPassEncoder, ref QuerySet querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderReference")]
        public unsafe partial void RenderPassEncoderReference(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderReference")]
        public partial void RenderPassEncoderReference(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderRelease")]
        public unsafe partial void RenderPassEncoderRelease(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderRelease")]
        public partial void RenderPassEncoderRelease(ref RenderPassEncoder renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineReference")]
        public unsafe partial void RenderPipelineReference(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineReference")]
        public partial void RenderPipelineReference(ref RenderPipeline renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineRelease")]
        public unsafe partial void RenderPipelineRelease(RenderPipeline* renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineRelease")]
        public partial void RenderPipelineRelease(ref RenderPipeline renderPipeline);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerReference")]
        public unsafe partial void SamplerReference(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerReference")]
        public partial void SamplerReference(ref Sampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerRelease")]
        public unsafe partial void SamplerRelease(Sampler* sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerRelease")]
        public partial void SamplerRelease(ref Sampler sampler);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleReference")]
        public unsafe partial void ShaderModuleReference(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleReference")]
        public partial void ShaderModuleReference(ref ShaderModule shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleRelease")]
        public unsafe partial void ShaderModuleRelease(ShaderModule* shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleRelease")]
        public partial void ShaderModuleRelease(ref ShaderModule shaderModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceReference")]
        public unsafe partial void SurfaceReference(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceReference")]
        public partial void SurfaceReference(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceRelease")]
        public unsafe partial void SurfaceRelease(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceRelease")]
        public partial void SurfaceRelease(ref Surface surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainConfigure")]
        public unsafe partial void SwapChainConfigure(SwapChain* swapChain, TextureFormat format, Silk.NET.WebGPU.TextureUsage allowedUsage, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainConfigure")]
        public partial void SwapChainConfigure(ref SwapChain swapChain, TextureFormat format, Silk.NET.WebGPU.TextureUsage allowedUsage, uint width, uint height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public unsafe partial void SwapChainReference(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainReference")]
        public partial void SwapChainReference(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public unsafe partial void SwapChainRelease(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public partial void SwapChainRelease(ref SwapChain swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureReference")]
        public unsafe partial void TextureReference(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureReference")]
        public partial void TextureReference(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureRelease")]
        public unsafe partial void TextureRelease(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureRelease")]
        public partial void TextureRelease(ref Texture texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewReference")]
        public unsafe partial void TextureViewReference(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewReference")]
        public partial void TextureViewReference(ref TextureView textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewRelease")]
        public unsafe partial void TextureViewRelease(TextureView* textureView);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewRelease")]
        public partial void TextureViewRelease(ref TextureView textureView);

        public Dawn(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

