namespace _0404
{
    public class Rectangle : Shape, IShape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }


        public Rectangle(Point point, int width, int height): base (point)
        {
            this.Width = width;
            this.Height = height;
        }
        public override string ToString()
        {
            return $"[{Point}, Width={Width}, Height={Height}]";
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
        public double Area()
        {
            return Width * Height;
        }
    }
}