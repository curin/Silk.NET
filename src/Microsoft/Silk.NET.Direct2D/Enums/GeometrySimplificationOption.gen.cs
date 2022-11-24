// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION")]
    public enum GeometrySimplificationOption : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CubicsAndLines\"")]
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES")]
        GeometrySimplificationOptionCubicsAndLines = 0x0,
        [Obsolete("Deprecated in favour of \"Lines\"")]
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES")]
        GeometrySimplificationOptionLines = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_FORCE_DWORD")]
        GeometrySimplificationOptionForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES")]
        CubicsAndLines = 0x0,
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES")]
        Lines = 0x1,
        [NativeName("Name", "D2D1_GEOMETRY_SIMPLIFICATION_OPTION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
