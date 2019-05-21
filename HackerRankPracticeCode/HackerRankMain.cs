using HackerRankPracticeCode.problem_solving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPracticeCode
{
    static class HackerRankMain
    {

        public static double RoundTo(this double value, double roundTo)
        {
            return Math.Ceiling(value / roundTo) * roundTo;
        }

        static void Main(string[] args)
        {
            ImplementationProblems iProblems = new ImplementationProblems();
            
            int[] testOneDArray = new int[] {73, 67, 38, 33};

            for(int i=0; i<testOneDArray.Length; i++)
            {
                Console.WriteLine(iProblems.gradingStudents(testOneDArray)[i]);
            }


            iProblems.countApplesAndOranges(7, 10, 4, 12, new int[3] { 2, 3, -4 }, new int[3] { 3, -2, -4 });
        }
    }
}
