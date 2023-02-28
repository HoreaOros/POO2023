using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _0228_2
{
    internal class Point
    {
        float x, y;
        public Point(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
        //public Point()
        //{
        //    this.x = 0;
        //    this.y = 0;
        //}
        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
        public float EuclideanDistanceTo(Point other)
        {
            return (float)Math.Sqrt(
                Math.Pow((x - other.x), 2) +
                Math.Pow((y - other.y), 2));
        }
        public float ManhattanDistance(Point other)
        {
            return Math.Abs(x - other.x) 
                + Math.Abs(y - other.y);
        }

        public float EuclideanDistanceToOrigin()
        {
            return this.EuclideanDistanceTo(new Point());
        }
    }
}