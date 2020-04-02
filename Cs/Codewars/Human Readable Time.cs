using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Human_Readable_Time
    {
        public static string GetReadableTime(int seconds)
        {
            int max = 359999;
            if(seconds > max)
            {
                seconds = max;
            }
            int hours = 60 * 60;
            int min = 60;
            int hh = seconds / hours;
            int mm = (seconds % hours) / min;
            int sec = (seconds % hours) % min;
            string result = "";
            if(hh < 10)
            {
                result += "0" + hh.ToString();
            }
            else
            {
                result += hh.ToString();
            }
            result += ":";
            if (mm < 10)
            {
                result += "0" + mm.ToString();
            }
            else
            {
                result += mm.ToString();
            }
            result += ":";
            if (sec < 10)
            {
                result += "0" + sec.ToString();
            }
            else
            {
                result += sec.ToString();
            }
            return result;
        }
        public static void Test()
        {
            Console.WriteLine(GetReadableTime(0));
            Console.WriteLine(GetReadableTime(5));
            Console.WriteLine(GetReadableTime(60));
            Console.WriteLine(GetReadableTime(86399));
            Console.WriteLine(GetReadableTime(359999));
        }
    }
}
