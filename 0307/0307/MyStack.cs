using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307
{
    internal class MyStack : IStack
    {
        private int[] arr;
        private int capacity;
        private int size;
        public MyStack() : this(4)
        {
        }
        public MyStack(int capacity)
        {
            this.capacity = capacity;
            arr = new int[capacity];
            size = 0;
        }
        private void resize(int newCapacity)
        {
            Console.WriteLine($"Resizing stack from {capacity} to {newCapacity}");
            int[] newarr = new int[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            capacity = newCapacity;
            arr = newarr;
        }
        public void Push(int value)
        {
            Console.Write($"Try to push {value}...");
            if (size == capacity)
            {
                resize(capacity * 2);
            }

            arr[size++] = value;
            Console.WriteLine(" success.");

        }
        public bool Empty
        {
            get
            {
                return size == 0;
            }
        }
        public int Pop()
        {
            if (!this.Empty)
            {
                size--;
                if (size == capacity / 4)
                {
                    resize(capacity / 2);
                }
                return arr[size];
            }
            else
                throw new StackEmptyException("Stack empty");
        }
        public int Count => size;
    }
}
