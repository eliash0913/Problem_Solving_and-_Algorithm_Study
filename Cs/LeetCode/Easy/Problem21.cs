/**
 * 21. Merge Two Sorted Lists
 * Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Easy
{
    class Problem21
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;
            else
            {
                if (head == null)
                {
                    if (l1.val < l2.val)
                    {
                        head = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        head = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                }
                ListNode currentNode = head;
                
                while (l1!=null || l2!=null)
                {
                    if (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    if (l1 == null)
                    {
                        currentNode.next = l2;
                        break;
                    }
                    if (l2 == null)
                    {
                        currentNode.next = l1;
                        break;
                    }
                    if (l1.val < l2.val)
                    {
                        currentNode.next = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        currentNode.next = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                }
            }
            return head;
        }
    

        public void Test()
        {
            ListNode ln1 = new ListNode(1);
            ln1.next = new ListNode(2);
            ln1.next.next = new ListNode(3);

            ListNode ln2 = new ListNode(4);
            ln2.next = new ListNode(5);
            ln2.next.next = new ListNode(6);

            Display(MergeTwoLists(ln1, ln2));
        }
        public void Display(ListNode t)
        {
            Console.WriteLine(t.val);
            while (t.next != null)
            {
                t = t.next;
                Console.WriteLine(t.val);
            }
        }
    }

    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
