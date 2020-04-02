using System;
using System.Collections.Generic;
using Interval = System.ValueTuple<int, int>;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Sum_of_Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            HashSet<int> result = new HashSet<int>();
            foreach(var x in intervals)
            {
                for(int i = x.Item1; i < x.Item2; i++)
                {
                    result.Add(i);
                }
            }
            return result.Count;
        }
        public static void Test()
        {
            Console.WriteLine(SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
            Console.WriteLine(SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
            Console.WriteLine(SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
            Console.WriteLine(SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
            Console.WriteLine(SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
            Console.WriteLine(SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
            Console.WriteLine(SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
            Console.WriteLine(SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
            Console.WriteLine(SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
            Console.WriteLine(SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
            Console.WriteLine(SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
            Console.WriteLine(SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
            Console.WriteLine(SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
        }
    }
}
