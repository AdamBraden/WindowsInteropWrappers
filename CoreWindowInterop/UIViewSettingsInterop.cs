using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.UI.ViewManagement;

namespace UWPInterop
{
    //MIDL_INTERFACE("3694dbf9-8f68-44be-8ff5-195c98ede8a6")
    //IUIViewSettingsInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND hwnd,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** ppv) = 0;

    //};
    [System.Runtime.InteropServices.Guid("3694dbf9-8f68-44be-8ff5-195c98ede8a6")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IUIViewSettingsInterop
    {
        UIViewSettings GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
    //MIDL_INTERFACE("ECC62F5D-14AA-4971-9F06-B2159B1FFD40")
    //IClassicApplicationViewFactory : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ HWND appWindow,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][retval][out] */ void** result) = 0;

    //};
    [System.Runtime.InteropServices.Guid("ECC62F5D-14AA-4971-9F06-B2159B1FFD40")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    interface IClassicApplicationViewFactory
    {
        UIViewSettings GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
    //MIDL_INTERFACE("7A05F995-6242-440E-A64E-34B7ED3413D3")
    //IClassicApplicationView : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetTitleBar(
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][retval][out] */ void** result) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE GetActiveIcon(
    //        /* [retval][out] */ HICON* value) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE SetActiveIcon(
    //        /* [in] */ HICON value) = 0;

    //};
    [System.Runtime.InteropServices.Guid("7A05F995-6242-440E-A64E-34B7ED3413D3")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    interface IClassicApplicationView
    {
        //TODO: Validate these, is this a PTITLEBARINFO?
        IntPtr GetTitleBar([System.Runtime.InteropServices.In] ref Guid riid);
        IntPtr GetActiveIcon();
        void SetActiveIcon(IntPtr value);
    }

    //Helper to initialize UIViewSettings
    public static class UIViewSettingsInterop
    {
        public static UIViewSettings GetForWindow(IntPtr hWnd)
        {
            IUIViewSettingsInterop uIViewSettingsInterop = (IUIViewSettingsInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(UIViewSettings));
            Guid guid = typeof(UIViewSettings).GUID;

            return uIViewSettingsInterop.GetForWindow(hWnd, ref guid);
        }
    }

}
