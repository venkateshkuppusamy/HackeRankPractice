using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.hack_the_interview_iv_apac
{
    class MinimumMoves
    {

        private static void Run()
        {
            int counter = minimumMoves("101", 2);
            //int counter = minimumMoves("00100", 2);
            //int counter = minimumMoves("0001", 2);
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        public static int minimumMoves(string s, int d)
        {
            char[] arr = s.ToCharArray();
            int counter = 0;
            bool oneExists = false;
            for (int i = 0; i < arr.Length - (d - 1); i++)
            {
                oneExists = false;
                for (int j = i; j < i + d; j++)
                {
                    if (arr[j] == '1')
                    {
                        oneExists = true;
                        i = j;
                        break;
                    }
                }
                if (!oneExists)
                {
                    arr[i + d - 1] = '1';
                    i = i + d - 1;
                    counter++;
                }

            }
            return counter;

        }
    }
}
