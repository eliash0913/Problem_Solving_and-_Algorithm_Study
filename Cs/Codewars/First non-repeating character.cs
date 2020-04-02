using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class First_non_repeating_character
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                string tmp = s.Substring(i, 1);
                if (s.ToLower().IndexOf(tmp.ToLower()) == s.ToLower().LastIndexOf(tmp.ToLower()))
                {
                    return tmp;
                }
            }
            return "";
        }

        /* this didn't pass random test. However, test passed with following python code.
         * 
         * def first_non_repeating_letter(string):
         *     if len(string) < 2:
         *         return string
         *     count = 0
         *     for c in string:
         *         if (string[:count] + string[count+1:]).lower().find(c.lower())== -1:
         *             return c
         *         else:
         *             count = count + 1
         *     return ""
         *     
         */
        public static void Test()
        {
            Console.WriteLine(FirstNonRepeatingLetter("a"));
            Console.WriteLine(FirstNonRepeatingLetter("stress"));
            Console.WriteLine(FirstNonRepeatingLetter("moonmen"));
            Console.WriteLine(FirstNonRepeatingLetter("ABC"));
        }
    }
}
