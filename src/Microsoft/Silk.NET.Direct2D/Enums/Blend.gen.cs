// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BLEND")]
    public enum Blend : int
    {
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D2D1_BLEND_ZERO")]
        BlendZero = 0x1,
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "D2D1_BLEND_ONE")]
        BlendOne = 0x2,
        [Obsolete("Deprecated in favour of \"SrcColor\"")]
        [NativeName("Name", "D2D1_BLEND_SRC_COLOR")]
        BlendSrcColor = 0x3,
        [Obsolete("Deprecated in favour of \"InvSrcColor\"")]
        [NativeName("Name", "D2D1_BLEND_INV_SRC_COLOR")]
        BlendInvSrcColor = 0x4,
        [Obsolete("Deprecated in favour of \"SrcAlpha\"")]
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x5,
        [Obsolete("Deprecated in favour of \"InvSrcAlpha\"")]
        [NativeName("Name", "D2D1_BLEND_INV_SRC_ALPHA")]
        BlendInvSrcAlpha = 0x6,
        [Obsolete("Deprecated in favour of \"DestAlpha\"")]
        [NativeName("Name", "D2D1_BLEND_DEST_ALPHA")]
        BlendDestAlpha = 0x7,
        [Obsolete("Deprecated in favour of \"InvDestAlpha\"")]
        [NativeName("Name", "D2D1_BLEND_INV_DEST_ALPHA")]
        BlendInvDestAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"DestColor\"")]
        [NativeName("Name", "D2D1_BLEND_DEST_COLOR")]
        BlendDestColor = 0x9,
        [Obsolete("Deprecated in favour of \"InvDestColor\"")]
        [NativeName("Name", "D2D1_BLEND_INV_DEST_COLOR")]
        BlendInvDestColor = 0xA,
        [Obsolete("Deprecated in favour of \"SrcAlphaSat\"")]
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA_SAT")]
        BlendSrcAlphaSat = 0xB,
        [Obsolete("Deprecated in favour of \"BlendFactor\"")]
        [NativeName("Name", "D2D1_BLEND_BLEND_FACTOR")]
        BlendBlendFactor = 0xE,
        [Obsolete("Deprecated in favour of \"InvBlendFactor\"")]
        [NativeName("Name", "D2D1_BLEND_INV_BLEND_FACTOR")]
        BlendInvBlendFactor = 0xF,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BLEND_FORCE_DWORD")]
        BlendForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BLEND_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "D2D1_BLEND_ONE")]
        One = 0x2,
        [NativeName("Name", "D2D1_BLEND_SRC_COLOR")]
        SrcColor = 0x3,
        [NativeName("Name", "D2D1_BLEND_INV_SRC_COLOR")]
        InvSrcColor = 0x4,
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA")]
        SrcAlpha = 0x5,
        [NativeName("Name", "D2D1_BLEND_INV_SRC_ALPHA")]
        InvSrcAlpha = 0x6,
        [NativeName("Name", "D2D1_BLEND_DEST_ALPHA")]
        DestAlpha = 0x7,
        [NativeName("Name", "D2D1_BLEND_INV_DEST_ALPHA")]
        InvDestAlpha = 0x8,
        [NativeName("Name", "D2D1_BLEND_DEST_COLOR")]
        DestColor = 0x9,
        [NativeName("Name", "D2D1_BLEND_INV_DEST_COLOR")]
        InvDestColor = 0xA,
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA_SAT")]
        SrcAlphaSat = 0xB,
        [NativeName("Name", "D2D1_BLEND_BLEND_FACTOR")]
        BlendFactor = 0xE,
        [NativeName("Name", "D2D1_BLEND_INV_BLEND_FACTOR")]
        InvBlendFactor = 0xF,
        [NativeName("Name", "D2D1_BLEND_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
