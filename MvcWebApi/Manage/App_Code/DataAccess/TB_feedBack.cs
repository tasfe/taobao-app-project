using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DataAccess
{
    /// <summary>
    /// 类tb_feedBack。
    /// </summary>
    public class tb_feedBack
    {
        public tb_feedBack()
        { }
        #region Model
        private string _name;
        private string _email;
        private string _tel;
        private string _title;
        private string _detail;
        private DateTime _updatetime;
        private string _type;
        private string _address;
        private string _company;
        private string _note;
        private int _fdid;
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
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string detail
        {
            set { _detail = value; }
            get { return _detail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime updateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
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
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company
        {
            set { _company = value; }
            get { return _company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string note
        {
            set { _note = value; }
            get { return _note; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int fdID
        {
            set { _fdid = value; }
            get { return _fdid; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_feedBack(int fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [name],[email],[tel],[title],[detail],[updateTime],[type],[address],[company],[note],[fdID] ");
            strSql.Append(" FROM tb_feedBack ");
            strSql.Append(" where [fdID]=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.Integer,4)};
            parameters[0].Value = fdID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                name = ds.Tables[0].Rows[0]["name"].ToString();
                email = ds.Tables[0].Rows[0]["email"].ToString();
                tel = ds.Tables[0].Rows[0]["tel"].ToString();
                title = ds.Tables[0].Rows[0]["title"].ToString();
                detail = ds.Tables[0].Rows[0]["detail"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                type = ds.Tables[0].Rows[0]["type"].ToString();
                address = ds.Tables[0].Rows[0]["address"].ToString();
                company = ds.Tables[0].Rows[0]["company"].ToString();
                note = ds.Tables[0].Rows[0]["note"].ToString();
                if (ds.Tables[0].Rows[0]["fdID"].ToString() != "")
                {
                    fdID = int.Parse(ds.Tables[0].Rows[0]["fdID"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_feedBack");
            strSql.Append(" where [fdID]=@fdID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.Integer,4)};
            parameters[0].Value = fdID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_feedBack(");
            strSql.Append("[name],[email],[tel],[title],[detail],[updateTime],[type],[address],[company],[note])");
            strSql.Append(" values (");
            strSql.Append("@name,@email,@tel,@title,@detail,@updateTime,@type,@address,@company,@note)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@name", OleDbType.VarChar,50),
					new OleDbParameter("@email", OleDbType.VarChar,50),
					new OleDbParameter("@tel", OleDbType.VarChar,50),
					new OleDbParameter("@title", OleDbType.VarChar,50),
					new OleDbParameter("@detail", OleDbType.VarChar,0),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@type", OleDbType.VarChar,50),
					new OleDbParameter("@address", OleDbType.VarChar,0),
					new OleDbParameter("@company", OleDbType.VarChar,50),
					new OleDbParameter("@note", OleDbType.VarChar,0)};
            parameters[0].Value = name;
            parameters[1].Value = email;
            parameters[2].Value = tel;
            parameters[3].Value = title;
            parameters[4].Value = detail;
            parameters[5].Value = updateTime;
            parameters[6].Value = type;
            parameters[7].Value = address;
            parameters[8].Value = company;
            parameters[9].Value = note;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_feedBack] set ");
            strSql.Append("[name]=@name,");
            strSql.Append("[email]=@email,");
            strSql.Append("[tel]=@tel,");
            strSql.Append("[title]=@title,");
            strSql.Append("[detail]=@detail,");
            strSql.Append("[updateTime]=@updateTime,");
            strSql.Append("[type]=@type,");
            strSql.Append("[address]=@address,");
            strSql.Append("[company]=@company,");
            strSql.Append("[note]=@note");
            strSql.Append(" where [fdID]=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@name", OleDbType.VarChar,50),
					new OleDbParameter("@email", OleDbType.VarChar,50),
					new OleDbParameter("@tel", OleDbType.VarChar,50),
					new OleDbParameter("@title", OleDbType.VarChar,50),
					new OleDbParameter("@detail", OleDbType.VarChar,0),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@type", OleDbType.VarChar,50),
					new OleDbParameter("@address", OleDbType.VarChar,0),
					new OleDbParameter("@company", OleDbType.VarChar,50),
					new OleDbParameter("@note", OleDbType.VarChar,0),
					new OleDbParameter("@fdID", OleDbType.Integer,4)};
            parameters[0].Value = name;
            parameters[1].Value = email;
            parameters[2].Value = tel;
            parameters[3].Value = title;
            parameters[4].Value = detail;
            parameters[5].Value = updateTime;
            parameters[6].Value = type;
            parameters[7].Value = address;
            parameters[8].Value = company;
            parameters[9].Value = note;
            parameters[10].Value = fdID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_feedBack ");
            strSql.Append(" where [fdID]=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.Integer,4)};
            parameters[0].Value = fdID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int fdID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [name],[email],[tel],[title],[detail],[updateTime],[type],[address],[company],[note],[fdID] ");
            strSql.Append(" FROM tb_feedBack ");
            strSql.Append(" where [fdID]=@fdID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@fdID", OleDbType.Integer,4)};
            parameters[0].Value = fdID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.name = ds.Tables[0].Rows[0]["name"].ToString();
                this.email = ds.Tables[0].Rows[0]["email"].ToString();
                this.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                this.title = ds.Tables[0].Rows[0]["title"].ToString();
                this.detail = ds.Tables[0].Rows[0]["detail"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    this.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                this.type = ds.Tables[0].Rows[0]["type"].ToString();
                this.address = ds.Tables[0].Rows[0]["address"].ToString();
                this.company = ds.Tables[0].Rows[0]["company"].ToString();
                this.note = ds.Tables[0].Rows[0]["note"].ToString();
                if (ds.Tables[0].Rows[0]["fdID"].ToString() != "")
                {
                    this.fdID = int.Parse(ds.Tables[0].Rows[0]["fdID"].ToString());
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
            strSql.Append(" FROM tb_feedBack ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

