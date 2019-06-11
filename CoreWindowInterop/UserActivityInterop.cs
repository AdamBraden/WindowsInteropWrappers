using System;
using System.Collections.Generic;
using System.Text;
using Windows.ApplicationModel.UserActivities;

namespace WindowsInterop
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
    interface IUserActivityInterop
    {
        UserActivitySession GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
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
    interface IUserActivitySourceHostInterop
    {
        void SetActivitySourceHost(string activitySourceHost);
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
    interface IUserActivityRequestManagerInterop
    {
        UserActivityRequestManager GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
