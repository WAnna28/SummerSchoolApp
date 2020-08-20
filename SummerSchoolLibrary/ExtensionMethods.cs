using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SummerSchoolLibrary
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            int wordCount = str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;

            return wordCount;
        }
    }
}
