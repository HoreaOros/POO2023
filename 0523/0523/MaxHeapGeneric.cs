using System.Text;
internal class MaxHeap<T> where T:IComparable
{
    T[] _data;
    int _size;
    public MaxHeap(T[] data)
    {
        _data =  new T[data.Length + 1];
        for (int i = 0; i < data.Length; i++)
        {
            _data[i + 1] = data[i];
        }
        _size = data.Length;
        BuildMaxHeap();
    }
    public int Size => _size;
    private int Parent(int i) => i / 2;
    private int Left(int i) => 2 * i;
    private int Right(int i) => 2 * i + 1;

    private void MaxHeapify(int i)
    {
        int l = Left(i);
        int r = Right(i);
        int largest = i;
        if (l <= Size && _data[l].CompareTo(_data[i]) < 0)
            largest = l;
        if(r <= Size && _data[r].CompareTo(_data[largest]) < 0)
            largest = r;

        if(largest != i)
        {
            (_data[i], _data[largest]) = (_data[largest], _data[i]);
            MaxHeapify(largest);
        }
    }
    private void BuildMaxHeap()
    {
        for (int i  = Size / 2; i >= 1; i--)
            MaxHeapify(i);
    }

    private void IncreaseKey(int i,T key)
    {
        if (key.CompareTo(_data[i])<0)
            throw new InvalidOperationException("New key is smaller than current key.");

        _data[i] = key;
        while(i>1 && _data[Parent(i)].CompareTo(_data[i])<0)
        {
            (_data[Parent(i)], _data[i]) = (_data[i], _data[Parent(i)]);
            i = Parent(i);
        }
    }
    protected void Add(T key)
    {
        _size++;

        T[] newData = new T[Size + 1];
        for (int i = 0; i < Size; i++)
            newData[i] = _data[i];
        newData[Size] = key;

        _data = newData;

        IncreaseKey(Size, key);
    }

    protected T RemoveMax()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");
        T max = _data[1];
        _data[1] = _data[Size];
        _size--;
        MaxHeapify(1);
        return max;
    }

    protected T Max()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");

        return _data[1];
    }

    public void Clear()
    {
        _size = 0;
        _data = new T[0];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= Size; i++)
        {
            sb.Append(_data[i]);
            sb.Append(" ");
        }
        return sb.ToString();
    }

}