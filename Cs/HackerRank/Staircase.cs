using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Staircase
    {
        /***** COMPLETED *****/
        static void staircase(int n)
        {
            char ws = ' ';
            char sh = '#';
            
            for(int i = 1; i <= n; i++) //First loop for the rows
            {
                string stair = "";
                for (int j = 1; j <= n; j++) //Second loop for the columns
                {
                    if (n - i >= j) // in n by n matrix, first row will have white spaces as many as n - i.
                        stair += ws;
                    else //fill the rest of matrix with #.
                        stair += sh;
                }
                Console.WriteLine(stair);
            }
        }

        public static void Test()
        {
            staircase(5);
        }
    }
}
