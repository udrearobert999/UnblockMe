using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.Rest.Api.V2010.Account;
using Twilio.AspNet.Core;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace UnblockMe.Controllers
{
    public class SMSController : TwilioController
    {
        public IActionResult SendSMS()
        {
            string accountSid = "ACac99927ddd42460cf677fb66fc753028";
            string authToken = "d5e8e2350f6aeacacd1af832932d2137";

            TwilioClient.Init(accountSid, authToken);

      

            var message = MessageResource.Create(
                body: "Ai fost blocat!",
                from: new Twilio.Types.PhoneNumber("+19096396207"),
                to: new Twilio.Types.PhoneNumber("+40772227129")
            );
            return Content(message.Sid);
        }
      
    }
}
