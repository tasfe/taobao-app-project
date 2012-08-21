using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TaoBaoKeDAL
{
    public class DBUtil
    {
        public static DataTable getDateByPager(string TableNames, string PrimaryKey, string Fields, string PageSize, string CurrentPage, string Filter, string Group, string Order, out int recordCount)
        {
            int topNum = int.Parse(PageSize) * int.Parse(CurrentPage);
            recordCount = Shop.DBUtility.DbHelperSQL.ExecuteSqlNum("select count(" + PrimaryKey + ") from " + TableNames + " where " + Filter);
            string sql = "";
            if (topNum <= 0)
            {
                sql = "select top " + PageSize + " " + Fields + " from " + TableNames + " where " + Filter + " order by " + Order;
            }
            else
            {
                sql = "select top " + PageSize + " " + Fields + " from " + TableNames + " where " + Filter + "and  " + PrimaryKey + " not in(select top " + topNum + " " + PrimaryKey + " from " + TableNames + " where " + Filter + "order by " + Order + ") order by " + Order;
            }

            return Shop.DBUtility.DbHelperSQL.Query(sql).Tables[0];
        }
    }
}
