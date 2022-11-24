// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COMBINE_MODE")]
    public enum CombineMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Union\"")]
        [NativeName("Name", "D2D1_COMBINE_MODE_UNION")]
        CombineModeUnion = 0x0,
        [Obsolete("Deprecated in favour of \"Intersect\"")]
        [NativeName("Name", "D2D1_COMBINE_MODE_INTERSECT")]
        CombineModeIntersect = 0x1,
        [Obsolete("Deprecated in favour of \"Xor\"")]
        [NativeName("Name", "D2D1_COMBINE_MODE_XOR")]
        CombineModeXor = 0x2,
        [Obsolete("Deprecated in favour of \"Exclude\"")]
        [NativeName("Name", "D2D1_COMBINE_MODE_EXCLUDE")]
        CombineModeExclude = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COMBINE_MODE_FORCE_DWORD")]
        CombineModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COMBINE_MODE_UNION")]
        Union = 0x0,
        [NativeName("Name", "D2D1_COMBINE_MODE_INTERSECT")]
        Intersect = 0x1,
        [NativeName("Name", "D2D1_COMBINE_MODE_XOR")]
        Xor = 0x2,
        [NativeName("Name", "D2D1_COMBINE_MODE_EXCLUDE")]
        Exclude = 0x3,
        [NativeName("Name", "D2D1_COMBINE_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
