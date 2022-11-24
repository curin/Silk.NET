// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE")]
    public enum PointspecularScaleMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_NEAREST_NEIGHBOR")]
        PointspecularScaleModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_LINEAR")]
        PointspecularScaleModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Cubic\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_CUBIC")]
        PointspecularScaleModeCubic = 0x2,
        [Obsolete("Deprecated in favour of \"MultiSampleLinear\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_MULTI_SAMPLE_LINEAR")]
        PointspecularScaleModeMultiSampleLinear = 0x3,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_ANISOTROPIC")]
        PointspecularScaleModeAnisotropic = 0x4,
        [Obsolete("Deprecated in favour of \"HighQualityCubic\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_HIGH_QUALITY_CUBIC")]
        PointspecularScaleModeHighQualityCubic = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_FORCE_DWORD")]
        PointspecularScaleModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_MULTI_SAMPLE_LINEAR")]
        MultiSampleLinear = 0x3,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_ANISOTROPIC")]
        Anisotropic = 0x4,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_HIGH_QUALITY_CUBIC")]
        HighQualityCubic = 0x5,
        [NativeName("Name", "D2D1_POINTSPECULAR_SCALE_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
