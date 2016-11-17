
using System;
using System.Runtime.InteropServices;

namespace NetCoreEx.Geometry {

    [StructLayout(LayoutKind.Sequential)]
	public partial struct Rectangle : IEquatable<Rectangle>
	{
		public Rectangle(int left = 0, int  top = 0, int  right = 0, int  bottom = 0)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rectangle(int  width = 0, int  height = 0) : this(0, 0, width, height) { }
        public Rectangle(int  all = 0) : this(all, all, all, all) { }

        public int  Left, Top, Right, Bottom;

        public bool Equals(Rectangle other)
        {
            return (Left == other.Left) && (Right == other.Right) && (Top == other.Top) && (Bottom == other.Bottom);
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle && Equals((Rectangle)obj);
        }

        public static bool operator ==(Rectangle left, Rectangle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Rectangle left, Rectangle right)
        {
            return !(left == right);
        }

		public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)Left;
                hashCode = (hashCode*397) ^ (int)Top;
                hashCode = (hashCode*397) ^ (int)Right;
                hashCode = (hashCode*397) ^ (int)Bottom;
                return hashCode;
            }
        }

		public Size Size
        {
            get { return new Size(Width, Height); }
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

		public bool IsEmpty
		{
		  get
		  {
			return this.Left == 0 && this.Top == 0 && this.Right == 0 && this.Bottom == 0;
		  }
		}

		public int  Width { get {  return unchecked((int)(Right - Left)); } set { Right = unchecked((int)(Left + value)); } }
        public int  Height { get { return unchecked((int)(Bottom - Top)); } set { Bottom = unchecked((int)(Top + value)); } }

		public static Rectangle Create(int  x, int  y, int  width, int  height)
		{
			unchecked {
				return new Rectangle(x, y, (int)(width + x), (int)(height + y));			
			}
		}

        public static Rectangle From(ref Rectangle lvalue, ref Rectangle rvalue,
            Func<int , int , int > leftTopOperation,
            Func<int , int , int > rightBottomOperation = null)
        {
            if (rightBottomOperation == null) rightBottomOperation = leftTopOperation;
            return new Rectangle(
                leftTopOperation(lvalue.Left, rvalue.Left),
                leftTopOperation(lvalue.Top, rvalue.Top),
                rightBottomOperation(lvalue.Right, rvalue.Right),
                rightBottomOperation(lvalue.Bottom, rvalue.Bottom)
            );
        }

        public void Add(Rectangle value)
        {
            Add(ref this, ref value);
        }

        public void Subtract(Rectangle value)
        {
            Subtract(ref this, ref value);
        }

		public void Multiply(Rectangle value)
        {
            Multiply(ref this, ref value);
        }

		public void Divide(Rectangle value)
        {
            Divide(ref this, ref value);
        }

        public void Deflate(Rectangle value)
        {
            Deflate(ref this, ref value);
        }

        public void Inflate(Rectangle value)
        {
            Inflate(ref this, ref value);
        }

        public void Offset(int  x, int  y)
        {
            Offset(ref this, x, y);
        }

		public void OffsetTo(int  x, int  y)
        {
            OffsetTo(ref this, x, y);
        }

        public void Scale(int  x, int  y)
        {
            Scale(ref this, x, y);
        }

		public void ScaleTo(int  x, int  y)
        {
            ScaleTo(ref this, x, y);
        }

        public static void Add(ref Rectangle lvalue, ref Rectangle rvalue)
        {
            lvalue.Left += rvalue.Left;
            lvalue.Top += rvalue.Top;
            lvalue.Right += rvalue.Right;
            lvalue.Bottom += rvalue.Bottom;
        }

        public static void Subtract(ref Rectangle lvalue, ref Rectangle rvalue)
        {
            lvalue.Left -= rvalue.Left;
            lvalue.Top -= rvalue.Top;
            lvalue.Right -= rvalue.Right;
            lvalue.Bottom -= rvalue.Bottom;
        }

		public static void Multiply(ref Rectangle lvalue, ref Rectangle rvalue)
        {
            lvalue.Left *= rvalue.Left;
            lvalue.Top *= rvalue.Top;
            lvalue.Right *= rvalue.Right;
            lvalue.Bottom *= rvalue.Bottom;
        }

		public static void Divide(ref Rectangle lvalue, ref Rectangle rvalue)
        {
            lvalue.Left /= rvalue.Left;
            lvalue.Top /= rvalue.Top;
            lvalue.Right /= rvalue.Right;
            lvalue.Bottom /= rvalue.Bottom;
        }

        public static void Deflate(ref Rectangle target, ref Rectangle deflation)
        {
            target.Top += deflation.Top;
            target.Left += deflation.Left;
            target.Bottom -= deflation.Bottom;
            target.Right -= deflation.Right;
        }

        public static void Inflate(ref Rectangle target, ref Rectangle inflation)
        {
            target.Top -= inflation.Top;
            target.Left -= inflation.Left;
            target.Bottom += inflation.Bottom;
            target.Right += inflation.Right;
        }

        public static void Offset(ref Rectangle target, int  x, int  y)
        {
            target.Top += y;
            target.Left += x;
            target.Bottom += y;
            target.Right += x;
        }

		public static void OffsetTo(ref Rectangle target, int x, int y)
        {
            var width = target.Width;
            var height = target.Height;
            target.Left = x;
            target.Top = y;
            target.Right = width;
            target.Bottom = height;
        }

        public static void Scale(ref Rectangle target, int  x, int  y)
        {
            target.Top *= y;
            target.Left *= x;
            target.Bottom *= y;
            target.Right *= x;
        }

		public static void ScaleTo(ref Rectangle target, int  x, int  y)
        {
			unchecked {
				x = (int)(target.Left / x);
				y = (int)(target.Top / y);
			}
			Scale(ref target, x, y);
        }

	}
	    [StructLayout(LayoutKind.Sequential)]
	public partial struct RectangleS : IEquatable<RectangleS>
	{
		public RectangleS(short left = 0, short  top = 0, short  right = 0, short  bottom = 0)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public RectangleS(short  width = 0, short  height = 0) : this(0, 0, width, height) { }
        public RectangleS(short  all = 0) : this(all, all, all, all) { }

        public short  Left, Top, Right, Bottom;

        public bool Equals(RectangleS other)
        {
            return (Left == other.Left) && (Right == other.Right) && (Top == other.Top) && (Bottom == other.Bottom);
        }

        public override bool Equals(object obj)
        {
            return obj is RectangleS && Equals((RectangleS)obj);
        }

        public static bool operator ==(RectangleS left, RectangleS right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RectangleS left, RectangleS right)
        {
            return !(left == right);
        }

		public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)Left;
                hashCode = (hashCode*397) ^ (int)Top;
                hashCode = (hashCode*397) ^ (int)Right;
                hashCode = (hashCode*397) ^ (int)Bottom;
                return hashCode;
            }
        }

		public SizeS Size
        {
            get { return new SizeS(Width, Height); }
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

		public bool IsEmpty
		{
		  get
		  {
			return this.Left == 0 && this.Top == 0 && this.Right == 0 && this.Bottom == 0;
		  }
		}

		public short  Width { get {  return unchecked((short)(Right - Left)); } set { Right = unchecked((short)(Left + value)); } }
        public short  Height { get { return unchecked((short)(Bottom - Top)); } set { Bottom = unchecked((short)(Top + value)); } }

		public static RectangleS Create(short  x, short  y, short  width, short  height)
		{
			unchecked {
				return new RectangleS(x, y, (short)(width + x), (short)(height + y));			
			}
		}

        public static RectangleS From(ref RectangleS lvalue, ref RectangleS rvalue,
            Func<short , short , short > leftTopOperation,
            Func<short , short , short > rightBottomOperation = null)
        {
            if (rightBottomOperation == null) rightBottomOperation = leftTopOperation;
            return new RectangleS(
                leftTopOperation(lvalue.Left, rvalue.Left),
                leftTopOperation(lvalue.Top, rvalue.Top),
                rightBottomOperation(lvalue.Right, rvalue.Right),
                rightBottomOperation(lvalue.Bottom, rvalue.Bottom)
            );
        }

        public void Add(RectangleS value)
        {
            Add(ref this, ref value);
        }

        public void Subtract(RectangleS value)
        {
            Subtract(ref this, ref value);
        }

		public void Multiply(RectangleS value)
        {
            Multiply(ref this, ref value);
        }

		public void Divide(RectangleS value)
        {
            Divide(ref this, ref value);
        }

        public void Deflate(RectangleS value)
        {
            Deflate(ref this, ref value);
        }

        public void Inflate(RectangleS value)
        {
            Inflate(ref this, ref value);
        }

        public void Offset(short  x, short  y)
        {
            Offset(ref this, x, y);
        }

		public void OffsetTo(short  x, short  y)
        {
            OffsetTo(ref this, x, y);
        }

        public void Scale(short  x, short  y)
        {
            Scale(ref this, x, y);
        }

		public void ScaleTo(short  x, short  y)
        {
            ScaleTo(ref this, x, y);
        }

        public static void Add(ref RectangleS lvalue, ref RectangleS rvalue)
        {
            lvalue.Left += rvalue.Left;
            lvalue.Top += rvalue.Top;
            lvalue.Right += rvalue.Right;
            lvalue.Bottom += rvalue.Bottom;
        }

        public static void Subtract(ref RectangleS lvalue, ref RectangleS rvalue)
        {
            lvalue.Left -= rvalue.Left;
            lvalue.Top -= rvalue.Top;
            lvalue.Right -= rvalue.Right;
            lvalue.Bottom -= rvalue.Bottom;
        }

		public static void Multiply(ref RectangleS lvalue, ref RectangleS rvalue)
        {
            lvalue.Left *= rvalue.Left;
            lvalue.Top *= rvalue.Top;
            lvalue.Right *= rvalue.Right;
            lvalue.Bottom *= rvalue.Bottom;
        }

		public static void Divide(ref RectangleS lvalue, ref RectangleS rvalue)
        {
            lvalue.Left /= rvalue.Left;
            lvalue.Top /= rvalue.Top;
            lvalue.Right /= rvalue.Right;
            lvalue.Bottom /= rvalue.Bottom;
        }

        public static void Deflate(ref RectangleS target, ref RectangleS deflation)
        {
            target.Top += deflation.Top;
            target.Left += deflation.Left;
            target.Bottom -= deflation.Bottom;
            target.Right -= deflation.Right;
        }

        public static void Inflate(ref RectangleS target, ref RectangleS inflation)
        {
            target.Top -= inflation.Top;
            target.Left -= inflation.Left;
            target.Bottom += inflation.Bottom;
            target.Right += inflation.Right;
        }

        public static void Offset(ref RectangleS target, short  x, short  y)
        {
            target.Top += y;
            target.Left += x;
            target.Bottom += y;
            target.Right += x;
        }

		public static void OffsetTo(ref RectangleS target, short x, short y)
        {
            var width = target.Width;
            var height = target.Height;
            target.Left = x;
            target.Top = y;
            target.Right = width;
            target.Bottom = height;
        }

        public static void Scale(ref RectangleS target, short  x, short  y)
        {
            target.Top *= y;
            target.Left *= x;
            target.Bottom *= y;
            target.Right *= x;
        }

		public static void ScaleTo(ref RectangleS target, short  x, short  y)
        {
			unchecked {
				x = (short)(target.Left / x);
				y = (short)(target.Top / y);
			}
			Scale(ref target, x, y);
        }

	}
	    [StructLayout(LayoutKind.Sequential)]
	public partial struct RectangleF : IEquatable<RectangleF>
	{
		public RectangleF(float left = 0, float  top = 0, float  right = 0, float  bottom = 0)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public RectangleF(float  width = 0, float  height = 0) : this(0, 0, width, height) { }
        public RectangleF(float  all = 0) : this(all, all, all, all) { }

        public float  Left, Top, Right, Bottom;

        public bool Equals(RectangleF other)
        {
            return (Left == other.Left) && (Right == other.Right) && (Top == other.Top) && (Bottom == other.Bottom);
        }

        public override bool Equals(object obj)
        {
            return obj is RectangleF && Equals((RectangleF)obj);
        }

        public static bool operator ==(RectangleF left, RectangleF right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RectangleF left, RectangleF right)
        {
            return !(left == right);
        }

		public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)Left;
                hashCode = (hashCode*397) ^ (int)Top;
                hashCode = (hashCode*397) ^ (int)Right;
                hashCode = (hashCode*397) ^ (int)Bottom;
                return hashCode;
            }
        }

		public SizeF Size
        {
            get { return new SizeF(Width, Height); }
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

		public bool IsEmpty
		{
		  get
		  {
			return this.Left == 0 && this.Top == 0 && this.Right == 0 && this.Bottom == 0;
		  }
		}

		public float  Width { get {  return unchecked((float)(Right - Left)); } set { Right = unchecked((float)(Left + value)); } }
        public float  Height { get { return unchecked((float)(Bottom - Top)); } set { Bottom = unchecked((float)(Top + value)); } }

		public static RectangleF Create(float  x, float  y, float  width, float  height)
		{
			unchecked {
				return new RectangleF(x, y, (float)(width + x), (float)(height + y));			
			}
		}

        public static RectangleF From(ref RectangleF lvalue, ref RectangleF rvalue,
            Func<float , float , float > leftTopOperation,
            Func<float , float , float > rightBottomOperation = null)
        {
            if (rightBottomOperation == null) rightBottomOperation = leftTopOperation;
            return new RectangleF(
                leftTopOperation(lvalue.Left, rvalue.Left),
                leftTopOperation(lvalue.Top, rvalue.Top),
                rightBottomOperation(lvalue.Right, rvalue.Right),
                rightBottomOperation(lvalue.Bottom, rvalue.Bottom)
            );
        }

        public void Add(RectangleF value)
        {
            Add(ref this, ref value);
        }

        public void Subtract(RectangleF value)
        {
            Subtract(ref this, ref value);
        }

		public void Multiply(RectangleF value)
        {
            Multiply(ref this, ref value);
        }

		public void Divide(RectangleF value)
        {
            Divide(ref this, ref value);
        }

        public void Deflate(RectangleF value)
        {
            Deflate(ref this, ref value);
        }

        public void Inflate(RectangleF value)
        {
            Inflate(ref this, ref value);
        }

        public void Offset(float  x, float  y)
        {
            Offset(ref this, x, y);
        }

		public void OffsetTo(float  x, float  y)
        {
            OffsetTo(ref this, x, y);
        }

        public void Scale(float  x, float  y)
        {
            Scale(ref this, x, y);
        }

		public void ScaleTo(float  x, float  y)
        {
            ScaleTo(ref this, x, y);
        }

        public static void Add(ref RectangleF lvalue, ref RectangleF rvalue)
        {
            lvalue.Left += rvalue.Left;
            lvalue.Top += rvalue.Top;
            lvalue.Right += rvalue.Right;
            lvalue.Bottom += rvalue.Bottom;
        }

        public static void Subtract(ref RectangleF lvalue, ref RectangleF rvalue)
        {
            lvalue.Left -= rvalue.Left;
            lvalue.Top -= rvalue.Top;
            lvalue.Right -= rvalue.Right;
            lvalue.Bottom -= rvalue.Bottom;
        }

		public static void Multiply(ref RectangleF lvalue, ref RectangleF rvalue)
        {
            lvalue.Left *= rvalue.Left;
            lvalue.Top *= rvalue.Top;
            lvalue.Right *= rvalue.Right;
            lvalue.Bottom *= rvalue.Bottom;
        }

		public static void Divide(ref RectangleF lvalue, ref RectangleF rvalue)
        {
            lvalue.Left /= rvalue.Left;
            lvalue.Top /= rvalue.Top;
            lvalue.Right /= rvalue.Right;
            lvalue.Bottom /= rvalue.Bottom;
        }

        public static void Deflate(ref RectangleF target, ref RectangleF deflation)
        {
            target.Top += deflation.Top;
            target.Left += deflation.Left;
            target.Bottom -= deflation.Bottom;
            target.Right -= deflation.Right;
        }

        public static void Inflate(ref RectangleF target, ref RectangleF inflation)
        {
            target.Top -= inflation.Top;
            target.Left -= inflation.Left;
            target.Bottom += inflation.Bottom;
            target.Right += inflation.Right;
        }

        public static void Offset(ref RectangleF target, float  x, float  y)
        {
            target.Top += y;
            target.Left += x;
            target.Bottom += y;
            target.Right += x;
        }

		public static void OffsetTo(ref RectangleF target, float x, float y)
        {
            var width = target.Width;
            var height = target.Height;
            target.Left = x;
            target.Top = y;
            target.Right = width;
            target.Bottom = height;
        }

        public static void Scale(ref RectangleF target, float  x, float  y)
        {
            target.Top *= y;
            target.Left *= x;
            target.Bottom *= y;
            target.Right *= x;
        }

		public static void ScaleTo(ref RectangleF target, float  x, float  y)
        {
			unchecked {
				x = (float)(target.Left / x);
				y = (float)(target.Top / y);
			}
			Scale(ref target, x, y);
        }

	}
	
}