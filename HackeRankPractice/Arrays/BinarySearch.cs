using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Arrays
{
    class BinarySearch
    {
        public static void Run()
        {
            int[] arr = new int[2] { 1, 3 };
            int index = binarySearch(arr, 3, 0, arr.Length);
            Console.WriteLine(index);
            Console.ReadLine();
        }

        static int binarySearch(int[] arr, int n, int start, int end)
        {
            if (start >= end) return -1;
            int mid = start + ((end - start) / 2);

            if (arr[mid] == n)
                return mid;
            if (arr[mid] > n)
            {
                return binarySearch(arr, n, 0, mid);
            }
            else
            {
                return binarySearch(arr, n, mid + 1, end);
            }
        }
    }
}
