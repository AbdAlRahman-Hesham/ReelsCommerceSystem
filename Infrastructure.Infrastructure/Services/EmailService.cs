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
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_options.UserName, _options.Email));
                message.To.Add(new MailboxAddress(toEmail, toEmail));
                message.Subject = "Your OTP Verification Code";

                // Create HTML email body
                var htmlBody = $@"
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <style>
                            body {{ font-family: Arial, sans-serif; line-height: 1.6; color: #333; }}
                            .container {{ max-width: 600px; margin: 0 auto; padding: 20px; }}
                            .header {{ background-color: #4CAF50; color: white; padding: 20px; text-align: center; border-radius: 5px 5px 0 0; }}
                            .content {{ background-color: #f9f9f9; padding: 30px; border-radius: 0 0 5px 5px; }}
                            .otp-code {{ font-size: 32px; font-weight: bold; color: #4CAF50; text-align: center; letter-spacing: 5px; margin: 20px 0; padding: 15px; background-color: #fff; border: 2px dashed #4CAF50; border-radius: 5px; }}
                            .footer {{ text-align: center; margin-top: 20px; color: #666; font-size: 12px; }}
                            .warning {{ color: #d32f2f; margin-top: 15px; }}
                        </style>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='header'>
                                <h1>Email Verification</h1>
                            </div>
                            <div class='content'>
                                <h2>Hello!</h2>
                                <p>Thank you for registering with Reels Commerce System. To complete your registration, please use the following One-Time Password (OTP):</p>
            
                                <div class='otp-code'>{otp}</div>
            
                                <p>This OTP is valid for <strong>10 minutes</strong>. Please do not share this code with anyone.</p>
            
                                <p class='warning'>⚠️ If you didn't request this code, please ignore this email or contact our support team.</p>
            
                                <p>Best regards,<br>Reels Commerce System Team</p>
                            </div>
                            <div class='footer'>
                                <p>This is an automated message, please do not reply to this email.</p>
                            </div>
                        </div>
                    </body>
                    </html>";

                message.Body = new TextPart("html")
                {
                    Text = htmlBody
                };

                using (var client = new SmtpClient())
                {
                    client.Connect(_options.Server, _options.Port, false);
                    client.Authenticate(_options.Email, _options.Password);
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
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