internal class Program
{
    private static void Main(string[] args)
    {
        Rational r1 = new Rational(3, 4);
        Console.WriteLine($"r1 = {r1}");
        Rational r2 = new Rational(4, 6);
        Console.WriteLine($"r2 = {r2}");
        Rational r3 = r1.Add(r2);
        Console.WriteLine($"r3 = {r3}");
        Rational r4 = r1 + r2;
        Console.WriteLine($"r4 = {r4}");
        if (r3 == r4)
            Console.WriteLine($"{r3} este egal cu {r4}");
        else
            Console.WriteLine($"{r3} nu este egal cu {r4}");

    }
}