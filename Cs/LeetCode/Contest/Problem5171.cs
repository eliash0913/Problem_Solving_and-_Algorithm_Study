/*5171. Closest Divisors
 * User Accepted:2634
 * User Tried:3149
 * Total Accepted:2683
 * Total Submissions:5664
 * Difficulty:Medium
 * Given an integer num, find the closest two integers in absolute difference whose product equals num + 1 or num + 2.
 * Return the two integers in any order.
 * 
 * Input: num = 8
 * Output: [3,3]
 * Explanation: For num + 1 = 9, the closest divisors are 3 & 3, for num + 2 = 10, the closest divisors are 2 & 5, hence 3 & 3 is chosen.
 * 
 * Input: num = 123
 * Output: [5,25]
 * 
 * Input: num = 999
 * Output: [40,25]
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    class Problem5171
    {
        public int[] ClosestDivisors(int num)
        {
            int[] min = new int[2];
            int minNum = num + 2;
            int i = 1;
            while (i <= num / 2 + 2)
            {
                if ((num + 1) % i == 0)
                {
                    int[] set = { i, (num + 1) / i };
                    if (Math.Abs(set[1] - set[0]) < minNum)
                    {
                        min = set;
                        minNum = set[1] - set[0];
                    }
                }
                if ((num + 2) % i == 0)
                {
                    int[] set = { i, (num + 2) / i };

                    if (Math.Abs(set[1] - set[0]) < minNum)
                    {
                        min = set;
                        minNum = set[1] - set[0];
                    }
                }
                i++;
            }
            return min;
        }

        public void Test()
        {
            foreach (var i in ClosestDivisors(1))
            {
                Console.Write(i + " ");
            }
            foreach (var i in ClosestDivisors(123))
            {
                Console.Write(i + " ");
            }
            foreach (var i in ClosestDivisors(999))
            {
                Console.Write(i + " ");
            }

            foreach (var i in ClosestDivisors(929467870))
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
