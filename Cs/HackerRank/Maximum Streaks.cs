using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Maximum_Streaks
    {
        public static List<int> getMaxStreaks(List<string> toss)
        {
            int headCount = 0;
            int tailCount = 0;
            int headCountMax = 0;
            int tailCountMax = 0;
            foreach(string t in toss)
            {
                if(t=="Heads")
                {
                    tailCount = 0;
                    headCount++;
                }
                if(t=="Tails")
                {
                    headCount = 0;
                    tailCount++;
                }
                if(headCount > headCountMax)
                {
                    headCountMax = headCount;
                }
                if(tailCount > tailCountMax)
                {
                    tailCountMax = tailCount;
                }
            }
            return new int[] { headCountMax, tailCountMax }.ToList();
        }

        public static void Test()
        {
            List<string> sample1 = new string[] { "Heads", "Tails", "Tails", "Tails", "Heads", "Heads", "Tails" }.ToList() ;
            DisplayResults.Display(getMaxStreaks(sample1));
            List<string> sample2 = new string[] { "Tails", "Tails", "Tails"}.ToList() ;
            DisplayResults.Display(getMaxStreaks(sample2));
        }
    }
}
