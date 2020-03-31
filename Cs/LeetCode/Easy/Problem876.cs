/**
 * 876. Middle of the Linked List
 * Easy
 * Add to List
 * Given a non-empty, singly linked list with head node head, return a middle node of linked list.
 * If there are two middle nodes, return the second middle node.
 * 
 * Example 1:
 * Input: [1,2,3,4,5]
 * Output: Node 3 from this list (Serialization: [3,4,5])
 * The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
 * Note that we returned a ListNode object ans, such that:
 * ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
 * 
 * Example 2:
 * Input: [1,2,3,4,5,6]
 * Output: Node 4 from this list (Serialization: [4,5,6])
 * Since the list has two middle nodes with values 3 and 4, we return the second one.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Easy
{
    class Problem876
    {
        /***** COMPLETED *****/
        public ListNode MiddleNode(ListNode head)
        {
            ListNode currentNode = head;
            int count = 0;
            while(currentNode.next!=null)
            {
                count++;
                currentNode = currentNode.next;
            }
            int midNode = (count + 1) / 2;
            count = 0;
            currentNode = head;
            while (count < midNode)
            {
                currentNode = currentNode.next;
                count++;
            }
            return currentNode;
        }

        public void Test()
        {
            ListNode sample1Head = new ListNode(1);
            ListNode currentSample1Node = sample1Head;
            for (int i = 2; i <= 5; i++)
            {
                currentSample1Node.next = new ListNode(i);
                currentSample1Node = currentSample1Node.next;

            }
            Console.WriteLine(MiddleNode(sample1Head).val);

            ListNode sample2Head = new ListNode(1);
            ListNode currentSample2Node = sample2Head;
            for (int i = 2; i <= 6; i++)
            {
                currentSample2Node.next = new ListNode(i);
                currentSample2Node = currentSample2Node.next;

            }
            Console.WriteLine(MiddleNode(sample2Head).val);
        }

        internal class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
   
}
