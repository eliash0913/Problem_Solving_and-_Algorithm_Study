using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Where_my_anagrams_at
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            foreach(var c in word)
            {
                if (characters.ContainsKey(c))
                    characters[c]++;
                else
                    characters.Add(c, 1);
            }
            HashSet<char> resulths = new HashSet<char>(characters.Keys.ToArray());
            for (int i = 0; i < words.Count; i++)
            {
                if(words[i].Length!=word.Length)
                {
                    continue;
                }
                else
                {
                    Dictionary<char, int> tmp = new Dictionary<char, int>();
                    foreach (char c in words[i].ToCharArray())
                    {
                        if (tmp.ContainsKey(c))
                            tmp[c]++;
                        else
                            tmp.Add(c, 1);
                    }
                    HashSet<char> tmphs = new HashSet<char>(tmp.Keys.ToArray());
                    if(resulths.SetEquals(tmphs))
                    {
                        foreach(var key in characters.Keys)
                        {
                            tmp[key] -= characters[key];
                        }
                        if(tmp.Values.Sum() == 0)
                        {
                            result.Add(words[i]);
                        }
                    }
                }
            }
            return result;
        }
        public static void Test()
        {
            int[] numbers1 = { 19, 5, 42, 2, 77 };
            DisplayResults.Display(Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            int[] numbers2 = { 1, 3, 4, 2, 5, 6, 1 };
            DisplayResults.Display(Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
}
