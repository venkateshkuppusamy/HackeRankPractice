using System;

namespace HackeRankPractice.Recursive
{
    class SearchCharService
    {

        static void Run()
        {
            Console.WriteLine(SearchChar("recursion", 0, 'b'));
            Console.ReadLine();
        }

        static int SearchChar(string s, int start, char c)
        {
            if (start == s.Length)
                return -1;
            if (s[start] == c)
                return start;
            else
            {
                return SearchChar(s, start + 1, c);
            }
        }
    }
}
