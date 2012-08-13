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
        public tb_weibo_template()
        { }
        #region Model
        private string _template;
        private int _type;
        private int _user_id;
        private DateTime _update_on;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string template
        {
            set { _template = value; }
            get { return _template; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime update_on
        {
            set { _update_on = value; }
            get { return _update_on; }
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
        public tb_weibo_template(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [template],[type],[user_id],[update_on],[ID] ");
            strSql.Append(" FROM tb_weibo_template ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                template = ds.Tables[0].Rows[0]["template"].ToString();
                if (ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["update_on"].ToString() != "")
                {
                    update_on = DateTime.Parse(ds.Tables[0].Rows[0]["update_on"].ToString());
                }
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
            strSql.Append("select count(1) from tb_weibo_template");
            strSql.Append(" where [ID]=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_weibo_template(");
            strSql.Append("[template],[type],[user_id],[update_on])");
            strSql.Append(" values (");
            strSql.Append("@template,@type,@user_id,@update_on)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@template", OleDbType.VarChar,0),
					new OleDbParameter("@type", OleDbType.Integer,4),
					new OleDbParameter("@user_id", OleDbType.Integer,4),
					new OleDbParameter("@update_on", OleDbType.Date)};
            parameters[0].Value = template;
            parameters[1].Value = type;
            parameters[2].Value = user_id;
            parameters[3].Value = update_on;

            return int.Parse(DbHelperSQL.ExecuteScalar(strSql.ToString(), "select @@identity as id", parameters).ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_weibo_template] set ");
            strSql.Append("[template]=@template,");
            strSql.Append("[type]=@type,");
            strSql.Append("[user_id]=@user_id,");
            strSql.Append("[update_on]=@update_on");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@template", OleDbType.VarChar,0),
					new OleDbParameter("@type", OleDbType.Integer,4),
					new OleDbParameter("@user_id", OleDbType.Integer,4),
					new OleDbParameter("@update_on", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = template;
            parameters[1].Value = type;
            parameters[2].Value = user_id;
            parameters[3].Value = update_on;
            parameters[4].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_weibo_template ");
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
            strSql.Append("select [template],[type],[user_id],[update_on],[ID] ");
            strSql.Append(" FROM tb_weibo_template ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.template = ds.Tables[0].Rows[0]["template"].ToString();
                if (ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = int.Parse(ds.Tables[0].Rows[0]["type"].ToString());
                }
                if (ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    this.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["update_on"].ToString() != "")
                {
                    this.update_on = DateTime.Parse(ds.Tables[0].Rows[0]["update_on"].ToString());
                }
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
            strSql.Append(" FROM tb_weibo_template ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得系统和个人模版
        /// </summary>
        public DataTable GetTemplate(int userID)
        {
            string filter = " type=1 or user_id=" + userID;
            return GetList(filter).Tables[0];
        }
        #endregion  成员方法
    }
}

