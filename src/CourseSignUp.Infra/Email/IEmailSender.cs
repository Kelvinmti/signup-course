using System.Threading.Tasks;

namespace CourseSignUp.Infra.Email
{
    public interface IEmailSender
    {
        Task SendMail(string email, string content);
    }
}
