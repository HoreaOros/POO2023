// See https://aka.ms/new-console-template for more information

using _0307;
class Node
{
    public int value;
    public Node? next;
}
internal class MyListStack: IStack
{
    Node? first = null;
    int size;
    public MyListStack()
    {
        size = 0;
        this.first = null;
    }

    public int Count => size;

    public bool Empty => size == 0; // first == null

    public int Pop()
    {
        if (size > 0)
        {
            int ret = first.value;
            first = first.next;
            size--;
            return ret;
        }
        else
            throw new StackEmptyException("Stack empty.");
    }

    public void Push(int value)
    {
        Console.Write($"Try to push {value}...");
        Node node = new Node();
        node.value = value;
        node.next = first;
        first = node;
        size++;
        Console.WriteLine("success.");
    }

}