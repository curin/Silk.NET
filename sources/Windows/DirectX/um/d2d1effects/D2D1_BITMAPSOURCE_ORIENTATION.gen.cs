// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION"]/*'/>
public enum D2D1_BITMAPSOURCE_ORIENTATION
{
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_DEFAULT"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_DEFAULT = 1,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_FLIP_HORIZONTAL"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_FLIP_HORIZONTAL = 2,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180 = 3,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL = 4,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL = 5,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90 = 6,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL = 7,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270 = 8,
    /// <include file='D2D1_BITMAPSOURCE_ORIENTATION.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_ORIENTATION.D2D1_BITMAPSOURCE_ORIENTATION_FORCE_DWORD"]/*'/>
    D2D1_BITMAPSOURCE_ORIENTATION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}