int[] arr = { 9, 16, 4, 14, 8, 7, 3, 10, 2, 1 };
MaxHeap m = new MaxHeap(arr);
Console.WriteLine(m);

//int type priority queue
MyPriorityQueue pq = new MyPriorityQueue();

pq.Enqueue(3);
pq.Enqueue(5);
pq.Enqueue(1);
Console.WriteLine($"Priority queue after adding: {pq} ");

Console.WriteLine($"Priority queue peek: {pq.Peek()} ");
Console.WriteLine($"Priority queue dequeue: {pq.Dequeue()} ");
Console.WriteLine($"Priority queue after these operations: {pq} ");

pq.Clear();
Console.WriteLine($"Priority queue after clear operation: {pq} ");

Console.WriteLine();


//char type priority queue
MyPriorityQueue<char> pq2 = new MyPriorityQueue<char>();

pq2.Enqueue('a');
pq2.Enqueue('r');
pq2.Enqueue('z');
Console.WriteLine($"Char priority queue after adding: {pq2} ");

Console.WriteLine($"Char priority queue peek: {pq2.Peek()} ");
Console.WriteLine($"Char priority queue dequeue: {pq2.Dequeue()} ");
Console.WriteLine($"Char priority queue after these operations: {pq2} ");

pq2.Clear();
Console.WriteLine($"Char priority queue after clear operation: {pq2} ");
