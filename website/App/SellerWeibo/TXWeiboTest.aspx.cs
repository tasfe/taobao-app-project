using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class App_SellerWeibo_TXWeiboTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string code=Request.QueryString["code"];
        OAuthTXWeibo.OAuthTXWeiboBase oAuthTXWeiboBase=new OAuthTXWeibo.OAuthTXWeiboBase();

        if (string.IsNullOrEmpty(code))
        {
            string url = oAuthTXWeiboBase.GetRequestCodeUrl(ShopUtil.XmlCOM.ReadConfig("TXAppKey"),
                "http://127.0.0.1:13396/website/App/Sellerweibo/TXWeiboTest.aspx");

            Response.Redirect(url);
        }
        else
        {
            oAuthTXWeiboBase.GetAccessToken(Request.QueryString["code"],
                ShopUtil.XmlCOM.ReadConfig("TXAppKey"),
                ShopUtil.XmlCOM.ReadConfig("TXAppSecret"),
                "http://127.0.0.1:13396/website/App/Sellerweibo/TXWeiboTest.aspx");
        }
    }
}
