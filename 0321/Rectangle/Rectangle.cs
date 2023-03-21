
namespace Rectangle
{
    public class Rectangle
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(int x, int y, int width, int height)
        {
            X = x; Y = y; Width = width; Height = height;
        }
        public Rectangle(Point p1, Point p2) 
        { 
        }
    }
}