using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class High_Security_Strings
    {
        public static int getStrength(string password, int weight_a)
        {
            int sum = 0;
            int shift = 97 - weight_a;
            foreach(char c in password)
            {
                int value = Convert.ToInt32(c) - shift;
                if (value >= 26)
                    value -= 26;
                sum += value;
            }
            return sum;
        }

        public static void Test()
        {
            string sample1 = "hellomrz";
            Console.WriteLine(getStrength(sample1, 2));
            string sample2 = "aaaaa";
            Console.WriteLine(getStrength(sample2, 1));
        }
    }
}
