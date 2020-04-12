using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    class Contest3
    {
        public string EntityParser(string text)
        {
            Dictionary<string, string> dict= new Dictionary<string, string>();
            dict.Add("&quot;", "\"");
            dict.Add("&apos;", "'");
            dict.Add("&amp;", "&");
            dict.Add("&gt;", ">");
            dict.Add("&lt;", "<");
            dict.Add("&frasl;", "/");
            foreach(var key in dict.Keys)
            {
                text = text.Replace(key, dict[key]);
            }
            return text;
        }
        public void Test()
        {
            string sample1 = "&amp; is an HTML entity but &ambassador; is not.";
            string sample2 = "and I quote: &quot;...&quot;";
            string sample3 = "Stay home! Practice on Leetcode:)";
            string sample4 = "x & gt; y & amp; &amp; x & lt; y is always false";
            Console.WriteLine(EntityParser(sample1));
            Console.WriteLine(EntityParser(sample2));
            Console.WriteLine(EntityParser(sample3));
            Console.WriteLine(EntityParser(sample4));
        }
    }
}
