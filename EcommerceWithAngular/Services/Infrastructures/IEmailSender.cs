namespace EcommerceWithAngular.Services.Infrastructures
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string msg);
    }
}
