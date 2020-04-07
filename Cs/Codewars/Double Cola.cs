using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Double_Cola
    {
        public static string WhoIsNext(string[] names, long n)
        {
            if(n <= names.Length)
            {
                return names[n-1];
            }
            long numberOfCompleteSet = 0;
            long queue = 0;
            int i = 0;
            while (5 * (long)Math.Pow(2, i+1) < n + 5)
            {
                i++;
            }
            Console.WriteLine(i);
            numberOfCompleteSet = 5 * (long)Math.Pow(2, i);
            queue = n + 5 - numberOfCompleteSet;
            long answer = (queue - 1) / (numberOfCompleteSet / names.Length);
            return names[answer];
        }

        public static string WhoIsNextBF(string[] names, long n)
        {
            Queue<string> queue = new Queue<string>(names);
            for (int i = 1; i < n; i++)
            {
                    string tmp = queue.Dequeue();
                    queue.Enqueue(tmp);
                    queue.Enqueue(tmp);
            }
            return queue.Peek();
        }

        public static void Test()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            long[] nums = new long[] { 1, 6, 10, 52, 63, 150, 7230702951 };
            foreach(var num in nums)
            {
                DisplayResults.Display(WhoIsNext(names, num));
                DisplayResults.Display(WhoIsNextBF(names, num));
            }
        }
    }
}
