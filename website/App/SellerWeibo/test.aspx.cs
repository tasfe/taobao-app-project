using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        weibo.DataAccess.tb_user user = (weibo.DataAccess.tb_user)Session["tb_user"];
        user.tb_subscribe = "ts-12485-1";
        Session["tb_user"] = user;
        //Response.Write(Server.MapPath("~/pages"));
        Response.Write(Request.Url.ToString());
        Response.Write(Request.Url.Port);
    }
}