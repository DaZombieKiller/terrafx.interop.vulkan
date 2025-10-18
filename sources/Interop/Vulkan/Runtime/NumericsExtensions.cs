using System;

namespace TerraFX.Interop;

internal static unsafe class UIntPtrExtensions
{
    extension(nuint @this)
    {
        public int CompareTo(nuint other) => sizeof(nuint) == sizeof(uint) ? ((uint)@this).CompareTo((uint)other) : ((ulong)@this).CompareTo(other);

        public string ToString(string? format) => sizeof(nuint) == sizeof(uint) ? ((uint)@this).ToString(format) : ((ulong)@this).ToString(format);

        public string ToString(string? format, IFormatProvider? formatProvider) => sizeof(nuint) == sizeof(uint) ? ((uint)@this).ToString(format, formatProvider) : ((ulong)@this).ToString(format, formatProvider);
    }
}

internal static unsafe class IntPtrExtensions
{
    extension(nint @this)
    {
        public int CompareTo(nint other) => sizeof(nint) == sizeof(int) ? ((int)@this).CompareTo((int)other) : ((long)@this).CompareTo(other);

        public string ToString(string? format) => sizeof(nint) == sizeof(int) ? ((int)@this).ToString(format) : ((long)@this).ToString(format);

        public string ToString(string? format, IFormatProvider? formatProvider) => sizeof(nint) == sizeof(int) ? ((int)@this).ToString(format, formatProvider) : ((long)@this).ToString(format, formatProvider);
    }
}
