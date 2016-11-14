using System;

namespace NetCoreEx.BinaryExtensions
{
    public static class IntPtrExtensions
    {
        public static int ToSafeInt32(this IntPtr ptr)
        {
            return unchecked(IntPtr.Size > 4 ? (int)ptr.ToInt64() : ptr.ToInt32());
        }

        public static uint ToSafeUInt32(this IntPtr ptr)
        {
            return IntPtr.Size > 4 ? (uint)ptr.ToInt64() : (uint)ptr.ToInt32();
        }

        public static void BreakInt64Into32(this IntPtr ptr, out int high32, out int low32)
        {
            var param = ptr.ToInt64();
            low32 = param.Low();
            high32 = param.High();
        }

        public static void BreakInt64Into32(this IntPtr ptr, out long high32, out long low32)
        {
            var param = ptr.ToInt64();
            low32 = param.LowAsLong();
            high32 = param.HighAsLong();
        }

        public static void BreakInt64Into32Signed(this IntPtr ptr, out long high32, out long low32)
        {
            var param = ptr.ToInt64();
            low32 = param.Low();
            high32 = param.High();
        }

        public static void BreakInt32Into16(this IntPtr ptr, out int high16, out int low16)
        {
            var param = ptr.ToInt32();
            low16 = param.LowAsInt();
            high16 = param.HighAsInt();
        }

        public static void BreakInt32Into16Signed(this IntPtr ptr, out int high16, out int low16)
        {
            var param = ptr.ToInt32();
            low16 = param.Low();
            high16 = param.High();
        }

        public static void BreakInt32Into16(this IntPtr ptr, out short high16, out short low16)
        {
            var param = ptr.ToInt32();
            low16 = param.Low();
            high16 = param.High();
        }

        public static void BreakSafeInt32To16(this IntPtr ptr, out short high16, out short low16)
        {
            var param = ptr.ToSafeInt32();
            low16 = param.Low();
            high16 = param.High();
        }

        public static void BreakSafeInt32To16(this IntPtr ptr, out int high16, out int low16)
        {
            var param = ptr.ToSafeInt32();
            low16 = param.LowAsInt();
            high16 = param.HighAsInt();
        }

        public static void BreakSafeInt32To16Signed(this IntPtr ptr, out int high16, out int low16)
        {
            var param = ptr.ToSafeInt32();
            low16 = param.Low();
            high16 = param.High();
        }
    }
}