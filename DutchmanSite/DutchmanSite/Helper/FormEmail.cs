using System;
using System.Net;
using System.Net.Mail;

namespace DutchmanSite.Helper
{
    public class FormEmail
    {
        public void SendEmail(string name, string emailaddress, string content)
        {
            if(NotSpam(name, emailaddress, content))
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("lostdutchmansoftware@gmail.com");

                message.To.Add(new MailAddress("lostdutchmansoftware@gmail.com"));

                message.Subject = "Form Inquiry LostDutchamSoftware.com, " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                message.Body = "Name: " + name + "\nEmail: " + emailaddress + "\n\n" + content;

                SmtpClient client = new SmtpClient();
                client.Send(message);
            }
        }

        public bool NotSpam(string name, string emailaddress, string content)
        {
            //Make sure that the info sent is valid
            if (name.Length < 2 || emailaddress.Length < 5 || content.Length < 5) 
            {
                Spam("Failed to enter valid data");
                return false;
            }
            //All spam so far has had bit.ly links.
            else if(content.Contains("http://bit.ly/"))
            {
                Spam("bit.ly link spam.");
                return false;
            }
            //Not Spam
            return true; 
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
