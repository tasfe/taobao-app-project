using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SASCMS;
using System.Threading;
using System.Globalization;

namespace SASCMS.UI
{
    /// <summary>
    /// PageBase 的摘要说明
    /// </summary>
    public class BasePage : Page
    {
        protected string configFilePath;
        protected SASCMS.DataAccess.TB_MEMBER member { get {
            return Session["MEMBER"] == null ? new SASCMS.DataAccess.TB_MEMBER() : (SASCMS.DataAccess.TB_MEMBER)Session["MEMBER"];
        } }

        public BasePage()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            //this.EnableViewState = false;
            configFilePath = Server.MapPath("~/Inc/SysInfo.xml");
            SetPageTitle();
        }

        protected void SetPageTitle()
        {
            //if (HttpRuntime.Cache["webtitle"] != null)
            //{
            //    this.Title = HttpRuntime.Cache["webtitle"].ToString();
            //}
            //else
            //{
                this.Title = SASCMS.BaseFunction.GetXmlNodeValue("SysInfo", "SiteName", configFilePath);
                //HttpRuntime.Cache.Insert("webtitle", this.Title);
            //}
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
            //PageErrorLog(SASCMS.BaseFunction.NoHTML(errorInfo));
            //ctx.Server.ClearError();
            //Response.Redirect("~/web/Sorry.htm");
            base.OnError(e);
        }

        protected void PageErrorLog(string errorInfo)
        {
            SASCMS.BaseFunction.LogInfo("~/log/", "pageError.txt", errorInfo);
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

        //弹出信息
        protected void alert(string msg)
        {       
            Page.RegisterClientScriptBlock("", "<script>alert('" + msg + "');</script>");
        }

        //执行脚本
        protected void ExceScript(string script)
        {
            Page.RegisterClientScriptBlock("", "<script>" + script + "</script>");
        }

        protected void CheckSqlInput(string input)
        {
            SASCMS.BaseFunction.CheckInPut(input, Page);
        }

        protected override void InitializeCulture()
        {
            //if (GetCurrLang() == "0001")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-cn");
            //    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("zh-cn");
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en");
            //}
        }
    }
}
