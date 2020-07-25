using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Looping
{
    class CountApplesAndOranges
    {
        static void Run(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0;
            foreach (var item in apples)
            {
                if (a + item >= s && a + item <= t)
                    appleCount++;
            }

            int orangesCount = 0;
            foreach (var item in oranges)
            {
                if (b + item >= s && b + item <= t)
                    orangesCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangesCount);
        }
    }
}
