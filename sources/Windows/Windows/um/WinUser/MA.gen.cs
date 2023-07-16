// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MA
{
    [NativeTypeName("#define MA_ACTIVATE 1")]
    public const int MA_ACTIVATE = 1;
    [NativeTypeName("#define MA_ACTIVATEANDEAT 2")]
    public const int MA_ACTIVATEANDEAT = 2;
    [NativeTypeName("#define MA_NOACTIVATE 3")]
    public const int MA_NOACTIVATE = 3;
    [NativeTypeName("#define MA_NOACTIVATEANDEAT 4")]
    public const int MA_NOACTIVATEANDEAT = 4;
}