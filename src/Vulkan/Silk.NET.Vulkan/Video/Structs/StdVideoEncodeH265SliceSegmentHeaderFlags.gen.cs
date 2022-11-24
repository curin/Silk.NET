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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeH265SliceSegmentHeaderFlags")]
    public unsafe partial struct StdVideoEncodeH265SliceSegmentHeaderFlags
    {
        public StdVideoEncodeH265SliceSegmentHeaderFlags
        (
            uint? firstSliceSegmentInPicFlag = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? dependentSliceSegmentFlag = null,
            uint? picOutputFlag = null,
            uint? shortTermRefPicSetSpsFlag = null,
            uint? sliceTemporalMvpEnableFlag = null,
            uint? sliceSaoLumaFlag = null,
            uint? sliceSaoChromaFlag = null,
            uint? numRefIdxActiveOverrideFlag = null,
            uint? mvdL1ZeroFlag = null,
            uint? cabacInitFlag = null,
            uint? cuChromaQpOffsetEnabledFlag = null,
            uint? deblockingFilterOverrideFlag = null,
            uint? sliceDeblockingFilterDisabledFlag = null,
            uint? collocatedFromL0Flag = null,
            uint? sliceLoopFilterAcrossSlicesEnabledFlag = null
        ) : this()
        {
            if (firstSliceSegmentInPicFlag is not null)
            {
                FirstSliceSegmentInPicFlag = firstSliceSegmentInPicFlag.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (dependentSliceSegmentFlag is not null)
            {
                DependentSliceSegmentFlag = dependentSliceSegmentFlag.Value;
            }

            if (picOutputFlag is not null)
            {
                PicOutputFlag = picOutputFlag.Value;
            }

            if (shortTermRefPicSetSpsFlag is not null)
            {
                ShortTermRefPicSetSpsFlag = shortTermRefPicSetSpsFlag.Value;
            }

            if (sliceTemporalMvpEnableFlag is not null)
            {
                SliceTemporalMvpEnableFlag = sliceTemporalMvpEnableFlag.Value;
            }

            if (sliceSaoLumaFlag is not null)
            {
                SliceSaoLumaFlag = sliceSaoLumaFlag.Value;
            }

            if (sliceSaoChromaFlag is not null)
            {
                SliceSaoChromaFlag = sliceSaoChromaFlag.Value;
            }

            if (numRefIdxActiveOverrideFlag is not null)
            {
                NumRefIdxActiveOverrideFlag = numRefIdxActiveOverrideFlag.Value;
            }

            if (mvdL1ZeroFlag is not null)
            {
                MvdL1ZeroFlag = mvdL1ZeroFlag.Value;
            }

            if (cabacInitFlag is not null)
            {
                CabacInitFlag = cabacInitFlag.Value;
            }

            if (cuChromaQpOffsetEnabledFlag is not null)
            {
                CuChromaQpOffsetEnabledFlag = cuChromaQpOffsetEnabledFlag.Value;
            }

            if (deblockingFilterOverrideFlag is not null)
            {
                DeblockingFilterOverrideFlag = deblockingFilterOverrideFlag.Value;
            }

            if (sliceDeblockingFilterDisabledFlag is not null)
            {
                SliceDeblockingFilterDisabledFlag = sliceDeblockingFilterDisabledFlag.Value;
            }

            if (collocatedFromL0Flag is not null)
            {
                CollocatedFromL0Flag = collocatedFromL0Flag.Value;
            }

            if (sliceLoopFilterAcrossSlicesEnabledFlag is not null)
            {
                SliceLoopFilterAcrossSlicesEnabledFlag = sliceLoopFilterAcrossSlicesEnabledFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint FirstSliceSegmentInPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint NoOutputOfPriorPicsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint DependentSliceSegmentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint PicOutputFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint ShortTermRefPicSetSpsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint SliceTemporalMvpEnableFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint SliceSaoLumaFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint SliceSaoChromaFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint NumRefIdxActiveOverrideFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint MvdL1ZeroFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint CabacInitFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint CuChromaQpOffsetEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint DeblockingFilterOverrideFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint SliceDeblockingFilterDisabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint CollocatedFromL0Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint SliceLoopFilterAcrossSlicesEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }
    }
}
