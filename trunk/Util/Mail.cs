using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ShopUtil
{
    /// <summary>
    /// Summary description for SendMail
    /// </summary>
    public class Mail
    {
        public Mail()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static void SendMail( string subject, string body)
        {
            SendMail("29738637@qq.com", subject, body);
        }

        public static void SendMail(string fromAddress,string subject, string body)
        {
            string[] toAddresses = new string[] { "29738637@qq.com" };
            string smtpAddress = "smtp.qq.com";
            string username = "29738637";
            string password = "sjk1234";
            int smtpPort=25;

            SendMail(toAddresses, subject, body,
               fromAddress,
               smtpAddress,
               username,
               password,
               smtpPort);
        }
        protected static void SendMail(string[] toAddresses, string subject, string body,
            string fromAddress,
            string smtpAddress,
            string username,
            string password,
            int smtpPort)
        {

            bool isSSL = false;

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(fromAddress);
            foreach (string thisAdd in toAddresses)
            {
                mail.To.Add(new System.Net.Mail.MailAddress(thisAdd));
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(smtpAddress);
            smtp.Port = smtpPort;
            smtp.Timeout = int.MaxValue;
            smtp.EnableSsl = isSSL;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(username, password);
            //smtp.UseDefaultCredentials = true;
            smtp.Send(mail);
        }
    }
}