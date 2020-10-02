using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.HashMaps
{
    class CountTriplets
    {
        public static void Run()
        {
            var lst = new List<long>();
            lst.AddRange(new List<long>() { 1, 3, 9, 9, 27, 81 });
            Console.WriteLine(countTriplets(lst, 3));
            Console.ReadLine();
        }

        static long countTriplets(List<long> arr, long r)
        {
            int i = 0;
            Dictionary<long, long> numberCountLookup = new Dictionary<long, long>();
            Dictionary<long, long> traversednumberCounts = new Dictionary<long, long>();
            while (i < arr.Count)
            {
                if (numberCountLookup.ContainsKey(arr[i]))
                {
                    numberCountLookup[arr[i]]++;
                }
                else
                {
                    numberCountLookup.Add(arr[i], 1);
                }
                i++;
            }
            i = 0;
            long counter = 0;
            while (i < arr.Count)
            {
                if (numberCountLookup[arr[i]] == 0)
                {
                    numberCountLookup.Remove(arr[i]);
                }
                else
                {
                    numberCountLookup[arr[i]]--;
                }
                long left = 0;
                if (arr[i] % r == 0)
                {
                    left = arr[i] / r;
                }
                long right = arr[i] * r;
                if (traversednumberCounts.ContainsKey(left) && numberCountLookup.ContainsKey(right))
                {
                    counter = counter + (traversednumberCounts[left] * numberCountLookup[right]);
                }
                if (traversednumberCounts.ContainsKey(arr[i]))
                {
                    traversednumberCounts[arr[i]]++;
                }
                else
                {
                    traversednumberCounts.Add(arr[i], 1);
                }
                i++;
            }

            return counter;


        }
    }
}
