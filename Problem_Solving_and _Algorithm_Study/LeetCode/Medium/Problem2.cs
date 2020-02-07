/*
2. Add Two Numbers
Medium

6902

1780

Add to List

Share
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Medium
{
  
 
    class Problem2
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode(0);
            //Console.WriteLine(recursiveNode(l1).val);
            RecursiveNode(l1);
/*            Stack<Int32> tmp = new Stack<Int32>();

            tmp.Push(l2.val);
            while (l2.next != null)
            {
                l2 = l2.next;
                tmp.Push(l2.val);
            }

            ListNode l3 = new ListNode(tmp.Pop());
            //Console.WriteLine(l3.val);
            //Console.WriteLine(tmp.Count);
            while (tmp.Count > 0)
            {
                ListNode t = new ListNode(tmp.Pop());
                     
                l3.next = l3.next.next;

                Console.WriteLine(l3.val);
                //Console.WriteLine(tmp.Count);
            }*/



            return l3;
        }

        private ListNode RecursiveNode(ListNode ln)
        {         
            if (ln.next.next == null)
            {
                ListNode FirstListNode = ln.next;
                FirstListNode.next = ln;
                return FirstListNode;
            }
            else
            {
                ListNode listNode = ln.next;
                listNode.next = ln;
                return RecursiveNode(listNode);
            }            
        }
        //private ListNode helper(ListNode child, ListNode parent)
        //{
        //    parent.next = child;
        //    return currentNode;
        //}






        public void Test()
        {
            ListNode ll = new ListNode(2);
            ll.next = new ListNode(4);
            ll.next.next = new ListNode(3);
            
            ListNode rr = new ListNode(5);
            rr.next = new ListNode(6);
            rr.next.next = new ListNode(4);

            Console.WriteLine(AddTwoNumbers(ll, rr));
        }
    }
}
