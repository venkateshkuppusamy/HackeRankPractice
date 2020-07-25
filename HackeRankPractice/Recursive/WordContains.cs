using System;

namespace HackeRankPractice.Recursive
{
    class WordContains
    {
        static void Run()
        {
            Console.WriteLine(wordIsh("seafish", "sam"));
            Console.ReadLine();
        }

        static bool wordIsh(string word, string letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (!containsLetter(letters[i], word, 0, word.Length))
                    return false;
            }
            return true;
        }
        static bool containsLetter(char c, string word, int start, int end)
        {
            if (start == end - 1)
                return (word[start] == c);
            return (word[start] == c) || containsLetter(c, word, start + 1, end);

        }
    }
}
