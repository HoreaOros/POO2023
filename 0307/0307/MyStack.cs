using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307
{
    internal class MyStack
    {
        private int[] arr;
        private int capacity;
        private int size;
        public MyStack(): this(4)
        { 
        }
        public MyStack(int capacity) 
        {
            this.capacity = capacity;
            arr = new int[capacity];
            size = 0;
        }
        public void Push(int value)
        {
            Console.Write($"Try to push {value}...");
            if (size < capacity)
            {
                arr[size++] = value;
                Console.WriteLine(" success.");
            }
            else
            {
                Console.WriteLine(" failed.");
                throw new StackFullException("Stack full");
            }
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
                return arr[size];
            }
            else
                throw new StackEmptyException("Stack empty");
        }
    }
}
