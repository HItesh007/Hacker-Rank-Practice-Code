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
        public void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {

            int applesCounter = 0;
            int orangesCounter = 0;
            // For Apples
            for(int i=0; i<apples.Length; i++)
            {
                if(apples[i] > 0)
                {
                    apples[i] =  a + apples[i];
                    
                }
                else if(apples[i] < 0)
                {
                    apples[i] = a + apples[i];
                }

                // Check if apple has fallen at >= s & <= t
                if (apples[i] >= s && apples[i] <= t)
                {
                    applesCounter++;
                }
            }

            // For Oranges
            for (int j = 0; j < oranges.Length; j++)
            {
                if (oranges[j] > 0)
                {
                    oranges[j] = b + oranges[j];
                }
                else if (oranges[j] < 0)
                {
                    oranges[j] = b + oranges[j];
                   
                }

                // Check if orange has fallen at >= s & <= t
                if (oranges[j] <= t && oranges[j] >= s)
                {
                    orangesCounter++;
                }
            }

            Console.WriteLine(applesCounter);
            Console.WriteLine(orangesCounter);

            Console.WriteLine("Total Apples That Fell On Sam's House Is :" + applesCounter);
            Console.WriteLine("Total Oranges That Fell On Sam's House Is :" + orangesCounter);

        }

        /// <summary>
        /// Definition: Kangaroo Problem
        /// URL: https://www.hackerrank.com/challenges/kangaroo/problem
        /// </summary>
        /// <param name="x1"> Starting position of Kangaroo #1 </param>
        /// <param name="v1"> Jump distance for kangaroo #1</param>
        /// <param name="x2"> Starting position of Kangaroo #2</param>
        /// <param name="v2"> Jump distance for kangaroo #2</param>
        /// <returns> It should return YES if they reach the same position at the same time, or NO if they don't. </returns>
        static string kangaroo(int x1, int v1, int x2, int v2)
        {

            var sameLocationPossible = "";
            if (x1 < x2 && v1 < v2)
                sameLocationPossible = "NO";

            else if (x2 < x1 && v2 < v1)
                sameLocationPossible = "NO";

            else if (x2 < x1)
            {
                //v2 > v1
                var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            else
            {
                //v1 > v2
                var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            return sameLocationPossible;
        }
    }
}
