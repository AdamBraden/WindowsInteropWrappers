using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;

namespace UWPInterop
{
    //MIDL_INTERFACE("F4B8E804-811E-4436-B69C-44CB67B72084")
    //IWebAuthenticationCoreManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RequestTokenForWindowAsync( 
    //        /* [in] */ HWND appWindow,
    //        /* [in] */ IInspectable *request,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][retval][out] */ void **asyncInfo) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE RequestTokenWithWebAccountForWindowAsync( 
    //        /* [in] */ HWND appWindow,
    //        /* [in] */ IInspectable *request,
    //        /* [in] */ IInspectable *webAccount,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][retval][out] */ void **asyncInfo) = 0;
    //};
    [System.Runtime.InteropServices.Guid("F4B8E804-811E-4436-B69C-44CB67B72084")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IWebAuthenticationCoreManagerInterop
    {
        IAsyncOperation<WebTokenRequestResult> RequestTokenForWindowAsync(IntPtr appWindow, WebTokenRequest request, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncOperation<WebTokenRequestResult> RequestTokenWithWebAccountForWindowAsync(IntPtr appWindow, WebTokenRequest request, WebAccount webAccount, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize WebAuthenticationCoreManager
    public static class WebAuthenticationCoreManagerInterop
    {
        public static IAsyncOperation<WebTokenRequestResult> RequestTokenForWindowAsync(IntPtr hWnd, WebTokenRequest request)
        {
            IWebAuthenticationCoreManagerInterop webAuthenticationCoreManagerInterop = (IWebAuthenticationCoreManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(WebAuthenticationCoreManager));
            //Guid guid = typeof(WebAuthenticationCoreManager).GetInterface("IWebAuthenticationCoreManager").GUID;
            Guid guid = typeof(IAsyncOperation<WebTokenRequestResult>).GUID;

            return webAuthenticationCoreManagerInterop.RequestTokenForWindowAsync(hWnd, request, ref guid);
        }
        public static IAsyncOperation<WebTokenRequestResult> RequestTokenWithWebAccountForWindowAsync(IntPtr hWnd, WebTokenRequest request, WebAccount webAccount)
        {
            IWebAuthenticationCoreManagerInterop webAuthenticationCoreManagerInterop = (IWebAuthenticationCoreManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(WebAuthenticationCoreManager));
            Guid guid = typeof(IAsyncOperation<WebTokenRequestResult>).GUID;

            return webAuthenticationCoreManagerInterop.RequestTokenWithWebAccountForWindowAsync(hWnd, request, webAccount, ref guid);

        }
    }
}
