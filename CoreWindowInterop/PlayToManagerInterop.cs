using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Media.PlayTo;

namespace UWPInterop
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
    public interface IPlayToManagerInterop
    {
        [Obsolete]
        PlayToManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        void ShowPlayToUIForWindow(IntPtr appWindow);
    }

    //Helper to initialize PlayToManager
    public static class PlayToManagerInterop
    {
        [Obsolete]
        public static PlayToManager GetForWindow(IntPtr hWnd)
        {
            IPlayToManagerInterop playToManagerInterop = (IPlayToManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(PlayToManager));
            Guid guid = typeof(PlayToManager).GUID;

            return playToManagerInterop.GetForWindow(hWnd, ref guid);
        }
        public static void ShowPlayToUIForWindow(IntPtr hWnd)
        {
            IPlayToManagerInterop playToManagerInterop = (IPlayToManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(PlayToManager));
            playToManagerInterop.ShowPlayToUIForWindow(hWnd);
        }
    }
}
