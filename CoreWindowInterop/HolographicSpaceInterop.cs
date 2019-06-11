using System;
using System.Collections.Generic;
using System.Text;
using Windows.Graphics.Holographic;

namespace WindowsInterop
{
    //MIDL_INTERFACE("5C4EE536-6A98-4B86-A170-587013D6FD4B")
    //IHolographicSpaceInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE CreateForWindow(
    //        /* [in] */ __RPC__in HWND window,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** holographicSpace) = 0;
        
    //};
    [System.Runtime.InteropServices.Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IHolographicSpaceInterop
    {
        HolographicSpace CreateForWindow(IntPtr window, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
