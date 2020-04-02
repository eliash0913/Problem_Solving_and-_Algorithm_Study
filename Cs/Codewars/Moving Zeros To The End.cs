using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Moving_Zeros_To_The_End
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int front = 0;
            int end = arr.Length - 1;
            int[] result = new int[arr.Length];
            for(int index = 0; index < arr.Length; index++)
            {
                if(arr[index]!=0)
                {
                    result[front++] = arr[index];
                }
                else
                {
                    result[end--] = arr[index];
                }
            }
            return result;
        }
        public static void Test()
        {
            DisplayResults.Display(MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}
