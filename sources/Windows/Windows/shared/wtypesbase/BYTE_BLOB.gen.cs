// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BYTE_BLOB.xml' path='doc/member[@name="BYTE_BLOB"]/*'/>
public unsafe partial struct BYTE_BLOB
{
    /// <include file='BYTE_BLOB.xml' path='doc/member[@name="BYTE_BLOB.clSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint clSize;
    /// <include file='BYTE_BLOB.xml' path='doc/member[@name="BYTE_BLOB.abData"]/*'/>
    [NativeTypeName("byte[1]")]
    public fixed byte abData[1];
}