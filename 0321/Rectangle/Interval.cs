namespace Rectangle
{
    internal class Interval: IComparable<Interval>
    {
        public Interval(int a, int b)
        {
            if (a > b)
                (a, b) = (b, a);
            Start = a;
            End = b;
        }
        public int Length => Math.Abs(End - Start);

        public int Start { get; }
        public int End { get; }

        public int CompareTo(Interval? other)
        {
            return this.Length - other!.Length;
        }

        public bool IntersectsWith(Interval other)
        {
            return !(this.End < other.Start || other.End < this.Start);
        }
    }
}