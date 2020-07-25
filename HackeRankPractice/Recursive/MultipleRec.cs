using System;

namespace HackeRankPractice.Recursive
{
    class MultipleRec
    {
        static void Run()
        {
            Console.WriteLine(MultiplyRecursive(6, 20));
            Console.ReadLine();
        }

        static int MultiplyRecursive(int a, int b)
        {
            if (b <= 1)
            {
                return a;
            }
            return a + MultiplyRecursive(a, b - 1);
        }

    }
}
