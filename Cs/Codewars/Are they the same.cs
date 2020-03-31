using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Are_they_the_same
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;
            if (a.Length == 0 || b.Length == 0)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= a[i];
            }
            HashSet<int> hashA = new HashSet<int>(a);
            HashSet<int> hashB = new HashSet<int>(b);
            if(hashA.SetEquals(hashB))
            {
                return true;
            }
            return false;
        }
        public static void Test()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = comp(a, b);
            Console.WriteLine(r);

            int[] a2 = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b2 = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            bool r2 = comp(a2, b2);
            Console.WriteLine(r2);


            int[] a3 = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b3 = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            bool r3 = comp(a3, b3);
            Console.WriteLine(r3);

            int[] a4 = new int[] { 11, 19, 19, 19, 121, 144, 144, 161 };
            int[] b4 = new int[] { 121, 361, 361, 14641, 20736, 20736, 25921, 36100 };
            bool r4 = comp(a4, b4);
            Console.WriteLine(r4);
        }
    }
}
