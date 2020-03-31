/**1019. Next Greater Node In Linked List
 * We are given a linked list with head as the first node.  Let's number the nodes in the list: node_1, node_2, node_3, ... etc.
 * Each node may have a next larger value: for node_i, next_larger(node_i) is the node_j.val such that j > i, node_j.val > node_i.val, and j is the smallest possible choice.  If such a j does not exist, the next larger value is 0.
 * Return an array of integers answer, where answer[i] = next_larger(node_{i+1}).
 * Note that in the example inputs (not outputs) below, arrays such as [2,1,5] represent the serialization of a linked list with a head node value of 2, second node value of 1, and third node value of 5.
 * Example 1:
 * Input: [2,1,5]
 * Output: [5,5,0]
 * Example 2:
 * Input: [2,7,4,3,5]
 * Output: [7,0,5,5,0]
 * Example 3:
 * Input: [1,7,5,1,9,2,5,1]
 * Output: [7,9,9,9,0,5,0,0]
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Medium
{
    class Problem1019
    {
        public int[] NextLargerNodes(ListNode head)
        {
            if (head == null)
                return new int[] { };
            else if (head.next == null)
                return new int[] { 0 };
            else
            {
                int length = 1;
                ListNode currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                    length++;
                }
                int[] result = new int[length];
                int index = 0;
                currentNode = head;
                ListNode comparedNode = head.next;
                while (currentNode.next != null)
                {
                    if(currentNode.val < comparedNode.val)
                    {
                        result[index++] = comparedNode.val;
                        currentNode = currentNode.next;
                        comparedNode = currentNode.next;
                    }
                    else
                    {
                        if(comparedNode.next != null)
                        {
                            comparedNode = comparedNode.next;
                        }
                        else
                        {
                            result[index++] = 0;
                            currentNode = currentNode.next;
                            comparedNode = currentNode.next;
                        }
                    }
                }
                return result;
            }
        }

        public void Test()
        {
            ListNode sample1Head = new ListNode(2);
            sample1Head.next = new ListNode(1);
            sample1Head.next.next = new ListNode(5);

            DisplayResults.Display(NextLargerNodes(sample1Head));

            ListNode sample2Head = new ListNode(2);
            sample2Head.next = new ListNode(7);
            sample2Head.next.next = new ListNode(4);
            sample2Head.next.next.next = new ListNode(3);
            sample2Head.next.next.next.next = new ListNode(5);

            DisplayResults.Display(NextLargerNodes(sample2Head));


            ListNode sample3Head = new ListNode(1);
            sample3Head.next = new ListNode(7);
            sample3Head.next.next = new ListNode(5);
            sample3Head.next.next.next = new ListNode(1);
            sample3Head.next.next.next.next = new ListNode(9);
            sample3Head.next.next.next.next.next = new ListNode(2);
            sample3Head.next.next.next.next.next.next = new ListNode(5);
            sample3Head.next.next.next.next.next.next.next = new ListNode(1);

            DisplayResults.Display(NextLargerNodes(sample3Head));
        }
        internal class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
