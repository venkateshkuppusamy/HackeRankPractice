using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class MatchingStrings
    {
        public static void Run()
        {
            var matches = matchingStrings(new string[4] { "aba", "baba", "aba", "xzxb" }, new string[3] { "aba", "xzxb", "ab" });
            foreach (var item in matches)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }

        static int[] matchingStrings(string[] strings, string[] queries)
        {
            Dictionary<string, int> stringCount = new Dictionary<string, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (stringCount.ContainsKey(strings[i]))
                    stringCount[strings[i]]++;
                else
                    stringCount.Add(strings[i], 1);
            }

            List<int> matches = new List<int>();

            for (int i = 0; i < queries.Length; i++)
            {
                if (stringCount.ContainsKey(queries[i]))
                    matches.Add(stringCount[queries[i]]);
                else
                {
                    matches.Add(0);
                }
            }

            return matches.ToArray();

        }
    }
}
