using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SummerSchoolLibrary
{
    public class GroupSubject : IScored
    {
        public string Title { get; set; }
        public string Materials { get; set; }
        public string Lecturer { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
        public int TestWordCount
        {
            get { return Title.WordCount(); }
        }
    }
}