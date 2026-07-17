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
        return SendOtpEmailTemplate(
            toEmail,
            otp,
            subject: "Your OTP Verification Code",
            headerTitle: "Email Verification",
            bodyMessage: "Thank you for registering with <strong>ALLUVO</strong>. To complete your registration, please use the following One-Time Password (OTP):",
            warningMessage: "⚠️ If you didn’t request this code, please ignore this email or contact our support team."
        );
    }

    public bool SendOTPEmailResetPassword(string toEmail, string otp)
    {
        return SendOtpEmailTemplate(
            toEmail,
            otp,
            subject: "Password Reset OTP",
            headerTitle: "Password Reset",
            bodyMessage: "We received a request to reset your password for your <strong>ALLUVO</strong> account. Use the following One-Time Password (OTP) to proceed:",
            warningMessage: "⚠️ If you didn’t request a password reset, please ignore this email or contact our support team."
        );
    }

    public bool SendOTPEmailAccountDeletion(string toEmail, string otp)
    {
        return SendOtpEmailTemplate(
            toEmail,
            otp,
            subject: "Account Deletion OTP",
            headerTitle: "Account Deletion",
            bodyMessage: "We received a request to delete your <strong>ALLUVO</strong> account. If you wish to proceed, use the following One-Time Password (OTP) to confirm your identity:",
            warningMessage: "⚠️ WARNING: Deleting your account is permanent and cannot be undone. If you didn’t request this, please secure your account immediately."
        );
    }

    private bool SendOtpEmailTemplate(string toEmail, string otp, string subject, string headerTitle, string bodyMessage, string warningMessage)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_options.UserName, _options.Email));
            message.To.Add(new MailboxAddress(toEmail, toEmail));
            message.Subject = subject;

            var htmlBody = $@"<!DOCTYPE html><html><head><meta charset='UTF-8'/><title>{headerTitle}</title><style>body{{font-family:Arial,sans-serif;line-height:1.6;color:#333333;margin:0;padding:0;background-color:#f2f2f7}}.container{{max-width:600px;margin:40px auto;background-color:#ffffff;border-radius:8px;box-shadow:0 2px 6px rgba(0,0,0,0.08);overflow:hidden}}.header{{background-color:#1b2351;background-image:linear-gradient(to right,#1b2351,#47c0d2);color:#ffffff;padding:25px 20px;text-align:center}}.header h1{{margin:0;font-size:24px;letter-spacing:1px}}.content{{padding:30px 25px;background-color:#fdfdfd}}.content h2{{color:#1b2351;margin-top:0}}.content p{{font-size:15px;margin-bottom:16px}}.otp-code{{font-size:36px;font-weight:bold;text-align:center;letter-spacing:8px;margin:25px 0;padding:18px;border:2px dashed #47c0d2;border-radius:8px;background-color:#f0faff;color:#1b2351}}.warning{{color:#F59E0B;background-color:#FEF3C7;padding:16px;border-radius:8px;font-weight:600;font-size:15px}}.footer{{background-color:#f8f8f8;text-align:center;padding:15px;font-size:12px;color:#888888;border-top:1px solid #e0e0e0}}</style></head><body><div class='container'><div class='header'><h1>{headerTitle}</h1></div><div class='content'><h2>Hello!</h2><p>{bodyMessage}</p><div class='otp-code'>{otp}</div><p>This OTP is valid for <strong>10 minutes</strong>. Please do not share this code with anyone.</p><div class='warning'>{warningMessage}</div><p style='margin-top:25px;'>Best regards,<br/><strong>ALLUVO Team</strong></p></div><div class='footer'><p>This is an automated message. Please do not reply to this email.</p></div></div></body></html>";


            message.Body = new TextPart("html") { Text = htmlBody };

            using var client = new SmtpClient();
            client.Connect(_options.Server, _options.Port, false);
            client.Authenticate(_options.Email, _options.Password);
            client.Send(message);
            client.Disconnect(true);

            return true;
        }
        catch
        {
            return false;
        }
    }


    public async Task<bool> SendContactEmailAsync(string name, string email, string message)
    {
        try
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(_options.UserName, _options.Email));
            mimeMessage.To.Add(new MailboxAddress("ALLUVO Support", _options.Email));
            mimeMessage.Subject = $"New Contact Message from {name}";

            var htmlBody = $@"<!DOCTYPE html><html><head><meta charset='UTF-8'/><title>New Contact Message</title><style>body{{font-family:Arial,sans-serif;line-height:1.6;color:#333333;margin:0;padding:0;background-color:#f2f2f7}}.container{{max-width:600px;margin:40px auto;background-color:#ffffff;border-radius:8px;box-shadow:0 2px 6px rgba(0,0,0,0.08);overflow:hidden}}.header{{background-color:#1b2351;background-image:linear-gradient(to right,#1b2351,#47c0d2);color:#ffffff;padding:25px 20px;text-align:center}}.header h1{{margin:0;font-size:24px;letter-spacing:1px}}.content{{padding:30px 25px;background-color:#fdfdfd}}.content h2{{color:#1b2351;margin-top:0}}.content p{{font-size:15px;margin-bottom:16px}}.field-label{{font-weight:700;color:#1b2351;font-size:14px;margin-bottom:4px}}.field-value{{background-color:#f0faff;border:1px solid #47c0d2;border-radius:8px;padding:14px;margin-bottom:16px;font-size:15px;color:#333333;white-space:pre-wrap}}.footer{{background-color:#f8f8f8;text-align:center;padding:15px;font-size:12px;color:#888888;border-top:1px solid #e0e0e0}}</style></head><body><div class='container'><div class='header'><h1>New Contact Message</h1></div><div class='content'><h2>You have a new message from the contact form</h2><div class='field-label'>Name</div><div class='field-value'>{System.Net.WebUtility.HtmlEncode(name)}</div><div class='field-label'>Email</div><div class='field-value'>{System.Net.WebUtility.HtmlEncode(email)}</div><div class='field-label'>Message</div><div class='field-value'>{System.Net.WebUtility.HtmlEncode(message)}</div><p style='margin-top:25px;'>Best regards,<br/><strong>ALLUVO System</strong></p></div><div class='footer'><p>This is an automated message from the ALLUVO contact form.</p></div></div></body></html>";

            mimeMessage.Body = new TextPart("html") { Text = htmlBody };

            using var client = new SmtpClient();
            await client.ConnectAsync(_options.Server, _options.Port, false);
            await client.AuthenticateAsync(_options.Email, _options.Password);
            await client.SendAsync(mimeMessage);
            await client.DisconnectAsync(true);

            return true;
        }
        catch
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