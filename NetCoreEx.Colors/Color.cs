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
        private uint value;

        public Color(uint value)
        {
            this.value = value;
        }

        public Color(byte b, byte g, byte r, byte a)
        {
            this.value = ColorHelpers.ToBgra32(r, g, b, a);
        }
    }
}
