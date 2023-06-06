using _0523;

int[] arr = { 9, 16, 4, 14, 8, 7, 3, 10, 2, 1 };
MaxHeap m = new MaxHeap(arr);
Console.WriteLine(m);


MyPriorityQueue pq = new MyPriorityQueue();

pq.Enqueue(3);
pq.Enqueue(5);
pq.Enqueue(1);
Console.WriteLine($"Priority queue after adding: {pq} ");

Console.WriteLine($"Priority queue peek: {pq.Peek()} ");
Console.WriteLine($"Priority queue deque: {pq.Dequeue()} ");
Console.WriteLine($"Priority queue after these operations: {pq} ");
