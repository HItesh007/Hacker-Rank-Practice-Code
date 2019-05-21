using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPracticeCode.problem_solving
{
    public class WarmUpProblems
    {
        /// <summary>
        /// Definition: Simple Array Sum
        /// URL: https://www.hackerrank.com/challenges/simple-array-sum/problem
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        static int simpleArraySum(int[] ar)
        {
            int sum = int.MinValue;
            for (int i = 0; i < ar.Length; i++)
            {
                sum = sum + ar[i];
            }

            return sum;
        }

        /// <summary>
        /// Definition : Complete the compareTriplets function below.
        /// URL: https://www.hackerrank.com/challenges/compare-the-triplets
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    result[0] = result[0] + 1;
                }
                else if (a[i] < b[i])
                {
                    result[1] = result[1] + 1;
                }
            }

            return result.ToList<int>();

        }

        
        /// <summary>
        /// Definition: Complete the diagonalDifference function below.
        /// URL: https://www.hackerrank.com/challenges/diagonal-difference/problem
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int diagonalDifference(int[][] arr)
        {
            int principal = 0, secondary = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                principal += arr[i][i];
                secondary += arr[i][arr.Length - i - 1];
            }

            int diff = principal - secondary;

            return Math.Abs(diff);

        }

        
        /// <summary>
        /// Definition: Complete the aVeryBigSum function below.
        /// URL: https://www.hackerrank.com/challenges/a-very-big-sum/problem
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        static long aVeryBigSum(long[] ar)
        {

            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum = sum + ar[i];
            }

            return sum;

        }

       
        /// <summary>
        /// Definition: Complete the plusMinus function below.
        /// URL: https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        /// <param name="arr"></param>
        static void plusMinus(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive = positive + 1;
                }
                else if (arr[i] < 0)
                {
                    negative += 1;
                }
                else if (arr[i] == 0)
                {
                    zero += 1;
                }

                Console.WriteLine(positive / arr.Length);
                Console.WriteLine(negative / arr.Length);
                Console.WriteLine(zero / arr.Length);

            }

        }

        /// <summary>
        ///      #
        ///     ##
        ///    ###
        ///   ####
        ///  #####
        ///  
        /// Definition: Complete the staircase function below.
        /// URL: https://www.hackerrank.com/challenges/staircase/problem
        /// </summary>
        /// <param name="n"></param>
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i < n - j ? " " : "#");
                }
                Console.WriteLine("");
            }

        }

        /// <summary>
        /// Deifinition: Complete the miniMaxSum function below.
        /// URL: https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// </summary>
        /// <param name="arr"></param>
        public void miniMaxSum(int[] arr)
        {
            Int64[] sumArray = new Int64[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                Int64 sumVal = 0;

                for (int x = 0; x < arr.Length; x++)
                {
                    if (x != i)
                    {
                        sumVal = sumVal + arr[x];
                    }
                    sumArray[i] = sumVal;
                }
                Console.WriteLine("sumArray[" + i + "] : " + sumArray[i]);
            }
            Console.WriteLine(sumArray.Min() + " " + sumArray.Max());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static string findNumber(List<int> arr, int k)
        {

            foreach (int a in arr)
            {
                
                if(a == k)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        static List<int> oddNumbers(int l, int r)
        {
            List<int> oddNumberList = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumberList.Add(i);
                }
            }

            return oddNumberList;

        }

        /// <summary>
        /// Finds max of an hourglass from an aaray
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int hourglassSum(int[][] arr)
        {
            int R = 6;
            int C = 6;


            int max_sum = int.MinValue;

            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    int sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]) + (arr[i + 1][j + 1]) + (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }
    }
}
