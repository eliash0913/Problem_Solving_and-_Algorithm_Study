using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    class Contest2
    {
        //public int[] ProcessQueries(int[] queries, int m)
        //{
        //    int[] p = new int[queries.Length];
        //    LinkedList<int> tmp = new LinkedList<int>();
        //    for (int i = 1; i <= m; i++)
        //        tmp.AddLast(i);
        //    int counter = 0;
        //    for(int q = 0; q < queries.Length; q++)
        //    {
        //        for(int pos = 0; pos < tmp.Count; pos++)
        //        {
        //            if (queries[q] == tmp.ElementAt(pos))
        //                p[counter++] = pos;
        //        }
        //        tmp.Remove(queries[q]);
        //        tmp.AddFirst(queries[q]);
        //    }
        //    return p;
        //}

        public int[] ProcessQueries(int[] queries, int m)
        {
            int[] p = new int[queries.Length];
            LinkedList<int> tmp = new LinkedList<int>();
            for (int i = 1; i <= m; i++)
                tmp.AddLast(i);
            int counter = 0;
            for (int q = 0; q < queries.Length; q++)
            {

                //p[counter++] = tmp;//tmp.Find(queries[q]).Value;
                tmp.Remove(queries[q]);
                tmp.AddFirst(queries[q]);
            }
            return p;
        }

        public void Test()
        {
            DisplayResults.Display(ProcessQueries(new int[] { 3, 1, 2, 1 }, 5));
            DisplayResults.Display(ProcessQueries(new int[] { 4, 1, 2, 2 }, 4));
            DisplayResults.Display(ProcessQueries(new int[] { 7, 5, 5, 8, 3 }, 8));
        }
    }
}
