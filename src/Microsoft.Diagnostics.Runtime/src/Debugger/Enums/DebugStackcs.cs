﻿using System;

namespace Microsoft.Diagnostics.Runtime.Interop
{
    [Flags]
    public enum DEBUG_STACK : uint
    {
        ARGUMENTS = 0x1,
        FUNCTION_INFO = 0x2,
        SOURCE_LINE = 0x4,
        FRAME_ADDRESSES = 0x8,
        COLUMN_NAMES = 0x10,
        NONVOLATILE_REGISTERS = 0x20,
        FRAME_NUMBERS = 0x40,
        PARAMETERS = 0x80,
        FRAME_ADDRESSES_RA_ONLY = 0x100,
        FRAME_MEMORY_USAGE = 0x200,
        PARAMETERS_NEWLINE = 0x400,
        DML = 0x800,
        FRAME_OFFSETS = 0x1000,
    }
}