using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Sort_the_odd
    {
        public static int[] SortArray(int[] array)
        {
            if (array.Length == 0)
                return array;
            List<int> buffer = new List<int>();
            for(int index = 0; index < array.Length; index++)
            {
                if(array[index]%2==1)
                {
                    buffer.Add(array[index]);
                }
            }
            buffer.Sort();
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] % 2 == 1)
                {
                    array[index] = buffer.First();
                    buffer.RemoveAt(0);
                }
            }
            return array;
        }
        public static void Test()
        {
            DisplayResults.Display(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            DisplayResults.Display(SortArray(new int[] { 5, 3, 1, 8, 0 }));
            DisplayResults.Display(SortArray(new int[] { }));
        }
    }
}
