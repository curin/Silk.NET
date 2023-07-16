// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID"]/*'/>
public enum WS_SECURITY_PROPERTY_ID
{
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_TRANSPORT_PROTECTION_LEVEL"]/*'/>
    WS_SECURITY_PROPERTY_TRANSPORT_PROTECTION_LEVEL = 1,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_ALGORITHM_SUITE"]/*'/>
    WS_SECURITY_PROPERTY_ALGORITHM_SUITE = 2,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_ALGORITHM_SUITE_NAME"]/*'/>
    WS_SECURITY_PROPERTY_ALGORITHM_SUITE_NAME = 3,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_MAX_ALLOWED_LATENCY"]/*'/>
    WS_SECURITY_PROPERTY_MAX_ALLOWED_LATENCY = 4,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_TIMESTAMP_VALIDITY_DURATION"]/*'/>
    WS_SECURITY_PROPERTY_TIMESTAMP_VALIDITY_DURATION = 5,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_MAX_ALLOWED_CLOCK_SKEW"]/*'/>
    WS_SECURITY_PROPERTY_MAX_ALLOWED_CLOCK_SKEW = 6,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_TIMESTAMP_USAGE"]/*'/>
    WS_SECURITY_PROPERTY_TIMESTAMP_USAGE = 7,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_SECURITY_HEADER_LAYOUT"]/*'/>
    WS_SECURITY_PROPERTY_SECURITY_HEADER_LAYOUT = 8,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_SECURITY_HEADER_VERSION"]/*'/>
    WS_SECURITY_PROPERTY_SECURITY_HEADER_VERSION = 9,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_EXTENDED_PROTECTION_POLICY"]/*'/>
    WS_SECURITY_PROPERTY_EXTENDED_PROTECTION_POLICY = 10,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_EXTENDED_PROTECTION_SCENARIO"]/*'/>
    WS_SECURITY_PROPERTY_EXTENDED_PROTECTION_SCENARIO = 11,
    /// <include file='WS_SECURITY_PROPERTY_ID.xml' path='doc/member[@name="WS_SECURITY_PROPERTY_ID.WS_SECURITY_PROPERTY_SERVICE_IDENTITIES"]/*'/>
    WS_SECURITY_PROPERTY_SERVICE_IDENTITIES = 12,
}