using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Determine_the_Winner
    {
        public static string getRoundResult(char winning_suit, char suit1, int number1, char suit2, int number2)
        {
            if(winning_suit == suit1 && winning_suit == suit2)
            {
                if (number1 > number2)
                    return "Player 1 wins";
                else if (number1 < number2)
                    return "Player 2 wins";
                else
                    return "Draw";
            }
            else if(winning_suit == suit1)
            {
                return "Player 1 wins";
            }
            else if(winning_suit == suit2)
            {
                return "Player 2 wins";
            }
            else
            {
                if (number1 > number2)
                    return "Player 1 wins";
                else if (number1 < number2)
                    return "Player 2 wins";
                else
                    return "Draw";
            }
        }
        public static void Test()
        {
            Console.WriteLine(getRoundResult('B', 'A', 2, 'B', 1));
            Console.WriteLine(getRoundResult('B', 'A', 7, 'D', 2));
            Console.WriteLine(getRoundResult('B', 'B', 5, 'D', 13));
            Console.WriteLine(getRoundResult('B', 'B', 3, 'B', 1));
            Console.WriteLine(getRoundResult('B', 'A', 12, 'C', 12));
        }
    }
}
