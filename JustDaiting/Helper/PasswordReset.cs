﻿using System.Net.Mail;

namespace JustDaiting.Helper
{
    public class PasswordReset
    {
        public static void PasswordResetSendEmail(string link)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("mail.example.com");
            mail.From = new MailAddress("berkancelikist@gmail.com");
            mail.To.Add("celikberkan1@outlook.com");
            mail.Subject = $"www.bıdı.com: Şifre sıfırlama";
            mail.Body = "<h2> Şifrenizi yenilemek için lütfen aşağıdkai linke tıklayımız</h2><hr/>";
            mail.Body += $"<a href='{link}'>şifre yenileme linki</a>";
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("berkancelikist@gmail.com", "Berkan123");
            smtpClient.Send(mail);
        }
    }
}