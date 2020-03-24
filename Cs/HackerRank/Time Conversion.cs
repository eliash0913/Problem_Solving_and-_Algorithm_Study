/// <summary>
/// Given a time in -hour AM/PM format, convert it to military (24-hour) time.
/// Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock.
/// Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.
/// </summary>
/// <param name="s"></param>
/// <returns></returns>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.HackerRank
{
    class Time_Conversion
    {
        /***** COMPLETED *****/
        static string TimeConversion(string s)
        {
            int hIdx = s.IndexOf(':'); //first ':' index to determine the position of hours.
            string prefix = s.Substring(0, hIdx); //Hour string
            string postFix = s.Substring(hIdx, s.Length - hIdx); //string after hour string
            int hour = prefix == "12" ? (Int32.Parse(prefix) - 12) : Int32.Parse(prefix); //Extract hour and convert to integer.
            if(s.EndsWith("PM")) //if is it afternoon, add 12 hours for 24 hour format.
            {
                hour += 12;
            }
            string result = (hour >= 10) ? hour.ToString() : '0' + hour.ToString(); //trim the hour format to two digit.
            char[] c = { 'A', 'M', 'P' }; //char array to remove AM and PM
            result += s.Substring(hIdx, s.Length - hIdx).Trim(c);
            return result;
        }

        public static void Test()
        {
            string[] samples = { "12:00:00AM", "12:00:00PM", "04:34:12AM", "09:41:43PM" };
            foreach(string sample in samples)
                Console.WriteLine(TimeConversion(sample));
        }
    }
}
