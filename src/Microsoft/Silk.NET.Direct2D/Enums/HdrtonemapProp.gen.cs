// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_HDRTONEMAP_PROP")]
    public enum HdrtonemapProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InputMaxLuminance\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_INPUT_MAX_LUMINANCE")]
        HdrtonemapPropInputMaxLuminance = 0x0,
        [Obsolete("Deprecated in favour of \"OutputMaxLuminance\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_OUTPUT_MAX_LUMINANCE")]
        HdrtonemapPropOutputMaxLuminance = 0x1,
        [Obsolete("Deprecated in favour of \"DisplayMode\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_DISPLAY_MODE")]
        HdrtonemapPropDisplayMode = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_FORCE_DWORD")]
        HdrtonemapPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_INPUT_MAX_LUMINANCE")]
        InputMaxLuminance = 0x0,
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_OUTPUT_MAX_LUMINANCE")]
        OutputMaxLuminance = 0x1,
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_DISPLAY_MODE")]
        DisplayMode = 0x2,
        [NativeName("Name", "D2D1_HDRTONEMAP_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
