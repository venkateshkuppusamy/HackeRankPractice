using System;
using System.Collections.Generic;

namespace HackeRankPractice.HashMaps
{
    class SimpleAnangram
    {
        static int anagram(string s)
        {
            if (s.Length % 2 == 1)
                return -1;
            else
            {
                int counter = 0;
                Dictionary<char, int> charDic = new Dictionary<char, int>();
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (charDic.ContainsKey(s[i]))
                    {
                        charDic[s[i]]++;
                    }
                    else
                    {
                        charDic.Add(s[i], 1);
                    }
                }

                for (int i = s.Length / 2; i < s.Length; i++)
                {
                    if (charDic.ContainsKey(s[i]) && charDic[s[i]] > 0)
                    {
                        charDic[s[i]]--;
                    }
                    else
                    {
                        counter++;
                    }
                }

                return counter;
            }
        }

        static void Main1(string[] args)
        {
            string s = "aaabbb";
            int result = anagram(s);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
