using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * A rectangle is represented as a list [x1, y1, x2, y2], where (x1, y1) are the coordinates of its bottom-left corner, and (x2, y2) are the coordinates of its top-right corner.
 * Two rectangles overlap if the area of their intersection is positive.  To be clear, two rectangles that only touch at the corner or edges do not overlap.
 * Given two (axis-aligned) rectangles, return whether they overlap.
 * Example 1:
 * Input: rec1 = [0,0,2,2], rec2 = [1,1,3,3]
 * Output: true
 * Example 2:
 * Input: rec1 = [0,0,1,1], rec2 = [1,0,2,1]
 * Output: false
 * Notes:
 * 
 * Both rectangles rec1 and rec2 are lists of 4 integers.
 * All coordinates in rectangles will be between -10^9 and 10^9.
*/
namespace Problem_Solving_and__Algorithm_Study.LeetCode.Easy
{
    class Problem836
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            int x1 = 0;
            int x2 = 2;
            int y1 = 1;
            int y2 = 3;
            if(rec1[x1]<=rec2[x1] && rec2[x1] < rec1[x2])
            {
                if(rec1[y2]>rec2[y1] && rec1[y1] < rec2[y2])
                {
                    return true;
                }
                else if (rec2[y2] > rec1[y1] && rec2[y1] < rec1[y2])
                {
                    return true;
                }
            }
            if (rec2[x1] <= rec1[x1] && rec1[x1] < rec2[x2])
            {
                if (rec1[y2] > rec2[y1] && rec1[y1] < rec2[y2])
                {
                    return true;
                }
                else if (rec2[y2] > rec1[y1] && rec2[y1] < rec1[y2])
                {
                    return true;
                }
            }
            return false;
        }
        public void Test()
        {
            int[] sample1a = new int[4] { 0, 0, 2, 2 };
            int[] sample1b = new int[4] { 1, 1, 3, 3 };
            Console.WriteLine(IsRectangleOverlap(sample1a, sample1b));
            int[] sample2a = new int[4] { 0, 0, 1, 1 };
            int[] sample2b = new int[4] { 1, 0, 2, 1 };
            Console.WriteLine(IsRectangleOverlap(sample2a, sample2b));
            int[] sample3a = new int[4] { 2, 17, 6, 20 };
            int[] sample3b = new int[4] { 3, 8, 6, 20 };
            Console.WriteLine(IsRectangleOverlap(sample3a, sample3b));
            int[] sample4a = new int[4] { -7, -3, 10, 5 };
            int[] sample4b = new int[4] { -6, -5, 5, 10 };
            Console.WriteLine(IsRectangleOverlap(sample4a, sample4b));
        }
    }
}
