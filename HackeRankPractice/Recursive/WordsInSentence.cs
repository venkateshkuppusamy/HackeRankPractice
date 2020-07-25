using System;

namespace HackeRankPractice.Recursive
{
    class WordsInSentence
    {
        static void Run()
        {
            Console.WriteLine(CountWordsInSentence("I   should do     focused   learning   with  more hands on ", 0) + 1);
            Console.ReadLine();
        }

        static int CountWordsInSentence(string str, int start)
        {
            if (start == str.Length - 1)
                return 0;
            int index = FindSpaces(str, start);
            if (index == -1)
                return 0;
            return 1 + CountWordsInSentence(str, index + 1);

        }

        static int FindSpaces(string str, int start)
        {
            bool isContinuousSpace = false;
            for (int i = start; i < str.Length; i++)
            {
                if (str[i] == ' ' && (i != 0 && i != str.Length - 1))
                {
                    isContinuousSpace = true;
                    continue;
                }
                else if (isContinuousSpace)
                {
                    return i - 1;
                }
            }
            return -1;
        }

    }
}
