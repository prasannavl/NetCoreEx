using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Margins
    {
        public Margins(int left = 0, int right = 0, int top = 0, int bottom = 0)
        {
            this.Left = left;
            this.Right = right;
            this.Top = top;
            this.Bottom = bottom;
        }

        public Margins(int x = 0, int y = 0)
        {
            this.Left = this.Right = x;
            this.Top = this.Bottom = y;
        }

        public Margins(int all = 0)
        {
            this.Left = this.Right = this.Top = this.Bottom = all;
        }

        public int Left, Right, Top, Bottom;
    }
}