using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Shop
{
    public class QQMailClient
    {
        private const string QQMAIL_DOMAIN = "http://w37.mail.qq.com";
        private const string QQMAIL_LOGINURL = QQMAIL_DOMAIN + "/cgi-bin/login";
        private const string QQMAIL_SENDURL = QQMAIL_DOMAIN + "/cgi-bin/cgi_redirect";
        private const string QQMAIL_LOGINDATA = "device=&tfcont=&f=xhtml&aliastype=@qq.com&btlogin=登录&mss=1&uin={0}&pwd={1}";
        private const string QQMAIL_SENDDATA =@"showto=&to={0}&showcc=&cc=%3B&showbcc=&bcc=%3B&subject={1}&content={2}&RedirectY29tcG9zZV9zZW5kP21vYmlsZXNlbmQ9MQ__=%E5%8F%91%E9%80%81&ignoredraft=y&ReAndFwMailid=&fmailid=&editorigin=1&frommobile=frommobile&sid={3}&citeprev=yes&mobileautosv=&noccbcc=no&savesendbox=1&contenttype=html&srcfolderid=&s=&ReAndFw=&fattachlist=&ftndowntpl=exs_ftn_download&signadded=yes&catid=&noteid=&sorttype=time&p=";

        public string LoginQQMail(string qq, string pwd, out CookieContainer cookieContainer, out string cookiesStr)
        {
            HttpRequestUtil httpRequestUtil = new HttpRequestUtil();
            
            string postResult= httpRequestUtil.DoPostRequest(QQMAIL_LOGINURL, string.Format(QQMAIL_LOGINDATA,
               qq,
               pwd), "");

            cookieContainer = httpRequestUtil.cc;
            cookiesStr = httpRequestUtil.Cookiesstr;

            return postResult;
        }

        public string SendQQMail(string toList, string subject, string body, CookieContainer cookieContainer, string cookiesStr)
        {
            HttpRequestUtil httpRequestUtil = new HttpRequestUtil(cookieContainer, cookiesStr);

            return httpRequestUtil.DoPostRequest(QQMAIL_SENDURL, string.Format(QQMAIL_SENDDATA,
                toList,
               subject,
               System.Web.HttpUtility.UrlEncode(body,Encoding.GetEncoding("GB2312")),

                httpRequestUtil.GetCookie("msid")), "");
        }

        //"xx"<xxx@qq.com>;
        protected string GetToList(string toList)
        {
            string mailTemplate = "\"{0}\"<{1}>;";
            string[] mailList=toList.Split(';');
            StringBuilder sbMail = new StringBuilder();
            foreach (string mail in mailList)
            {
                if (mail.Split('@').Length == 2)
                {
                    sbMail.Append(string.Format(mailTemplate, mail.Split('@')[0], mail));
                }
            }

            return sbMail.ToString();
        }
    }
}
