using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Josephus_Permutation
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> result = new List<object>();
            while(items.Count > 0)
            {
                items.RemoveAt(k);
            }
            return new List<object>();
        }
        public static void Test()
        {
            object[] sample = new object[] { 1, 2, 3, 4, 5, 6, 7 };
            DisplayResults.Display(JosephusPermutation(new List<object>(sample), 3));
        }
    }
}
