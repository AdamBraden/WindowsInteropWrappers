using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Windows.Media.Casting;

namespace UWPInterop
{
    //MIDL_INTERFACE("C79A6CB7-BEBD-47a6-A2AD-4D45AD79C7BC")
    //ICastingEventHandler : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE OnStateChanged(
    //        /* [in] */ CASTING_CONNECTION_STATE newState) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE OnError(
    //        /* [in] */ CASTING_CONNECTION_ERROR_STATUS errorStatus,
    //        /* [in] */ __RPC__in LPCWSTR errorMessage) = 0;

    //};
    [System.Runtime.InteropServices.Guid("C79A6CB7-BEBD-47a6-A2AD-4D45AD79C7BC")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICastingEventHandler
    {
        TypedEventHandler<CastingConnection, CastingConnectionState> OnStateChanged();
        TypedEventHandler<CastingConnection, CastingConnectionErrorOccurredEventArgs> OnError();
    }

    //MIDL_INTERFACE("F0A56423-A664-4fbd-8B43-409A45E8D9A1")
    //ICastingController : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE Initialize(
    //        /* [in] */ __RPC__in_opt IUnknown *castingEngine,
    //        /* [in] */ __RPC__in_opt IUnknown *castingSource) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE Connect(void) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE Disconnect(void) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE Advise(
    //        /* [in] */ __RPC__in_opt ICastingEventHandler *eventHandler,
    //        /* [out] */ __RPC__out DWORD *cookie) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE UnAdvise(
    //        /* [in] */ DWORD cookie) = 0;
    //};
    [System.Runtime.InteropServices.Guid("F0A56423-A664-4fbd-8B43-409A45E8D9A1")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICastingController
    {
        void Initialize(object CastingEngine, object CastingSource);
        void Connect();
        void Disconnect();
        int Advise(ICastingEventHandler EventHandler);
        void UnAdvise(int Cookie);
    }
}
