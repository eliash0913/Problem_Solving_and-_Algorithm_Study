using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.LeetCode.Contest
{
    class Contest1
    {
        public IList<string> StringMatching(string[] words)
        {
            List<string> result = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = 0; j < words.Length; j++)
                {
                    if(i!=j && words[i].Contains(words[j]) && words[i]!=words[j])
                    {
                        if(!result.Contains(words[j]))
                            result.Add(words[j]);
                    }
                }
            }
            return result;
        }
        public void Test()
        {
            string[] sample1 = new string[] { "mass", "as", "hero", "superhero" };
            DisplayResults.Display(StringMatching(sample1));
        }
    }
}

