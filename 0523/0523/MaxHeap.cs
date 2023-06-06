using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

internal class MaxHeap
{
    int[] _data;
    int _size;
    public MaxHeap(int[] data)
    {
        _data =  new int[data.Length + 1];
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
        if (l <= Size && _data[l] > _data[i])
            largest = l;
        if(r <= Size && _data[r] > _data[largest])
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

    private void IncreaseKey(int i,int key)
    {
        if (key < _data[i])
            throw new InvalidOperationException("New key is smaller than current key.");

        _data[i] = key;
        while(i>1 && _data[Parent(i)] < _data[i])
        {
            (_data[Parent(i)], _data[i]) = (_data[i], _data[Parent(i)]);
            i = Parent(i);
        }
    }
    protected void Add(int key)
    {
        _size++;

        int[] newData = new int[Size + 1];
        for (int i = 0; i < Size; i++)
            newData[i] = _data[i];
        newData[Size] = int.MinValue;

        _data = newData;

        IncreaseKey(Size, key);
    }

    protected int RemoveMax()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");
        int max = _data[1];
        _data[1] = _data[Size];
        _size--;
        MaxHeapify(1);
        return max;
    }

    protected int Max()
    {
        if (Size < 1)
            throw new InvalidOperationException("Heap is empty.");

        return _data[1];
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