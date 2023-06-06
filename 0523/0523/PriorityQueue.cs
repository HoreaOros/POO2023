
using System.Net.Http.Headers;

namespace _0523
{
    internal class MyPriorityQueue : MaxHeap
    {
        public MyPriorityQueue(int[] data) : base(data)
        { }

        public MyPriorityQueue() : base(new int[0])
        { }

        public void Enqueue(int priority)
        {
            base.Add(priority);
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

        public int Count => base.Size; 
    }
}
