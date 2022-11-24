// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_CAP_STYLE")]
    public enum CapStyle : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Flat\"")]
        [NativeName("Name", "D2D1_CAP_STYLE_FLAT")]
        CapStyleFlat = 0x0,
        [Obsolete("Deprecated in favour of \"Square\"")]
        [NativeName("Name", "D2D1_CAP_STYLE_SQUARE")]
        CapStyleSquare = 0x1,
        [Obsolete("Deprecated in favour of \"Round\"")]
        [NativeName("Name", "D2D1_CAP_STYLE_ROUND")]
        CapStyleRound = 0x2,
        [Obsolete("Deprecated in favour of \"Triangle\"")]
        [NativeName("Name", "D2D1_CAP_STYLE_TRIANGLE")]
        CapStyleTriangle = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_CAP_STYLE_FORCE_DWORD")]
        CapStyleForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_CAP_STYLE_FLAT")]
        Flat = 0x0,
        [NativeName("Name", "D2D1_CAP_STYLE_SQUARE")]
        Square = 0x1,
        [NativeName("Name", "D2D1_CAP_STYLE_ROUND")]
        Round = 0x2,
        [NativeName("Name", "D2D1_CAP_STYLE_TRIANGLE")]
        Triangle = 0x3,
        [NativeName("Name", "D2D1_CAP_STYLE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
