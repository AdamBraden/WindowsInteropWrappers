using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Foundation;
using Windows.Security.EnterpriseData;

namespace UWPInterop
{
    //MIDL_INTERFACE("4652651d-c1fe-4ba1-9F0a-c0f56596f721")
    //IProtectionPolicyManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING targetIdentity,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** result) = 0;
    //};
    [System.Runtime.InteropServices.Guid("4652651d-c1fe-4ba1-9F0a-c0f56596f721")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IProtectionPolicyManagerInterop
    {
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string targetIdentity, [In] ref Guid riid);
        ProtectionPolicyManager GetForWindow(IntPtr appWindow, [In] ref Guid riid);
    }

    //MIDL_INTERFACE("157cfbe4-a78d-4156-b384-61fdac41e686")
    //IProtectionPolicyManagerInterop2 : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessForAppWithWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessWithAuditingInfoForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING targetIdentity,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessWithMessageForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING targetIdentity,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessForAppWithAuditingInfoForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessForAppWithMessageForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //};
    [System.Runtime.InteropServices.Guid("157cfbe4-a78d-4156-b384-61fdac41e686")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    public interface IProtectionPolicyManagerInterop2
    {
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppWithWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string appPackageFamilyName, [System.Runtime.InteropServices.In] ref Guid riid);

        //TODO: Need to validate the 4 below...
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessWithAuditingInfoForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string targetIdentity, ProtectionPolicyAuditInfo auditInfoUnk, [System.Runtime.InteropServices.In] ref Guid riid);
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessWithMessageForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string targetIdentity, ProtectionPolicyAuditInfo auditInfoUnk, [MarshalAs(UnmanagedType.HString)] string messageFromApp, [In] ref Guid riid);
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppWithAuditingInfoForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string appPackageFamilyName, ProtectionPolicyAuditInfo auditInfoUnk, [In] ref Guid riid);
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessForAppWithMessageForWindowAsync(IntPtr appWindow, [MarshalAs(UnmanagedType.HString)] string sourceIdentity, [MarshalAs(UnmanagedType.HString)] string appPackageFamilyName, ProtectionPolicyAuditInfo auditInfoUnk, [MarshalAs(UnmanagedType.HString)] string messageFromApp, [In] ref Guid riid);

    }
    //MIDL_INTERFACE("c1c03933-b398-4d93-b0fd-2972adf802c2")
    //IProtectionPolicyManagerInterop3 : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessWithBehaviorForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING targetIdentity,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ UINT32 behavior,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessForAppWithBehaviorForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in HSTRING sourceIdentity,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ UINT32 behavior,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessToFilesForAppForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in_opt IUnknown *sourceItemListUnk,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessToFilesForAppWithMessageAndBehaviorForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in_opt IUnknown *sourceItemListUnk,
    //        /* [in] */ __RPC__in HSTRING appPackageFamilyName,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ UINT32 behavior,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessToFilesForProcessForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in_opt IUnknown *sourceItemListUnk,
    //        /* [in] */ UINT32 processId,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //    virtual HRESULT STDMETHODCALLTYPE RequestAccessToFilesForProcessWithMessageAndBehaviorForWindowAsync(
    //        /* [in] */ __RPC__in HWND appWindow,
    //        /* [in] */ __RPC__in_opt IUnknown *sourceItemListUnk,
    //        /* [in] */ UINT32 processId,
    //        /* [in] */ __RPC__in_opt IUnknown *auditInfoUnk,
    //        /* [in] */ __RPC__in HSTRING messageFromApp,
    //        /* [in] */ UINT32 behavior,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** asyncOperation) = 0;

    //};

}
