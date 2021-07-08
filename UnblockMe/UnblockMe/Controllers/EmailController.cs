using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Controllers
{
    public class EmailController : Controller
    {
     
            public async Task<IActionResult> SendEmail()
            {
                var apikey = Environment.GetEnvironmentVariable("emailKey");
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
                var response = await client.SendEmailAsync(msg);
                return Content(msg.ToString());
            }
        
    }
}
