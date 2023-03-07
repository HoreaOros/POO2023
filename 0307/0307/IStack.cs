namespace _0307
{
    internal interface IStack
    {
        int Count { get; }
        bool Empty { get; }

        int Pop();
        void Push(int value);
    }
}