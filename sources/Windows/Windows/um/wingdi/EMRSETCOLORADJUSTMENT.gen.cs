// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSETCOLORADJUSTMENT.xml' path='doc/member[@name="EMRSETCOLORADJUSTMENT"]/*'/>
public partial struct EMRSETCOLORADJUSTMENT
{
    /// <include file='EMRSETCOLORADJUSTMENT.xml' path='doc/member[@name="EMRSETCOLORADJUSTMENT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETCOLORADJUSTMENT.xml' path='doc/member[@name="EMRSETCOLORADJUSTMENT.ColorAdjustment"]/*'/>
    public COLORADJUSTMENT ColorAdjustment;
}