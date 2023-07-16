// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_ELLIPSE.xml' path='doc/member[@name="D2D1_ELLIPSE"]/*'/>
public partial struct D2D1_ELLIPSE
{
    /// <include file='D2D1_ELLIPSE.xml' path='doc/member[@name="D2D1_ELLIPSE.point"]/*'/>
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F point;
    /// <include file='D2D1_ELLIPSE.xml' path='doc/member[@name="D2D1_ELLIPSE.radiusX"]/*'/>
    public float radiusX;
    /// <include file='D2D1_ELLIPSE.xml' path='doc/member[@name="D2D1_ELLIPSE.radiusY"]/*'/>
    public float radiusY;
}