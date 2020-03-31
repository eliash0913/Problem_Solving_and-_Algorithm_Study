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

        public void DisplayHeight()
        {
            Console.WriteLine("\nNumber of Height:{0}", Height(root));
        }

        public int Height(Node n)
        {
            if (n == null)
                return -1;
            else
            {
                return 1 + Math.Max(Height(n.Left), Height(n.Right));
            }           
        }

        public void Test()
        {
            Binrary_Search_Tree bst = new Binrary_Search_Tree();
            bst.Insert(21);
            bst.Insert(16);
            bst.Insert(5);
            bst.Insert(0);
            bst.Insert(13);
            bst.Insert(27);
            bst.Insert(58);
            bst.Insert(30);
            bst.Insert(35);
            //Console.WriteLine(bst.GetMaxValue());
            bst.DisplayHeight();
        }
    }


}
