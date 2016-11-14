using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rectangle
    {
        public static Rectangle Create(int x, int y, int width, int height)
        {
            return new Rectangle(x, y, width + x, height + y);
        }

        public Rectangle(int left = 0, int top = 0, int right = 0, int bottom = 0)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        public Rectangle(int width = 0, int height = 0)
        {
            this.Left = 0;
            this.Top = 0;
            this.Right = width;
            this.Bottom = height;
        }

        public Rectangle(int all = 0)
        {
            this.Left = this.Right = this.Top = this.Bottom = all;
        }

        public int Left, Top, Right, Bottom;

        public int Width { get { return this.Right - this.Left; } set { this.Right = this.Left + value; } }

        public int Height { get { return this.Bottom - this.Top; } set { this.Bottom = this.Top + value; } }

        public Size GetSize()
        {
            return new Size(this.Width, this.Height);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RectangleS
    {
        public RectangleS(short left = 0, short top = 0, short right = 0, short bottom = 0)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        public short Left, Top, Right, Bottom;

        public short Width
        {
            get { return (short)(this.Right - this.Left); }
            set { this.Right = (short)(this.Left + value); }
        }

        public short Height
        {
            get { return (short)(this.Bottom - this.Top); }
            set { this.Bottom = (short)(this.Top + value); }
        }
    }
}