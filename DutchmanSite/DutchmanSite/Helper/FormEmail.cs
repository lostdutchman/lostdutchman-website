using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

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

                AutoReply(name, emailaddress);
            }
        }

        public void AutoReply(string name, string emailaddress)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("lostdutchmansoftware@gmail.com");

            message.To.Add(new MailAddress(emailaddress));

            message.Subject = "Your inquary for Lost Dutchman Software was probably only intercepted by a few governemt organizations.";
            message.Body = "Hello " + name + ",\nYour message has been received at our undisclosed office deep beneath the Superstition Mountains. We will consult the wall and get back to you when it reveals its truths to us.";

            SmtpClient client = new SmtpClient();
            client.Send(message);
        }

        public bool NotSpam(string name, string emailaddress, string content)
        {
            //Make sure that the info sent is valid
            if (name.Length < 2 || emailaddress.Length < 7 || content.Length < 5) { return false; }
            //Contains URL's
            else if (content.ToLower().Contains("http://") || content.ToLower().Contains("https://") || content.ToLower().Contains("www.")) { return false; }
            //Contains Russian
            else if (Regex.IsMatch(content, @"\p{IsCyrillic}")) { return false; }
            //Contains no letters
            else if (!Regex.IsMatch(content.ToLower(), "[a-z]")) { return false; }
            //Ad Agency
            else if (
                content.ToLower().Contains("online presence") ||
                content.ToLower().Contains("digital agency") ||
                content.ToLower().Contains("advertising service") ||
                content.ToLower().Contains("converting visitors") ||
                content.ToLower().Contains("do not respond") || 
                content.ToLower().Contains("most visited websites") || 
                content.ToLower().Contains("online promotion") || 
                content.ToLower().Contains("offer our services") ||
                content.ToLower().Contains("will sеnd up tо") || 
                content.ToLower().Contains("seo")
                ) { return false; }
            //Product Ad's?
            else if (content.ToLower().Contains("wide-angle binoculars with variable tilt")) { return false; }
            //Contains a different email in the body
            else if (HasSecondEmailInBody(emailaddress, content)) { return false; }
            //Blacklist
            else if (
                emailaddress.ToLower().Contains("alychidesigns.com") ||
                emailaddress.ToLower().Contains("glmux.com") || 
                emailaddress.ToLower().Contains("jessicarobert") || 
                emailaddress.ToLower().Contains("casa-versicherung.de") || 
                emailaddress.ToLower().Contains("sonantic.io") ||
                emailaddress.ToLower().Contains("mail.ru") ||
                emailaddress.ToLower().Contains("lostdutchmansoftware.com")
                ) { return false; }

            return true; 
        }

        public bool HasSecondEmailInBody(string emailaddress, string content)
        {
            const string MatchEmailPattern =
               @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
               + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
               + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Find matches.
            MatchCollection matches = rx.Matches(content);

            foreach (Match match in matches)
            {
                if(match.Value.ToString().ToLower() != emailaddress.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
