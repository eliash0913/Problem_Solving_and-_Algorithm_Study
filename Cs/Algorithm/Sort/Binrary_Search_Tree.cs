using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Algorithm.Sort
{
    class Node
    {
        public int Value { get; set; }
        public Node Left;
        public Node Right;

        public Node(int newVal)
        {
            Value = newVal;
        }
    }
    class Binrary_Search_Tree
    {
        Node root;
        public Binrary_Search_Tree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }
        
        public int GetMaxValue()
        {
            if (IsEmpty())
                throw new Exception("No max can be found in an empty tree!");
            Node currentNode = root;
            while(currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }
            return currentNode.Value;
        }

        public void Insert(int newValue)
        {
            Node newNode = new Node(newValue);
            if (IsEmpty())
                root = newNode;
            else
            {
                Node currentNode = root;
                while(true)
                {
                    if(currentNode.Value>=newValue)
                    {
                        if (currentNode.Left != null)
                            currentNode = currentNode.Left;
                        else
                        {
                            currentNode.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (currentNode.Right != null)
                            currentNode = currentNode.Right;
                        else
                        {
                            currentNode.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void Test()
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, 10, 13, 16 };
            int arr_size = arr.Length;
            Binrary_Search_Tree bst = new Binrary_Search_Tree();
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(5);
            bst.Insert(4);
            bst.Insert(2);
            Console.WriteLine(bst.GetMaxValue());
        }
    }


}
