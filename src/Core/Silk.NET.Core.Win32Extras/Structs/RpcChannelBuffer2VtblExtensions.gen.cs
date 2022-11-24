// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras;

public unsafe static class RpcChannelBuffer2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcChannelBuffer2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcChannelBuffer2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref TagRPCOLEMESSAGE pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref TagRPCOLEMESSAGE pMessage, ref Guid riid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStatusPtr = &pStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref TagRPCOLEMESSAGE pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref TagRPCOLEMESSAGE pMessage, ref uint pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
        {
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatusPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreeBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, int>)@this->LpVtbl[5])(@this, pMessage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreeBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref TagRPCOLEMESSAGE pMessage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, TagRPCOLEMESSAGE*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, uint* pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, uint* pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDestContextPtr = &ppvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref uint pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref uint pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwDestContextPtr = &pdwDestContext)
        {
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsConnected(this ComPtr<IRpcChannelBuffer2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProtocolVersion(this ComPtr<IRpcChannelBuffer2> thisVtbl, uint* pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProtocolVersion(this ComPtr<IRpcChannelBuffer2> thisVtbl, ref uint pdwVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwVersionPtr = &pdwVersion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer2*, uint*, int>)@this->LpVtbl[8])(@this, pdwVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IRpcChannelBuffer2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(pMessage, ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<TagRPCOLEMESSAGE> pMessage, Guid* riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), riid);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<TagRPCOLEMESSAGE> pMessage, Span<Guid> riid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(ref pMessage.GetPinnableReference(), ref riid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, TagRPCOLEMESSAGE* pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(pMessage, ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<TagRPCOLEMESSAGE> pMessage, uint* pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), pStatus);
    }

    /// <summary>To be documented.</summary>
    public static int SendReceive(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<TagRPCOLEMESSAGE> pMessage, Span<uint> pStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SendReceive(ref pMessage.GetPinnableReference(), ref pStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreeBuffer(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<TagRPCOLEMESSAGE> pMessage)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FreeBuffer(ref pMessage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<uint> pdwDestContext, void** ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestCtx(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<uint> pdwDestContext, ref void* ppvDestContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDestCtx(ref pdwDestContext.GetPinnableReference(), ref ppvDestContext);
    }

    /// <summary>To be documented.</summary>
    public static int GetProtocolVersion(this ComPtr<IRpcChannelBuffer2> thisVtbl, Span<uint> pdwVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProtocolVersion(ref pdwVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IRpcChannelBuffer2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
