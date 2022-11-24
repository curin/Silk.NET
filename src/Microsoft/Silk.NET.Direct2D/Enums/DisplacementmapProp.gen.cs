// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP")]
    public enum DisplacementmapProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Scale\"")]
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_SCALE")]
        DisplacementmapPropScale = 0x0,
        [Obsolete("Deprecated in favour of \"XChannelSelect\"")]
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT")]
        DisplacementmapPropXChannelSelect = 0x1,
        [Obsolete("Deprecated in favour of \"YChannelSelect\"")]
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT")]
        DisplacementmapPropYChannelSelect = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_FORCE_DWORD")]
        DisplacementmapPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_SCALE")]
        Scale = 0x0,
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT")]
        XChannelSelect = 0x1,
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT")]
        YChannelSelect = 0x2,
        [NativeName("Name", "D2D1_DISPLACEMENTMAP_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
