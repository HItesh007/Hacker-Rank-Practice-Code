using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPracticeCode.problem_solving
{
    class ImplementationProblems
    {
        /// <summary>
        /// Description: Grading Problem 
        /// URL: https://www.hackerrank.com/challenges/grading/problem
        /// </summary>
        /// <param name="grades">  An array of integers representing grades before rounding </param>
        /// <returns> It should return an integer array consisting of rounded grades. </returns>
        public int[] gradingStudents(int[] grades)
        {
            double [] finalGrades = new double[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                var tempGrade = Utility.RoundTo(grades[i], 5);
                var gradeDiff = tempGrade - grades[i];

                if(gradeDiff < 3 && tempGrade >= 40)
                {
                    finalGrades[i] = tempGrade;
                }
                else
                {
                    finalGrades[i] = grades[i];
                }
            }

            return finalGrades.Select(item => (int)item).ToArray();   
        }

        /// <summary>
        /// Definition: Apple and Orange Problem
        /// URL: https://www.hackerrank.com/challenges/apple-and-orange/problem
        /// </summary>
        /// <param name="s"> integer, starting point of Sam's house location </param>
        /// <param name="t"> integer, ending location of Sam's house location. </param>
        /// <param name="a"> integer, location of the Apple tree. </param>
        /// <param name="b"> integer, location of the Orange tree. </param>
        /// <param name="apples">  integer array, distances at which each apple falls from the tree. </param>
        /// <param name="oranges"> integer array, distances at which each orange falls from the tree. </param>
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            
        }
    }
}
