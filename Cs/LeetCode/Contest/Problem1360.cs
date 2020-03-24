/*1360. Number of Days Between Two Dates
 * Write a program to count the number of days between two dates.
 * The two dates are given as strings, their format is YYYY-MM-DD as shown in the examples.
 * Input: date1 = "2019-06-29", date2 = "2019-06-30"
 * Output: 1
 * Input: date1 = "2020-01-15", date2 = "2019-12-31"
 * Output: 15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    /***** COMPLETED *****/
    class Problem1360
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            return Math.Abs(ConvertToJulianDays(date2) - ConvertToJulianDays(date1));
        }

        private int ConvertToJulianDays(string date)
        {
            int year = Int32.Parse(date.Substring(0, 4));
            int month = Int32.Parse(date.Substring(date.IndexOf("-") + 1, 2));
            int day = Int32.Parse(date.Substring(date.LastIndexOf("-") + 1, 2));
            int julianDay = 0;
            for (int y = 1971; y < year; y++)
            {
                julianDay += GetDays(y);
            }
            for (int m = 1; m < month; m++)
            {
                julianDay += GetMonthDay(year, m);
            }
            julianDay += day;
            return julianDay;
        }

        private int GetDays(int year)
        {
            return IsLeapYear(year) ? 366 : 365;
        }

        private int GetMonthDay(int year, int month)
        {
            if (month <= 7)
            {
                if (month == 2)
                {
                    if (IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else if (month % 2 == 0)
                {
                    return 30;
                }
                return 31;
            }
            else
            {
                if (month % 2 == 0)
                {
                    return 31;
                }
                return 30;
            }
        }

        private bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            else if (year % 100 == 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else
                return false;
        }
        public void Test()
        {
            string date1 = "2019-06-29", date2 = "2019-06-30";
            string date3 = "2020-01-15", date4 = "2019-12-31";
            string date5 = "1991-03-12", date6 = "2100-09-22";


            Console.WriteLine(DaysBetweenDates(date1, date2));
            Console.WriteLine(DaysBetweenDates(date3, date4));
            Console.WriteLine(DaysBetweenDates(date5, date6));
        }
    }
}
