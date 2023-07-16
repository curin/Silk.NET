// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID"]/*'/>
public enum DWRITE_INFORMATIONAL_STRING_ID
{
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_NONE"]/*'/>
    DWRITE_INFORMATIONAL_STRING_NONE,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE"]/*'/>
    DWRITE_INFORMATIONAL_STRING_COPYRIGHT_NOTICE,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS"]/*'/>
    DWRITE_INFORMATIONAL_STRING_VERSION_STRINGS,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_TRADEMARK"]/*'/>
    DWRITE_INFORMATIONAL_STRING_TRADEMARK,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_MANUFACTURER"]/*'/>
    DWRITE_INFORMATIONAL_STRING_MANUFACTURER,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_DESIGNER"]/*'/>
    DWRITE_INFORMATIONAL_STRING_DESIGNER,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_DESIGNER_URL"]/*'/>
    DWRITE_INFORMATIONAL_STRING_DESIGNER_URL,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_DESCRIPTION"]/*'/>
    DWRITE_INFORMATIONAL_STRING_DESCRIPTION,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL"]/*'/>
    DWRITE_INFORMATIONAL_STRING_FONT_VENDOR_URL,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION"]/*'/>
    DWRITE_INFORMATIONAL_STRING_LICENSE_DESCRIPTION,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL"]/*'/>
    DWRITE_INFORMATIONAL_STRING_LICENSE_INFO_URL,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_WIN32_FAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_WIN32_SUBFAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT"]/*'/>
    DWRITE_INFORMATIONAL_STRING_SAMPLE_TEXT,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_FULL_NAME"]/*'/>
    DWRITE_INFORMATIONAL_STRING_FULL_NAME,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME"]/*'/>
    DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_NAME,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME"]/*'/>
    DWRITE_INFORMATIONAL_STRING_POSTSCRIPT_CID_NAME,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME"]/*'/>
    DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG"]/*'/>
    DWRITE_INFORMATIONAL_STRING_DESIGN_SCRIPT_LANGUAGE_TAG,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG"]/*'/>
    DWRITE_INFORMATIONAL_STRING_SUPPORTED_SCRIPT_LANGUAGE_TAG,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_PREFERRED_FAMILY_NAMES = DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_FAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES"]/*'/>
    DWRITE_INFORMATIONAL_STRING_PREFERRED_SUBFAMILY_NAMES = DWRITE_INFORMATIONAL_STRING_TYPOGRAPHIC_SUBFAMILY_NAMES,
    /// <include file='DWRITE_INFORMATIONAL_STRING_ID.xml' path='doc/member[@name="DWRITE_INFORMATIONAL_STRING_ID.DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME"]/*'/>
    DWRITE_INFORMATIONAL_STRING_WWS_FAMILY_NAME = DWRITE_INFORMATIONAL_STRING_WEIGHT_STRETCH_STYLE_FAMILY_NAME,
}