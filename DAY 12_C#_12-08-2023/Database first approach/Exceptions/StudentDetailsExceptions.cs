namespace StudentDetailsDBF.Exceptions
{
    public class StudentDetailsExceptions : Exception
    {
        public static List<string> ExecptionMessages { get;} =
            new List<string> { "Student Not Found", "No Student with this Roll Number",
            "Student that you want to update does not exist", "Student not found for the given Roll Number"};

    }
}
