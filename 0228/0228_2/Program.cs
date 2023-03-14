using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0228_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(5);
            Console.WriteLine(p1);
            Console.WriteLine(p1.EuclideanDistanceTo(new Point(6, 8)));
            Console.WriteLine(p1.ManhattanDistance(new Point(6, 8)));
            Console.WriteLine(p1.EuclideanDistanceToOrigin());
        }
    }
}
