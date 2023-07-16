// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.Output"]/*'/>
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.DeviceHandle"]/*'/>
    public HANDLE DeviceHandle;
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.CryptoSessionHandle"]/*'/>
    public HANDLE CryptoSessionHandle;
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT.OutputIDCount"]/*'/>
    public uint OutputIDCount;
}