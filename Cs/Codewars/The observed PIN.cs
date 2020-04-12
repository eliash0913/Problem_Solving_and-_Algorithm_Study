using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class The_observed_PIN
    {
        public static List<string> GetPINs(string observed)
        {
            List<string> result = new List<string>();
            Dictionary<string, List<string>> pn = new Dictionary<string, List<string>>();
            string[,] keypad =
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" },
                { "", "0", "" }
            };
            int m, n;
            for(m = 0; m < keypad.GetLength(0); m++)
            {
                for (n = 0; n < keypad.GetLength(1); n++)
                {
                    List<string> tmp = new List<string>();
                    tmp.Add(keypad[m, n]);
                    if (m+1 < keypad.GetLength(0))
                    {
                        if(keypad[m+1,n].Length == 1)
                            tmp.Add(keypad[m + 1, n]);
                    }
                    if(n+1 < keypad.GetLength(1))
                    {
                        if (keypad[m, n+1].Length == 1)
                            tmp.Add(keypad[m, n + 1]);
                    }
                    if (m - 1 >= 0)
                    {
                        if (keypad[m - 1, n].Length == 1)
                            tmp.Add(keypad[m-1, n]);
                    }
                    if (n - 1 >= 0)
                    {
                        if (keypad[m, n-1].Length == 1)
                            tmp.Add(keypad[m,n-1]);
                    }
                    tmp.Sort();
                    if(keypad[m, n].Length==1)
                        pn.Add(keypad[m, n], tmp);
                }
            }
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < observed.Length; i++)
            {
                if(i==0)
                {
                    foreach (var x in pn[observed[i].ToString()])
                    {
                        queue.Enqueue(x);
                    }
                }
                else
                {
                    while (queue.Peek().Length == i)
                    {
                        string tmp = queue.Dequeue();
                        foreach (var x in pn[observed[i].ToString()])
                        {
                            queue.Enqueue(tmp+x);
                        }
                    }
                }
            }
            result = queue.ToList();
            return result;
        }

        public static void Test()
        {
            string sample1 = "3";
            string sample2 = "5";
            string sample3 = "111";
            string sample4 = "369";
            DisplayResults.Display(GetPINs(sample1));
            DisplayResults.Display(GetPINs(sample2));
            DisplayResults.Display(GetPINs(sample3));
            DisplayResults.Display(GetPINs(sample4));
        }
    }
}
