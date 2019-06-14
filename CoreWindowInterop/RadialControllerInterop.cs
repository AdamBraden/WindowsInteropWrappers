using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Input;
using Windows.UI.Input.Core;

namespace UWPInterop
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
    public interface IRadialControllerInterop
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
    public interface IRadialControllerConfigurationInterop
    {
        RadialControllerConfiguration GetForWindow(IntPtr hwnd, [System.Runtime.InteropServices.In]ref Guid riid);
    }

    //MIDL_INTERFACE("3D577EFF-4CEE-11E6-B535-001BDC06AB3B")
    //IRadialControllerIndependentInputSourceInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE CreateForWindow(
    //        /* [annotation][in] */
    //        _In_ HWND hwnd,
    //        /* [annotation][in] */
    //        _In_ REFIID riid,
    //        /* [annotation][iid_is][out] */
    //        _COM_Outptr_  void** ppv) = 0;

    //};
    [System.Runtime.InteropServices.Guid("3D577EFF-4CEE-11E6-B535-001BDC06AB3B")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IRadialControllerIndependentInputSourceInterop
    {
        RadialControllerIndependentInputSource CreateForWindow(IntPtr hwnd, [System.Runtime.InteropServices.In]ref Guid riid);
    }

    //Helper to initialize RadialController
    public static class RadialControllerInterop
    {
        public static RadialController Initialize(IntPtr hWnd)
        {
            IRadialControllerInterop radialControllerInterop = (IRadialControllerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(RadialController));
            Guid guid = typeof(RadialController).GUID;
            
            return radialControllerInterop.CreateForWindow(hWnd, ref guid);
        }
    }

    //Helper to initialize RadialControllerConfiguration
    public static class RadialControllerConfigurationInterop
    {
        public static RadialControllerConfiguration Initialize(IntPtr hWnd)
        {

            IRadialControllerConfigurationInterop radialControllerConfigInterop = (IRadialControllerConfigurationInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(RadialControllerConfiguration));
            Guid guid = typeof(RadialControllerConfiguration).GUID;

            return radialControllerConfigInterop.GetForWindow(hWnd, ref guid);
        }
    }

    //Helper to initialize RadialControllerIndependentInputSource
    public static class RadialControllerIndependentInputSourceInterop
    {
        public static RadialControllerIndependentInputSource Initialize(IntPtr hwnd)
        {
            IRadialControllerIndependentInputSourceInterop radialControllerIndependentInputSourceInterop = (IRadialControllerIndependentInputSourceInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(RadialControllerIndependentInputSource));
            Guid guid = typeof(RadialControllerIndependentInputSource).GUID;

            return radialControllerIndependentInputSourceInterop.CreateForWindow(hwnd, ref guid);
        }
    }

}
