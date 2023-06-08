
internal class MyPriorityQueue<TKey, TValue> : MaxHeap<TKey, TValue>  where TKey: IComparable
{
    public MyPriorityQueue(TKey[] keys, TValue[] values) : base(keys, values)
    { }

    public MyPriorityQueue() : base(new TKey[0], new TValue[0])
    { }

    public void Enqueue(TKey priority, TValue value)
    {
        base.Add(priority,value);
    }

    public TValue Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        return base.RemoveMax();
    }

    public TValue Peek()
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

