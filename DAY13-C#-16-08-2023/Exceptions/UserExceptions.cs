namespace JwtAuth.Exceptions
{
    public class UserExceptions
    {
        public static List<string> ExecptionMessages { get; } =
            new List<string> { "User Found", "No User found with this Username"};
    }
}
