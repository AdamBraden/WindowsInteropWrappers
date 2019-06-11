using System;
using System.Collections.Generic;
using System.Text;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;

namespace WindowsInterop
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
    interface IAppServiceConnectionExtendedExecution
    {
        IAsyncOperation<AppServiceConnectionStatus> OpenForExtendedExecutionAsync([System.Runtime.InteropServices.In] ref Guid riid);
    }
}
