using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Security.Credentials.UI;

namespace UWPInterop
{
    //MIDL_INTERFACE("39E050C3-4E74-441A-8DC0-B81104DF949C")
    //IUserConsentVerifierInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RequestVerificationForWindowAsync(
    //        /* [in] */ HWND appWindow,
    //        /* [in] */ HSTRING message,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][retval][out] */ void** asyncOperation) = 0;
    //};
    [System.Runtime.InteropServices.Guid("39E050C3-4E74-441A-8DC0-B81104DF949C")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IUserConsentVerifierInterop
    {
        IAsyncOperation<UserConsentVerificationResult> RequestVerificationForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string Message, [In] ref Guid riid);
    }

    //Helper to initialize UserConsentVerifier
    public static class UserConsentVerifierInterop
    {
        public static IAsyncOperation<UserConsentVerificationResult> RequestVerificationForWindowAsync(IntPtr hWnd, string Message)
        {
            IUserConsentVerifierInterop userConsentVerifierInterop = (IUserConsentVerifierInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(UserConsentVerifier));
            Guid guid = typeof(IAsyncOperation<UserConsentVerificationResult>).GUID;

            return userConsentVerifierInterop.RequestVerificationForWindowAsync(hWnd, Message, ref guid);

        }
    }
}
