using System;
using System.Collections.Generic;
using System.Text;
using Windows.Data.Pdf;

namespace UWPInterop
{
    //MIDL_INTERFACE("7d9dcd91-d277-4947-8527-07a0daeda94a")
    //IPdfRendererNative : public IUnknown
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RenderPageToSurface(
    //        /* [annotation][in] */
    //        _In_ IUnknown *pdfPage,
    //        /* [annotation][in] */
    //        _In_ IDXGISurface *pSurface,
    //        /* [annotation][in] */
    //        _In_ POINT offset,
    //        /* [annotation][in] */
    //        _In_opt_ PDF_RENDER_PARAMS *pRenderParams) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RenderPageToDeviceContext(
    //        /* [annotation][in] */
    //        _In_ IUnknown *pdfPage,
    //        /* [annotation][in] */
    //        _In_ ID2D1DeviceContext *pD2DDeviceContext,
    //        /* [annotation][in] */
    //        _In_opt_ PDF_RENDER_PARAMS *pRenderParams) = 0;

    //};
    [System.Runtime.InteropServices.Guid("7d9dcd91-d277-4947-8527-07a0daeda94a")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPdfRendererNative
    {
        //int RenderPageToSurface(...);
        //int RenderPageToDeviceContext(...);
    }
}
