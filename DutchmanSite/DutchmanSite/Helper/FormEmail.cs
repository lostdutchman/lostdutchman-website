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
            if (name.Length < 2 || emailaddress.Length < 7 || content.Length < 5) { return false; }
            //Contains URL's
            else if(content.ToLower().Contains("http://") || content.ToLower().Contains("https://") || content.ToLower().Contains("www.")) { return false; }
            //Ad Agency
            else if (content.ToLower().Contains("online presence") || content.ToLower().Contains("digital agency") || content.ToLower().Contains("advertising service") || content.ToLower().Contains("converting visitors") || content.ToLower().Contains("do not respond") || content.ToLower().Contains("most visited websites")) { return false; }
            //Blacklist
            else if (emailaddress.ToLower().Contains("alychidesigns.com")) { return false; }
            //Not Spam
            return true; 
        }
    }
}
