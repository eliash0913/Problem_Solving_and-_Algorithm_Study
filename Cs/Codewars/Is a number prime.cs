using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Is_a_number_prime
    {
        public static bool IsPrime(int n)
        {
            if(n<=1)
            {
                return false;
            }
            else if(n==2)
            {
                return true;
            }
            else if(n%2==0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < n; i += 2)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
        public static void Test()
        {
            DisplayResults.Display(IsPrime(1));
            DisplayResults.Display(IsPrime(0));
            DisplayResults.Display(IsPrime(-1));
            DisplayResults.Display(IsPrime(2));
            DisplayResults.Display(IsPrime(3));
            DisplayResults.Display(IsPrime(4));
            DisplayResults.Display(IsPrime(5));
            DisplayResults.Display(IsPrime(6));
        }
    }
}
