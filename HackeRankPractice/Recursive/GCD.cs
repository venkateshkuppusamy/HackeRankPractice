using System;

namespace HackeRankPractice.Recursive
{
    class GCD
    {
        static void Run()
        {
            int a = 60, b = 75;
            Console.WriteLine(FindGCD(a, b, ReturnSmallest(a, b)));
            Console.ReadLine();
        }

        static int ReturnSmallest(int a, int b)
        {
            return a < b ? a : b;
        }

        static int FindGCD(int a, int b, int d)
        {
            if (a < d || b < d)
                return 1;
            if (a % d == 0 && b % d == 0)
                return d;
            else
            {
                return FindGCD(a, b, d - 1);
            }
        }
    }
}
