using CourseSignUp.Application.Events;
using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Repositories;
using CourseSignUp.Infra.Caching;
using CourseSignUp.Infra.Data.Context;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Handlers
{
    //This would be the Worker that will process the SignUp
    public class SignUpToCourseEventHandler : INotificationHandler<SignUpToCourseEvent>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ISignUpRepository _signUpRepository;
        private readonly IStatisticsRepository _statisticsRepository;
        private readonly IMediator _mediator;

        public SignUpToCourseEventHandler(ICourseRepository courseRepository, 
                                          IStudentRepository studentRepository, 
                                          ISignUpRepository signUpRepository,
                                          IMediator mediator,
                                          IStatisticsRepository statisticsRepository)
        {
            _courseRepository = courseRepository;
            _studentRepository = studentRepository;
            _signUpRepository = signUpRepository;
            _mediator = mediator;
            _statisticsRepository = statisticsRepository;
        }

        public async Task Handle(SignUpToCourseEvent signUpToCourseEvent, CancellationToken cancellationToken)
        {
            Course course = await _courseRepository.GetCourseById(signUpToCourseEvent.SignUpToCourseDTO.CourseId);
            if (course == null)
            {
                //replace this for saving response into a response topic, indicating an error that course is not found
                throw new Exception("Invalid course");
            }


            //If there is no student, then create one
            Student student = await _studentRepository.GetStudentByEmail(signUpToCourseEvent.SignUpToCourseDTO.Email);
            
            if (student == null)
            {
                student = new Student(signUpToCourseEvent.SignUpToCourseDTO.Email, signUpToCourseEvent.SignUpToCourseDTO.Name, signUpToCourseEvent.SignUpToCourseDTO.DateOfBirth);

                if (!student.IsValid)
                {
                    //replace this for saving response into a response topic, indicating an error and saving all errors returned by ValidationResult
                    throw new Exception("Invalid student");                     
                }
            }            

            //Only create if course has capacity
            if (course.HasCapacity())
            {
                await _signUpRepository.SignUpAsync(course, student);                
                await _mediator.Publish(new ResponseEmailEvent { SignUpToCourseDTO = signUpToCourseEvent.SignUpToCourseDTO, Message = "Sign Up process completed successfully!" });
                await _statisticsRepository.UpdateStatistics(course.Id); //Update statistics for the course
            }
        }
    }
}
