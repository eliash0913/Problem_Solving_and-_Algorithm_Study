using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Dubstep
    {
        public static string SongDecoder(string input)
        {
            string result = "";
            string[] tmp = input.Replace("WUB",",").Split(',');
            foreach(string str in tmp)
            {
                if(str.Length!=0)
                {
                    result += str + " ";
                }
            }
            return result.Trim();
        }
        public static void Test()
        {
            DisplayResults.Display(SongDecoder("WUBWUBABCWUB"));
            DisplayResults.Display(SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
