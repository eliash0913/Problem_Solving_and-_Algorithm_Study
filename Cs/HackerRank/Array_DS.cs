using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Array_DS
    {
        /// <summary>
        /// An array is a type of data structure that stores elements of the same type in a contiguous block of memory. 
        /// In an array,A, of size N, each memory location has some unique index ,  
        /// i (where 0 < i < N), that can be referenced as A[i] (you may also see it written as Ai).
        /// Given an array,A, of N integers, print each element in reverse order as a single line of space-separated integers.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int[] ReverseArray(int[] a)
        {
            int tmp; //declare tmp to temporarily store a value
            int size = a.Length; //Size of array
            for (int i = 0; i < size/2; i++) //iterate half of array to switch symmetrically located two values 
            {
                tmp = a[i];
                a[i] = a[size - i - 1];
                a[size - i - 1] = tmp;
            }
            return a;
        }
        public static void Test()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 1, 3, 2, 4, 5, 6, 8, 7 };
            int[] arr3 = { 8, 7, 6, 5, 4, 3, 2, 1 };
            DisplayResults.Display(ReverseArray(arr1));
            DisplayResults.Display(ReverseArray(arr2));
            DisplayResults.Display(ReverseArray(arr3));
        }
    }
}
