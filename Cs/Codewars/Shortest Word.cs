using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Shortest_Word
    {
        public static int FindShort(string s)
        {
            int min = s.Length;
            foreach(var word in s.Split())
            {
                int length = word.Length;
                if (length < min)
                    min = length;
            }
            return min;
        }

        public static void Test()
        {
            DisplayResults.Display(FindShort("bitcoin take over the world maybe who knows perhaps"));
            DisplayResults.Display(FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
}
