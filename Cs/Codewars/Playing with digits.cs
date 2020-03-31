using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Playing_with_digits
    {
        public static long digPow(int n, int p)
        {
            int digit = 0;
            int tmp = n;
            while(tmp > 9)
            {
                tmp /= 10;
                digit++;
            }
            int firstDigit = n / (int)Math.Pow(10, digit);
            int restDigit = n % (int)Math.Pow(10, digit--);
            int sum = (int)Math.Pow(firstDigit, p++);
            while(digit >= 0)
            {
                firstDigit = restDigit / (int)Math.Pow(10, digit);
                restDigit = restDigit % (int)Math.Pow(10, digit--);
                sum += (int)Math.Pow(firstDigit, p++);
            }
            int result = -1;
            if (sum % n == 0)
                result = sum / n;
            return result;
        }

        public static void Test()
        {
            Console.WriteLine(digPow(89, 1));
            Console.WriteLine(digPow(92, 1));
            Console.WriteLine(digPow(695, 2));
            Console.WriteLine(digPow(46288, 3));
        }
    }
}
