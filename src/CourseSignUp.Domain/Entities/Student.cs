using CourseSignUp.Domain.Entities.Base;
using CourseSignUp.Domain.ValueObjects;
using System;

namespace CourseSignUp.Domain.Entities
{
    public class Student : Entity
    {
        public string Name { get; }
        public Email Email { get; }
        public DateTime DateOfBirth { get; }

        public Student(Email email, string name, DateTime dateOfBirth)
        {
            Email = email;
            Name = name;
            DateOfBirth = dateOfBirth;

            //Create Validator e Call Validade from the base Entity class and the value object
            
        }

        public void Deconstruct(out string name, out Email email, out DateTime dateOfBirth)
        {
            name = Name;
            email = Email;
            dateOfBirth = DateOfBirth;
        }
    }
}
