using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class ArrayManipulation
    {

        public static void Run()
        {
            int[][] queries = new int[3][] { new int[] { 1, 5, 3 }, new int[] { 4, 8, 7 }, new int[] { 6, 9, 1 } };
            long result = arrayManipulation(10, queries);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static long arrayManipulation(int n, int[][] queries)
        {
            long[] numList = new long[n + 1];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int a = queries[i][0];
                int b = queries[i][1];
                long k = (long)queries[i][2];

                numList[a] += k;
                if (b + 1 <= n) numList[b + 1] -= k;
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numList[i];
                if (tempMax > max) max = tempMax;
            }
            return max;
        }
    }
}
