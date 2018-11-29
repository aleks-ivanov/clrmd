using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.ICorDebug
{
    [ComImport, InterfaceType(1), Guid("8CB96A16-B588-42E2-B71C-DD849FC2ECCC")]
    public interface ICorDebugAppDomain3
    {
        void GetCachedWinRTTypesForIIDs([In] uint cReqTypes, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] System.Guid[] iidsToResolve, out ICorDebugTypeEnum ppTypesEnum);

        void GetCachedWinRTTypes(out ICorDebugGuidToTypeEnum ppGuidToTypeEnum);
    }
}