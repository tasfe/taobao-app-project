using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["subscribe_code"] = "ts-13815-4";
        Response.Write(Request.Url.AbsolutePath);
        Response.Write(Server.MapPath("~/"));

        ShopUtil.LogInfo.FileLogPath = Server.MapPath("~/app/Sellerhelp");
        ShopUtil.LogInfo.WriteLog("top_log.txt", "tradesSoldGetResponse.ErrMsg" + "|" + "tradesSoldGetResponse.SubErrMsg");
    }
}