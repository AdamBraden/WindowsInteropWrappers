using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.ApplicationModel.DataTransfer.DragDrop.Core;

namespace UWPInterop
{
    //MIDL_INTERFACE("5AD8CBA7-4C01-4DAC-9074-827894292D63")
    //IDragDropManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ HWND hwnd,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][out] */ void** ppv) = 0;
    //};
    [System.Runtime.InteropServices.Guid("5AD8CBA7-4C01-4DAC-9074-827894292D63")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IDragDropManagerInterop
    {
        CoreDragDropManager GetForWindow(IntPtr hWnd, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initalize DragDropManager
    public static class DragDropManagerInterop
    {
        public static CoreDragDropManager GetForWindow(IntPtr hWnd)
        {
            IDragDropManagerInterop dragDropManagerInterop = (IDragDropManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(CoreDragDropManager));
            Guid guid = typeof(CoreDragDropManager).GUID;

            return dragDropManagerInterop.GetForWindow(hWnd, ref guid);
        }
    }
}
