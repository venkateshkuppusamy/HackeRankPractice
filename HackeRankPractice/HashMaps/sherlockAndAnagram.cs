using System;
using System.Collections.Generic;
using System.Linq;

namespace HackeRankPractice.HashMaps
{
    class sherlockAndAnagram
    {
        // Complete the sherlockAndAnagrams function below.
        static void Run()
        {
            string input = "kkkk";

            Dictionary<string, int> dicStrings = new Dictionary<string, int>();
            for (int l = 0; l < input.Length; l++)
            {
                for (int i = 0; i < input.Length - (l); i++)
                {
                    string orderedSubString = new string(input.Substring(i, l + 1).OrderBy(o => o).ToArray());
                    if (dicStrings.ContainsKey(orderedSubString))
                    {
                        dicStrings[orderedSubString]++;
                    }
                    else
                    {
                        dicStrings.Add(orderedSubString, 1);
                    }
                }
            }
            int count = 0;
            foreach (var item in dicStrings)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    for (int j = i + 1; j < item.Value; j++)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
