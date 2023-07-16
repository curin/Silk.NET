// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_MOTION_TYPES
{
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_NONE"]/*'/>
    DIRECTMANIPULATION_MOTION_NONE = 0,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_TRANSLATEX"]/*'/>
    DIRECTMANIPULATION_MOTION_TRANSLATEX = 0x1,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_TRANSLATEY"]/*'/>
    DIRECTMANIPULATION_MOTION_TRANSLATEY = 0x2,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_ZOOM"]/*'/>
    DIRECTMANIPULATION_MOTION_ZOOM = 0x4,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_CENTERX"]/*'/>
    DIRECTMANIPULATION_MOTION_CENTERX = 0x10,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_CENTERY"]/*'/>
    DIRECTMANIPULATION_MOTION_CENTERY = 0x20,
    /// <include file='DIRECTMANIPULATION_MOTION_TYPES.xml' path='doc/member[@name="DIRECTMANIPULATION_MOTION_TYPES.DIRECTMANIPULATION_MOTION_ALL"]/*'/>
    DIRECTMANIPULATION_MOTION_ALL = ((((DIRECTMANIPULATION_MOTION_TRANSLATEX | DIRECTMANIPULATION_MOTION_TRANSLATEY) | DIRECTMANIPULATION_MOTION_ZOOM) | DIRECTMANIPULATION_MOTION_CENTERX) | DIRECTMANIPULATION_MOTION_CENTERY),
}