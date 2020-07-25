using System;

namespace HackeRankPractice.Recursive
{
    class ReverseString
    {
        static void Run()
        {
            string s = "january";
            char[] result = s.ToCharArray();
            string output = new string(stringReversal(s, 0, s.Length - 1, result));
            Console.WriteLine(Convert.ToString(output));
            Console.ReadLine();
        }

        static char[] stringReversal(string s, int left, int right, char[] result)
        {
            if (left == right || left > right)
                return result;

            result[left] = s[right];
            result[right] = s[left];
            return stringReversal(s, left + 1, right - 1, result);
        }
    }
}
