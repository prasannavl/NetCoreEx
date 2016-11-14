using System;
using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Size : IEquatable<Size>
    {
        public Size(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool Equals(Size other)
        {
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is Size && this.Equals((Size)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (this.Width * 397) ^ this.Height; }
        }

        public int Width;
        public int Height;

        public static bool operator ==(Size left, Size right)
        {
            return (left.Width == right.Width) && (left.Height == right.Height);
        }

        public static bool operator !=(Size left, Size right)
        {
            return !(left == right);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SizeS : IEquatable<SizeS>
    {
        public SizeS(short width, short height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool Equals(SizeS other)
        {
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is SizeS && this.Equals((SizeS)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (this.Width * 397) ^ this.Height; }
        }

        public short Width;
        public short Height;

        public static bool operator ==(SizeS left, SizeS right)
        {
            return (left.Width == right.Width) && (left.Height == right.Height);
        }

        public static bool operator !=(SizeS left, SizeS right)
        {
            return !(left == right);
        }
    }
}
