using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Entities.Base;

namespace CourseSignUp.Domain.Entities
{
    public class Course : Entity
    {        
        public int Capacity { get; private set; }
        public int NumberOfStudents { get; private set; }
        public Lecturer Lecturer { get; private set; }

        public Course(int capacity, Lecturer lecturer)
        {
            SetId();
            Capacity = capacity;
            Lecturer = lecturer;

            //Create Validator e Call Validade from the base Entity class and the value object
        }

        public bool HasCapacity()
        {
            return NumberOfStudents < Capacity;
        }

        public void IncrementNumberOfStudents()
        {            
            if (!HasCapacity())
                throw new System.Exception("This course is full!"); //replace for Notification Pattern

            NumberOfStudents++;
        }
    }
}
