using System;
using System.Text;

namespace SummerSchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            string timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);

            return sb.ToString();
        }

        // For show, not for use
        // new modifier
        public string TestNewModifier()
        {
            return "Person: Just For test";
        }
    }
}