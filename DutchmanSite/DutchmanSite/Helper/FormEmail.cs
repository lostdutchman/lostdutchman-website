using System;
using System.Net;
using System.Net.Mail;

namespace DutchmanSite.Helper
{
    public class FormEmail
    {
        public void SendEmail(string name, string emailaddress, string content)
        {
            if (name.Length > 2 && emailaddress.Length > 5 && content.Length > 5) {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("lostdutchmansoftware@gmail.com");

                message.To.Add(new MailAddress("lostdutchmansoftware@gmail.com"));

                message.Subject = "Form Inquiry LostDutchamSoftware.com, " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                message.Body = "Name: " + name + "\nEmail: " + emailaddress + "\n\n" + content;

                SmtpClient client = new SmtpClient();
                client.Send(message);
            }
            else { Spam("Failed to enter valid data"); }
        }

        public void Spam(string str)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("lostdutchmansoftware@gmail.com");

            message.To.Add(new MailAddress("lostdutchmansoftware@gmail.com"));

            message.Subject = "Spam Blocked! " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            message.Body = "Blocked Spam with my own code. Reason: " + str;

            SmtpClient client = new SmtpClient();
            client.Send(message);
        }
    }
}
