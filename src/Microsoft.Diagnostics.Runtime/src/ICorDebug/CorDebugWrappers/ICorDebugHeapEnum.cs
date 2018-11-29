using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.ICorDebug
{
    [ComImport, InterfaceType(1), Guid("76D7DAB8-D044-11DF-9A15-7E29DFD72085"), ComConversionLoss]
    public interface ICorDebugHeapEnum : ICorDebugEnum
    {
        new void Skip([In] uint celt);

        new void Reset();

        new void Clone([Out, MarshalAs(UnmanagedType.Interface)] out ICorDebugEnum ppEnum);

        new void GetCount([Out] out uint pcelt);

        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int Next([In] uint celt, [Out, MarshalAs(UnmanagedType.LPArray)] COR_HEAPOBJECT[] objs, [Out] out uint pceltFetched);
    }
}