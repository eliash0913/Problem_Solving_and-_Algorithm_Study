
/*1363. Largest Multiple of Three
* 
* Given an integer array of digits, return the largest multiple of three that can be formed by concatenating some of the given digits in any order.
* Since the answer may not fit in an integer data type, return the answer as a string.
* If there is no answer return an empty string.
* Input: digits = [8,1,9]
* Output: "981"
* Input: digits = [8,6,7,1,0]
* Output: "8760"
* Input: digits = [1]
* Output: ""
* Input: digits = [0,0,0,0,0,0]
* Output: "0"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Hard
{
    class Problem1363
    {
        public string LargestMultipleOfThree(int[] digits)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();
            string result = "";
            for (int i = 0; i < digits.Length; i++)
            {
                if(nums.ContainsKey(digits[i]))
                    nums[digits[i]]++;
                else
                    nums.Add(digits[i], 1);
            }
            int sum = 0;
            foreach (int key in nums.Keys)
            {
                sum += key * nums[key];
            }
            if (sum == 0)
                return "0";
            int rem = sum % 3;
            while (rem != 0)
            {
                int minKey = nums.Keys.Min();
                List<int> keys = nums.Keys.ToList<int>();
                keys.Sort();
                for (int i=0; i < keys.Count; i++)
                {
                    if (keys[i] % 3 == 0)
                    {
                        continue;
                    }
                    else if (keys[i]%3 == rem)
                    {
                        minKey = keys[i];
                        break;
                    }
                    else
                    {
                        minKey = keys[i];
                        continue;
                    }
                }
                if (nums[minKey]>1)
                {
                    sum -= minKey;
                    nums[minKey]--;
                }
                else if (nums[minKey] == 1)
                {
                    sum -= minKey;
                    nums.Remove(minKey);
                }
                else
                {
                    nums.Remove(minKey);
                }
                rem = sum % 3;
            }
            while (nums.Count != 0)
            {
                int maxKey = nums.Keys.Max();
                result += maxKey.ToString();
                if(nums[maxKey] > 1)
                {
                    nums[maxKey]--;
                }
                else
                {
                    nums.Remove(maxKey);
                }
            }
            return result;
        }
      
        public void Test()
        {
            int[] sample1 = { 8, 1, 9 };
            int[] sample2 = { 8, 6, 7, 1, 0 };
            int[] sample3 = { 1 };
            int[] sample4 = { 0, 0, 0, 0, 0, 0 };
            int[] sample5 = { 9, 8, 6, 8, 6 };
            int[] sample6 = { 7, 8, 7, 2, 1, 2, 6, 6, 9, 2 };
            int[] sample7 = { 7, 1, 2, 4, 0, 0, 4, 0, 3, 8 };
            Console.WriteLine(LargestMultipleOfThree(sample1));
            Console.WriteLine(LargestMultipleOfThree(sample2));
            Console.WriteLine(LargestMultipleOfThree(sample3));
            Console.WriteLine(LargestMultipleOfThree(sample4));
            Console.WriteLine(LargestMultipleOfThree(sample5));
            Console.WriteLine(LargestMultipleOfThree(sample6));
            Console.WriteLine(LargestMultipleOfThree(sample7));
        }
    }
}
