# NetCoreEx

Extended collection of packages that provide common structures, extensions, and helpers that can be used across many libraries, and applications.

<img src="https://raw.githubusercontent.com/prasannavl/NetCoreEx/master/Misc/Logo.png" width="64" alt="Logo"/>

**Nuget:**
> Install-Package NetCoreEx.[PackageName]

All packages fully support the **CoreCLR.**

### Goals

Abstraction operations like:

- Common IntPtr operations (Example: Break IntPtr into low, and high, convert to int safely on both 32-bit and 64-bit safely, and so on)
- Common binary manipulations of int, long, etc (Example: get or set low and high value of int) 
- Common geometric patterns like Rect, Point, Size, RectF, RectS and so on

### Packages

- **`NetCoreEx.Source`** - A fully inclusive source-only package.
- **`NetCoreEx.Geometry`** - Contains common core geometries like Point, PointS, Rectangle, Size, RectangleF, SizeF and so on.
- **`NetCoreEx.BinaryExtensions`** - Pointers and numeric binary helpers.