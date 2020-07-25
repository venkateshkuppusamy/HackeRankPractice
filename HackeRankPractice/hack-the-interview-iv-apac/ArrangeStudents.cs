using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackeRankPractice.hack_the_interview_iv_apac
{
    class ArrangeStudents
    {
        public static void Run()
        {
            //string s = arrangeStudents(new List<int>() { 1, 3 }, new List<int>() { 2, 4 });
            //string s = arrangeStudents(new List<int>() { 2, 3, 5 }, new List<int>() { 1, 3, 4 });
            string s = arrangeStudents(new List<int>() { 1, 2 }, new List<int>() { 3, 4 });
            //string s = arrangeStudents(new List<int>() { 3,5,7 }, new List<int>() { 3,4,6 });

            Console.WriteLine(s);
            Console.ReadLine();
        }

        private static string arrangeStudents(List<int> a, List<int> b)
        {
            int[] sortB = a.OrderBy(o => o).ToArray();
            int[] sortG = b.OrderBy(o => o).ToArray();
            bool CompareBoyWithGirl = false;
            if ((sortB[0] < sortG[0]) || (sortB[0] == sortG[0] && sortB[sortB.Length - 1] <= sortG[sortG.Length - 1]))
            {
                CompareBoyWithGirl = true;
            }

            int i = 0, j = 0;
            while (i < sortB.Length && j < sortG.Length)
            {
                if (CompareBoyWithGirl)
                {
                    if (sortB[i] <= sortG[j])
                    {
                        i++;
                        CompareBoyWithGirl = false;
                    }
                    else
                        return "NO";
                }
                else
                {

                    if (sortG[j] <= sortB[i])
                    {
                        j++;
                        CompareBoyWithGirl = true;
                    }
                    else
                        return "NO";

                }
            }
            return "YES";

        }
    }
}
