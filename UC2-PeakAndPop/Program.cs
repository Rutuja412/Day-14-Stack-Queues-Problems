using System;

namespace UC2_PeakAndPop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
             linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.peek();
            linkedListStack.pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();
        }
    }
}