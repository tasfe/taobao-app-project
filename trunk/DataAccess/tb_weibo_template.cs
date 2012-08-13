using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
    /// <summary>
    /// 类tb_weibo_template。
    /// </summary>
    public partial class tb_weibo_template
    {
        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string  template)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_weibo_template");
            strSql.Append(" where [template]=@template ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@template", OleDbType.VarChar)};
            parameters[0].Value = template;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        #endregion  成员方法
    }
}

