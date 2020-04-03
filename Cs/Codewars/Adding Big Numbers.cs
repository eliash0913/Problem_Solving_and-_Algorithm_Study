using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Adding_Big_Numbers
    {
        public static string Add(string a, string b)
        {
            int max = a.Length > b.Length ? a.Length : b.Length;
            string tmpStr = "";
            for(int i = 0; i < Math.Abs(a.Length - b.Length); i++)
            {
                tmpStr += "0";
            }
            if (a.Length > b.Length)
            {
                b = tmpStr + b;
            }
            else if (a.Length < b.Length)
            {
                a = tmpStr + a;
            }
            int[] tmpa = new int[max];
            int[] tmpb = new int[max];
            Stack<int> resultTmp = new Stack<int>();
            string result = "";
            int oneth = 0;
            int carry = 0;
            for(int i = 0; i < max; i++)
            {
                tmpa[i] = Convert.ToInt32(a.ElementAt(max -1- i).ToString());
                tmpb[i] = Convert.ToInt32(b.ElementAt(max -1- i).ToString());
            }
            for (int i = 0; i < max ; i++)
            {
                int tmp = tmpa[i] + tmpb[i] + carry;
                if (tmp > 9)
                {
                    carry = 1;
                    oneth = tmp - 10;
                }
                else
                {
                    carry = 0;
                    oneth = tmp;
                }
                resultTmp.Push(oneth);
            }
            if(carry>0)
            {
                resultTmp.Push(carry);
            }
            while(resultTmp.Count>0)
            {
                result += resultTmp.Pop().ToString();
            }
            return result;
        }
        public static void Test()
        {
            DisplayResults.Display(Add("123", "345"));
            DisplayResults.Display(Add("3", "345"));
            DisplayResults.Display(Add("1", "345"));
            DisplayResults.Display(Add("555", "555"));
            DisplayResults.Display(Add("155", "555"));
            DisplayResults.Display(Add("155", "555"));
            DisplayResults.Display(Add("99999999999999999999", "1"));
        }
    }
}
