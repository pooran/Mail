using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace SendMail.Controllers
{
    public class SendMailController : ApiController
    {
        // GET api/sendmail
        public string Get(string from, string to, string cc, string subject, string body)
        {
            MailAddress fromAddress = new MailAddress(from);
            MailAddress toAddress = new MailAddress(to);
            MailAddress ccAddress = null;
            if(cc!="")
                ccAddress = new MailAddress(cc);
            const string fromPassword = "p00ranpra5ad";
            
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            var message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = body;
            message.CC.Add(ccAddress);
            smtp.Send(message);
            return "success";
        }
    }
}
