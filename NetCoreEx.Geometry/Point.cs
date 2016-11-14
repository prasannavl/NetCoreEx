using System;
using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point : IEquatable<Point>
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(Point other)
        {
            return (this.X == other.X) && (this.Y == other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Point && this.Equals((Point)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (this.X * 397) ^ this.Y; }
        }

        public int X, Y;

        public static bool operator ==(Point left, Point right)
        {
            return (left.X == right.X) && (left.Y == right.Y);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PointS : IEquatable<PointS>
    {
        public PointS(short x, short y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(PointS other)
        {
            return (this.X == other.X) && (this.Y == other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointS && this.Equals((PointS)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (this.X * 397) ^ this.Y; }
        }

        public short X, Y;

        public static bool operator ==(PointS left, PointS right)
        {
            return (left.X == right.X) && (left.Y == right.Y);
        }

        public static bool operator !=(PointS left, PointS right)
        {
            return !(left == right);
        }
    }
}