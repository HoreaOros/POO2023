using System.Reflection.Metadata.Ecma335;

public class Point
{
    private int x;
    private int y;
    public int X
    { 
        get
        {
            return x;
        }
    }
    public int Y => y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}