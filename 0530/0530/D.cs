internal class D
{
    // transmit valoare prin valoare
    public void doSomething(int n)
    {
        n = n + 1;
    }
    public void doSomethingElse(ref int n) 
    {
        n = n + 1;
    }

    public void doSomethingAgain(C c)
    {
        c = new C(2);
        Console.WriteLine($"Inside doSomethingAgain {c}");
    }

    public void doSomethingElseAgain(ref C c)
    {
        c = new C(3);
        Console.WriteLine($"Inside doSomethingElseAgain {c}");
    }

    public void doSomeMagic(C a)
    {
        a.id = 10;
    }

    public D()
    {
    }
}