/*4. Median of Two Sorted Arrays
* There are two sorted arrays nums1 and nums2 of size m and n respectively.
* Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
* You may assume nums1 and nums2 cannot be both empty.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Hard
{
    class Problem4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length - 1;
            int length2 = nums2.Length - 1;
            int min1 = nums1[0];
            int min2 = nums2[0];
            int max1 = nums1[length1];
            int max2 = nums2[length2];
            int pos1 = length1 / 2, pos2 = length2 / 2;

            if (nums1[pos1] < nums2[pos2])
            {

            }
            int currentArray;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }








        }

        /*static int criticalCount = 0;
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] storage = new int[4];
            int m = nums1.Length;
            int n = nums2.Length;
            int mn = m + n;
            *//*int mPos = m / 2;
            int nPos = n / 2;*//*
            int mPos = (m % 2 == 0) ? m / 2 : (m - 1) / 2;
            int nPos = (n % 2 == 0) ? n / 2 : (n - 1) / 2;
            int pos = (mn % 2 == 0) ? mn / 2 : (mn - 1) / 2;
            int count = 0;
            double result;
            int maxCount = ((mn % 2 == 0) ? mn / 2 : (mn + 1) / 2);
            //while (count < maxCount)
            while(mPos + nPos < mn / 2)
            {
                if ((mPos == nPos) && (nums1[mPos] == nums2[nPos]) && ( mPos+nPos < mn/2))
                {
                    Console.WriteLine($"Equal num1: {nums1[mPos]} num2: {nums2[nPos]} strage: {storage[0]} {storage[1]} {storage[2]} {storage[3]}");
                    return nums1[mPos];
                }
                else if (nums1[mPos] < nums2[nPos])
                {
                    if (nPos > 0)
                    {
                        //storage[3] = nums2[nPos];
                        nPos--;
                    }
                    else if (mPos < m - 1)
                    {
                        //storage[0] = nums1[mPos];
                        mPos++;
                    }
                }
                else if (nums1[mPos] > nums2[nPos])
                {
                    if (mPos > 0)
                    {
                        //storage[2] = nums1[mPos];
                        mPos--;
                    }
                    else if (nPos < n - 1)
                    {
                        //storage[1] = nums2[nPos];
                        nPos++;
                    }
                }
                else
                {
                    if (mPos > 0 & nPos < n - 1)
                    {
                        mPos--;
                        nPos++;
                    }
                    else if (nPos > 0 & mPos < n - 1)
                    {
                        mPos++;
                        nPos--;
                    }
                    else if(mPos == 0 && nPos == 0)
                    {
                    }
                    else if (mPos == 0)
                    {
                        nPos--;
                    }
                    else if (nPos == 0)
                    {
                        mPos++;
                    }
                    //Console.WriteLine($"num1: {nums1[mPos]} num2: {nums2[nPos]} strage: {storage[0]} {storage[1]} {storage[2]} {storage[3]}");
                    //return nums1[mPos];
                }
                count++;

                criticalCount++;
            }
            
            Console.WriteLine($"num1: {nums1[mPos]} num2: {nums2[nPos]} strage: {storage[0]} {storage[1]} {storage[2]} {storage[3]}");
            result = (mn % 2 == 1) ? ((nums1[mPos] < nums2[nPos]) ? nums1[mPos] : nums2[nPos]) : (double)(nums1[mPos] + nums2[nPos]) / 2;
            return result;
        }*/
        public void Test()
        {
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 })); //2.5
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 })); //2
            Console.WriteLine(FindMedianSortedArrays(new int[] { 2 }, new int[] { 1, 3 })); //2
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1,2,3,4 }, new int[] { 5,6,7,8 }));//4.5
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1,3,5,7 }, new int[] { 2,4,5,6,8 })); //5
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2,3 })); //2.5
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3, 5, 7,15,45,55,67,81,94,101,125,215,344 }, new int[] { 2, 4, 5, 6, 8,8,9,10,23,34,45,54,67,87,98,101,201,230 }));//45
        }
    }
}
