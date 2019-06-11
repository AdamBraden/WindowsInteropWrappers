using System;
using System.Collections.Generic;
using System.Text;
using Windows.Media.PlayTo;

namespace WindowsInterop
{
    //MIDL_INTERFACE("24394699-1F2C-4EB3-8CD7-0EC1DA42A540")
    //IPlayToManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** playToManager) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE ShowPlayToUIForWindow(
    //        /* [in] */ __RPC__in HWND appWindow) = 0;

    //};
    [System.Runtime.InteropServices.Guid("24394699-1F2C-4EB3-8CD7-0EC1DA42A540")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IPlayToManagerInterop
    {
        [Obsolete]
        PlayToManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        void ShowPlayToUIForWindow(IntPtr appWindow);
    }
}
