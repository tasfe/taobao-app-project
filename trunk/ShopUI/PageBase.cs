using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class PageBase : System.Web.UI.Page
    {
        /// <summary>
        /// 覆盖系统默认的错误页
        /// </summary>
        protected override void OnError(EventArgs e)
        {
            System.Web.HttpContext ctx = System.Web.HttpContext.Current;
            Exception exception = ctx.Server.GetLastError();
            string errorInfo =
                "<br>Offending URL: " + ctx.Request.Url.ToString() +
                "<br>Source: " + exception.Source +
                "<br>Message: " + exception.Message +
                "<br>Stack trace: " + exception.StackTrace;
            //PageErrorLog(Shop.BaseFunction.NoHTML(errorInfo));
            //ctx.Server.ClearError();
            //Response.Redirect("~/web/Sorry.htm");
            ShopUtil.Mail.SendMail("29738637@qq.com", "淘翻天卖家助手", errorInfo);

            Response.Write("<h1 align='center'>非常抱歉，系统出现异常，<a href='?'>点击返回重试</a>！</h1>");
            Response.End();

            base.OnError(e);
        }

        protected string nick = "未登录用户";
        protected string GetQueryString(string key)
        {
            return Request.QueryString[key];
        }
        protected int GetQueryInt(string key)
        {
            int iQ = 0;
            string q = GetQueryString(key);
            if (!string.IsNullOrEmpty(q))
            {
                int.TryParse(q, out iQ);
            }
            return iQ;
        }
        protected void CheckLogin()
        {
            weibo.DataAccess.tb_user user = GetLoginUser();
            if (user == null || user.tb_nick == null)
            {    
                Response.Redirect("Default.aspx?from=timeout");
            }
            else
            {
                nick = user.tb_nick;
            }
        }
        protected object GetSession(string key)
        {
            return Session[key];
        }

        protected string GetSessionString(string key)
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
        protected void SetSession(string key,object value)
        {
            Session[key] = value;
        }

        protected weibo.DataAccess.tb_user GetLoginUser()
        {
            object user=GetSession("tb_user");
            if (user != null)
            {
                return (weibo.DataAccess.tb_user)user;
            }
            else
            {
                return null;
            }
        }

        //0:free,1:pay
        protected int UserType()
        {
            if (GetLoginUser() != null)
            {
                if (GetLoginUser().tb_subscribe == "ts-12485-1")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
