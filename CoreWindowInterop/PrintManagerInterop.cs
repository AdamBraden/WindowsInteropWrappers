using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Windows.Graphics.Printing;

namespace WindowsInterop
{
    //MIDL_INTERFACE("c5435a42-8d43-4e7b-a68a-ef311e392087")
    //IPrintManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** printManager) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE ShowPrintUIForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //};

    [System.Runtime.InteropServices.Guid("c5435a42-8d43-4e7b-a68a-ef311e392087")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IPrintManagerInterop
    {
        PrintManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncOperation<bool> ShowPrintUIForWindowAsync(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
