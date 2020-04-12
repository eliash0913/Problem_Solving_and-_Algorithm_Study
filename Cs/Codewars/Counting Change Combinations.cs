using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Counting_Change_Combinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            List<Queue<int>> lq = new List<Queue<int>>();
            List<List<int>> result = new List<List<int>>();
            int count = 0;
            for(int i = 0; i < coins.Length; i++)
            {
                //if (money - coins[i] > 0)
                  //  queue.Enqueue(coins[i]);
            }
            
            
            return count;
        }
        public static void Test()
        {
            Console.WriteLine(CountCombinations(4, new[] { 1, 2 }));
            Console.WriteLine(CountCombinations(10, new[] { 5, 2, 3 }));
            Console.WriteLine(CountCombinations(11, new[] { 5, 7 }));
        }
    }
}
