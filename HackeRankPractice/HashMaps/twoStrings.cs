using System;
using System.Collections.Generic;

namespace HackeRankPractice.HashMaps
{
    class twoString
    {

        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            Dictionary<Char, bool> charDic = new Dictionary<char, bool>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!charDic.ContainsKey(s1[i]))
                {
                    charDic.Add(s1[i], true);
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (charDic.ContainsKey(s2[i]))
                {
                    return "Yes";
                }
            }
            return "No";
        }

        static void Main1(string[] args)
        {
            string s1 = "hi";

            string s2 = "world";

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
