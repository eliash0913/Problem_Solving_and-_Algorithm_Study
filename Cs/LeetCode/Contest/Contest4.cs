using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    class Contest4
    {
        public int NumOfWays(int n)
        {
            char[] colors = new char[] { 'r', 'g', 'b' };
            List<List<List<char>>> grids = new List<List<List<char>>>();
            int max = n * 3;
            List<List<char>> grid = new List<List<char>>();
            for (int i = 0; i<n; i++)
            {
                foreach (var color1 in colors)
                    foreach (var color2 in colors)
                        foreach (var color3 in colors)
                        {
                            if(i==0)
                            {
                                if (color1 != color2 && color2 != color3)
                                {
                                    grid.Add(new List<char>() { color1, color2, color3 });
                                    Console.WriteLine($"Row{i} {color1} {color2} {color3}");
                                }
                            }
                            else
                            {
                                if (grid[i - 1][0] != color1 && grid[i - 1][1] != color2 && grid[i - 1][2] != color3)
                                {
                                    Console.WriteLine($"Row{i} {color1} {color2} {color3}");
                                }
                            }
                        }
                      
                //grids.Add(grid);
                
            }
            return grid.Count;
        }
        public void Test()
        {
            Console.WriteLine(NumOfWays(2));
            //Console.WriteLine(NumOfWays(2));
            //Console.WriteLine(NumOfWays(3));
        }
    }
}
