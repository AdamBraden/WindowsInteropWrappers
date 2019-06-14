using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Media;

namespace UWPInterop
{
    //MIDL_INTERFACE("ddb0472d-c911-4a1f-86d9-dc3d71a95f5a")
    //ISystemMediaTransportControlsInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** mediaTransportControl) = 0;

    //};
    [System.Runtime.InteropServices.Guid("ddb0472d-c911-4a1f-86d9-dc3d71a95f5a")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface ISystemMediaTransportControlsInterop
    {
        SystemMediaTransportControls GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize SystemMediaTransportControls
    public static class SystemMediaTransportControlsInterop
    {
        public static SystemMediaTransportControls GetForWindow(IntPtr hWnd)
        {
            ISystemMediaTransportControlsInterop systemMediaTransportControlsInterop = (ISystemMediaTransportControlsInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(SystemMediaTransportControls));
            Guid guid = typeof(SystemMediaTransportControls).GUID;

            return systemMediaTransportControlsInterop.GetForWindow(hWnd, ref guid);
        }
    }
}
