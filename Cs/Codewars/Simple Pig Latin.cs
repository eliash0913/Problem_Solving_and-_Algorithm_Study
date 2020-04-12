using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            string result = "";
            string[] tmp = str.Split();
            for(int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i].ToLower() == tmp[i].ToUpper())
                {
                    result += tmp[i];
                }
                else
                {
                    result += tmp[i].Substring(1) + tmp[i].ElementAt(0) + "ay";
                    if (i != tmp.Length - 1)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
        public static void Test()
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
            Console.WriteLine(PigIt("Hello world !"));
        }
    }
}
