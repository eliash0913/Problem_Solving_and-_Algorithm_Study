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
    /***** WORKING *****/

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
           
            return null;
        }

        private void RecursiveNode(ListNode ln)
        {
            while(ln.next != null)
            {
                ln = ln.next;
                Console.WriteLine(ln.val);
            }
        }

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
