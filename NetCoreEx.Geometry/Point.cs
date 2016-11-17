
using System;
using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry {

    [StructLayout(LayoutKind.Sequential)]
	public partial struct Point : IEquatable<Point>
	{
	    public Point(int  x, int  y)
        {
			X = x;
			Y = y;
        }

        public bool Equals(Point other)
        {
            return (X == other.X) && (Y == other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Point && Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)X*397) ^ (int)Y; }
        }

        public int  X, Y;

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }

		public void Offset(int  x, int  y) {
			X += x;
			Y += y;
		}

		public void Set(int  x, int  y) {
			X = x;
			Y = y;
		}
	}

    [StructLayout(LayoutKind.Sequential)]
	public partial struct PointS : IEquatable<PointS>
	{
	    public PointS(short  x, short  y)
        {
			X = x;
			Y = y;
        }

        public bool Equals(PointS other)
        {
            return (X == other.X) && (Y == other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointS && Equals((PointS) obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)X*397) ^ (int)Y; }
        }

        public short  X, Y;

        public static bool operator ==(PointS left, PointS right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PointS left, PointS right)
        {
            return !(left == right);
        }

		public void Offset(short  x, short  y) {
			X += x;
			Y += y;
		}

		public void Set(short  x, short  y) {
			X = x;
			Y = y;
		}
	}

    [StructLayout(LayoutKind.Sequential)]
	public partial struct PointF : IEquatable<PointF>
	{
	    public PointF(float  x, float  y)
        {
			X = x;
			Y = y;
        }

        public bool Equals(PointF other)
        {
            return (X == other.X) && (Y == other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointF && Equals((PointF) obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)X*397) ^ (int)Y; }
        }

        public float  X, Y;

        public static bool operator ==(PointF left, PointF right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PointF left, PointF right)
        {
            return !(left == right);
        }

		public void Offset(float  x, float  y) {
			X += x;
			Y += y;
		}

		public void Set(float  x, float  y) {
			X = x;
			Y = y;
		}
	}

}
