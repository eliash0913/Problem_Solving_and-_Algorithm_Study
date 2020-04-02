using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Weight_for_weight : IComparable
    {
        public int CompareTo(object obj)
        {
            return 0;
        }
        public static string orderWeight(string strng)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] arr = strng.Split();
            for(int index = 0; index< arr.Length; index++ )
            {
                int tmp = 0;
                for(int j = 0; j < arr[index].Length; j++)
                {
                    tmp += Int32.Parse(arr[index].ElementAt(j).ToString());
                }
                count.Add(arr[index], tmp);
            }
            string result = "";
            List<int> sort = new List<int>();
            int[] test = new int[2];

            sort.Sort();
            foreach (var key in sort)
            {
                //result += count[key] + " ";
            }

            return result.Trim();
        }
        public static void Test()
        {
            Console.WriteLine(orderWeight("103 123 4444 99 2000"));
        }
    }
}
