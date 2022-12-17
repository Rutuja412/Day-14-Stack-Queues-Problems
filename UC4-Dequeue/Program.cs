using System;

namespace UC4_Dequeue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue=new LinkedListQueue();
           linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
           linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue(56);
            linkedListQueue.Dequeue(30);
            linkedListQueue.Dequeue(70);
           // linkedListQueue.Display();

        }
    }
}
