using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;

namespace UWPInterop
{
    //MIDL_INTERFACE("65219584-F9CB-4AE3-81F9-A28A6CA450D9")
    //IAppServiceConnectionExtendedExecution : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE OpenForExtendedExecutionAsync(
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][out] */ __RPC__deref_out_opt void** operation) = 0;
    //};
    [System.Runtime.InteropServices.Guid("65219584-F9CB-4AE3-81F9-A28A6CA450D9")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppServiceConnectionExtendedExecution
    {
        IAsyncOperation<AppServiceConnectionStatus> OpenForExtendedExecutionAsync([System.Runtime.InteropServices.In] ref Guid riid);
    }

    //Helper to intialize AppServiceConnection
    public static class AppServiceConnectionExtendedExecution
    {
        public static IAsyncOperation<AppServiceConnectionStatus> OpenForExtendedExecutionAsync()
        {
            IAppServiceConnectionExtendedExecution appServiceConnectionStatus = (IAppServiceConnectionExtendedExecution)WindowsRuntimeMarshal.GetActivationFactory(typeof(AppServiceConnection));
            Guid guid = typeof(IAsyncOperation<AppServiceConnectionStatus>).GUID;

            return appServiceConnectionStatus.OpenForExtendedExecutionAsync(ref guid);
        }
    }
}
