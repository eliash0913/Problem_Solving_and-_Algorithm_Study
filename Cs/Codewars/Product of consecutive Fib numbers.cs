using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Product_of_consecutive_Fib_numbers
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong[] tmp = { 0, 1, 1 };
            while(tmp[1] * tmp[2] < prod)
            {
                tmp[0] = tmp[1];
                tmp[1] = tmp[2];
                tmp[2] = tmp[0] + tmp[1];
            }
            if (tmp[1] * tmp[2] == prod)
                return new ulong[] { tmp[1], tmp[2], 1 };
            else
                return new ulong[] { tmp[1], tmp[2], 0 };
        }

       /*the below is slow.*/
        
        /*public static ulong[] productFib(ulong prod)
        {
            ulong num = 0;
            ulong resultN = 0;
            ulong resultNP = 0;
            while (resultN * resultNP < prod)
            {
                num++;
                resultN = Fibonacci(num);
                resultNP = Fibonacci(num + 1);
            }
            if (resultN * resultNP == prod)
                return new ulong[] { resultN, resultNP, 1 };
            else
                return new ulong[] { resultN, resultNP, 0 };
            //return new ulong[] { resultN-(num * 2 - 3), resultNP - ((num+1) * 2 - 3), 0 };
        }

        public static ulong Fibonacci(ulong n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }*/

        public static void Test()
        {
            DisplayResults.Display(productFib(0));
            DisplayResults.Display(productFib(1));
            DisplayResults.Display(productFib(2));
            DisplayResults.Display(productFib(3));
            DisplayResults.Display(productFib(4));
            DisplayResults.Display(productFib(5));
            DisplayResults.Display(productFib(714));
            DisplayResults.Display(productFib(800));
            DisplayResults.Display(productFib(4895));
        }
    }
}
