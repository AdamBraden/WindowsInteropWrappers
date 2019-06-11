using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Windows.Graphics.Printing3D;

namespace WindowsInterop
{
    //MIDL_INTERFACE("9CA31010-1484-4587-B26B-DDDF9F9CAECD")
    //IPrinting3DManagerInterop : public IInspectable
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
    [System.Runtime.InteropServices.Guid("9CA31010-1484-4587-B26B-DDDF9F9CAECD")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IPrinting3DManagerInterop
    {
        Print3DManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncOperation<bool> ShowPrintUIForWindowAsync(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
