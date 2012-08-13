using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using Shop;
namespace Shop.DataAccess
{
    /// <summary>
    /// Summary description for TaoBaoKeCommon
    /// </summary>
    public class TaoBaoKeCommon
    {
        public TaoBaoKeCommon()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static DataTable GetTaoBaoKe(string where, int titleLength, int topNum)
        {
            string strSql = "select top " + topNum.ToString() + " * from tb_taobaoke where " + where;
            DataTable dt = Shop.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["title"] = Shop.BaseFunction.cutString( BaseFunction.NoHTML(dt.Rows[i]["title"].ToString()), titleLength);
            }

            return dt;
        }

        public static DataTable GetTaoBaoPager(string currentPage,string filter,out int totlePage,string order)
        {
            int pageSize =24;
            int totleCount=0;

            DataTable dt = null;// BaseFunction.getDateByPager("Tb_TaoBaoKe", "TBK_ID", "*", pageSize.ToString(), currentPage, filter, "", order, out totleCount).Tables[0];
            totlePage = totleCount % 24 == 0 ? totleCount / 24 : totleCount / 24+1;
            return dt;
        }
    }
}
