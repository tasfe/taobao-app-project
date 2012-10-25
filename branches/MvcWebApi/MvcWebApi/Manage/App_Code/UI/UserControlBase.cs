using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SASCMS.UI
{
    /// <summary>
    /// Summary description for UserControlBase
    /// </summary>
    public class UserControlBase : UserControl
    {
        public UserControlBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        protected void CheckSqlInput(string input)
        {
            SASCMS.BaseFunction.CheckInPut(input, Page);
        }

        /// <summary>
        /// 获得querystring
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        protected string GetQueryString(string queryString)
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
        //执行脚本
        protected void ExceScript(System.Web.UI.Page page, string script)
        {
            page.RegisterClientScriptBlock("", "<script>" + script + "</script>");
        }
    }
}
