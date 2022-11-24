// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_GEOMETRY_RELATION")]
    public enum GeometryRelation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_UNKNOWN")]
        GeometryRelationUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Disjoint\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_DISJOINT")]
        GeometryRelationDisjoint = 0x1,
        [Obsolete("Deprecated in favour of \"IsContained\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_IS_CONTAINED")]
        GeometryRelationIsContained = 0x2,
        [Obsolete("Deprecated in favour of \"Contains\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_CONTAINS")]
        GeometryRelationContains = 0x3,
        [Obsolete("Deprecated in favour of \"Overlap\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_OVERLAP")]
        GeometryRelationOverlap = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_FORCE_DWORD")]
        GeometryRelationForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_DISJOINT")]
        Disjoint = 0x1,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_IS_CONTAINED")]
        IsContained = 0x2,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_CONTAINS")]
        Contains = 0x3,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_OVERLAP")]
        Overlap = 0x4,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
