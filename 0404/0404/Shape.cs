namespace _0404
{
    public abstract class Shape: IShape
    {
        public Point Point { get; protected set; }
        public Shape(Point point)
        {
            this.Point = point;
        }
        public abstract void Draw();
        public abstract double Area();
    }
}