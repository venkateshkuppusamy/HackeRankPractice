using System;

namespace HackeRankPractice.Recursive
{
    class PalindromNumber
    {
        static void RunPalindrome()
        {
            int input = 56788765;
            int output = ReverseNumber(input, input.ToString().Length);
            Console.WriteLine(output == input);
            Console.Read();
        }

        static int ReverseNumber(int n, int l)
        {
            if (n < 10)
                return n;
            else
            {
                return (n % 10) * (int)(Math.Pow(10, l - 1)) + ReverseNumber(n / 10, l - 1);
            }
        }
    }
}
