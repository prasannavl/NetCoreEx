namespace NetCoreEx.Colors
{
    public static class ColorHelpers
    {
        public static uint Bgr24(byte r, byte g, byte b)
        {
            return unchecked ((uint)(r | g << 8 | b << 16));
        }

        public static uint Bgra32(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(a | r << 8 | g << 16 | b << 24));
        }

        public static uint Rgb24(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(b | g << 8 | r << 16));
        }

        public static uint Rgba32(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(a | b << 8 | g << 16 | r << 24));
        }
    }
}