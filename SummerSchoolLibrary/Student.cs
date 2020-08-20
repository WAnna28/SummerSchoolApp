using System.Text;

namespace SummerSchoolLibrary
{
    public class Student: Person
    {
        public enum GradeLevels: ushort { Freshman = 4545, Sophomore, Junior = 88, Senior }

        public Student()
        {
            GradeLevel = GradeLevels.Junior;
        }

        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 2020.0f;
        }

        public override string SendMessage(string message)
        {
            string original = base.SendMessage(message);
            StringBuilder sb = new StringBuilder(original);
            sb.Append("GradeLevel: ");
            sb.AppendLine(GradeLevel.ToString());
            sb.AppendLine("This message is private and confidential.");

            return sb.ToString();
        }

        public new string TestNewModifier()
        {
            return base.TestNewModifier() + " " + "Student: Test2";
        }
    }
}
