using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI.ApplicationSettings;

namespace UWPInterop
{
    //MIDL_INTERFACE("D3EE12AD-3865-4362-9746-B75A682DF0E6")
    //IAccountsSettingsPaneInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** accountsSettingsPane) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE ShowManageAccountsForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncAction) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE ShowAddAccountForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncAction) = 0;
    //};
    [System.Runtime.InteropServices.Guid("D3EE12AD-3865-4362-9746-B75A682DF0E6")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IAccountsSettingsPaneInterop
    {
        AccountsSettingsPane GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncAction ShowManagedAccountsForWindowAsync(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncAction ShowAddAccountForWindowAsync(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize AccountsSettingsPane
    public static class AccountsSettingsPaneInterop 
    {
        public static AccountsSettingsPane GetForWindow(IntPtr hWnd)
        {
            IAccountsSettingsPaneInterop accountsSettingsPaneInterop = (IAccountsSettingsPaneInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AccountsSettingsPane));
            Guid guid = typeof(AccountsSettingsPane).GUID;

            return accountsSettingsPaneInterop.GetForWindow(hWnd, ref guid);
        }
        public static IAsyncAction ShowManagedAccountsForWindowAsync(IntPtr hWnd)
        {
            IAccountsSettingsPaneInterop accountsSettingsPaneInterop = (IAccountsSettingsPaneInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AccountsSettingsPane));
            Guid guid = typeof(IAsyncAction).GUID;

            return accountsSettingsPaneInterop.ShowManagedAccountsForWindowAsync(hWnd, ref guid);
        }
        public static IAsyncAction ShowAddAccountForWindowAsync(IntPtr hWnd)
        {
            IAccountsSettingsPaneInterop accountsSettingsPaneInterop = (IAccountsSettingsPaneInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AccountsSettingsPane));
            Guid guid = typeof(IAsyncAction).GUID;

            return accountsSettingsPaneInterop.ShowAddAccountForWindowAsync(hWnd, ref guid);
        }
    }
}
