using System;
using System.Collections.Generic;

namespace HackeRankPractice.HashMaps
{
    class CheckMagazine
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magDic = new Dictionary<string, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (magDic.ContainsKey(magazine[i]))
                {
                    magDic[magazine[i]]++;
                }
                else
                {
                    magDic.Add(magazine[i], 1);
                }
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (magDic.ContainsKey(note[i]) && magDic[note[i]] != 0)
                {
                    magDic[note[i]]--;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
        static void Main1(string[] args)
        {
            int m = Convert.ToInt32(15);

            int n = Convert.ToInt32(6);

            string[] magazine = "apgo clm w lxkvg mwz elo bg elo lxkvg elo apgo apgo w elo bg".Split(' ');

            string[] note = "elo lxkvg bg mwz clm w".Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
