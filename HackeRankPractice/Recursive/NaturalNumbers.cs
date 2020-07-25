using System;

namespace HackeRankPractice.Recursive
{
    class NaturalNumbers
    {
        static void Run()
        {
            Console.WriteLine(SumNaturalNumbers(100));
            Console.Read();
        }

        static int SumNaturalNumbers(int n)
        {
            if (n <= 0)
                return 0;
            return n + SumNaturalNumbers(n - 1);
        }
    }
}
