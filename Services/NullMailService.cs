using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BigJigSaw.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string from, string subject, string body)
        {
            _logger.LogInformation($"To: {from} Subject: {subject} Body: {body}");

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("aspdotnetjakubbor@gmail.com", "ZupaPomidorowa!1")
            };
            var msg = new MailMessage(from, "boruckuba7@gmail.com",
                $"Formularz kontaktowy: {subject} ", $"<h1>{body}</h1>");
            msg.IsBodyHtml = true;
            smtpClient.Send(msg);
        }
    }
}
