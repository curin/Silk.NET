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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("d5f56b60-593b-101a-b569-08002b2dbf7a")]
    [NativeName("Name", "IRpcChannelBuffer")]
    public unsafe partial struct IRpcChannelBuffer : IComVtbl<IRpcChannelBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d5f56b60-593b-101a-b569-08002b2dbf7a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRpcChannelBuffer val)
            => Unsafe.As<IRpcChannelBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRpcChannelBuffer
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(TagRPCOLEMESSAGE* pMessage, Guid* riid)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(TagRPCOLEMESSAGE* pMessage, ref Guid riid)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessage, riidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(ref TagRPCOLEMESSAGE pMessage, Guid* riid)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riid);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffer(ref TagRPCOLEMESSAGE pMessage, ref Guid riid)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, Guid*, int>)@this->LpVtbl[3])(@this, pMessagePtr, riidPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(TagRPCOLEMESSAGE* pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(TagRPCOLEMESSAGE* pMessage, ref uint pStatus)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessage, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SendReceive(ref TagRPCOLEMESSAGE pMessage, uint* pStatus)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SendReceive(ref TagRPCOLEMESSAGE pMessage, ref uint pStatus)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
            {
                fixed (uint* pStatusPtr = &pStatus)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, uint*, int>)@this->LpVtbl[4])(@this, pMessagePtr, pStatusPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreeBuffer(TagRPCOLEMESSAGE* pMessage)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, int>)@this->LpVtbl[5])(@this, pMessage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreeBuffer(ref TagRPCOLEMESSAGE pMessage)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagRPCOLEMESSAGE* pMessagePtr = &pMessage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, TagRPCOLEMESSAGE*, int>)@this->LpVtbl[5])(@this, pMessagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(uint* pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestContextPtr = &ppvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContext, ppvDestContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, void** ppvDestContext)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDestCtx(ref uint pdwDestContext, ref void* ppvDestContext)
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwDestContextPtr = &pdwDestContext)
            {
                fixed (void** ppvDestContextPtr = &ppvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, uint*, void**, int>)@this->LpVtbl[6])(@this, pdwDestContextPtr, ppvDestContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsConnected()
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRpcChannelBuffer*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRpcChannelBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
