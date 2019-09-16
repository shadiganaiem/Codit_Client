using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using Codit_Client.Models;

namespace Codit_Client.Services
{
    public class MailService : IMailService
    {


        public void SendMail(Client model)
        {
            MailMessage mail = new MailMessage();
            string body = "<div style='font-size:18px;direction:rtl;'>";
            mail.To.Add("shadi.stu@gmail.com");
            mail.From = new MailAddress("shadi.stu@gmail.com", "Codit Website");

            mail.Subject = $"יצירת קשר";
            body += $"שם לקוח : ";
            body += $"{model.fullName} <br />";
            if (!String.IsNullOrEmpty(model.email))
            {
                body += $"דוא\"ל : ";
                body += $"{model.email} <br />";
            }

            body += $"נייד : ";
            body += $"{model.phone} <br />";


            mail.Body = body;
            mail.IsBodyHtml = true;
            try
            {
                new SmtpClient(ConfigurationManager.AppSettings["GMAIL_HOST"].ToString(), int.Parse(ConfigurationManager.AppSettings["GMAIL_PORT"].ToString()))
                {
                    EnableSsl = true, //Encript Message
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential("shadi.stu@gmail.com", "Shade22111")
                }.Send(mail);
            }
            catch (Exception ex) { }
        }
    }
}