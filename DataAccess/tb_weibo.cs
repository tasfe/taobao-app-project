using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
    /// <summary>
    /// 类tb_weibo。
    /// </summary>
    public class tb_weibo
    {
        public tb_weibo()
        { }
        #region Model
        private string _platform_name;
        private string _short_name;
        private string _appkey;
        private string _appsecret;
        private string _callbackurl;
        private DateTime _updateon;
        private string _weibo_url;
        private string _logo_url;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string platform_name
        {
            set { _platform_name = value; }
            get { return _platform_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string short_name
        {
            set { _short_name = value; }
            get { return _short_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string appkey
        {
            set { _appkey = value; }
            get { return _appkey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string appsecret
        {
            set { _appsecret = value; }
            get { return _appsecret; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string callbackurl
        {
            set { _callbackurl = value; }
            get { return _callbackurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime updateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_url
        {
            set { _weibo_url = value; }
            get { return _weibo_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string logo_url
        {
            set { _logo_url = value; }
            get { return _logo_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_weibo(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [platform_name],[short_name],[appkey],[appsecret],[callbackurl],[updateOn],[weibo_url],[logo_url],[ID] ");
            strSql.Append(" FROM tb_weibo ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                platform_name = ds.Tables[0].Rows[0]["platform_name"].ToString();
                short_name = ds.Tables[0].Rows[0]["short_name"].ToString();
                appkey = ds.Tables[0].Rows[0]["appkey"].ToString();
                appsecret = ds.Tables[0].Rows[0]["appsecret"].ToString();
                callbackurl = ds.Tables[0].Rows[0]["callbackurl"].ToString();
                if (ds.Tables[0].Rows[0]["updateOn"].ToString() != "")
                {
                    updateOn = DateTime.Parse(ds.Tables[0].Rows[0]["updateOn"].ToString());
                }
                weibo_url = ds.Tables[0].Rows[0]["weibo_url"].ToString();
                logo_url = ds.Tables[0].Rows[0]["logo_url"].ToString();
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_weibo");
            strSql.Append(" where [ID]=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_weibo(");
            strSql.Append("[platform_name],[short_name],[appkey],[appsecret],[callbackurl],[updateOn],[weibo_url],[logo_url])");
            strSql.Append(" values (");
            strSql.Append("@platform_name,@short_name,@appkey,@appsecret,@callbackurl,@updateOn,@weibo_url,@logo_url)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@platform_name", OleDbType.VarChar,255),
					new OleDbParameter("@short_name", OleDbType.VarChar,255),
					new OleDbParameter("@appkey", OleDbType.VarChar,255),
					new OleDbParameter("@appsecret", OleDbType.VarChar,255),
					new OleDbParameter("@callbackurl", OleDbType.VarChar,255),
					new OleDbParameter("@updateOn", OleDbType.Date),
					new OleDbParameter("@weibo_url", OleDbType.VarChar,255),
					new OleDbParameter("@logo_url", OleDbType.VarChar,255)};
            parameters[0].Value = platform_name;
            parameters[1].Value = short_name;
            parameters[2].Value = appkey;
            parameters[3].Value = appsecret;
            parameters[4].Value = callbackurl;
            parameters[5].Value = updateOn;
            parameters[6].Value = weibo_url;
            parameters[7].Value = logo_url;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_weibo] set ");
            strSql.Append("[platform_name]=@platform_name,");
            strSql.Append("[short_name]=@short_name,");
            strSql.Append("[appkey]=@appkey,");
            strSql.Append("[appsecret]=@appsecret,");
            strSql.Append("[callbackurl]=@callbackurl,");
            strSql.Append("[updateOn]=@updateOn,");
            strSql.Append("[weibo_url]=@weibo_url,");
            strSql.Append("[logo_url]=@logo_url");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@platform_name", OleDbType.VarChar,255),
					new OleDbParameter("@short_name", OleDbType.VarChar,255),
					new OleDbParameter("@appkey", OleDbType.VarChar,255),
					new OleDbParameter("@appsecret", OleDbType.VarChar,255),
					new OleDbParameter("@callbackurl", OleDbType.VarChar,255),
					new OleDbParameter("@updateOn", OleDbType.Date),
					new OleDbParameter("@weibo_url", OleDbType.VarChar,255),
					new OleDbParameter("@logo_url", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = platform_name;
            parameters[1].Value = short_name;
            parameters[2].Value = appkey;
            parameters[3].Value = appsecret;
            parameters[4].Value = callbackurl;
            parameters[5].Value = updateOn;
            parameters[6].Value = weibo_url;
            parameters[7].Value = logo_url;
            parameters[8].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_weibo ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [platform_name],[short_name],[appkey],[appsecret],[callbackurl],[updateOn],[weibo_url],[logo_url],[ID] ");
            strSql.Append(" FROM tb_weibo ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.platform_name = ds.Tables[0].Rows[0]["platform_name"].ToString();
                this.short_name = ds.Tables[0].Rows[0]["short_name"].ToString();
                this.appkey = ds.Tables[0].Rows[0]["appkey"].ToString();
                this.appsecret = ds.Tables[0].Rows[0]["appsecret"].ToString();
                this.callbackurl = ds.Tables[0].Rows[0]["callbackurl"].ToString();
                if (ds.Tables[0].Rows[0]["updateOn"].ToString() != "")
                {
                    this.updateOn = DateTime.Parse(ds.Tables[0].Rows[0]["updateOn"].ToString());
                }
                this.weibo_url = ds.Tables[0].Rows[0]["weibo_url"].ToString();
                this.logo_url = ds.Tables[0].Rows[0]["logo_url"].ToString();
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tb_weibo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

