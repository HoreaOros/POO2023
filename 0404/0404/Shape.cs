namespace _0404
{
    public abstract class Shape
    {
        public Point Point { get; protected set; }
        public Shape(Point point)
        {
            this.Point = point;
        }
        public abstract void Draw();
    }
}