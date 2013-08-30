using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
    /// <summary>
    /// 类tb_access_weibo。
    /// </summary>
    public partial class tb_access_weibo
    {

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelByKey(string key)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [weibo_id],[user_id],[accesskey],[accesssecret],[updateOn],[lastOperateOn],[day_send],[weibo_name],[weibo_url],[ID] ");
            strSql.Append(" FROM tb_access_weibo ");
            strSql.Append(" where [accesskey]=@accesskey ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@accesskey", OleDbType.Char)};
            parameters[0].Value = key;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["weibo_id"].ToString() != "")
                {
                    this.weibo_id = int.Parse(ds.Tables[0].Rows[0]["weibo_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    this.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                this.accesskey = ds.Tables[0].Rows[0]["accesskey"].ToString();
                this.accesssecret = ds.Tables[0].Rows[0]["accesssecret"].ToString();
                if (ds.Tables[0].Rows[0]["updateOn"].ToString() != "")
                {
                    this.updateOn = DateTime.Parse(ds.Tables[0].Rows[0]["updateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lastOperateOn"].ToString() != "")
                {
                    this.lastOperateOn = DateTime.Parse(ds.Tables[0].Rows[0]["lastOperateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["day_send"].ToString() != "")
                {
                    this.day_send = int.Parse(ds.Tables[0].Rows[0]["day_send"].ToString());
                }
                this.weibo_name = ds.Tables[0].Rows[0]["weibo_name"].ToString();
                this.weibo_url = ds.Tables[0].Rows[0]["weibo_url"].ToString();
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelBySinaUID(string SinaUID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tb_access_weibo] ");
            strSql.Append(" where SinaUID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar)};
            parameters[0].Value = SinaUID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["weibo_id"] != null && ds.Tables[0].Rows[0]["weibo_id"].ToString() != "")
                {
                    this.weibo_id = int.Parse(ds.Tables[0].Rows[0]["weibo_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null && ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    this.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["accesskey"] != null && ds.Tables[0].Rows[0]["accesskey"].ToString() != "")
                {
                    this.accesskey = ds.Tables[0].Rows[0]["accesskey"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accesssecret"] != null && ds.Tables[0].Rows[0]["accesssecret"].ToString() != "")
                {
                    this.accesssecret = ds.Tables[0].Rows[0]["accesssecret"].ToString();
                }
                if (ds.Tables[0].Rows[0]["updateOn"] != null && ds.Tables[0].Rows[0]["updateOn"].ToString() != "")
                {
                    this.updateOn = DateTime.Parse(ds.Tables[0].Rows[0]["updateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lastOperateOn"] != null && ds.Tables[0].Rows[0]["lastOperateOn"].ToString() != "")
                {
                    this.lastOperateOn = DateTime.Parse(ds.Tables[0].Rows[0]["lastOperateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["day_send"] != null && ds.Tables[0].Rows[0]["day_send"].ToString() != "")
                {
                    this.day_send = int.Parse(ds.Tables[0].Rows[0]["day_send"].ToString());
                }
                if (ds.Tables[0].Rows[0]["weibo_name"] != null && ds.Tables[0].Rows[0]["weibo_name"].ToString() != "")
                {
                    this.weibo_name = ds.Tables[0].Rows[0]["weibo_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weibo_url"] != null && ds.Tables[0].Rows[0]["weibo_url"].ToString() != "")
                {
                    this.weibo_url = ds.Tables[0].Rows[0]["weibo_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AccessToken"] != null && ds.Tables[0].Rows[0]["AccessToken"].ToString() != "")
                {
                    this.AccessToken = ds.Tables[0].Rows[0]["AccessToken"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ExpiresIn"] != null && ds.Tables[0].Rows[0]["ExpiresIn"].ToString() != "")
                {
                    this.ExpiresIn = int.Parse(ds.Tables[0].Rows[0]["ExpiresIn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SinaUID"] != null && ds.Tables[0].Rows[0]["SinaUID"].ToString() != "")
                {
                    this.SinaUID = ds.Tables[0].Rows[0]["SinaUID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AccessTokenExpires"] != null && ds.Tables[0].Rows[0]["AccessTokenExpires"].ToString() != "")
                {
                    this.AccessTokenExpires = DateTime.Parse(ds.Tables[0].Rows[0]["AccessTokenExpires"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelByWeiboName(string weiboName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tb_access_weibo] ");
            strSql.Append(" where Weibo_Name=@Weibo_Name ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@weiboName", OleDbType.VarChar)};
            parameters[0].Value = weiboName;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["weibo_id"] != null && ds.Tables[0].Rows[0]["weibo_id"].ToString() != "")
                {
                    this.weibo_id = int.Parse(ds.Tables[0].Rows[0]["weibo_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null && ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    this.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["accesskey"] != null && ds.Tables[0].Rows[0]["accesskey"].ToString() != "")
                {
                    this.accesskey = ds.Tables[0].Rows[0]["accesskey"].ToString();
                }
                if (ds.Tables[0].Rows[0]["accesssecret"] != null && ds.Tables[0].Rows[0]["accesssecret"].ToString() != "")
                {
                    this.accesssecret = ds.Tables[0].Rows[0]["accesssecret"].ToString();
                }
                if (ds.Tables[0].Rows[0]["updateOn"] != null && ds.Tables[0].Rows[0]["updateOn"].ToString() != "")
                {
                    this.updateOn = DateTime.Parse(ds.Tables[0].Rows[0]["updateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lastOperateOn"] != null && ds.Tables[0].Rows[0]["lastOperateOn"].ToString() != "")
                {
                    this.lastOperateOn = DateTime.Parse(ds.Tables[0].Rows[0]["lastOperateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["day_send"] != null && ds.Tables[0].Rows[0]["day_send"].ToString() != "")
                {
                    this.day_send = int.Parse(ds.Tables[0].Rows[0]["day_send"].ToString());
                }
                if (ds.Tables[0].Rows[0]["weibo_name"] != null && ds.Tables[0].Rows[0]["weibo_name"].ToString() != "")
                {
                    this.weibo_name = ds.Tables[0].Rows[0]["weibo_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["weibo_url"] != null && ds.Tables[0].Rows[0]["weibo_url"].ToString() != "")
                {
                    this.weibo_url = ds.Tables[0].Rows[0]["weibo_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AccessToken"] != null && ds.Tables[0].Rows[0]["AccessToken"].ToString() != "")
                {
                    this.AccessToken = ds.Tables[0].Rows[0]["AccessToken"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ExpiresIn"] != null && ds.Tables[0].Rows[0]["ExpiresIn"].ToString() != "")
                {
                    this.ExpiresIn = int.Parse(ds.Tables[0].Rows[0]["ExpiresIn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SinaUID"] != null && ds.Tables[0].Rows[0]["SinaUID"].ToString() != "")
                {
                    this.SinaUID = ds.Tables[0].Rows[0]["SinaUID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AccessTokenExpires"] != null && ds.Tables[0].Rows[0]["AccessTokenExpires"].ToString() != "")
                {
                    this.AccessTokenExpires = DateTime.Parse(ds.Tables[0].Rows[0]["AccessTokenExpires"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAccessList(int userID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ,tb_access_weibo.id as access_weibo_id,tb_access_weibo.weibo_url as access_weibo_url");
            strSql.Append(" FROM tb_access_weibo,tb_weibo where tb_access_weibo.weibo_id=tb_weibo.id and tb_access_weibo.user_id=" + userID);
            strSql.Append(" order by tb_access_weibo.id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public int UpdateDaySend(string key)
        {
            GetModelByKey(key);
            string sql = "update tb_access_weibo set lastOperateOn=#{0}# , day_send={1} where accesskey='{2}'";
            if (lastOperateOn!=null&&DateTime.Now.ToString("yyyyMMdd") == lastOperateOn.Value.ToString("yyyyMMdd"))
            {
                sql = string.Format(sql, DateTime.Now.ToString(), day_send+1, key);
            }
            else
            {
                sql = string.Format(sql, DateTime.Now.ToString(), "1", key);
            }
            return DbHelperSQL.ExecuteSql(sql.ToString());
        }
    }
}

