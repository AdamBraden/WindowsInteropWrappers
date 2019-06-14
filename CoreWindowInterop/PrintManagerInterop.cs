using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Graphics.Printing;

namespace UWPInterop
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
    public interface IPrintManagerInterop
    {
        PrintManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncOperation<bool> ShowPrintUIForWindowAsync(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize PrintManager
    public static class PrintManagerInterop
    {
        public static PrintManager GetForWindow(IntPtr hWnd)
        {
            IPrintManagerInterop printManagerInterop = (IPrintManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(PrintManager));
            Guid guid = typeof(PrintManager).GetInterface("IPrintManager").GUID;

            return printManagerInterop.GetForWindow(hWnd, ref guid);
        }
        public static IAsyncOperation<bool> ShowPrintUIForWindowAsync(IntPtr hWnd)
        {
            IPrintManagerInterop printManagerInterop = (IPrintManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(PrintManager));
            Guid guid = typeof(IAsyncOperation<bool>).GUID;

            return printManagerInterop.ShowPrintUIForWindowAsync(hWnd, ref guid);
        }
    }
}
