﻿using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DEBUG_LAST_EVENT_INFO_UNLOAD_MODULE
    {
        public ulong Base;
    }
}