// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_PLACEHOLDER_VERSION_INFO
{
    /// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO.ProviderID"]/*'/>
    [NativeTypeName("UINT8[128]")]
    public fixed byte ProviderID[128];
    /// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO.ContentID"]/*'/>
    [NativeTypeName("UINT8[128]")]
    public fixed byte ContentID[128];
}