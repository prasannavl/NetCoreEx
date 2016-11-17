using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Margins
    {
        public Margins(int left = 0, int right = 0, int top = 0, int bottom = 0)
        {
            Left = left;
            Right = right;
            Top = top;
            Bottom = bottom;
        }

        public Margins(int x = 0, int y = 0): this(x, x, y, y) { }

        public Margins(int all = 0): this(all, all) { }

        public int Left, Right, Top, Bottom;
    }
}