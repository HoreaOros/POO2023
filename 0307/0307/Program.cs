// See https://aka.ms/new-console-template for more information

// Clasa Stack...
using _0307;

/*
Console.WriteLine("Hello, World!");
Stack<int> st = new Stack<int>();

for (int i = 0; i < 10; i++)
    st.Push(i);
while (st.Count > 0)
    Console.WriteLine(st.Pop());

try
{
	st.Pop();
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}

int result;
bool ok = st.TryPop(out result);
if (ok)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Pop failed.Stack empty.");
}
*/

Random rnd = new Random();
// Clasa MyStack

/*
MyStack ms = new MyStack();
while (true)
{
	if (ms.Count == 100)
	{
		break;
	}
	try
	{
		ms.Push(rnd.Next(1000));
	}
	catch (StackFullException e)
	{
        Console.WriteLine(e.Message);
		break;
	}
}
while (!ms.Empty)
{
    Console.WriteLine(ms.Pop());
}
*/

MyListStack mls = new MyListStack();

for (int i = 0; i < 10; i++)
{
	mls.Push(rnd.Next(1000));
}
while (!mls.Empty)
{
    Console.WriteLine(mls.Pop());
}
