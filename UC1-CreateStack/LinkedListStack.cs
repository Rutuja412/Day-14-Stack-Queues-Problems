using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace UC1_CreateStack
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
 }  }
