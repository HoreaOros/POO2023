
namespace Rectangle
{
    public class Rectangle : IPolygon
    {
        public Point Origin { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(int x, int y, int width, int height)
        {
            Origin = new Point { X = x, Y = y }; Width = width; Height = height;
        }
        public Rectangle(Point p1, Point p2)
        {
            Origin = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Width = Math.Abs(p1.X - p2.X);
            Height = Math.Abs(p1.Y - p2.Y);
        }
        public override string ToString()
        {
            return $"[{Origin.ToString()}, Width = {Width}, Height = {Height}]";
        }
        public int Perimeter()
        {
            return 2 * (Width + Height);
        }
        public int Area()
        {
            return Width * Height;
        }

    }
}