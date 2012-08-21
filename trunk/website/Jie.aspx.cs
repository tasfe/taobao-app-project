using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Jie : System.Web.UI.Page
{
      protected string colName = "";
        protected int count = 0;
        protected int pageSize = 10;
        protected int currPage = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        string filter= " 1=1 ";

        DataTable dt = TaoBaoKeDAL.DBUtil.getDateByPager("tb_taobaoke", "tbk_id", "*", pageSize.ToString(), (currPage - 1).ToString(), filter, "", "UpdateOn desc", out count);//feedBack.GetList("").Tables[0];
        rptList.DataSource = dt;

        rptList.DataBind();
    }
}