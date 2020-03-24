/// <summary>
/// ou are in charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age. 
/// When she blows out the candles, she’ll only be able to blow out the tallest ones. 
/// Your task is to find out how many candles she can successfully blow out.
/// </summary>
/// <param name="ar"></param>
/// <returns></returns>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    /***** COMPLETED *****/
    class Birthday_Cake_Candles
    {

        static int BirthdayCakeCandles(int[] ar)
        {
            int max = ar[0]; //set an initial max value to be compared.
            int count = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if (max < ar[i]) //If there is taller candle.
                {
                    max = ar[i]; //Reset the tallest candle.
                    count = 1; //Reset count.
                }
                else if(max == ar[i])
                {
                    count++;
                }
            }
            return count;
        }

        public static void Test()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 5, 3, 2 };
            int[] arr2 = { 1, 2, 3, 3, 3, 3, 3, 2 };
            int[] arr3 = { 1, 2, 3, 4, 5, 1, 3, 2 };
            Console.WriteLine(BirthdayCakeCandles(arr1));
            Console.WriteLine(BirthdayCakeCandles(arr2));
            Console.WriteLine(BirthdayCakeCandles(arr3));
        }
    }
}
