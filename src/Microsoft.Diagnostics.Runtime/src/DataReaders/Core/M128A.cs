﻿using System;
using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct M128A
    {
        public ulong Low;
        public ulong High;

        public void Clear()
        {
            Low = 0;
            High = 0;
        }

        public static bool operator ==(M128A lhs, M128A rhs)
        {
            return lhs.Low == rhs.Low && lhs.High == rhs.High;
        }

        public static bool operator !=(M128A lhs, M128A rhs)
        {
            return lhs.Low != rhs.Low || lhs.High != rhs.High;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");

            if (obj.GetType() != typeof(M128A))
                return false;

            return this == (M128A)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}