using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Shop.ShopUI
{
    /// <summary>
    /// Summary description for AdminPage
    /// </summary>
    public class AdminPage : Shop.ShopUI.BasePage
    {
        public AdminPage()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        protected void Admin_Load()
        {
            CheckLogin();
        }

        protected void CheckLogin()
        {
            if (Session["LoginInfo"] == null)
            {
                //Shop.BaseFuntion.BaseFunction.alert(this.Page," ��δ��½��ʱ�������µ�½��");
                Response.Write("<script>alert('��δ��½��ʱ�������µ�½��');top.location='Login.aspx'</script>");
                Response.End();
            }
        }
    }
}
