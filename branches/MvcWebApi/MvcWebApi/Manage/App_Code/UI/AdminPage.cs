using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SASCMS.UI
{
    /// <summary>
    /// Summary description for AdminPage
    /// </summary>
    public class AdminPage : SASCMS.UI.BasePage
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
                //SASCMS.BaseFuntion.BaseFunction.alert(this.Page," ��δ��½��ʱ�������µ�½��");
                Response.Write("<script>alert('��δ��½��ʱ�������µ�½��');top.location='Login.aspx'</script>");
                Response.End();
            }
        }
        //�����Ŀ����
        protected string getColNameById(string id)
        {
            SASCMS.BLL.TB_ColumnBll colBll = new SASCMS.BLL.TB_ColumnBll();
            SASCMS.Model.TB_Column column = colBll.GetModel(id);
            return column.Title;
        }
    }
}
