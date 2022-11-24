// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_PATH_COMMAND")]
    public enum SvgPathCommand : int
    {
        [Obsolete("Deprecated in favour of \"ClosePath\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CLOSE_PATH")]
        SvgPathCommandClosePath = 0x0,
        [Obsolete("Deprecated in favour of \"MoveAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE")]
        SvgPathCommandMoveAbsolute = 0x1,
        [Obsolete("Deprecated in favour of \"MoveRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE")]
        SvgPathCommandMoveRelative = 0x2,
        [Obsolete("Deprecated in favour of \"LineAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE")]
        SvgPathCommandLineAbsolute = 0x3,
        [Obsolete("Deprecated in favour of \"LineRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_RELATIVE")]
        SvgPathCommandLineRelative = 0x4,
        [Obsolete("Deprecated in favour of \"CubicAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE")]
        SvgPathCommandCubicAbsolute = 0x5,
        [Obsolete("Deprecated in favour of \"CubicRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE")]
        SvgPathCommandCubicRelative = 0x6,
        [Obsolete("Deprecated in favour of \"QuadradicAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE")]
        SvgPathCommandQuadradicAbsolute = 0x7,
        [Obsolete("Deprecated in favour of \"QuadradicRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE")]
        SvgPathCommandQuadradicRelative = 0x8,
        [Obsolete("Deprecated in favour of \"ArcAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE")]
        SvgPathCommandArcAbsolute = 0x9,
        [Obsolete("Deprecated in favour of \"ArcRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_RELATIVE")]
        SvgPathCommandArcRelative = 0xA,
        [Obsolete("Deprecated in favour of \"HorizontalAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE")]
        SvgPathCommandHorizontalAbsolute = 0xB,
        [Obsolete("Deprecated in favour of \"HorizontalRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE")]
        SvgPathCommandHorizontalRelative = 0xC,
        [Obsolete("Deprecated in favour of \"VerticalAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE")]
        SvgPathCommandVerticalAbsolute = 0xD,
        [Obsolete("Deprecated in favour of \"VerticalRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE")]
        SvgPathCommandVerticalRelative = 0xE,
        [Obsolete("Deprecated in favour of \"CubicSmoothAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE")]
        SvgPathCommandCubicSmoothAbsolute = 0xF,
        [Obsolete("Deprecated in favour of \"CubicSmoothRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE")]
        SvgPathCommandCubicSmoothRelative = 0x10,
        [Obsolete("Deprecated in favour of \"QuadradicSmoothAbsolute\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE")]
        SvgPathCommandQuadradicSmoothAbsolute = 0x11,
        [Obsolete("Deprecated in favour of \"QuadradicSmoothRelative\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE")]
        SvgPathCommandQuadradicSmoothRelative = 0x12,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_FORCE_DWORD")]
        SvgPathCommandForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CLOSE_PATH")]
        ClosePath = 0x0,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE")]
        MoveAbsolute = 0x1,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE")]
        MoveRelative = 0x2,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE")]
        LineAbsolute = 0x3,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_RELATIVE")]
        LineRelative = 0x4,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE")]
        CubicAbsolute = 0x5,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE")]
        CubicRelative = 0x6,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE")]
        QuadradicAbsolute = 0x7,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE")]
        QuadradicRelative = 0x8,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE")]
        ArcAbsolute = 0x9,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_RELATIVE")]
        ArcRelative = 0xA,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE")]
        HorizontalAbsolute = 0xB,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE")]
        HorizontalRelative = 0xC,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE")]
        VerticalAbsolute = 0xD,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE")]
        VerticalRelative = 0xE,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE")]
        CubicSmoothAbsolute = 0xF,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE")]
        CubicSmoothRelative = 0x10,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE")]
        QuadradicSmoothAbsolute = 0x11,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE")]
        QuadradicSmoothRelative = 0x12,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
