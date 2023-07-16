// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP"]/*'/>
public enum D3D12_AUTO_BREADCRUMB_OP
{
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETMARKER"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_SETMARKER = 0,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_BEGINEVENT = 1,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENDEVENT"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ENDEVENT = 2,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DRAWINSTANCED = 3,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DRAWINDEXEDINSTANCED = 4,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_EXECUTEINDIRECT = 5,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCH"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DISPATCH = 6,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_COPYBUFFERREGION = 7,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_COPYTEXTUREREGION = 8,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_COPYRESOURCE = 9,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYTILES"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_COPYTILES = 10,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCE = 11,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_CLEARRENDERTARGETVIEW = 12,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_CLEARUNORDEREDACCESSVIEW = 13,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_CLEARDEPTHSTENCILVIEW = 14,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOURCEBARRIER = 15,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_EXECUTEBUNDLE = 16,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PRESENT"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_PRESENT = 17,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOLVEQUERYDATA = 18,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_BEGINSUBMISSION = 19,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ENDSUBMISSION = 20,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME = 21,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES = 22,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT = 23,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ATOMICCOPYBUFFERUINT64 = 24,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOLVESUBRESOURCEREGION = 25,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_WRITEBUFFERIMMEDIATE = 26,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME1 = 27,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_SETPROTECTEDRESOURCESESSION = 28,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DECODEFRAME2 = 29,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_PROCESSFRAMES1 = 30,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_BUILDRAYTRACINGACCELERATIONSTRUCTURE = 31,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_EMITRAYTRACINGACCELERATIONSTRUCTUREPOSTBUILDINFO = 32,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_COPYRAYTRACINGACCELERATIONSTRUCTURE = 33,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DISPATCHRAYS = 34,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_INITIALIZEMETACOMMAND = 35,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_EXECUTEMETACOMMAND = 36,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ESTIMATEMOTION = 37,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOLVEMOTIONVECTORHEAP = 38,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_SETPIPELINESTATE1 = 39,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_INITIALIZEEXTENSIONCOMMAND = 40,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_EXECUTEEXTENSIONCOMMAND = 41,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_DISPATCHMESH = 42,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_ENCODEFRAME = 43,
    /// <include file='D3D12_AUTO_BREADCRUMB_OP.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_OP.D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA"]/*'/>
    D3D12_AUTO_BREADCRUMB_OP_RESOLVEENCODEROUTPUTMETADATA = 44,
}