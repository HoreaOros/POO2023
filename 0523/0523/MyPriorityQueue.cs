
internal class MyPriorityQueue : MaxHeap
{
    public MyPriorityQueue(int[] data) : base(data)
    { }

    public MyPriorityQueue() : base(new int[0])
    { }

    public void Enqueue(int priority,int value)
    {
        base.Add(priority,value);
    }

    public void Enqueue(int priority)
    {
        base.Add(priority, priority);
    }

    public int Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        return base.RemoveMax();
    }

    public int Peek()
    {
        if (Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        return base.Max();
    }

    public void Clear()
    {
         base.Clear();
    }

    public int Count => base.Size;
}
