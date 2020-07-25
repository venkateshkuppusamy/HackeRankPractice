using System;
using System.Collections.Generic;
using System.Text;

namespace HackeRankPractice.Looping
{
    class GradingStudents
    {

        public static List<int> Run(List<int> grades)
        {
            List<int> modifiedGrades = new List<int>();
            foreach (var item in grades)
            {
                if (5 - (item % 5) <= 2)
                {
                    int newGrad = item + 5 - (item % 5);
                    if (newGrad >= 40)
                        modifiedGrades.Add(newGrad);
                    else
                        modifiedGrades.Add(item);
                }
                else
                {
                    modifiedGrades.Add(item);
                }
            }

            return modifiedGrades;
        }
    }
}
