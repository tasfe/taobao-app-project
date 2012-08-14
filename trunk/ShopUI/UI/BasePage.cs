using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Shop;

namespace Shop.ShopUI
{
    /// <summary>
    /// PageBase 的摘要说明
    /// </summary>
    public class BasePage : Page
    {
        public BasePage()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            //this.EnableViewState = false;
        }
        protected void SetPageTitle()
        {
            //if (HttpRuntime.Cache["webtitle"] != null)
            //{
            //    this.Title = HttpRuntime.Cache["webtitle"].ToString();
            //}
            //else
            //{
            string xmlFilePath = Server.MapPath("~/Inc/SysInfo.xml");
            this.Title = Shop.BaseFunction.GetXmlNodeValue("SysInfo", "SiteName", xmlFilePath);
            //HttpRuntime.Cache.Insert("webtitle", this.Title);
            //}
        }

        protected void SetPageTitle(string categoryId)
        {

        }
        /// <summary>
        /// 覆盖系统默认的错误页
        /// </summary>
        protected override void OnError(EventArgs e)
        {
            //HttpContext ctx = HttpContext.Current;
            //Exception exception = ctx.Server.GetLastError();
            //string errorInfo =
            //    "<br>Offending URL: " + ctx.Request.Url.ToString() +
            //    "<br>Source: " + exception.Source +
            //    "<br>Message: " + exception.Message +
            //    "<br>Stack trace: " + exception.StackTrace;
            //PageErrorLog(Shop.BaseFunction.NoHTML(errorInfo));
            //ctx.Server.ClearError();
            //Response.Redirect("~/web/Sorry.htm");

            System.Web.HttpContext ctx = System.Web.HttpContext.Current;
            Exception exception = ctx.Server.GetLastError();
            string errorInfo =
                "\r\n<br>Offending URL: " + ctx.Request.Url.ToString() +
                "\r\n<br>Source: " + exception.Source +
                "\r\n<br>Message: " + exception.Message +
                "\r\n<br>Stack trace: " + exception.StackTrace;
            //PageErrorLog(Shop.BaseFunction.NoHTML(errorInfo));
            //ctx.Server.ClearError();
            //Response.Redirect("~/web/Sorry.htm");
            //ShopUtil.Mail.SendMail("29738637@qq.com", "淘翻天推广平台", errorInfo);
            //Response.Write("<h1 align='center'>非常抱歉，系统出现异常，<a href='?'>点击返回重试</a>！</h1>");

            ShopUtil.LogInfo.FileLogPath = Server.MapPath("~/app/Sellerhelp/log");
            ShopUtil.LogInfo.WriteLog("page_error_log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", errorInfo);

            Response.Redirect("Error.aspx");
            Response.End();
            base.OnError(e);
        }

        protected void PageErrorLog(string errorInfo)
        {
            Shop.BaseFunction.LogInfo("~/log/", "pageError.txt", errorInfo);
        }

        /// <summary>
        /// 获得querystring
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public string GetQueryString(string queryString)
        {
            if (Request.QueryString[queryString] != null)
            {
                return Request.QueryString[queryString];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获得formstring
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public string GetFormString(string queryString)
        {
            string form = Request.Form[queryString];
            if (!string.IsNullOrEmpty(form))
            {
                return Request.Form[queryString];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获得query int
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public int GetQueryInt(string queryString)
        {
            int i = 0;
            int.TryParse(GetQueryString(queryString), out i);
            return i;
        }

        /// <summary>
        /// 获得query long
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public long GetQueryLong(string queryString)
        {
            long i = 0;
            long.TryParse(GetQueryString(queryString), out i);
            return i;
        }
        protected object GetSession(string key)
        {
            return Session[key];
        }

        public string GetSessionString(string key)
        {
            object o = GetSession(key);
            if (o == null)
            {
                return "";
            }
            else
            {
                return o.ToString();
            }
        }
        public void SetSession(string key, object value)
        {
            Session[key] = value;
        }
        //弹出信息
        protected void alert(string msg)
        {
            Page.RegisterClientScriptBlock("", "<script>alert('" + msg + "！');</script>");
        }

        //执行脚本
        protected void ExceScript(string script)
        {
            Page.RegisterClientScriptBlock("", "<script>" + script + "</script>");
        }

        protected void CheckSqlInput(string input)
        {
            Shop.BaseFunction.CheckInPut(input, Page);
        }

        public string GetCurrLang()
        {
            if (Session["lang"] != null)
            {
                return Session["lang"].ToString();
            }
            else
            {
                return "0001";
            }
        }
        public void SetCurrLang(string lang)
        {
            Session["lang"] = lang;
        }

        protected DropDownList GetDepMail(DropDownList ddl)
        {
            string xmlFilePath = Server.MapPath("~/Inc/SysInfo.xml");
            string depMails = Shop.BaseFunction.GetXmlNodeValue("SysInfo", "SendDepartment", xmlFilePath);
            //DropDownList ddl = new DropDownList();
            string[] depMail = depMails.Split('|');
            for (int i = 0; i < depMail.Length; i++)
            {
                string[] depMailAndName = depMail[i].Split(',');
                if (depMailAndName.Length == 2)
                {
                    ListItem li = new ListItem();
                    li.Text = depMailAndName[0];
                    li.Value = depMailAndName[1];
                    ddl.Items.Add(li);
                }
            }

            return ddl;
        }
        protected void SendMail(string[] toAddresses, string subject, string body)
        {
            string xmlFilePath = Server.MapPath("~/Inc/MailSetting.xml");
            string fromAddress = Shop.BaseFunction.GetXmlNodeValue("MailSetting", "Sender", xmlFilePath);
            string smtpAddress = Shop.BaseFunction.GetXmlNodeValue("MailSetting", "Smtp", xmlFilePath);
            string username = Shop.BaseFunction.GetXmlNodeValue("MailSetting", "UserName", xmlFilePath);
            string password = Shop.BaseFunction.GetXmlNodeValue("MailSetting", "Password", xmlFilePath);
            int smtpPort = 587;
            bool isSSL = true;

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
            smtp.Credentials = new System.Net.NetworkCredential(username, password);
            //smtp.UseDefaultCredentials = true;
            smtp.Send(mail);
        }

        protected string GetBannerFlash(string code)
        {
            string flashUrl = "";
            if (code.StartsWith("0001"))
            {
                flashUrl = "images/banner/1.swf";
            }
            if (code.StartsWith("0002"))
            {
                flashUrl = "images/banner/2.swf";
            }
            if (code.StartsWith("0003"))
            {
                flashUrl = "images/banner/3.swf";
            }
            if (code.StartsWith("0004"))
            {
                flashUrl = "images/banner/4.swf";
            }
            if (code.StartsWith("0005"))
            {
                flashUrl = "images/banner/5.swf";
            }
            if (code.StartsWith("0007"))
            {
                flashUrl = "images/banner/7.swf";
            }
            return flashUrl;
        }

        protected HttpCookie GetFromCookie(string key)
        {
            return Request.Cookies[key];
        }

        protected void SetFromCookie(string key,string  value)
        {
            Response.SetCookie(new HttpCookie(key,value));
        }

        public string GetUrlEncode(string str)
        {
            System.Text.Encoding GB2312 = System.Text.Encoding.GetEncoding("GB2312");
            System.Text.Encoding UTF8 = System.Text.Encoding.UTF8;
            string msg = GB2312.GetString(UTF8.GetBytes(str));

            return Server.UrlEncode(msg);
        }
    }
}

