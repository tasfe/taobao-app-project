using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
    public partial class tb_user
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelByNick(string nick)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_user ");
            strSql.Append(" where [tb_nick]=@tb_nick ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@tb_nick", OleDbType.Char)};
            parameters[0].Value = nick;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.tb_subscribe = ds.Tables[0].Rows[0]["tb_subscribe"].ToString();
                this.tb_userid = ds.Tables[0].Rows[0]["tb_userid"].ToString();
                this.tb_nick = ds.Tables[0].Rows[0]["tb_nick"].ToString();
                this.tx_key = ds.Tables[0].Rows[0]["tx_key"].ToString();
                this.tx_secret = ds.Tables[0].Rows[0]["tx_secret"].ToString();
                if (ds.Tables[0].Rows[0]["updateon"].ToString() != "")
                {
                    this.updateon = DateTime.Parse(ds.Tables[0].Rows[0]["updateon"].ToString());
                }
                this.sina_key = ds.Tables[0].Rows[0]["sina_key"].ToString();
                this.sina_secret = ds.Tables[0].Rows[0]["sina_secret"].ToString();
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByNick(string field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_user] set ");
            strSql.Append(field);
            strSql.Append(" where [tb_nick]=@tb_nick ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@tb_nick", OleDbType.VarChar,255)};
            parameters[0].Value = tb_nick;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
    }
}
