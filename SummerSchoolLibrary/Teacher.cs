namespace SummerSchoolLibrary
{
    public class HighTeacher : Teacher
    {

    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 2020.0f;
        }

        //public override string TestNewModifier()
        //{
        //    return "lkl";
        //}
    }

    //public sealed class ttt
    //{

    //}

    //public class h : ttt
    //{

    //}
}