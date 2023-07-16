// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class IP
{
    [NativeTypeName("#define IP_CURSOR_DOWN 0x00000001")]
    public const int IP_CURSOR_DOWN = 0x00000001;
    [NativeTypeName("#define IP_INVERTED 0x00000002")]
    public const int IP_INVERTED = 0x00000002;
    [NativeTypeName("#define IP_MARGIN 0x00000004")]
    public const int IP_MARGIN = 0x00000004;
}