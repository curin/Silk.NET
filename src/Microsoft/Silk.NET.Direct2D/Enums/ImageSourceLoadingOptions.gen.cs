// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS")]
    public enum ImageSourceLoadingOptions : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE")]
        ImageSourceLoadingOptionsNone = 0x0,
        [Obsolete("Deprecated in favour of \"ReleaseSource\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE")]
        ImageSourceLoadingOptionsReleaseSource = 0x1,
        [Obsolete("Deprecated in favour of \"CacheOnDemand\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND")]
        ImageSourceLoadingOptionsCacheOnDemand = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD")]
        ImageSourceLoadingOptionsForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE")]
        ReleaseSource = 0x1,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND")]
        CacheOnDemand = 0x2,
        [NativeName("Name", "D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
