using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using BloggerWay.Services.Abstract;
using BloggerWay.Shared.Utilities.Results.Abstract;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using BloggerWay.Shared.Utilities.Results.Concrete;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BloggerWay.Services.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;
        private readonly ILogger<MailManager> _logger;

        public MailManager(IOptionsMonitor<SmtpSettings> smtpSettings, ILogger<MailManager> logger)
        {
            _smtpSettings = smtpSettings.CurrentValue;
            _logger = logger;
        }

        public IResult Send(EmailSendDto emailSendDto)
        {
            try
            {
                var message = new MailMessage
                {
                    From = new MailAddress(_smtpSettings.SenderEmail),
                    Subject = emailSendDto.Subject,
                    IsBodyHtml = true,
                    Body = emailSendDto.Message
                };
                message.To.Add(new MailAddress(emailSendDto.Email));

                using var smtpClient = new SmtpClient
                {
                    Host = _smtpSettings.Server,
                    Port = _smtpSettings.Port,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                smtpClient.Send(message);
                _logger.LogInformation("E-Posta başarıyla gönderildi: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Success, "E-Postanız başarıyla gönderilmiştir.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "E-Posta gönderimi sırasında bir hata oluştu: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Error, "E-Posta gönderimi sırasında bir hata oluştu.", ex);
            }
        }

        public IResult SendContactEmail(EmailSendDto emailSendDto)
        {
            try
            {
                var message = new MailMessage
                {
                    From = new MailAddress(_smtpSettings.SenderEmail),
                    Subject = emailSendDto.Subject,
                    IsBodyHtml = true,
                    Body = $"Gönderen Kişi: {emailSendDto.Name}, Gönderen E-Posta Adresi:{emailSendDto.Email}<br/>{emailSendDto.Message}"
                };
                message.To.Add(new MailAddress("info@BloggerWay.com"));

                using var smtpClient = new SmtpClient
                {
                    Host = _smtpSettings.Server,
                    Port = _smtpSettings.Port,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                smtpClient.Send(message);
                _logger.LogInformation("İletişim e-postası başarıyla gönderildi: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Success, "E-Postanız başarıyla gönderilmiştir.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "İletişim e-postası gönderimi sırasında bir hata oluştu: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Error, "E-Posta gönderimi sırasında bir hata oluştu.", ex);
            }
        }

        public async Task<IResult> SendAsync(EmailSendDto emailSendDto)
        {
            try
            {
                var message = new MailMessage
                {
                    From = new MailAddress(_smtpSettings.SenderEmail),
                    Subject = emailSendDto.Subject,
                    IsBodyHtml = true,
                    Body = emailSendDto.Message
                };
                message.To.Add(new MailAddress(emailSendDto.Email));

                using var smtpClient = new SmtpClient
                {
                    Host = _smtpSettings.Server,
                    Port = _smtpSettings.Port,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                await smtpClient.SendMailAsync(message);
                _logger.LogInformation("E-Posta başarıyla gönderildi: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Success, "E-Postanız başarıyla gönderilmiştir.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "E-Posta gönderimi sırasında bir hata oluştu: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Error, "E-Posta gönderimi sırasında bir hata oluştu.", ex);
            }
        }

        public async Task<IResult> SendContactEmailAsync(EmailSendDto emailSendDto)
        {
            try
            {
                var message = new MailMessage
                {
                    From = new MailAddress(_smtpSettings.SenderEmail),
                    Subject = emailSendDto.Subject,
                    IsBodyHtml = true,
                    Body = $"Gönderen Kişi: {emailSendDto.Name}, Gönderen E-Posta Adresi:{emailSendDto.Email}<br/>{emailSendDto.Message}"
                };
                message.To.Add(new MailAddress("info@BloggerWay.com"));

                using var smtpClient = new SmtpClient
                {
                    Host = _smtpSettings.Server,
                    Port = _smtpSettings.Port,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                await smtpClient.SendMailAsync(message);
                _logger.LogInformation("İletişim e-postası başarıyla gönderildi: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Success, "E-Postanız başarıyla gönderilmiştir.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "İletişim e-postası gönderimi sırasında bir hata oluştu: {Email}", emailSendDto.Email);
                return new Result(ResultStatus.Error, "E-Posta gönderimi sırasında bir hata oluştu.", ex);
            }
        }
    }
}
