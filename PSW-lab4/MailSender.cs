using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Net;


namespace PSW_lab4
{
    class MailSender
    {
        private String f = "roshpyn@gmail.com";
        private String p = "123!@#qweQAZ";

        public String endLine = "\n";

        public string Pass { get => p; }
        public string From { get => f; }

        public void SendEmail(string to, string userLogin, string userPassword)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com", 587);
                mail.Subject = "Rejestracja PSW lab4 udana";
                mail.From = new MailAddress(From);
                mail.To.Add(to);
                mail.Body = "Dziękujemy za rejestrację w PSW-LAB4 \n"
                    + "Twój login to:  " + userLogin + endLine
                    + "Twoje hasło to: " + userPassword + endLine
                    + "Za skorzystanie z naszych usług dziękują:" + endLine
                    + "H. G. & Ł. Sz.";
                smtpServer.Credentials = new NetworkCredential(From, Pass);
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
