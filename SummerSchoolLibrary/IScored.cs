using System;
using System.Collections.Generic;
using System.Text;

namespace SummerSchoolLibrary
{
    public interface IScored
    {
        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
