using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Moving_Zeros_To_The_End
    {
        //public static int[] MoveZeroes(int[] arr)
        //{
        //    int front = 0;
        //    int end = arr.Length - 1;
        //    int[] result = new int[arr.Length];
        //    for (int index = 0; index < arr.Length; index++)
        //    {
        //        if (arr[index] != 0)
        //        {
        //            result[front++] = arr[index];
        //        }
        //        else
        //        {
        //            result[end--] = arr[index];
        //        }
        //    }
        //    return result;
        //}


        //In place method
        public static int[] MoveZeroes(int[] arr)
        {
            int end = arr.Length - 1;
            for (int index = 0; index < end; index++)
            {
                if (arr[index] == 0)
                {
                    int cIndex = index;
                    while (arr[cIndex] == 0 && cIndex < end)
                    {
                        cIndex++;
                    }
                    arr[index] = arr[cIndex];
                    arr[cIndex] = 0;
                }
            }
            return arr;
        }

        public static void Test()
        {
            DisplayResults.Display(MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}
