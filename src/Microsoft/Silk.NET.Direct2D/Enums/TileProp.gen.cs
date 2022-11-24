// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_TILE_PROP")]
    public enum TileProp : int
    {
        [Obsolete("Deprecated in favour of \"Rect\"")]
        [NativeName("Name", "D2D1_TILE_PROP_RECT")]
        TilePropRect = 0x0,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_TILE_PROP_FORCE_DWORD")]
        TilePropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_TILE_PROP_RECT")]
        Rect = 0x0,
        [NativeName("Name", "D2D1_TILE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
