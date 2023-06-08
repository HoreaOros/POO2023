using System.Text;

internal class MaxHeap
{
    int[] _keys;
    int[] _values;
    int _size;

    //if values are not mentioned, keys are considered as values and sorted this way
    public MaxHeap(int[] keys)
    {
        _keys = new int[keys.Length + 1];
        _values = new int[keys.Length + 1];
        for (int i = 0; i < keys.Length; i++)
        {
            _keys[i + 1] = keys[i];
            _values[i + 1] = keys[i];
        }
        _size = keys.Length;
        BuildMaxHeap();
    }

    public MaxHeap(int[] keys, int[] values)
    {
        if (keys.Length != values.Length)
            throw new InvalidOperationException("Keys count doesn't match values count");

        _keys = new int[keys.Length + 1];
        _values = new int[keys.Length + 1];
        for (int i = 0; i < keys.Length; i++)
        {
            _keys[i + 1] = keys[i];
            _values[i + 1] = values[i];
        }
        _size = keys.Length;
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
        if (l <= Size && _keys[l] > _keys[i])
            largest = l;
        if (r <= Size && _keys[r] > _keys[largest])
            largest = r;

        if (largest != i)
        {
            (_keys[i], _keys[largest]) = (_keys[largest], _keys[i]);
            (_values[i], _values[largest]) = (_values[largest], _values[i]);
            MaxHeapify(largest);
        }
    }
    private void BuildMaxHeap()
    {
        for (int i = Size / 2; i >= 1; i--)
            MaxHeapify(i);
    }

    private void IncreaseKey(int i, int key, int value)
    {
        if (key.CompareTo(_keys[i]) < 0)
            throw new InvalidOperationException("New key is smaller than current key.");

        _keys[i] = key;
        _values[i] = value;
        while (i > 1 && _keys[Parent(i)].CompareTo(_keys[i]) < 0)
        {
            (_keys[Parent(i)], _keys[i]) = (_keys[i], _keys[Parent(i)]);
            (_values[Parent(i)], _values[i]) = (_values[i], _values[Parent(i)]);
            i = Parent(i);
        }
    }

    protected void Add(int key, int value)
    {
        _size++;

        int[] newKeys = new int[Size + 1];
        int[] newValues = new int[Size + 1];

        for (int i = 0; i < Size; i++)
        {
            newKeys[i] = _keys[i];
            newValues[i] = _values[i];

        }

        newKeys[Size] = key;
        newValues[Size] = value;

        _keys = newKeys;
        _values = newValues;

        IncreaseKey(Size, key, value);
    }

    protected int RemoveMax()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");

        int max = _values[1];

        _values[1] = _values[Size];
        _keys[1] = _keys[Size];
        
        _size--;
        MaxHeapify(1);
        return max;
    }

    protected int Max()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");
        return _values[1];
    }

    public void Clear()
    {
        _size = 0;
        _keys = new int[0];
        _values = new int[0];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= Size; i++)
        {
            sb.Append(_values[i]);
            sb.Append(" ");
        }
        return sb.ToString();
    }

}
