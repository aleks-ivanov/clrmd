﻿using System.Runtime.InteropServices;
using Microsoft.Diagnostics.Runtime.Desktop;

namespace Microsoft.Diagnostics.Runtime.DacInterface
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GCInfo : IGCInfo
    {
        public readonly int ServerMode;
        public readonly int GCStructuresValid;
        public readonly int HeapCount;
        public readonly int MaxGeneration;

        bool IGCInfo.ServerMode => ServerMode != 0;
        int IGCInfo.HeapCount => HeapCount;
        int IGCInfo.MaxGeneration => MaxGeneration;
        bool IGCInfo.GCStructuresValid => GCStructuresValid != 0;
    }
}