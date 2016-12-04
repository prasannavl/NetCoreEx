using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NetCoreEx.Colors
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Color
    {
        public uint Value { get; set; }

        public Color(uint value)
        {
            this.Value = value;
        }

        public static Color FromBgr24(byte r, byte g, byte b)
        {
            return new Color(ColorHelpers.Bgr24(r, g, b));
        }

        public Color(byte b, byte g, byte r, byte a)
        {
            this.Value = ColorHelpers.Bgra32(r, g, b, a);
        }
    }

}
