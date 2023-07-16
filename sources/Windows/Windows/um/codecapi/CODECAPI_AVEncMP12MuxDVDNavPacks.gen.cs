// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_AVEncMP12MuxDVDNavPacks.xml' path='doc/member[@name="CODECAPI_AVEncMP12MuxDVDNavPacks"]/*'/>
[Guid("C7607CED-8CF1-4A99-83A1-EE5461BE3574")]
public unsafe partial struct CODECAPI_AVEncMP12MuxDVDNavPacks : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMP12MuxDVDNavPacks));
}