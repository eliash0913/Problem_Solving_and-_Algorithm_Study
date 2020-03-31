using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Equal_Sides_Of_An_Array
    {
        public static int FindEvenIndex(int[] arr)
        {
            for(int index = 0; index<arr.Length; index++)
            {
                int leftsum = 0;
                int rightsum = 0;
                for(int left = 0; left<index; left++)
                {
                    leftsum += arr[left];
                }
                for(int right = arr.Length-1; right>index; right--)
                {
                    rightsum += arr[right];
                }
                if(leftsum == rightsum)
                {
                    return index;
                }
            }
            return -1;
        }
        public static void Test()
        {
            int[] numbers1 = { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(FindEvenIndex(numbers1));
            int[] numbers2 = { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(FindEvenIndex(numbers2));
            int[] numbers3 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(FindEvenIndex(numbers3));
            int[] numbers4 = { 20, 10, 30, 10, 10, 15, 35 };
            Console.WriteLine(FindEvenIndex(numbers4));
        }
    }
}
