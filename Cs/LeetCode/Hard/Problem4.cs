/*4. Median of Two Sorted Arrays
* There are two sorted arrays nums1 and nums2 of size m and n respectively.
* Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
* You may assume nums1 and nums2 cannot be both empty.
* https://leetcode.com/problems/median-of-two-sorted-arrays/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Hard
{
    /***** WORKING *****/
    class Problem4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n1Size = nums1.Length;
            int n2Size = nums2.Length;
            bool isLefteven = n1Size % 2 == 0 ? true : false;
            bool isRighteven = n2Size % 2 == 0 ? true : false;
            int n1MinPos = 0;
            int n1MaxPos = n1Size - 1;
            int n2MinPos = 0;
            int n2MaxPos = n2Size - 1;
            int leftPos = (n1Size - 1) / 2;
            int rightPos = (n2Size - 1) / 2;
            while (true)
            {
                if (n1Size == 0)
                {
                    return isRighteven ? (double)(nums2[rightPos + 1] + nums2[rightPos]) / 2 : nums2[rightPos];
                }
                else if (n2Size == 0)
                {
                    return isLefteven ? (double)(nums1[leftPos + 1] + nums1[leftPos]) / 2 : nums1[leftPos];
                }
                else if (n1Size == 1 && n2Size == 1)
                {
                    return (double)(nums1[0] + nums2[0]) / 2;
                }
                else if (n1Size == 1)
                {
                    if (nums1[0] < nums2[rightPos])
                    {
                        if (n2Size % 2 == 1)
                        {
                            if (nums2[rightPos - 1] <= nums1[0])
                                return (double)(nums1[0] + nums2[rightPos]) / 2;
                            else
                                return (double)(nums2[rightPos - 1] + nums2[rightPos]) / 2;
                        }
                        else
                        {
                            return nums2[rightPos];
                        }
                    }
                    else if (nums1[0] > nums2[rightPos])
                    {
                        if (n2Size % 2 == 0)
                        {
                            if (nums2[rightPos + 1] > nums1[0])
                                return nums1[0];
                            else
                                return nums2[rightPos + 1];
                        }
                        else
                        {
                            if (nums2[rightPos + 1] > nums1[0])
                                return (double)(nums2[rightPos] + nums1[0]) / 2;
                            else
                                return (double)(nums2[rightPos] + nums2[rightPos + 1]) / 2;
                        }
                    }
                    else
                        return nums1[0];
                }
                else if (n2Size == 1)
                {
                    if (nums2[0] < nums1[leftPos])
                    {
                        if (n1Size % 2 == 1)
                        {
                            if (nums1[leftPos - 1] <= nums2[0])
                                return (double)(nums2[0] + nums1[leftPos]) / 2;
                            else
                                return (double)(nums1[leftPos - 1] + nums1[leftPos]) / 2;
                        }
                        else
                        {
                            return nums1[leftPos];
                        }
                    }
                    else if (nums2[0] > nums1[leftPos])
                    {
                        if (n1Size % 2 == 0)
                        {
                            if (nums1[leftPos + 1] > nums2[0])
                                return nums2[0];
                            else
                                return nums1[leftPos + 1];
                        }
                        else
                        {
                            if (nums1[leftPos + 1] > nums2[0])
                                return (double)(nums1[leftPos] + nums2[0]) / 2;
                            else
                                return (double)(nums1[leftPos] + nums1[leftPos + 1]) / 2;
                        }
                    }
                    else
                        return nums2[0];
                }
                else if (n1Size == 2 && n2Size == 2)
                {
                    Console.WriteLine($"Left Pos: {leftPos} Min: {n1MinPos} Max: {n1MaxPos} Right Pos: {rightPos} Min: {n2MinPos} Max: {n2MaxPos}");
                    int[] temp;
                    int shift = (nums1.Length - n1MaxPos + nums2.Length - n2MaxPos - 2 - n1MinPos - n2MinPos);
                    Console.WriteLine(shift);
                    shift = shift < 1 ?  (shift < -1 ? -1 : shift) + 1: (shift > 2 ? 2 : shift);
                    if (nums1[n1MinPos] < nums2[n2MinPos])
                    {
                        if (nums1[n1MaxPos] < nums2[n2MaxPos])
                        {
                            if (nums1[n1MaxPos] < nums2[n2MinPos])
                            {
                                temp = new int[4] { nums1[n1MinPos], nums1[n1MaxPos], nums2[n2MinPos], nums2[n2MaxPos] };
                            }
                            else
                            {
                                temp = new int[4] { nums1[n1MinPos], nums2[n2MinPos], nums1[n1MaxPos], nums2[n2MaxPos] };
                            }
                        }
                        else
                        {
                            temp = new int[4] { nums1[n1MinPos], nums2[n2MinPos], nums2[n2MaxPos], nums1[n1MaxPos] };
                        }
                    }
                    else
                    {
                        if (nums1[n1MaxPos] < nums2[n2MaxPos])
                        {

                            temp = new int[4] { nums2[n2MinPos], nums1[n1MinPos], nums1[n1MaxPos], nums2[n2MaxPos] };

                        }
                        else
                        {
                            if (nums1[n1MinPos] < nums2[n2MaxPos])
                            {
                                temp = new int[4] { nums2[n2MinPos], nums1[n1MinPos], nums2[n2MaxPos], nums1[n1MaxPos] };
                            }
                            else
                            {
                                temp = new int[4] { nums2[n2MinPos], nums2[n2MaxPos], nums1[n1MinPos], nums1[n1MaxPos] };
                            }
                        }
                    }
                if (nums1.Length % 2 != nums2.Length % 2)
                    {

                        return temp[1 + shift];
                    }
                    else
                    {
                        return (double)(temp[0 + shift] + temp[1 + shift]) / 2;
                    }
                }
                else if (nums1[n1Size / 2] == nums2[n2Size / 2])
                {
                    if (isLefteven && isRighteven)
                    {
                        leftPos = (n1MaxPos - n1MinPos) / 2;
                        n1MinPos = leftPos;
                        n1MaxPos = leftPos + 1;
                        rightPos = (n2MaxPos - n2MinPos) / 2;
                        n2MinPos = rightPos;
                        n2MaxPos = rightPos + 1;
                        if (nums1[n1MinPos] < nums2[n2MinPos])
                        {
                            if (nums1[n1MaxPos] < nums2[n2MaxPos])
                                return (double)(nums2[n2MinPos] + nums1[n1MaxPos]) / 2;
                            else
                                return (double)(nums2[n2MinPos] + nums2[n2MaxPos]) / 2;
                        }
                        else
                        {
                            if (nums1[n1MaxPos] < nums2[n2MaxPos])
                                return (double)(nums1[n1MinPos] + nums1[n1MaxPos]) / 2;
                            else
                                return (double)(nums2[n2MaxPos] + nums1[n1MinPos]) / 2;
                        }
                    }
                    else
                    {
                        return nums1[n1Size/2];
                    }
                }
                else if (nums1[leftPos] == nums2[rightPos])
                {
                    if(isLefteven && isRighteven)
                    {
                        leftPos = (n1MaxPos - n1MinPos + 1) / 2;
                        n1MinPos = leftPos;
                        n1MaxPos = leftPos + 1;
                        rightPos = (n2MaxPos - n2MinPos + 1) / 2;
                        n2MinPos = rightPos;
                        n2MaxPos = rightPos + 1;

                        if (nums1[n1MinPos] < nums2[n2MinPos])
                        {
                            if (nums1[n1MaxPos] < nums2[n2MaxPos])
                                return (double)(nums2[n2MinPos] + nums1[n1MaxPos]) / 2;
                            else
                                return (double)(nums2[n2MinPos] + nums2[n2MaxPos]) / 2;
                        }
                        else
                        {
                            if (nums1[n1MaxPos] < nums2[n2MaxPos])
                                return (double)(nums1[n1MinPos] + nums1[n1MaxPos]) / 2;
                            else
                                return (double)(nums2[n2MaxPos] + nums1[n1MinPos]) / 2;
                        }
                    }
                    else
                    {
                        return nums1[leftPos];
                    }
                }
                else
                {
                    if (nums1[leftPos] < nums2[rightPos])
                    {
                        if (n2Size % 2 == 0)
                        {
                            if (n1Size == 2 && nums1[n1MaxPos] > nums2[rightPos])
                            {
                                n2MinPos = rightPos;
                            }
                            else
                            {
                                n2MaxPos = rightPos + 1;
                            }
                        }
                        else
                        {
                            n2MaxPos = rightPos;
                        }
                        rightPos = (n2MaxPos + n2MinPos) / 2;
                        n2Size = n2MaxPos - n2MinPos + 1;
                        if (n1Size % 2 == 0)
                        {
                            if (nums1.Length - n1Size > nums2.Length - n2Size)
                            {
                                if (n1Size % 2 == 0)
                                {
                                    n1MaxPos = leftPos + 1;
                                }
                                else
                                {
                                    n1MaxPos = leftPos;
                                }
                            }
                            else
                            {
                                if (nums1.Length % 2 == 0)
                                    n1MinPos = leftPos;
                                else
                                    n1MinPos = leftPos + 1;
                            }
                        }
                        else
                        {
                            n1MinPos = leftPos;
                        }
                        leftPos = (n1MaxPos + n1MinPos) / 2;
                        n1Size = n1MaxPos - n1MinPos + 1;
                    }
                    else if (nums1[leftPos] > nums2[rightPos])
                    {
                        if (n1Size % 2 == 0)
                        {
                            if(n2Size == 2 && nums2[n2MaxPos] > nums1[leftPos])
                            {
                                n1MinPos = leftPos;
                            }
                            else
                            {
                                n1MaxPos = leftPos + 1;
                            }
                        }
                        else
                        {
                            n1MaxPos = leftPos;
                        }
                        leftPos = (n1MaxPos + n1MinPos) / 2;
                        n1Size = n1MaxPos - n1MinPos + 1;
                        if (n2Size % 2 == 0)
                        {
                            if(nums2.Length - n2Size > nums1.Length - n1Size)
                            {
                                if (n2Size % 2 == 0)
                                {
                                    n2MaxPos = rightPos + 1;
                                }
                                else
                                {
                                    n2MaxPos = rightPos;
                                }
                            }
                            else
                            {
                                if (nums2.Length % 2 == 0)
                                    n2MinPos = rightPos;
                                else
                                    n2MinPos = rightPos + 1;
                            }
                        }
                        else
                        {
                            n2MinPos = rightPos;
                        }
                        rightPos = (n2MaxPos + n2MinPos) / 2;
                        n2Size = n2MaxPos - n2MinPos + 1;
                    }
                    else
                    {
                        if (n1Size % 2 == 0)
                        {
                            n1MinPos = leftPos - 1;
                            leftPos = n1MinPos;
                            n1Size = 2;
                        }
                        else
                        {
                            n1MinPos = leftPos;
                            n1Size = 1;
                        }
                        n1MaxPos = leftPos;
                        if (n2Size % 2 == 0)
                        {
                            n2MinPos = rightPos - 1;
                            rightPos = n2MinPos;
                            n2Size = 2;
                        }
                        else
                        {
                            n2MinPos = rightPos;
                            n2Size = 1;
                        }
                        n2MaxPos = rightPos;
                    }
                    
                    isLefteven = n1Size % 2 == 0 ? true : false;
                    isRighteven = n2Size % 2 == 0 ? true : false;
                }
            }
            
        }

        private static int number = 1;
        public void GetResult(int[] nums1, int[] nums2, double expected)
        {
            string n1s = "{ ";
            foreach (var n1 in nums1)
                n1s += n1 + " ";
            n1s += "}";

            string n2s = "{ ";
            foreach (var n2 in nums2)
                n2s += n2 + " ";
            n2s += "}";

            //Console.WriteLine("nums1 = {0}     nums2 = {1}", n1s, n2s);

            double result = FindMedianSortedArrays(nums1, nums2);
            if (result == expected)
            {
                Console.WriteLine($"{number++}: Pass / Result: {result} Expected: {expected}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{number++}: Fail / Result: {result} Expected: {expected}");
                Console.WriteLine();
            }
        }

        public void Test()
        {
            /*            Console.WriteLine("---------------- When n1Size == 0 or n2Size == 0 ----------------");
                        GetResult(new int[] { 3 }, new int[] { }, 3);
                        GetResult(new int[] { 1, 1, 3, 3 }, new int[] { }, 2.0);
                        GetResult(new int[] { 1, 1, 1, 1 }, new int[] { }, 1.0);
                        GetResult(new int[] { 2, 3 }, new int[] { }, 2.5);
                        GetResult(new int[] { }, new int[] { 1, 1, 3 }, 1.0);
                        GetResult(new int[] { 1, 1, 3 }, new int[] { }, 1.0);
                        Console.WriteLine("---------------- When n1Size == 1 or n2Size == 1 ----------------");
                        GetResult(new int[] { 3 }, new int[] { 0 }, 1.5);
                        GetResult(new int[] { 3 }, new int[] { 2 }, 2.5);
                        GetResult(new int[] { 1, 3 }, new int[] { 2 }, 2);
                        GetResult(new int[] { 2 }, new int[] { 1, 3 }, 2);
                        GetResult(new int[] { 5 }, new int[] { 1, 2, 3, 4 }, 3);
                        GetResult(new int[] { 2, 3 }, new int[] { 1 }, 2);
                        GetResult(new int[] { 1 }, new int[] { 2, 3 }, 2);
                        GetResult(new int[] { 1, 2, 3, 4 }, new int[] { 5 }, 3);
                        GetResult(new int[] { 1, 2, 3 }, new int[] { 4 }, 2.5);
                        GetResult(new int[] { 4 }, new int[] { 1, 2, 3 }, 2.5);
                        GetResult(new int[] { 3 }, new int[] { 1, 2, 4 }, 2.5);
                        GetResult(new int[] { 1, 2, 4 }, new int[] { 3 }, 2.5);
                        GetResult(new int[] { 2 }, new int[] { 1, 3, 4 }, 2.5);
                        GetResult(new int[] { 1, 3, 4 }, new int[] { 2 }, 2.5);
                        GetResult(new int[] { 1 }, new int[] { 2, 3, 4 }, 2.5);
                        GetResult(new int[] { 2, 3, 4 }, new int[] { 1 }, 2.5);
                        Console.WriteLine("---------------- When else ----------------");*/
            GetResult(new int[] { 1, 5 }, new int[] { 2, 3, 4, 6, 7 }, 4);
            GetResult(new int[] { 2, 3, 4, 6, 7 }, new int[] { 1, 5 }, 4);  
            GetResult(new int[] { 1, 2 }, new int[] { 3, 4, 5, 6, 7 }, 4);
            GetResult(new int[] { 3, 4, 5, 6, 7 }, new int[] { 1, 2 }, 4);  
            GetResult(new int[] { 4, 5 }, new int[] { 1, 2, 3, 6 }, 3.5);
            GetResult(new int[] { 1, 2, 3, 6 }, new int[] { 4, 5 }, 3.5);
            GetResult(new int[] { 2, 3, 4, 6 }, new int[] { 1, 5 }, 3.5);
            GetResult(new int[] { 1, 5 }, new int[] { 2, 3, 4, 6 }, 3.5);
            GetResult(new int[] { 1, 2 }, new int[] { 3, 4, 5, 6 }, 3.5);
            GetResult(new int[] { 3,4,5,6 }, new int[] { 1,2 }, 3.5);
            GetResult(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, 3);
            GetResult(new int[] { 3, 4, 5 }, new int[] { 1, 2 }, 3);
            GetResult(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, 3);
            GetResult(new int[] { 4,5 }, new int[] { 1,2,3 }, 3);
            GetResult(new int[] { 1, 3, 5, 7 }, new int[] { 2, 4, 5, 6, 8 }, 5);
            GetResult(new int[] { 1, 2 }, new int[] { -1, 3 }, 1.5);
            GetResult(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5);
            GetResult(new int[] { 3, 4 }, new int[] { 1, 2 }, 2.5);
            GetResult(new int[] { -1, 3 }, new int[] { 1, 2 }, 1.5);
            GetResult(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, 4.5);
            GetResult(new int[] { 1, 3, 5, 7 }, new int[] { 2, 4, 5, 6, 8 }, 5);
            GetResult(new int[] { 1, 2 }, new int[] { 1, 2 }, 1.5);
            GetResult(new int[] { 1, 3 }, new int[] { 2, 3 }, 2.5);
            GetResult(new int[] { 2, 4, 5, 6, 8, 8, 9, 10, 23, 34, 45, 54, 67, 87, 98, 101, 201, 230 }, new int[] { 2 }, 23);
            GetResult(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, 3);
            GetResult(new int[] { 1, 2 }, new int[] { 1, 2, 3 }, 2);
            GetResult(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, 2);
            GetResult(new int[] { 3, 4 }, new int[] { 1, 2, 5 }, 3);
            GetResult(new int[] { 1, 2, 5 }, new int[] { 3, 4 }, 3);
            GetResult(new int[] { 1, 3, 4 }, new int[] { 2, 3, 4 }, 3);
            GetResult(new int[] { 1, 2, 2 }, new int[] { 1, 2, 3 }, 2);
            GetResult(new int[] { 1, 3, 94, 101, 125, 215, 344 }, new int[] { 2, 4, 5, 6, 8, 8, 9, 10, 23, 34, 45, 54, 67, 87, 98, 101, 201, 230 }, 45);
            GetResult(new int[] { 2, 4, 5, 6, 8, 8, 9, 10, 23, 34, 45, 54, 67, 87, 98, 101, 201, 230 }, new int[] { 1, 3, 94, 101, 125, 215, 344 }, 45);
            GetResult(new int[] { 1, 3, 5, 7, 15, 45, 55, 67, 81, 94, 101, 125, 215, 344 }, new int[] { 2, 4, 5, 6, 8, 8, 9, 10, 23, 34, 45, 54, 67, 87, 98, 101, 201, 230 }, 45);
            GetResult(new int[] { 2, 4, 5, 6, 8, 8, 9, 10, 23, 34, 45, 54, 67, 87, 98, 101, 201, 230 }, new int[] { 1, 3, 5, 7, 15, 45, 55, 67, 81, 94, 101, 125, 215, 344 }, 45);
            GetResult(new int[] { 1, 1, 3, 3 }, new int[] { 1, 1, 3, 3 }, 2.0);
            GetResult(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, 1.0);
            GetResult(new int[] { 1, 1, 1, 1 }, new int[] { 0, 0, 0, 0 }, 0.5);
        }
    }


}
