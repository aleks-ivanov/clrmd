using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.ICorDebug
{
    [ComImport, Guid("CC7BCAF5-8A68-11D2-983C-0000F808342D"), InterfaceType(1)]
    public interface ICorDebugClass
    {

        void GetModule([Out, MarshalAs(UnmanagedType.Interface)] out ICorDebugModule pModule);

        void GetToken([Out] out uint pTypeDef);

        void GetStaticFieldValue([In] uint fieldDef, [In, MarshalAs(UnmanagedType.Interface)] ICorDebugFrame pFrame, [Out, MarshalAs(UnmanagedType.Interface)] out ICorDebugValue ppValue);
    }
}