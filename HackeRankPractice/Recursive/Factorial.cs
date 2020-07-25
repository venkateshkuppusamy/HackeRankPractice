using System;

namespace HackeRankPractice.Recursive
{
    class Factorial
    {
        private static void GetFactorial()
        {
            Console.WriteLine(Fact(5));
            Console.ReadLine();
        }

        static int Fact(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
}
