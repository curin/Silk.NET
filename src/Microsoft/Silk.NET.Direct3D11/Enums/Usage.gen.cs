// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_USAGE")]
    public enum Usage : int
    {
        [NativeName("Name", "D3D11_USAGE_DEFAULT")]
        UsageDefault = 0x0,
        [NativeName("Name", "D3D11_USAGE_IMMUTABLE")]
        UsageImmutable = 0x1,
        [NativeName("Name", "D3D11_USAGE_DYNAMIC")]
        UsageDynamic = 0x2,
        [NativeName("Name", "D3D11_USAGE_STAGING")]
        UsageStaging = 0x3,
    }
}