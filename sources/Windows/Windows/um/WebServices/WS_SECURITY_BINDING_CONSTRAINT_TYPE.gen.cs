// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
public enum WS_SECURITY_BINDING_CONSTRAINT_TYPE
{
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE = 1,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_CONSTRAINT_TYPE = 2,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_HTTP_HEADER_AUTH_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_HTTP_HEADER_AUTH_SECURITY_BINDING_CONSTRAINT_TYPE = 3,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_USERNAME_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_USERNAME_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 4,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 5,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_ISSUED_TOKEN_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 6,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_CERT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_CERT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 7,
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT_TYPE.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT_TYPE.WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE"]/*'/>
    WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_CONSTRAINT_TYPE = 8,
}