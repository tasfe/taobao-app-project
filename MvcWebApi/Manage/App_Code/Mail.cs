using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


namespace SASCMS
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

        public static void SendMail(string subject, string body)
        {
            string xmlFilePath = HttpContext.Current.Server.MapPath("~/Inc/MailSetting.xml");
            string WebMaster = SASCMS.BaseFunction.GetXmlNodeValue("MailSetting", "WebMaster", xmlFilePath);

            SendMail(new string[] { WebMaster }, subject, body);
        }
        public static void SendMail(string subject, string body, string sendTo)
        {
            SendMail(sendTo.Split(';'), subject, body);
        }

        public static void SendMail(string[] toAddresses, string subject, string body)
        {
            string xmlFilePath = HttpContext.Current.Server.MapPath("~/Inc/MailSetting.xml");
            string fromAddress = SASCMS.BaseFunction.GetXmlNodeValue("MailSetting", "Sender", xmlFilePath);
            string smtpAddress = SASCMS.BaseFunction.GetXmlNodeValue("MailSetting", "Smtp", xmlFilePath);
            string username = SASCMS.BaseFunction.GetXmlNodeValue("MailSetting", "UserName", xmlFilePath);
            string password = SASCMS.BaseFunction.GetXmlNodeValue("MailSetting", "Password", xmlFilePath);
            int smtpPort = 587;
            bool isSSL = true;

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(fromAddress);
            foreach (string thisAdd in toAddresses)
            {
                if (thisAdd.Trim().Length > 0)
                {
                    mail.To.Add(new System.Net.Mail.MailAddress(thisAdd));
                }
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(smtpAddress);
            smtp.Port = smtpPort;
            smtp.Timeout = int.MaxValue;
            smtp.EnableSsl = isSSL;
            smtp.Credentials = new System.Net.NetworkCredential(username, password);
            //smtp.UseDefaultCredentials = true;
            smtp.Send(mail);
        }
    }
}
