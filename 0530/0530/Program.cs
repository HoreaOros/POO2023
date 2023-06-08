C a = new C(1);
Console.WriteLine(a);


D d = new D();
int x = 2;
d.doSomething(x);
Console.WriteLine(x);
d.doSomethingElse(ref x);
Console.WriteLine(x);


d.doSomethingAgain(a);
Console.WriteLine($"In main() {a}");

d.doSomethingElseAgain(ref a);
Console.WriteLine($"In main() {a}");


d.doSomeMagic(a);
Console.WriteLine($"In main() {a}");


Base r = new Derived();

internal class C
{
    public int id;
    public C(int id)
    {
        this.id = id;
    }
    public override string ToString()
    {
        return $"#{id}";
    }
}

