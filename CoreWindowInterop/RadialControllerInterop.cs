using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Input;

namespace WindowsInterop
{
    //RadialControllerInterop.h
    //    MIDL_INTERFACE("1B0535C9-57AD-45C1-9D79-AD5C34360513")
    //      IRadialControllerInterop : public IInspectable
    //      {
    //      public:
    //      virtual HRESULT STDMETHODCALLTYPE CreateForWindow(
    //        /* [annotation][in] */
    //        _In_ HWND hwnd,
    //        /* [annotation][in] */
    //        _In_ REFIID riid,
    //        /* [annotation][iid_is][out] */
    //        _COM_Outptr_  void** ppv) = 0;
    //};
    [System.Runtime.InteropServices.Guid("1B0535C9-57AD-45C1-9D79-AD5C34360513")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IRadialControllerInterop
    {
        RadialController CreateForWindow(IntPtr hwnd, [System.Runtime.InteropServices.In]ref Guid riid);
    }

    //MIDL_INTERFACE("787cdaac-3186-476d-87e4-b9374a7b9970")
    //    IRadialControllerConfigurationInterop : public IInspectable
    //    {
    //    public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [annotation][in] */
    //        _In_ HWND hwnd,
    //        /* [annotation][in] */
    //        _In_ REFIID riid,
    //        /* [annotation][iid_is][out] */
    //        _COM_Outptr_  void** ppv) = 0;
    //    };
    [System.Runtime.InteropServices.Guid("787cdaac-3186-476d-87e4-b9374a7b9970")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface IRadialControllerConfigurationInterop
    {
        RadialControllerConfiguration GetForWindow(IntPtr hwnd, [System.Runtime.InteropServices.In]ref Guid riid);
    }
}
