/*Problem 7
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Easy
{
    class Problem7
    {
        public int Reverse(int x)
        {
            string strNum = x.ToString();
            string resultStr = "";
            int firstIndex;
            if (strNum[0] == '-')
            {
                resultStr += "-";
                firstIndex = 1;
            }
            else
                firstIndex = 0;

            for(int index = strNum.Length-1; index >= firstIndex ; index--)
            {
                resultStr += strNum[index];
            }
            int result;
            try
            {
                result = Int32.Parse(resultStr);
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        public void Test()
        {
            Console.WriteLine(Reverse(1534236469));
        }
    }
}
