using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.AllJoyn;

namespace UWPInterop
{
    //MIDL_INTERFACE("fd89c65b-b50e-4a19-9d0c-b42b783281cd")
    //IWindowsDevicesAllJoynBusAttachmentInterop : public IInspectable
    //{
    //public:
    //    virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Win32Handle(
    //        /* [retval][out] */ UINT64* value) = 0;

    //};
    [System.Runtime.InteropServices.Guid("fd89c65b-b50e-4a19-9d0c-b42b783281cd")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IWindowsDevicesAllJoynBusAttachmentInterop
    {
        IntPtr GetWin32Handle();
    }

    //MIDL_INTERFACE("4b8f7505-b239-4e7b-88af-f6682575d861")
    //IWindowsDevicesAllJoynBusAttachmentFactoryInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE CreateFromWin32Handle(
    //        /* [in] */ UINT64 win32handle,
    //        /* [in] */ boolean enableAboutData,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][out] */ void** ppv) = 0;
    //};
    [System.Runtime.InteropServices.Guid("4b8f7505-b239-4e7b-88af-f6682575d861")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IWindowsDevicesAllJoynBusAttachmentFactoryInterop
    {
        AllJoynBusAttachment CreateFromWin32Handle(IntPtr win32Handle, bool enableAboutData, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //MIDL_INTERFACE("d78aa3d5-5054-428f-99f2-ec3a5de3c3bc")
    //IWindowsDevicesAllJoynBusObjectInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE AddPropertyGetHandler(
    //        /* [in] */ PVOID context,
    //        /* [in] */ HSTRING interfaceName,
    //        /* [in] */ INT32 (STDMETHODCALLTYPE* callback )(
    //            PVOID context,
    //            HSTRING interfaceName,
    //            HSTRING propertyName,
    //            alljoyn_msgarg value)) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE AddPropertySetHandler(
    //        /* [in] */ PVOID context,
    //        /* [in] */ HSTRING interfaceName,
    //        /* [in] */ INT32 (STDMETHODCALLTYPE* callback )(
    //            PVOID context,
    //            HSTRING interfaceName,
    //            HSTRING propertyName,
    //            alljoyn_msgarg value)) = 0;

    //    virtual /* [propget] */ HRESULT STDMETHODCALLTYPE get_Win32Handle(
    //        /* [retval][out] */ UINT64* value) = 0;

    //};
    [System.Runtime.InteropServices.Guid("d78aa3d5-5054-428f-99f2-ec3a5de3c3bc")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IWindowsDevicesAllJoynBusObjectInterop
    {
        int AddPropertyHandler();
        int AddPropertySetHandler();
        UInt64 GetWin32Handle();
    }

    //MIDL_INTERFACE("6174e506-8b95-4e36-95c0-b88fed34938c")
    //IWindowsDevicesAllJoynBusObjectFactoryInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE CreateFromWin32Handle(
    //        /* [in] */ UINT64 win32handle,
    //        /* [in] */ REFIID riid,
    //        /* [iid_is][out] */ void** ppv) = 0;

    //};
    [System.Runtime.InteropServices.Guid("6174e506-8b95-4e36-95c0-b88fed34938c")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IWindowsDevicesAllJoynBusObjectFactoryInterop
    {
        AllJoynBusObject CreateFromWin32Handle(IntPtr win32Handle, [System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to initialize AllJoynBusAttachment
    public static class AllJoynBusAttachmentInterop
    {
        public static IntPtr GetWin32Handle()
        {
            IWindowsDevicesAllJoynBusAttachmentInterop allJoynBusAttachmentInterop = (IWindowsDevicesAllJoynBusAttachmentInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AllJoynBusAttachment));

            //Guid guid = typeof(AllJoynBusAttachment).GetInterface("IAllJoynBusAttachment").GUID;
            //Guid guid = typeof(AllJoynBusAttachment).GUID;

            return allJoynBusAttachmentInterop.GetWin32Handle();
        }
    }

    //Helper to initialize AllJoynBusAttachmentFactory
    public static class AllJoynBusAttachmentFactoryInterop
    {
        public static AllJoynBusAttachment CreateFromWin32Handle(IntPtr hWnd, bool enableAboutData)
        {
            IWindowsDevicesAllJoynBusAttachmentFactoryInterop allJoynBusAttachmentInterop = (IWindowsDevicesAllJoynBusAttachmentFactoryInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AllJoynBusAttachment));

            //Guid guid = typeof(AllJoynBusAttachmentFactory).GetInterface("IAllJoynBusAttachmentFactory").GUID;
            Guid guid = typeof(AllJoynBusAttachment).GUID;

            return allJoynBusAttachmentInterop.CreateFromWin32Handle(hWnd, enableAboutData, ref guid);
        }
    }

    //Helper to initialize AllJoynBusObject
    public static class AllJoynBusObjectInterop
    {
        public static AllJoynBusObject CreateFromWin32Handle(IntPtr hWnd)
        {
            IWindowsDevicesAllJoynBusObjectFactoryInterop allJoynBusObjectInterop = (IWindowsDevicesAllJoynBusObjectFactoryInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(AllJoynBusObject));

            //Guid guid = typeof(AllJoynBusObject).GetInterface("IAllJoynBusObject").GUID;
            Guid guid = typeof(AllJoynBusObject).GUID;

            return allJoynBusObjectInterop.CreateFromWin32Handle(hWnd, ref guid);
        }
    }
}
