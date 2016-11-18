namespace NetCoreEx.Colors
{
    public static class ColorHelpers
    {
        public static uint ToBgr24(byte r, byte g, byte b)
        {
            return unchecked ((uint)(r | g << 8 | b << 16));
        }

        public static uint ToBgra32(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(a | r << 8 | g << 16 | b << 24));
        }

        public static uint ToRgb24(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(b | g << 8 | r << 16));
        }

        public static uint ToRgba32(byte r, byte g, byte b, byte a)
        {
            return unchecked((uint)(a | b << 8 | g << 16 | r << 24));
        }
    }
}