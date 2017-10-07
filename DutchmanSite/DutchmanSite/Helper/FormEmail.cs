using System;
using System.Net;
using System.Net.Mail;

namespace DutchmanSite.Helper
{
    public class FormEmail
    {
        public void SendEmail(string name, string emailaddress, string message, string phone)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    const string email = "lostdutchmansoftware@gmail.com";
                    const string password = "TifaT0TheR1gh7";

                    var loginInfo = new NetworkCredential(email, password);


                    mail.From = new MailAddress(email);
                    //Add more recipiants?
                    mail.To.Add(new MailAddress(email));
                    mail.Subject = "Form Inquiry Main Site, " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"); //add time stamp
                    mail.Body = "Name:" + name + "\nEmail:" + emailaddress + "\nPhone Number:" + phone + "\n" + message;
                    mail.IsBodyHtml = false;

                    try
                    {
                        using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtpClient.EnableSsl = true;
                            smtpClient.UseDefaultCredentials = true;
                            smtpClient.Credentials = loginInfo;
                            smtpClient.Send(mail);
                        }

                    }

                    finally
                    {
                        //dispose the client
                        mail.Dispose();
                    }
                }
            }
            catch
            {
                //What to do if mail send fails
            }
        }
    }
}
