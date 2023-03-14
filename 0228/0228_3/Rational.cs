using System;
internal class Rational
{
	int numarator, numitor;
	public Rational()
	{
		numarator = numitor = 0;
	}
	public Rational(int numarator, int numitor)
    {
        this.numarator = numarator;
        this.numitor = numitor;
    }
    public override string ToString()
    {
        return $"({numarator}/{numitor})";
    }

    public Rational Add(Rational r2)
    {
        Rational result = new Rational();
        result.numitor = this.numitor * r2.numitor;
        result.numarator = this.numarator * r2.numitor + 
            r2.numarator * this.numitor;
        result.Reduce();
        return result;
    }

    public void Reduce()
    {
        int d = Gcd(Math.Abs(this.numarator),
            Math.Abs(this.numitor));
        this.numarator /= d;
        this.numitor /= d;
    }

    private int Gcd(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return Gcd(b, a % b);
    }
    public static Rational operator+(Rational r1, Rational r2)
    {
        return r1.Add(r2);
    }
}