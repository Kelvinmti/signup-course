namespace CourseSignUp.Application.DTOs
{
    public class CourseAvarageDTO : BaseDTO
    {
        public string CourseName { get; set; }
        public byte MinAge { get; set; }
        public byte MaxAge { get; set; }
        public byte AverageAge { get; set; }
        public long NumberOfSignedUsers { get; set; }
    }
}
