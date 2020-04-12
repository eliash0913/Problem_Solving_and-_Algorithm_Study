using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Hamming_Numbers
    {
        /*public static long hamming(int n)
        {
            int i = 0, j = 0, k = 0;
            List<long> result = new List<long>();
            HashSet<long> result2 = new HashSet<long>();
            for (k = 0; k <= n / 5 + 1; k++)
            {
                for (j = 0; j <= n / 3 + 1; j++)
                {
                    for (i = 0; i <= n / 2 + 1; i++)
                    {
                        if ((long)Math.Pow(2, i) * (long)Math.Pow(3, j) * (long)Math.Pow(5, k) > 0)
                            result.Add((long)Math.Pow(2, i) * (long)Math.Pow(3, j) * (long)Math.Pow(5, k));
                    }
                }
            }
            result.Sort();
            return result[n - 1];
        }*/
        public static long hamming(int n)
        {
            int i = 0, j = 0, k = 0;
            List<long> result = new List<long>();
            for (k = 0; k <= 2; k++)
            {
                for (j = 0; j <= 2; j++)
                {
                    for (i = 0; i <= 5; i++)
                    {
                        if((long)Math.Pow(2, i) * (long)Math.Pow(3, j) * (long)Math.Pow(5, k)>0)
                            result.Add((long)Math.Pow(2, i) * (long)Math.Pow(3, j) * (long)Math.Pow(5, k));
                    }
                }
            }
            result.Sort();
            DisplayResults.Display(result);
            long[] set = new long[5];
            int index = 0;
            for (int s = 7; s <= 26; s++)
            {
                set[index++] = result[s-1];
            }
            if (n>6)
            {
                int setCoefficient = ((n - 7) / 28)+1;
                int setIndex = (n - 28) % 5;
                return set[setIndex] * (long)Math.Pow(2, setCoefficient - 1);
            }
            else
            {
                return result[n-1];
            }
        }
        public static void Test()
        {
            int n = 20;
            for (int i = 1; i < n; i++)
                Console.WriteLine(hamming(i));
            /*Console.WriteLine(hamming(7));
            Console.WriteLine(hamming(8));
            Console.WriteLine(hamming(40));*/
            //Console.WriteLine(hamming(110));
            /*hamming(1);
            hamming(2);
            hamming(3);
            hamming(4);
            hamming(5);
            hamming(6);
            hamming(7);
            hamming(8);*/
            /*            Console.WriteLine();
                        Console.WriteLine(hamming(2));
                        Console.WriteLine(hamming(3));*/
            //Console.WriteLine(hamming(4));
        }
    }
}
