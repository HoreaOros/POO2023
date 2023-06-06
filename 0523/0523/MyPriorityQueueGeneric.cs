
internal class MyPriorityQueue<T> : MaxHeap<T>  where T: IComparable
{
    public MyPriorityQueue(T[] data) : base(data)
    { }

    public MyPriorityQueue() : base(new T[0])
    { }

    public void Enqueue(T priority)
    {
        base.Add(priority);
    }

    public T Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        return base.RemoveMax();
    }

    public T Peek()
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

