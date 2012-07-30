using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SellerHelp_MasterPage2 : System.Web.UI.MasterPage
{
    protected string siteUrl = "";
    protected string nick = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        siteUrl = ShopUtil.XmlCOM.ReadConfig("SiteUrl");
        nick = ((Shop.ShopUI.BasePage)this.Page).GetSessionString("tb_username");
    }
}
