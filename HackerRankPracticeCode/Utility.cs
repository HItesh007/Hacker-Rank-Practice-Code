using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPracticeCode
{
    static class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="roundTo"></param>
        /// <returns></returns>
        public static double RoundTo(this double value, double roundTo)
        {
            return Math.Ceiling(value / roundTo) * roundTo;
        }
    }
}
