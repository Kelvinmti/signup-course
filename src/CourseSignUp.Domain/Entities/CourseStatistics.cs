using CourseSignUp.Domain.Entities.Base;

namespace CourseSignUp.Domain.Entities
{
    public class CourseStatistics : Entity
    {
        public string CourseName { get; }
        public byte MinAge { get; }
        public byte MaxAge { get; }
        public byte AverageAge { get; }
        public long NumberOfSignedUsers { get; }

        public CourseStatistics(string courseName, byte minAge, byte maxAge, byte averageAge, long numberOfSignedUsers)
        {
            CourseName = courseName;
            MinAge = minAge;
            MaxAge = maxAge;
            AverageAge = averageAge;
            NumberOfSignedUsers = numberOfSignedUsers;
        }
    }
}
