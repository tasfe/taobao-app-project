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
        protected int pageSize = 20;
        protected int currPage = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["p"]))
        {
            int.TryParse(Request.QueryString["p"], out currPage);
        }

        string filter= " 1=1 ";

        DataTable dt = TaoBaoKeDAL.DBUtil.getDateByPager("tb_taobaoke", "tbk_id", "*", pageSize.ToString(), (currPage - 1).ToString(), filter, "", "UpdateOn desc", out count);//feedBack.GetList("").Tables[0];

        DataTable dt1 = dt.Clone();
        DataTable dt2 = dt.Clone();
        DataTable dt3 = dt.Clone();
        DataTable dt4 = dt.Clone();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i < 5)
            {
                dt1.Rows.Add(dt.Rows[i].ItemArray);
            }
            else if (i < 10)
            {
                dt2.Rows.Add(dt.Rows[i].ItemArray);
            }
            else if (i < 15)
            {
                dt3.Rows.Add(dt.Rows[i].ItemArray);
            }
            else if (i < 20)
            {
                dt4.Rows.Add(dt.Rows[i].ItemArray);
            }
        }

        rptList1.DataSource = dt1;
        rptList1.DataBind();

        rptList2.DataSource = dt2;
        rptList2.DataBind();

        rptList3.DataSource = dt3;
        rptList3.DataBind();

        rptList4.DataSource = dt4;
        rptList4.DataBind();
    }
}