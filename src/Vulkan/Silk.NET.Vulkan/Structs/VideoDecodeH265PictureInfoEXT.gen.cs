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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoDecodeH265PictureInfoEXT")]
    public unsafe partial struct VideoDecodeH265PictureInfoEXT : IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeH265PictureInfoEXT
        (
            StructureType? sType = StructureType.VideoDecodeH265PictureInfoExt,
            void* pNext = null,
            Video.StdVideoDecodeH265PictureInfo* pStdPictureInfo = null,
            uint? sliceCount = null,
            uint* pSliceOffsets = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
            }

            if (sliceCount is not null)
            {
                SliceCount = sliceCount.Value;
            }

            if (pSliceOffsets is not null)
            {
                PSliceOffsets = pSliceOffsets;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "StdVideoDecodeH265PictureInfo*")]
        [NativeName("Type.Name", "StdVideoDecodeH265PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoDecodeH265PictureInfo* PStdPictureInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sliceCount")]
        public uint SliceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pSliceOffsets")]
        public uint* PSliceOffsets;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeH265PictureInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
