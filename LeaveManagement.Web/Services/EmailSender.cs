using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
namespace LeaveManagement.Services
{ 


public class EmailSender: IEmailSender
{
    private string smptServer;
    private int smptPort;
    private string fromEmailAddress;

    public EmailSender(string smptServer, int smptPort, string fromEmailAddress)
    {
        this.smptServer = smptServer;
        this.smptPort = smptPort;
        this.fromEmailAddress = fromEmailAddress;
    }

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var message = new MailMessage
        {
            From = new MailAddress(fromEmailAddress),
            Subject = subject,
            Body = htmlMessage,
            IsBodyHtml = true
        };

        try
        {
            using (var client = new SmtpClient(smptServer, smptPort))
            {
                client.Send(message);
            }
        }
        catch { 
            // fake implementation - I have no smptp srv!
        }
       
        return Task.CompletedTask;
    }
}

}