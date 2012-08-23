using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string filter = " 1=1 ";
        int count = 0;
        DataTable dt = TaoBaoKeDAL.DBUtil.getDateByPager("tb_taobaoke", "tbk_id", "*", "5", "0", filter, "", "UpdateOn desc", out count);//feedBack.GetList("").Tables[0];
        rptList.DataSource = dt;

        rptList.DataBind();
    }
}