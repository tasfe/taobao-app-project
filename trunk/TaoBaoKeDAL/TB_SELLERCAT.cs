using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//Please add references
namespace Taobaoke.DAL
{
    /// <summary>
    /// 类TB_SELLERCAT。
    /// </summary>
    [Serializable]
    public partial class TB_SELLERCAT
    {
        public TB_SELLERCAT()
        { }
        #region Model
        private string _cid;
        private string _name;
        private string _parent_cid;
        private string _pic_url;
        private string _type;
        private string _nick;
        private int? _sort_order;
        private DateTime? _updateon;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string cid
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string parent_cid
        {
            set { _parent_cid = value; }
            get { return _parent_cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pic_url
        {
            set { _pic_url = value; }
            get { return _pic_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nick
        {
            set { _nick = value; }
            get { return _nick; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? sort_order
        {
            set { _sort_order = value; }
            get { return _sort_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateON
        {
            set { _updateon = value; }
            get { return _updateon; }
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
        public TB_SELLERCAT(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cid,name,parent_cid,pic_url,type,nick,sort_order,UpdateON,ID ");
            strSql.Append(" FROM [TB_SELLERCAT] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["cid"] != null && ds.Tables[0].Rows[0]["cid"].ToString() != "")
                {
                    this.cid = ds.Tables[0].Rows[0]["cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null && ds.Tables[0].Rows[0]["name"].ToString() != "")
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["parent_cid"] != null && ds.Tables[0].Rows[0]["parent_cid"].ToString() != "")
                {
                    this.parent_cid = ds.Tables[0].Rows[0]["parent_cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pic_url"] != null && ds.Tables[0].Rows[0]["pic_url"].ToString() != "")
                {
                    this.pic_url = ds.Tables[0].Rows[0]["pic_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["nick"] != null && ds.Tables[0].Rows[0]["nick"].ToString() != "")
                {
                    this.nick = ds.Tables[0].Rows[0]["nick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_order"] != null && ds.Tables[0].Rows[0]["sort_order"].ToString() != "")
                {
                    this.sort_order = int.Parse(ds.Tables[0].Rows[0]["sort_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpdateON"] != null && ds.Tables[0].Rows[0]["UpdateON"].ToString() != "")
                {
                    this.UpdateON = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateON"].ToString());
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
            strSql.Append("select count(1) from [TB_SELLERCAT]");
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
            strSql.Append("insert into [TB_SELLERCAT] (");
            strSql.Append("cid,name,parent_cid,pic_url,type,nick,sort_order,UpdateON)");
            strSql.Append(" values (");
            strSql.Append("@cid,@name,@parent_cid,@pic_url,@type,@nick,@sort_order,@UpdateON)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@cid", OleDbType.VarChar,255),
					new OleDbParameter("@name", OleDbType.VarChar,255),
					new OleDbParameter("@parent_cid", OleDbType.VarChar,255),
					new OleDbParameter("@pic_url", OleDbType.VarChar,255),
					new OleDbParameter("@type", OleDbType.VarChar,255),
					new OleDbParameter("@nick", OleDbType.VarChar,255),
					new OleDbParameter("@sort_order", OleDbType.Integer,4),
					new OleDbParameter("@UpdateON", OleDbType.Date)};
            parameters[0].Value = cid;
            parameters[1].Value = name;
            parameters[2].Value = parent_cid;
            parameters[3].Value = pic_url;
            parameters[4].Value = type;
            parameters[5].Value = nick;
            parameters[6].Value = sort_order;
            parameters[7].Value = UpdateON;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_SELLERCAT] set ");
            strSql.Append("cid=@cid,");
            strSql.Append("name=@name,");
            strSql.Append("parent_cid=@parent_cid,");
            strSql.Append("pic_url=@pic_url,");
            strSql.Append("type=@type,");
            strSql.Append("nick=@nick,");
            strSql.Append("sort_order=@sort_order,");
            strSql.Append("UpdateON=@UpdateON");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@cid", OleDbType.VarChar,255),
					new OleDbParameter("@name", OleDbType.VarChar,255),
					new OleDbParameter("@parent_cid", OleDbType.VarChar,255),
					new OleDbParameter("@pic_url", OleDbType.VarChar,255),
					new OleDbParameter("@type", OleDbType.VarChar,255),
					new OleDbParameter("@nick", OleDbType.VarChar,255),
					new OleDbParameter("@sort_order", OleDbType.Integer,4),
					new OleDbParameter("@UpdateON", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = cid;
            parameters[1].Value = name;
            parameters[2].Value = parent_cid;
            parameters[3].Value = pic_url;
            parameters[4].Value = type;
            parameters[5].Value = nick;
            parameters[6].Value = sort_order;
            parameters[7].Value = UpdateON;
            parameters[8].Value = ID;

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
            strSql.Append("delete from [TB_SELLERCAT] ");
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
            strSql.Append("select cid,name,parent_cid,pic_url,type,nick,sort_order,UpdateON,ID ");
            strSql.Append(" FROM [TB_SELLERCAT] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["cid"] != null && ds.Tables[0].Rows[0]["cid"].ToString() != "")
                {
                    this.cid = ds.Tables[0].Rows[0]["cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null && ds.Tables[0].Rows[0]["name"].ToString() != "")
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["parent_cid"] != null && ds.Tables[0].Rows[0]["parent_cid"].ToString() != "")
                {
                    this.parent_cid = ds.Tables[0].Rows[0]["parent_cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pic_url"] != null && ds.Tables[0].Rows[0]["pic_url"].ToString() != "")
                {
                    this.pic_url = ds.Tables[0].Rows[0]["pic_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["nick"] != null && ds.Tables[0].Rows[0]["nick"].ToString() != "")
                {
                    this.nick = ds.Tables[0].Rows[0]["nick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_order"] != null && ds.Tables[0].Rows[0]["sort_order"].ToString() != "")
                {
                    this.sort_order = int.Parse(ds.Tables[0].Rows[0]["sort_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpdateON"] != null && ds.Tables[0].Rows[0]["UpdateON"].ToString() != "")
                {
                    this.UpdateON = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateON"].ToString());
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
            strSql.Append(" FROM [TB_SELLERCAT] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

