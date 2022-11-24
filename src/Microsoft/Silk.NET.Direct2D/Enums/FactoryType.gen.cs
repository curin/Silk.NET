// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_FACTORY_TYPE")]
    public enum FactoryType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SingleThreaded\"")]
        [NativeName("Name", "D2D1_FACTORY_TYPE_SINGLE_THREADED")]
        FactoryTypeSingleThreaded = 0x0,
        [Obsolete("Deprecated in favour of \"MultiThreaded\"")]
        [NativeName("Name", "D2D1_FACTORY_TYPE_MULTI_THREADED")]
        FactoryTypeMultiThreaded = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_FACTORY_TYPE_FORCE_DWORD")]
        FactoryTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_FACTORY_TYPE_SINGLE_THREADED")]
        SingleThreaded = 0x0,
        [NativeName("Name", "D2D1_FACTORY_TYPE_MULTI_THREADED")]
        MultiThreaded = 0x1,
        [NativeName("Name", "D2D1_FACTORY_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
