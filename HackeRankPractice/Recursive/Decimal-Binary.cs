using System;

namespace HackeRankPractice.Recursive
{
    class Decimal_Binary
    {
        static void Run()
        {
            Console.WriteLine(ConvertDecimalToBinary(26));
            Console.ReadLine();
        }

        static string ConvertDecimalToBinary(int num)
        {
            if (num == 1)
                return "1";
            return ConvertDecimalToBinary(num / 2) + num % 2;
        }

    }
}
