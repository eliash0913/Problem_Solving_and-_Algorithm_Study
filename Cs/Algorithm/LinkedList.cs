using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Algorithm
{
    class LinkedList
    {
        Node head;
        private void Add(int value)
        {
            Node currentNode = head;
            if (currentNode == null)
                currentNode = new Node(value);
            else
            {
                while(currentNode.Next!=null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node(value);
            }
        }

        public void Test()
        {
            LinkedList ll = new LinkedList();
            ll.Add(10);
        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }
    }
}
