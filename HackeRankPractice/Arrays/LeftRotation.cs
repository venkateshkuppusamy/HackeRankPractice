using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class LeftRotation
    {

        private static void Run()
        {
            int n = 20;
            int r = 10;
            int[] arr = new int[20] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            List<int> backup = new List<int>();
            r = r % n;
            if (r > 0)
            {
                for (int i = 0; i < r; i++)
                {
                    backup.Add(arr[i]);
                }

                for (int i = 0, j = r; i < n - r; i++, j++)
                {
                    arr[i] = arr[j];
                }

                for (int i = n - r, j = 0; i < n; i++, j++)
                {
                    arr[i] = backup[j];
                }

                int count = n - r;
                foreach (var item in backup)
                {
                    arr[count] = item;
                    count++;
                }
            }

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
