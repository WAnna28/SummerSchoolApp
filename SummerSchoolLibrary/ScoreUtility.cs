using System;
using System.Collections.Generic;
using System.Text;

namespace SummerSchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment1.MaximumScore;
            var score2 = Assignment2.Score / Assignment2.MaximumScore;

            return score1 > score2 ? Assignment1 : Assignment2;
        }
    }
}
