# WindowsInteropWrappers
Repo to prototype creating .Net wrappers for the Interop interfaces in UWP.
A lot of these wrap APIs that pop a dialog which relies upon CoreWindow, which is not available in Win32 & .NET. 
The APIs expose an Interop interface, usually in the shape of <IManagerInterop>.GetForWindow(hWnd) that allow 
calling the API from Win32 & .NET.

Some APIs expose additional interop interfaces. This repo will focus on the CoreWindow dependencies
