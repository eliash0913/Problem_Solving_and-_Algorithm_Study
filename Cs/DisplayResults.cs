using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study
{
    class DisplayResults
    {
        public static void Display(string[] arr)
        {
            string result = "";
            foreach(string s in arr)
            {
                result += s + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(int[] arr)
        {
            string result = "";
            foreach (int s in arr)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }

        public static void Display(List<int> ll)
        {
            string result = "";
            foreach (int s in ll)
            {
                result += s.ToString() + " ";
            }
            Console.WriteLine(result);
        }
    }
}
