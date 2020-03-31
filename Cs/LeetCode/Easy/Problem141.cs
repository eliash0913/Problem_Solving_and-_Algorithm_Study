using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Easy
{
    class Problem141
    {
        public void Test()
        {
            ListNode sample1Head = new ListNode(3);
            sample1Head.next = new ListNode(2);
            sample1Head.next = new ListNode(3);

        }

        internal class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
