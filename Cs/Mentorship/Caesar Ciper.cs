using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Mentorship
{
    class Caesar_Ciper
    {
        public static string CaesarCiper(string input, int shift)
        {
            int upperEnd = (int)'z';
            int lowerEnd = (int)'Z';
            string result = "";
            const int NUMBEROFALPHABET = 26;
            int maxNumber;
            shift %= NUMBEROFALPHABET;
            for(int index = 0; index < input.Length; index++)
            {
                int letter = (int)input.ElementAt(index);
                if (letter <= lowerEnd)
                {
                    maxNumber = lowerEnd;
                }
                else
                {
                    maxNumber = upperEnd;
                }
                letter += shift;
                if(letter > maxNumber)
                {
                    letter -= NUMBEROFALPHABET;
                }
                result += Convert.ToChar(letter);
            }
            return result;
        }
        public static void Test()
        {
            string sample = "ABabcdCD";
            Console.WriteLine(CaesarCiper(sample, 3));

            string sample2 = "wWxXyYzZ";
            Console.WriteLine(CaesarCiper(sample2, 3));
        }
    }
}
