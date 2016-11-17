namespace NetCoreEx.BinaryExtensions
{
    public static class IntExtensions
    {
        public static short Low(this int dword)
        {
            return unchecked((short) dword);
        }

        public static int WithLow(this int dword, short low16)
        {
            return unchecked((int) (dword & 0xffff0000) | (ushort) low16);
        }

        public static short High(this int dword)
        {
            return unchecked((short) (dword >> 16));
        }

        public static int WithHigh(this int dword, short high16)
        {
            return (high16 << 16) | dword.LowAsInt();
        }

        public static int LowAsInt(this int dword)
        {
            return dword & 0xffff;
        }

        public static int HighAsInt(this int dword)
        {
            return (dword >> 16) & 0xffff;
        }
    }

    public static class UIntExtensions
    {
        public static ushort Low(this uint dword)
        {
            return (ushort) dword;
        }

        public static uint WithLow(this uint dword, ushort low16)
        {
            return (dword & 0xffff0000) | low16;
        }

        public static ushort High(this uint dword)
        {
            return (ushort) (dword >> 16);
        }

        public static uint WithHigh(this uint dword, ushort high16)
        {
            return ((uint) high16 << 16) | dword.LowAsUInt();
        }

        public static uint LowAsUInt(this uint dword)
        {
            return dword & 0xffff;
        }

        public static uint HighAsUInt(this uint dword)
        {
            return (dword >> 16) & 0xffff;
        }
    }

    public static class LongExtensions
    {
        public static int Low(this long qword)
        {
            return unchecked((int) qword);
        }

        public static long WithLow(this long qword, int low32)
        {
            return unchecked(qword & (long) 0xffffffff00000000) | (uint) low32;
        }

        public static int High(this long qword)
        {
            return unchecked((int) (qword >> 32));
        }

        public static long WithHigh(this long qword, int high32)
        {
            return ((long) high32 << 32) | qword.LowAsLong();
        }

        public static long LowAsLong(this long qword)
        {
            return qword & 0xffffffff;
        }

        public static long HighAsLong(this long qword)
        {
            return (qword >> 32) & 0xffffffff;
        }
    }

    public static class ULongExtensions
    {
        public static uint Low(this ulong qword)
        {
            return (uint) qword;
        }

        public static ulong WithLow(this ulong qword, uint low32)
        {
            return (qword & 0xffffffff00000000) | low32;
        }

        public static uint High(this ulong qword)
        {
            return (uint) (qword >> 32);
        }

        public static ulong WithHigh(this ulong qword, uint high32)
        {
            return ((ulong) high32 << 32) | qword.LowAsULong();
        }

        public static ulong LowAsULong(this ulong qword)
        {
            return qword & 0xffffffff;
        }

        public static ulong HighAsULong(this ulong qword)
        {
            return (qword >> 32) & 0xffffffff;
        }
    }
}