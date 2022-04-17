

namespace Project.Core.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAsync(string ToEmail, string body, string subject);
    }
}
