using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Is_my_friend_cheating
    {
        public static List<long[]> removNb(long n)
        {
            List<long[]> result = new List<long[]>();
            long sum = n * (n + 1) / 2;
            long sqrt = (long)Math.Sqrt(sum);
            for (long x = sqrt - (n-sqrt); x < sqrt; x++)
            {
                long y = (sum - x) / (x + 1);
                if(x < n && y < n)
                {
                    if (x * y == sum - x - y)
                    {
                        result.Add(new long[] { x, y });
                    }
                }
            }
            int resultEnd = result.Count - 1;
            for(int i = resultEnd; i >= 0; i--)
            {
                result.Add(new long[] { result[i][1], result[i][0] });
            }
            return result;
        }
        public static void Test()
        {
            List<long[]> tmp = removNb(26);

            foreach (long[] x in tmp)
            {
                DisplayResults.Display(x);
            }

            List<long[]> tmp2 = removNb(1000003);

            foreach (long[] x in tmp2)
            {
                DisplayResults.Display(x);
            }

            List<long[]> tmp3 = removNb(846);

            foreach (long[] x in tmp3)
            {
                DisplayResults.Display(x);
            }
        }
    }
}
