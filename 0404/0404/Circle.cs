using _0404;

internal class Circle : Shape
{
    public int Radius { get; private set; }

    public Circle(Point point, int radius) : base(point)
    {
        this.Radius = radius;
    }
    public override string ToString()
    {
        return $"[{Point}, Radius={Radius}]";
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle...");
    }
    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}