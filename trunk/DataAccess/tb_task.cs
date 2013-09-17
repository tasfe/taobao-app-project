using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace TaobaoApp.DataAccess
{
    /// <summary>
    /// 类tb_task。
    /// </summary>
    public partial class tb_task
    {
        #region  Method


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID,string taobaonick)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tb_task] ");
            strSql.Append(" where ID=@ID ");
            strSql.Append(" AND TaobaoNick=@TaobaoNick ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4),
                    new OleDbParameter("@TaobaoNick", OleDbType.VarChar)};
            parameters[0].Value = ID;
            parameters[1].Value = taobaonick;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  Method
    }
}

