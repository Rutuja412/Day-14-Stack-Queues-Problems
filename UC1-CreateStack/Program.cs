using System;

namespace UC1_CreateStack
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            linkedListStack.Display();
        }
    }
}
