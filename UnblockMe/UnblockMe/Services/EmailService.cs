using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Services
{
    public class EmailService :IEmailService
    {
     
            public void SendEmail()
            {
                var apikey = "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";
                var client = new SendGridClient(apikey);
                var from = new EmailAddress("udrearobert999@gmail.com","Robert");
                var to = new EmailAddress("udrearobert999@gmail.com","Robert");
                var subject = "Sending EMAIL";
                var PlainTextContent = "asdadsasdadsad";
                var htmlcontent = "<strong>and easy to do anywhere, even in C#</strong>";
                var msg = MailHelper.CreateSingleEmail
                    (
                        from,
                        to,
                        subject,
                        PlainTextContent,
                        htmlcontent
                    );
                var response = client.SendEmailAsync(msg).Result;
               
            }
        
    }

    public interface IEmailService
    {
        public void SendEmail();
    }
}
