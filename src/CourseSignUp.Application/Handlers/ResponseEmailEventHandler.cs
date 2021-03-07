using CourseSignUp.Application.Events;
using CourseSignUp.Infra.Email;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Handlers
{
    public class ResponseEmailEventHandler : INotificationHandler<ResponseEmailEvent>
    {
        private readonly IEmailSender _emailSender;

        public ResponseEmailEventHandler(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task Handle(ResponseEmailEvent responseEmailEvent, CancellationToken cancellationToken)
        {
            await _emailSender.SendMail(responseEmailEvent.SignUpToCourseDTO.Email, responseEmailEvent.Message);
        }
    }
}
