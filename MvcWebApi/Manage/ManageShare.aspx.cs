using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcWebApi.Manage
{
    public partial class WebForm1 : SASCMS.UI.ManagePage
    {
        protected void Page_Init()
        {
            tableName = "share";
            tableKey = "id";
            keyWord = txtKeyword.Text.Trim();
            assemblyName = "sharejoy.Model.share";
            searchColumn = " content";
            orderBy = " update_date";

            base.plEdit = this.plEdit;
            base.plList = this.plList;
            base.CtrlPager = this.CtrlPager;
            base.GridView1 = this.GridView1;
        }
    }
}