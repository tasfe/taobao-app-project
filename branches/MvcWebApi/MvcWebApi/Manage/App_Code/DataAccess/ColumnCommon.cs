using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SASCMS.DataAccess
{
    /// <summary>
    /// ColumnCommon 的摘要说明
    /// </summary>
    public class ColumnCommon
    {
        public ColumnCommon()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        static SASCMS.BLL.TB_ColumnBll columnBll = new SASCMS.BLL.TB_ColumnBll();
        public static DataTable GetColumn(string where, int titleLength)
        {
            DataTable dt = columnBll.GetList(where).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["title"] = SASCMS.BaseFunction.cutString(dt.Rows[i]["title"].ToString(), titleLength);
            }
            return dt;
        }

        public static string GetFirstChildID(string colID)
        {
            DataTable dt = columnBll.GetList(" parentId='"+colID+"' order by code").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }
            else
            {
                return colID;
            }
        }

        public static string GetColName(string colID)
        {
            DataTable dt = columnBll.GetList(" id='" + colID + "' order by code").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["title"].ToString();
            }
            else
            {
                return colID;
            }
        }
    }
}
