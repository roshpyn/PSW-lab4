using System;
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

                smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpServer.UseDefaultCredentials = false;

                mail.Subject = "Rejestracja PSW lab4 udana";
                mail.From = new MailAddress(From);
                mail.To.Add(to);
                mail.Body = "Dziękujemy za rejestrację w PSW-LAB4 \n"
                    + "Twój login to:  " + userLogin + endLine
                    + "Twoje hasło to: " + userPassword + endLine
                    + "Autorzy:" + endLine
                    + "H. Gabryszewski & Ł. Szadowski";
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
