using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Snail_travel
    {
        public static int[] Snail(int[][] array)
        {
            int xMin = 0;
            int xMax = array.Length-1;
            int yMin = 0;
            int yMax = array[0].Length-1;
            int x = 0;
            int y = 0;
            int index = 0;
            int resultSize = array.Length * array[0].Length;
            int[] result = new int[resultSize];
            while(index < resultSize)
            {
                if(x == xMax && y == yMin)
                {
                    result[index++] = array[y++][x];
                    yMin++;
                }
                else if (x == xMax && y == yMax)
                {
                    result[index++] = array[y][x--];
                    xMax--;
                }
                else if(x == xMin && y == yMax)
                {
                    result[index++] = array[y--][x];
                    yMax--;
                }
                else if(x == xMin && y == yMin && x!=y)
                {
                    result[index++] = array[y][x++];
                    xMin++;
                }
                if (x < xMax && y == yMin)
                {
                    result[index++] = array[y][x++];
                }
                else if(x == xMax && y < yMax)
                {
                    result[index++] = array[y++][x];
                }
                else if(x > xMin && y == yMax)
                {
                    result[index++] = array[y][x--];
                }
                else if(x == xMin && y > yMin)
                {
                    result[index++] = array[y--][x];
                }
            }
            return result;
        }

        public static void Test()
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            DisplayResults.Display(Snail(array));

            int[][] array2 =
            {
                new []{1, 2, 3, 4},
                new []{12, 13, 14, 5},
                new []{11, 16, 15, 6},
                new []{10, 9, 8, 7}
            };
            DisplayResults.Display(Snail(array2));

            int[][] array3 = { new int[] { } };
            DisplayResults.Display(Snail(array3));
        }
        
    }
}
