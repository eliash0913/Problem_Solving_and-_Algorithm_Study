using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Mexican_Wave
    {
        public static List<string> wave(string str)
        {
            List<string> result = new List<string>();
            if (str.Length == 0)
                return new List<string> { };
            for(int i = 0; i < str.Length; i++)
            {
                char index = str.ElementAt(i);
                if (index == ' ')
                {
                    continue;
                }
                else
                {
                    result.Add(str.Substring(0, i) + index.ToString().ToUpper() + str.Substring(i + 1));
                }
            }
            return result;
        }
        public static void Test()
        {
            DisplayResults.Display(wave("hello"));
            DisplayResults.Display(wave("two words"));
        }
    }
}
