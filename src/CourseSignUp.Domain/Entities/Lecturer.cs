using CourseSignUp.Domain.Entities.Base;

namespace CourseSignUp.Domain.Entities
{
    public class Lecturer : Entity
    {
        public string Name { get; private set; }

        public Lecturer(string name)
        {
            SetId();
            Name = name;

            //Create Validator e Call Validade from the base Entity class
        }
    }
}
