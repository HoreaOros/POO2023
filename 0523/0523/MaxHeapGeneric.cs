using System.Text;
internal class MaxHeap<TKey, TValue> where TKey:IComparable
{
    TKey[] _keys;
    TValue[]? _values;

    int _size;
    public MaxHeap(TKey[] keys)
    {
        _keys =  new TKey[keys.Length + 1];
        for (int i = 0; i < keys.Length; i++)
        {
            _keys[i + 1] = keys[i];
        }
        _size = keys.Length;
        BuildMaxHeap();
    }

    public MaxHeap(TKey[] keys, TValue[] values)
    {
        if(keys.Length != values.Length)
            throw new InvalidOperationException();

        _keys = new TKey[keys.Length + 1];
        _values = new TValue[keys.Length + 1];
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
        if (l <= Size && _keys[l].CompareTo(_keys[i]) < 0)
            largest = l;
        if(r <= Size && _keys[r].CompareTo(_keys[largest]) < 0)
            largest = r;

        if(largest != i)
        {
            (_keys[i], _keys[largest]) = (_keys[largest], _keys[i]);
            if(_values != null)
                (_values[i], _values[largest]) = (_values[largest], _values[i]);
            MaxHeapify(largest);
        }
    }
    private void BuildMaxHeap()
    {
        for (int i  = Size / 2; i >= 1; i--)
            MaxHeapify(i);
    }

    private void IncreaseKey(int i,TKey key, TValue value)
    {
        if (key.CompareTo(_keys[i])<0)
            throw new InvalidOperationException("New key is smaller than current key.");

        _keys[i] = key;
        if (_values != null)
            _values[i] = value;

        while(i>1 && _keys[Parent(i)].CompareTo(_keys[i])<0)
        {
            (_keys[Parent(i)], _keys[i]) = (_keys[i], _keys[Parent(i)]);

            if(_values!=null)
                (_values[Parent(i)], _values[i]) = (_values[i], _values[Parent(i)]);

            i = Parent(i);
        }
    }
    protected void Add(TKey key, TValue value)
    {
        _size++;

        TKey[] newKeys = new TKey[Size + 1];
        for (int i = 0; i < Size; i++)
        {
            newKeys[i] = _keys[i];
        }
        newKeys[Size] = key;

        if(_values!=null)
        {
            TValue[] newValues = new TValue[Size + 1];
            for (int i = 0; i < Size; i++)
                newValues[i] = _values[i];

            newValues[Size] = value;
            _values= newValues;
        }

        _keys = newKeys;

        IncreaseKey(Size, key, value);
    }

    protected TValue RemoveMax()
    {
        if (Size < 1 || _values == null)
            throw new InvalidOperationException("Heap is empty.");

        var max = _values[1];

        _keys[1] = _keys[Size];
        _values[1] = _values[Size];

        _size--;
        MaxHeapify(1);
        return max;
    }

    protected TValue Max()
    {
        if (Size < 1 || _values == null)
            throw new InvalidOperationException("Heap is empty.");

        return _values[1];
    }

    public void Clear()
    {
        _size = 0;
        _keys = new TKey[0];

        if(_values != null )
            _values = new TValue[0];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= Size; i++)
        {
            if (_values != null)
                sb.Append(_values[i]);
            else
                sb.Append(_keys[i]);
            sb.Append(" ");
        }
        return sb.ToString();
    }

}