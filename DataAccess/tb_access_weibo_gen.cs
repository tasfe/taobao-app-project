using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//Please add references
namespace weibo.DataAccess
{
    /// <summary>
    /// 类tb_access_weibo。
    /// </summary>
    [Serializable]
    public partial class tb_access_weibo
    {
        public tb_access_weibo()
        { }
        #region Model
        private int? _weibo_id;
        private int? _user_id;
        private string _accesskey;
        private string _accesssecret;
        private DateTime? _updateon;
        private DateTime? _lastoperateon;
        private int? _day_send;
        private string _weibo_name;
        private string _weibo_url;
        private string _accesstoken;
        private int? _expiresin;
        private string _sinauid;
        private DateTime? _accesstokenexpires;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int? weibo_id
        {
            set { _weibo_id = value; }
            get { return _weibo_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string accesskey
        {
            set { _accesskey = value; }
            get { return _accesskey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string accesssecret
        {
            set { _accesssecret = value; }
            get { return _accesssecret; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? updateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? lastOperateOn
        {
            set { _lastoperateon = value; }
            get { return _lastoperateon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? day_send
        {
            set { _day_send = value; }
            get { return _day_send; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_name
        {
            set { _weibo_name = value; }
            get { return _weibo_name; }
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
        public string AccessToken
        {
            set { _accesstoken = value; }
            get { return _accesstoken; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ExpiresIn
        {
            set { _expiresin = value; }
            get { return _expiresin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SinaUID
        {
            set { _sinauid = value; }
            get { return _sinauid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AccessTokenExpires
        {
            set { _accesstokenexpires = value; }
            get { return _accesstokenexpires; }
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


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_access_weibo(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select weibo_id,user_id,accesskey,accesssecret,updateOn,lastOperateOn,day_send,weibo_name,weibo_url,AccessToken,ExpiresIn,SinaUID,AccessTokenExpires,ID ");
            strSql.Append(" FROM [tb_access_weibo] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tb_access_weibo]");
            strSql.Append(" where ID=@ID ");

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
            strSql.Append("insert into [tb_access_weibo] (");
            strSql.Append("weibo_id,user_id,accesskey,accesssecret,updateOn,lastOperateOn,day_send,weibo_name,weibo_url,AccessToken,ExpiresIn,SinaUID,AccessTokenExpires)");
            strSql.Append(" values (");
            strSql.Append("@weibo_id,@user_id,@accesskey,@accesssecret,@updateOn,@lastOperateOn,@day_send,@weibo_name,@weibo_url,@AccessToken,@ExpiresIn,@SinaUID,@AccessTokenExpires)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@weibo_id", OleDbType.Integer,4),
					new OleDbParameter("@user_id", OleDbType.Integer,4),
					new OleDbParameter("@accesskey", OleDbType.VarChar,255),
					new OleDbParameter("@accesssecret", OleDbType.VarChar,255),
					new OleDbParameter("@updateOn", OleDbType.Date),
					new OleDbParameter("@lastOperateOn", OleDbType.Date),
					new OleDbParameter("@day_send", OleDbType.Integer,4),
					new OleDbParameter("@weibo_name", OleDbType.VarChar,255),
					new OleDbParameter("@weibo_url", OleDbType.VarChar,255),
					new OleDbParameter("@AccessToken", OleDbType.VarChar,0),
					new OleDbParameter("@ExpiresIn", OleDbType.Integer,4),
					new OleDbParameter("@SinaUID", OleDbType.VarChar,255),
					new OleDbParameter("@AccessTokenExpires", OleDbType.Date)};
            parameters[0].Value = weibo_id;
            parameters[1].Value = user_id;
            parameters[2].Value = accesskey;
            parameters[3].Value = accesssecret;
            parameters[4].Value = updateOn;
            parameters[5].Value = lastOperateOn;
            parameters[6].Value = day_send;
            parameters[7].Value = weibo_name;
            parameters[8].Value = weibo_url;
            parameters[9].Value = AccessToken;
            parameters[10].Value = ExpiresIn;
            parameters[11].Value = SinaUID;
            parameters[12].Value = AccessTokenExpires;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_access_weibo] set ");
            strSql.Append("weibo_id=@weibo_id,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("accesskey=@accesskey,");
            strSql.Append("accesssecret=@accesssecret,");
            strSql.Append("updateOn=@updateOn,");
            strSql.Append("lastOperateOn=@lastOperateOn,");
            strSql.Append("day_send=@day_send,");
            strSql.Append("weibo_name=@weibo_name,");
            strSql.Append("weibo_url=@weibo_url,");
            strSql.Append("AccessToken=@AccessToken,");
            strSql.Append("ExpiresIn=@ExpiresIn,");
            strSql.Append("SinaUID=@SinaUID,");
            strSql.Append("AccessTokenExpires=@AccessTokenExpires");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@weibo_id", OleDbType.Integer,4),
					new OleDbParameter("@user_id", OleDbType.Integer,4),
					new OleDbParameter("@accesskey", OleDbType.VarChar,255),
					new OleDbParameter("@accesssecret", OleDbType.VarChar,255),
					new OleDbParameter("@updateOn", OleDbType.Date),
					new OleDbParameter("@lastOperateOn", OleDbType.Date),
					new OleDbParameter("@day_send", OleDbType.Integer,4),
					new OleDbParameter("@weibo_name", OleDbType.VarChar,255),
					new OleDbParameter("@weibo_url", OleDbType.VarChar,255),
					new OleDbParameter("@AccessToken", OleDbType.VarChar,0),
					new OleDbParameter("@ExpiresIn", OleDbType.Integer,4),
					new OleDbParameter("@SinaUID", OleDbType.VarChar,255),
					new OleDbParameter("@AccessTokenExpires", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = weibo_id;
            parameters[1].Value = user_id;
            parameters[2].Value = accesskey;
            parameters[3].Value = accesssecret;
            parameters[4].Value = updateOn;
            parameters[5].Value = lastOperateOn;
            parameters[6].Value = day_send;
            parameters[7].Value = weibo_name;
            parameters[8].Value = weibo_url;
            parameters[9].Value = AccessToken;
            parameters[10].Value = ExpiresIn;
            parameters[11].Value = SinaUID;
            parameters[12].Value = AccessTokenExpires;
            parameters[13].Value = ID;

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

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tb_access_weibo] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select weibo_id,user_id,accesskey,accesssecret,updateOn,lastOperateOn,day_send,weibo_name,weibo_url,AccessToken,ExpiresIn,SinaUID,AccessTokenExpires,ID ");
            strSql.Append(" FROM [tb_access_weibo] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

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
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tb_access_weibo] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

