// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_BYTES.xml' path='doc/member[@name="WS_BYTES"]/*'/>
public unsafe partial struct WS_BYTES
{
    /// <include file='WS_BYTES.xml' path='doc/member[@name="WS_BYTES.length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint length;
    /// <include file='WS_BYTES.xml' path='doc/member[@name="WS_BYTES.bytes"]/*'/>
    public byte* bytes;
}