using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class EmailService
    {
        private readonly SmtpClient smtpClient;

        public EmailService()
        {
            smtpClient = new SmtpClient()
            {
                Host = "smtp-relay.sendinblue.com",
                Port = 587,
                Credentials = new NetworkCredential("taskoudisdimitris@gmail.com", "VO9nF2HvgTUZs5IK"),
                EnableSsl = true,
            };
        }

        public void SendEmail(string to, string subject, string body)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("HomeManagment@gmail.com");
            message.To.Add(to);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            smtpClient.Send(message);

        }

    }
}
