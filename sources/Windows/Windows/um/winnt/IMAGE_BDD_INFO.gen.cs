// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_BDD_INFO.xml' path='doc/member[@name="IMAGE_BDD_INFO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_BDD_INFO
{
    /// <include file='IMAGE_BDD_INFO.xml' path='doc/member[@name="IMAGE_BDD_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='IMAGE_BDD_INFO.xml' path='doc/member[@name="IMAGE_BDD_INFO.BDDSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BDDSize;
}