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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    public static class DawnOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Adapter* adapter, [Flow(FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(adapter, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Span<Adapter> adapter, [Flow(FlowDirection.In)] DeviceDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(ref adapter.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1601, Column 24 in dawn-webgpu.h")]
        public static unsafe Device* AdapterCreateDevice(this Dawn thisApi, Span<Adapter> adapter, [Flow(FlowDirection.In)] ReadOnlySpan<DeviceDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.AdapterCreateDevice(ref adapter.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1607, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterReference(this Dawn thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterReference(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1608, Column 18 in dawn-webgpu.h")]
        public static unsafe void AdapterRelease(this Dawn thisApi, Span<Adapter> adapter)
        {
            // SpanOverloader
            thisApi.AdapterRelease(ref adapter.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupReference(this Dawn thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupReference(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1613, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupRelease(this Dawn thisApi, Span<BindGroup> bindGroup)
        {
            // SpanOverloader
            thisApi.BindGroupRelease(ref bindGroup.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1617, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutReference(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutReference(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1618, Column 18 in dawn-webgpu.h")]
        public static unsafe void BindGroupLayoutRelease(this Dawn thisApi, Span<BindGroupLayout> bindGroupLayout)
        {
            // SpanOverloader
            thisApi.BindGroupLayoutRelease(ref bindGroupLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1629, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferReference(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferReference(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1630, Column 18 in dawn-webgpu.h")]
        public static unsafe void BufferRelease(this Dawn thisApi, Span<Buffer> buffer)
        {
            // SpanOverloader
            thisApi.BufferRelease(ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1634, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferReference(this Dawn thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferReference(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1635, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandBufferRelease(this Dawn thisApi, Span<CommandBuffer> commandBuffer)
        {
            // SpanOverloader
            thisApi.CommandBufferRelease(ref commandBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(commandEncoder, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1645, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderCopyTextureToTextureInternal(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize)
        {
            // SpanOverloader
            thisApi.CommandEncoderCopyTextureToTextureInternal(ref commandEncoder.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, CommandEncoder* commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(commandEncoder, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] byte* message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1647, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderInjectValidationError(this Dawn thisApi, Span<CommandEncoder> commandEncoder, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.CommandEncoderInjectValidationError(ref commandEncoder.GetPinnableReference(), message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, CommandEncoder* commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(commandEncoder, ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), buffer, bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In)] byte* data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In)] ReadOnlySpan<byte> data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1653, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderWriteBuffer(this Dawn thisApi, Span<CommandEncoder> commandEncoder, Span<Buffer> buffer, ulong bufferOffset, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size)
        {
            // SpanOverloader
            thisApi.CommandEncoderWriteBuffer(ref commandEncoder.GetPinnableReference(), ref buffer.GetPinnableReference(), bufferOffset, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderReference(this Dawn thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderReference(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1656, Column 18 in dawn-webgpu.h")]
        public static unsafe void CommandEncoderRelease(this Dawn thisApi, Span<CommandEncoder> commandEncoder)
        {
            // SpanOverloader
            thisApi.CommandEncoderRelease(ref commandEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1659, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatch(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatch(ref computePassEncoder.GetPinnableReference(), workgroupCountX, workgroupCountY, workgroupCountZ);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(computePassEncoder, ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Buffer* indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(ref computePassEncoder.GetPinnableReference(), indirectBuffer, indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1660, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderDispatchIndirect(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<Buffer> indirectBuffer, ulong indirectOffset)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderDispatchIndirect(ref computePassEncoder.GetPinnableReference(), ref indirectBuffer.GetPinnableReference(), indirectOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1664, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderEndPass(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderEndPass(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, ComputePassEncoder* computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(computePassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(ref computePassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderWriteTimestamp(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderWriteTimestamp(ref computePassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1672, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderReference(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderReference(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1673, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePassEncoderRelease(this Dawn thisApi, Span<ComputePassEncoder> computePassEncoder)
        {
            // SpanOverloader
            thisApi.ComputePassEncoderRelease(ref computePassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1678, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineReference(this Dawn thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineReference(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1679, Column 18 in dawn-webgpu.h")]
        public static unsafe void ComputePipelineRelease(this Dawn thisApi, Span<ComputePipeline> computePipeline)
        {
            // SpanOverloader
            thisApi.ComputePipelineRelease(ref computePipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1688, Column 24 in dawn-webgpu.h")]
        public static unsafe Buffer* DeviceCreateErrorBuffer(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorBuffer(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1689, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateErrorExternalTexture(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorExternalTexture(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(device, in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Span<Device> device, [Flow(FlowDirection.In)] TextureDescriptor* descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(ref device.GetPinnableReference(), descriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1690, Column 25 in dawn-webgpu.h")]
        public static unsafe Texture* DeviceCreateErrorTexture(this Dawn thisApi, Span<Device> device, [Flow(FlowDirection.In)] ReadOnlySpan<TextureDescriptor> descriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateErrorTexture(ref device.GetPinnableReference(), in descriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Device* device, [Flow(FlowDirection.In)] ReadOnlySpan<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(device, in externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Span<Device> device, [Flow(FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(ref device.GetPinnableReference(), externalTextureDescriptor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1691, Column 33 in dawn-webgpu.h")]
        public static unsafe ExternalTextureImpl* DeviceCreateExternalTexture(this Dawn thisApi, Span<Device> device, [Flow(FlowDirection.In)] ReadOnlySpan<ExternalTextureDescriptor> externalTextureDescriptor)
        {
            // SpanOverloader
            return thisApi.DeviceCreateExternalTexture(ref device.GetPinnableReference(), in externalTextureDescriptor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Device* device, DeviceLostReason type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, [Flow(FlowDirection.In)] byte* message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1703, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceForceLoss(this Dawn thisApi, Span<Device> device, DeviceLostReason type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.DeviceForceLoss(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 25 in dawn-webgpu.h")]
        public static unsafe Adapter* DeviceGetAdapter(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            return thisApi.DeviceGetAdapter(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Device* device, ErrorType type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(device, type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, [Flow(FlowDirection.In)] byte* message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, in message.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceInjectError(this Dawn thisApi, Span<Device> device, ErrorType type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message)
        {
            // SpanOverloader
            thisApi.DeviceInjectError(ref device.GetPinnableReference(), type, message);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Device* device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(device, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback(this Dawn thisApi, Span<Device> device, PfnLoggingCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(ref device.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceSetLoggingCallback<T0>(this Dawn thisApi, Span<Device> device, PfnLoggingCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DeviceSetLoggingCallback(ref device.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1715, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceTick(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceTick(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1716, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceReference(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceReference(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 18 in dawn-webgpu.h")]
        public static unsafe void DeviceRelease(this Dawn thisApi, Span<Device> device)
        {
            // SpanOverloader
            thisApi.DeviceRelease(ref device.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1720, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureDestroy(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureDestroy(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, ExternalTextureImpl* externalTexture, [Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(externalTexture, in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, [Flow(FlowDirection.In)] byte* label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, [Flow(FlowDirection.In)] ReadOnlySpan<byte> label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), in label.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1721, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureSetLabel(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label)
        {
            // SpanOverloader
            thisApi.ExternalTextureSetLabel(ref externalTexture.GetPinnableReference(), label);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1722, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureReference(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureReference(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1723, Column 18 in dawn-webgpu.h")]
        public static unsafe void ExternalTextureRelease(this Dawn thisApi, Span<ExternalTextureImpl> externalTexture)
        {
            // SpanOverloader
            thisApi.ExternalTextureRelease(ref externalTexture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceReference(this Dawn thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceReference(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1729, Column 18 in dawn-webgpu.h")]
        public static unsafe void InstanceRelease(this Dawn thisApi, Span<Instance> instance)
        {
            // SpanOverloader
            thisApi.InstanceRelease(ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1733, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutReference(this Dawn thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutReference(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1734, Column 18 in dawn-webgpu.h")]
        public static unsafe void PipelineLayoutRelease(this Dawn thisApi, Span<PipelineLayout> pipelineLayout)
        {
            // SpanOverloader
            thisApi.PipelineLayoutRelease(ref pipelineLayout.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1741, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetReference(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetReference(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1742, Column 18 in dawn-webgpu.h")]
        public static unsafe void QuerySetRelease(this Dawn thisApi, Span<QuerySet> querySet)
        {
            // SpanOverloader
            thisApi.QuerySetRelease(ref querySet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1745, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyExternalTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyExternalTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyExternalTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Queue* queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(queue, in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ImageCopyTexture* source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), source, in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ImageCopyTexture* destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), destination, in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] Extent3D* copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), copySize, in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] CopyTextureForBrowserOptions* options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1746, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueCopyTextureForBrowser(this Dawn thisApi, Span<Queue> queue, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> source, [Flow(FlowDirection.In)] ReadOnlySpan<ImageCopyTexture> destination, [Flow(FlowDirection.In)] ReadOnlySpan<Extent3D> copySize, [Flow(FlowDirection.In)] ReadOnlySpan<CopyTextureForBrowserOptions> options)
        {
            // SpanOverloader
            thisApi.QueueCopyTextureForBrowser(ref queue.GetPinnableReference(), in source.GetPinnableReference(), in destination.GetPinnableReference(), in copySize.GetPinnableReference(), in options.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1752, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueReference(this Dawn thisApi, Span<Queue> queue)
        {
            // SpanOverloader
            thisApi.QueueReference(ref queue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 18 in dawn-webgpu.h")]
        public static unsafe void QueueRelease(this Dawn thisApi, Span<Queue> queue)
        {
            // SpanOverloader
            thisApi.QueueRelease(ref queue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1756, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleReference(this Dawn thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleReference(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1757, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleRelease(this Dawn thisApi, Span<RenderBundle> renderBundle)
        {
            // SpanOverloader
            thisApi.RenderBundleRelease(ref renderBundle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1773, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderReference(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderReference(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1774, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderBundleEncoderRelease(this Dawn thisApi, Span<RenderBundleEncoder> renderBundleEncoder)
        {
            // SpanOverloader
            thisApi.RenderBundleEncoderRelease(ref renderBundleEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderEndPass(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderEndPass(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, RenderPassEncoder* renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(renderPassEncoder, ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, QuerySet* querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(ref renderPassEncoder.GetPinnableReference(), querySet, queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderWriteTimestamp(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder, Span<QuerySet> querySet, uint queryIndex)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderWriteTimestamp(ref renderPassEncoder.GetPinnableReference(), ref querySet.GetPinnableReference(), queryIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1799, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderReference(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderReference(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1800, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPassEncoderRelease(this Dawn thisApi, Span<RenderPassEncoder> renderPassEncoder)
        {
            // SpanOverloader
            thisApi.RenderPassEncoderRelease(ref renderPassEncoder.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1805, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineReference(this Dawn thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineReference(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 18 in dawn-webgpu.h")]
        public static unsafe void RenderPipelineRelease(this Dawn thisApi, Span<RenderPipeline> renderPipeline)
        {
            // SpanOverloader
            thisApi.RenderPipelineRelease(ref renderPipeline.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1810, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerReference(this Dawn thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerReference(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1811, Column 18 in dawn-webgpu.h")]
        public static unsafe void SamplerRelease(this Dawn thisApi, Span<Sampler> sampler)
        {
            // SpanOverloader
            thisApi.SamplerRelease(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleReference(this Dawn thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleReference(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1817, Column 18 in dawn-webgpu.h")]
        public static unsafe void ShaderModuleRelease(this Dawn thisApi, Span<ShaderModule> shaderModule)
        {
            // SpanOverloader
            thisApi.ShaderModuleRelease(ref shaderModule.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1820, Column 18 in dawn-webgpu.h")]
        public static unsafe void SurfaceReference(this Dawn thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceReference(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1821, Column 18 in dawn-webgpu.h")]
        public static unsafe void SurfaceRelease(this Dawn thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.SurfaceRelease(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1824, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainConfigure(this Dawn thisApi, Span<SwapChain> swapChain, TextureFormat format, Silk.NET.WebGPU.TextureUsage allowedUsage, uint width, uint height)
        {
            // SpanOverloader
            thisApi.SwapChainConfigure(ref swapChain.GetPinnableReference(), format, allowedUsage, width, height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1827, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainReference(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainReference(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1828, Column 18 in dawn-webgpu.h")]
        public static unsafe void SwapChainRelease(this Dawn thisApi, Span<SwapChain> swapChain)
        {
            // SpanOverloader
            thisApi.SwapChainRelease(ref swapChain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1842, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureReference(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureReference(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureRelease(this Dawn thisApi, Span<Texture> texture)
        {
            // SpanOverloader
            thisApi.TextureRelease(ref texture.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1847, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewReference(this Dawn thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewReference(ref textureView.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1848, Column 18 in dawn-webgpu.h")]
        public static unsafe void TextureViewRelease(this Dawn thisApi, Span<TextureView> textureView)
        {
            // SpanOverloader
            thisApi.TextureViewRelease(ref textureView.GetPinnableReference());
        }

    }
}

