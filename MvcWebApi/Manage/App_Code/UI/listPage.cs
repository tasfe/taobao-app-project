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
    public class ListPage : BasePage
    {
        protected string colName = "";
        protected int count = 0;
        protected int pageSize = 15;
        protected int currPage = 0;

        protected void Page_Init()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["p"]))
            {
                int.TryParse(Request.QueryString["p"], out currPage);
            }
        }
    }
}
