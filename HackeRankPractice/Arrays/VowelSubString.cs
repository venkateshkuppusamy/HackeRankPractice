using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class VowelSubString
    {

        public static void Run()
        {
            string s = "qwdftr";
            int k = 2;
            int counter = 0;
            int maxCounter = 0;
            int maxCounterIndex = 0;
            for (int i = 0; i < s.Length - (k - 1); i++)
            {
                counter = 0;
                for (int j = i; j < i + k; j++)
                {
                    if (s[j] == 'a' || s[j] == 'e' || s[j] == 'i' || s[j] == 'o' || s[j] == 'u')
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxCounterIndex = i;
                }
            }

            for (int i = maxCounterIndex; i < maxCounterIndex + k; i++)
            {
                Console.Write(s[i]);
            }

            Console.ReadLine();
        }
    }
}
