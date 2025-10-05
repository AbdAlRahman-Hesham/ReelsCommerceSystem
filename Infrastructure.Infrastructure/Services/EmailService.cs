using Microsoft.Extensions.Options;
using MimeKit;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Utilities;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;


namespace ReelsCommerceSystem.Infrastructure.Services;

public class EmailService(IOptions<EmailSettings> options) : IEmailService
{
    private EmailSettings _options = options.Value;
    public bool SendOTPEmail(string toEmail, string otp)
    {
        throw new NotImplementedException();
    }
    public async void SendAsync(Email email)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(_options.UserName, _options.Email));
        message.To.Add(new MailboxAddress(email.Name, email.To));
        message.Subject = email.Subject;
        message.Body = new TextPart("html")
        {
            Text = email.Body
        };


        using (var client = new SmtpClient())
        {
            await client.ConnectAsync(_options.Server, _options.Port, false);
            await client.AuthenticateAsync(_options.Email, _options.Password);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}