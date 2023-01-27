using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using BloggerWay.Services.Abstract;
using BloggerWay.Shared.Utilities.Results.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using BloggerWay.Shared.Utilities.Results.Concrete;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
namespace BloggerWay.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;

        public MailManager(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }
        public IResult Send(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail), //aliveli4950.39@outlook.com
                To = { new MailAddress(emailSendDto.Email) }, //ali@veli.dev
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = emailSendDto.Message
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);

            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }

        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail), // Ali Veli aliveli@gmail.com // Blog Uygulamanıza Yeni Bir İçerik Önerisi
                To = { new MailAddress("info@BloggerWay.com") },
                Subject = emailSendDto.Subject,
                IsBodyHtml = true,
                Body = $"Gönderen Kişi: {emailSendDto.Name}, Gönderen E-Posta Adresi:{emailSendDto.Email}<br/>{emailSendDto.Message}"
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(message);

            return new Result(ResultStatus.Success, $"E-Postanız başarıyla gönderilmiştir.");
        }
    }
}
