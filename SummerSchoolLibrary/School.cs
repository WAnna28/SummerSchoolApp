using System;
using System.Collections.Generic;
using System.Text;

namespace SummerSchoolLibrary
{
    // for show
    enum ErrorCode: byte
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 2,
        OutlierReading
    }

    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {                    
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string schoolName, string schoolPhoneNumber)
        {
            Name = schoolName;
            PhoneNumber = schoolPhoneNumber;

            // For show, not for use
            // Both properties are accessible in the constructor.
            OnlyGet = "Test";
            SetIsPrivate = "Test";
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c)/3;

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.AppendLine(Zip);
            sb.AppendLine(PhoneNumber);
            sb.AppendLine(TwitterAddress);

            return sb.ToString();
        }

        // For show, not for use
        public string OnlyGet { get; }
        public string SetIsPrivate { get; private set; }

        // OnlyGet isn't assignable here. This will generate a compile error.
        //public void ChangeOnlyGet(string newOnlyGet) => OnlyGet = newOnlyGet;

        // SetIsPrivate is assignable here.
        public void ChangeSetIsPrivate(string newSetIsPrivate) => SetIsPrivate = newSetIsPrivate;
    }
}
