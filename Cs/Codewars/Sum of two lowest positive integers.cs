using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Sum_of_two_lowest_positive_integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int lowest = numbers[0];
            int lower = numbers[1];
            for(int i = 2; i<numbers.Length; i++)
            {
                int num = numbers[i];
                if(num < lowest && num < lower)
                {
                    if(lowest < lower)
                    {
                        lower = num;
                    }
                    else
                    {
                        lowest = num;
                    }
                }
                else if(num<lower)
                {
                    lower = num;
                }
                else if(num<lowest)
                {
                    lowest = num;
                }
            }
            return lower+lowest;
        }

        public static void Test()
        {
            int[] numbers1 = { 19, 5, 42, 2, 77 };
            Console.WriteLine(sumTwoSmallestNumbers(numbers1));
            int[] numbers2 = { 1,3,4,2,5,6,1 };
            Console.WriteLine(sumTwoSmallestNumbers(numbers2));
        }
    }
}
