using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.ViewManagement;

namespace WindowsInterop
{
    //MIDL_INTERFACE("75CF2C57-9195-4931-8332-F0B409E916AF")
    //IInputPaneInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** inputPane) = 0;

    //};
    [System.Runtime.InteropServices.Guid("75CF2C57-9195-4931-8332-F0B409E916AF")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IInputPaneInterop
    {
        InputPane GetForWindow(IntPtr appWindow, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
