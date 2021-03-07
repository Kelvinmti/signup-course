using FluentValidation;
using FluentValidation.Results;
using System;

namespace CourseSignUp.Domain.Entities.Base
{
    public abstract class Entity
    {
        public string Id { get; private set; }

        public bool IsValid { get; protected set; }
        public ValidationResult ValidationResult { get; private set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return IsValid = ValidationResult.IsValid;
        }

        protected void SetId()
        {
            Id = Guid.NewGuid().ToString();
        } 
    }
}
