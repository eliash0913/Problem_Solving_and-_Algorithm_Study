using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Valid_Braces
    {
        public static bool validBraces(String braces)
        {
            string open = "{[(";
            string close = "}])";
            Stack<char> tmp = new Stack<char>();
            for(int i = 0; i < braces.Length; i++)
            {
                if(open.Contains(braces[i]))
                {
                    tmp.Push(braces[i]);
                }
                else if(close.Contains(braces[i]))
                {
                    if (tmp.Count == 0)
                        return false;
                    else if (tmp.Peek() != open[close.IndexOf(braces[i])])
                    {
                        return false;
                    }
                    else
                    {
                        tmp.Pop();
                    }
                }
            }
            if (tmp.Count != 0)
                return false;
            return true;
        }
        public static void Test()
        {
            Console.WriteLine(validBraces(""));
            Console.WriteLine(validBraces("({["));
            Console.WriteLine(validBraces(")}]"));
            Console.WriteLine(validBraces("()"));
            Console.WriteLine(validBraces("(){}[]"));
            Console.WriteLine(validBraces("(}"));
            Console.WriteLine(validBraces("[(])"));
            Console.WriteLine(validBraces("[({})](]"));
            Console.WriteLine(validBraces("[(])"));
        }
    }
}
