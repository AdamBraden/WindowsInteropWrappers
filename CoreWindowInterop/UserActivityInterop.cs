using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.ApplicationModel.UserActivities;

namespace UWPInterop
{
    //MIDL_INTERFACE("1ADE314D-0E0A-40D9-824C-9A088A50059F")
    //IUserActivityInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE CreateSessionForWindow(
    //        /* [in] */ HWND window,
    //        /* [in] */ REFIID iid,
    //        /* [retval][iid_is][out] */ void** value) = 0;

    //};
    [System.Runtime.InteropServices.Guid("1ADE314D-0E0A-40D9-824C-9A088A50059F")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IUserActivityInterop
    {
        UserActivitySession CreateSessionForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
    //MIDL_INTERFACE("C15DF8BC-8844-487A-B85B-7578E0F61419")
    //IUserActivitySourceHostInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE SetActivitySourceHost(
    //        /* [in] */ HSTRING activitySourceHost) = 0;

    //};
    [System.Runtime.InteropServices.Guid("C15DF8BC-8844-487A-B85B-7578E0F61419")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IUserActivitySourceHostInterop
    {
        void SetActivitySourceHost([MarshalAs(UnmanagedType.HString)] string activitySourceHost);
    }
    //MIDL_INTERFACE("DD69F876-9699-4715-9095-E37EA30DFA1B")
    //IUserActivityRequestManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ HWND window,
    //        /* [in] */ REFIID iid,
    //        /* [retval][iid_is][out] */ void** value) = 0;

    //};
    [System.Runtime.InteropServices.Guid("DD69F876-9699-4715-9095-E37EA30DFA1B")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IUserActivityRequestManagerInterop
    {
        UserActivityRequestManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize UserActivity
    public static class UserActivityInterop
    {
        public static UserActivitySession CreateSessionForWindow(IntPtr hWnd)
        {
            IUserActivityInterop userActivityInterop = (IUserActivityInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(UserActivitySession));
            Guid guid = typeof(UserActivitySession).GUID;

            return userActivityInterop.CreateSessionForWindow(hWnd, ref guid);
        }

        public static void SetActivitySourceHost(string activitySourceHost)
        {
            IUserActivitySourceHostInterop userActivitySourceHostInterop = (IUserActivitySourceHostInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(UserActivityChannel));
            userActivitySourceHostInterop.SetActivitySourceHost(activitySourceHost);
        }
        public static UserActivityRequestManager GetForWindow(IntPtr hWnd)
        {
            IUserActivityRequestManagerInterop userActivityRequestManagerInterop = (IUserActivityRequestManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(UserActivityRequestManager));
            Guid guid = typeof(UserActivityRequestManager).GUID;

            return userActivityRequestManagerInterop.GetForWindow(hWnd, ref guid);
        }
    }
}
