using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Algorithm.Sort
{
    class Merge_Sort
    {
        void merge(int[] arr, int l, int m, int r)
        {
            int start = l;
            int end = m + 1;
            int[] tmp = new int[r - l + 1];
            int k = 0;
            for(int i = start; i < end; i++)
            {
                if(start > m)
                {
                    tmp[k++] = arr[end++];
                }
                else if(end > r)
                {
                    tmp[k++] = arr[start++];
                }
                else if(arr[start] < arr[end])
                {
                    tmp[k++] = arr[start++];
                }
                else
                {
                    tmp[k++] = arr[end++];
                }
            }
            for(int i = 0; i < k; i++)
            {
                arr[l++] = tmp[i];
            }
        }

        void mergeSort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = (l + r) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        public void Test()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int arr_size = arr.Length;
            mergeSort(arr, 0, arr_size - 1);
            DisplayResults.Display(arr);
        }
    }
}
