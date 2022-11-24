// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_EXPOSURE_PROP")]
    public enum ExposureProp : int
    {
        [Obsolete("Deprecated in favour of \"ExposureValue\"")]
        [NativeName("Name", "D2D1_EXPOSURE_PROP_EXPOSURE_VALUE")]
        ExposurePropExposureValue = 0x0,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_EXPOSURE_PROP_FORCE_DWORD")]
        ExposurePropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_EXPOSURE_PROP_EXPOSURE_VALUE")]
        ExposureValue = 0x0,
        [NativeName("Name", "D2D1_EXPOSURE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
