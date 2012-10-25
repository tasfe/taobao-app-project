using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DataAccess
{
    /// <summary>
    /// 类TB_Project。
    /// </summary>
    [Serializable]
    public partial class TB_Project
    {
        public TB_Project()
        { }
        #region Model
        private string _gcname;
        private DateTime _datestart;
        private DateTime _dateend;
        private int? _formid = 0;
        private string _classname;
        private string _detail;
        private string _project_protype;
        private string _check_type;
        private string _send_type;
        private DateTime? _update_on;
        private string _tb_member;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string gcname
        {
            set { _gcname = value; }
            get { return _gcname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime datestart
        {
            set { _datestart = value; }
            get { return _datestart; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime dateend
        {
            set { _dateend = value; }
            get { return _dateend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? FormID
        {
            set { _formid = value; }
            get { return _formid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassName
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Detail
        {
            set { _detail = value; }
            get { return _detail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROJECT_PROTYPE
        {
            set { _project_protype = value; }
            get { return _project_protype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_TYPE
        {
            set { _check_type = value; }
            get { return _check_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SEND_TYPE
        {
            set { _send_type = value; }
            get { return _send_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATE_ON
        {
            set { _update_on = value; }
            get { return _update_on; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TB_MEMBER
        {
            set { _tb_member = value; }
            get { return _tb_member; }
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
        public TB_Project(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select gcname,datestart,dateend,FormID,ClassName,Detail,PROJECT_PROTYPE,CHECK_TYPE,SEND_TYPE,UPDATE_ON,TB_MEMBER,ID ");
            strSql.Append(" FROM [TB_Project] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["gcname"] != null && ds.Tables[0].Rows[0]["gcname"].ToString() != "")
                {
                    this.gcname = ds.Tables[0].Rows[0]["gcname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["datestart"] != null && ds.Tables[0].Rows[0]["datestart"].ToString() != "")
                {
                    this.datestart = DateTime.Parse(ds.Tables[0].Rows[0]["datestart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dateend"] != null && ds.Tables[0].Rows[0]["dateend"].ToString() != "")
                {
                    this.dateend = DateTime.Parse(ds.Tables[0].Rows[0]["dateend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FormID"] != null && ds.Tables[0].Rows[0]["FormID"].ToString() != "")
                {
                    this.FormID = int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassName"] != null && ds.Tables[0].Rows[0]["ClassName"].ToString() != "")
                {
                    this.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Detail"] != null && ds.Tables[0].Rows[0]["Detail"].ToString() != "")
                {
                    this.Detail = ds.Tables[0].Rows[0]["Detail"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PROJECT_PROTYPE"] != null && ds.Tables[0].Rows[0]["PROJECT_PROTYPE"].ToString() != "")
                {
                    this.PROJECT_PROTYPE = ds.Tables[0].Rows[0]["PROJECT_PROTYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CHECK_TYPE"] != null && ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString() != "")
                {
                    this.CHECK_TYPE = ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SEND_TYPE"] != null && ds.Tables[0].Rows[0]["SEND_TYPE"].ToString() != "")
                {
                    this.SEND_TYPE = ds.Tables[0].Rows[0]["SEND_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TB_MEMBER"] != null && ds.Tables[0].Rows[0]["TB_MEMBER"].ToString() != "")
                {
                    this.TB_MEMBER = ds.Tables[0].Rows[0]["TB_MEMBER"].ToString();
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
            strSql.Append("select count(1) from [TB_Project]");
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
            strSql.Append("insert into [TB_Project] (");
            strSql.Append("gcname,datestart,dateend,FormID,ClassName,Detail,PROJECT_PROTYPE,CHECK_TYPE,SEND_TYPE,UPDATE_ON,TB_MEMBER)");
            strSql.Append(" values (");
            strSql.Append("@gcname,@datestart,@dateend,@FormID,@ClassName,@Detail,@PROJECT_PROTYPE,@CHECK_TYPE,@SEND_TYPE,@UPDATE_ON,@TB_MEMBER)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@gcname", OleDbType.VarChar,50),
					new OleDbParameter("@datestart", OleDbType.Date),
					new OleDbParameter("@dateend", OleDbType.Date),
					new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ClassName", OleDbType.VarChar,50),
					new OleDbParameter("@Detail", OleDbType.VarChar,0),
					new OleDbParameter("@PROJECT_PROTYPE", OleDbType.VarChar,255),
					new OleDbParameter("@CHECK_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@SEND_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@TB_MEMBER", OleDbType.VarChar,0)};
            parameters[0].Value = gcname;
            parameters[1].Value = datestart;
            parameters[2].Value = dateend;
            parameters[3].Value = FormID;
            parameters[4].Value = ClassName;
            parameters[5].Value = Detail;
            parameters[6].Value = PROJECT_PROTYPE;
            parameters[7].Value = CHECK_TYPE;
            parameters[8].Value = SEND_TYPE;
            parameters[9].Value = UPDATE_ON;
            parameters[10].Value = TB_MEMBER;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_Project] set ");
            strSql.Append("gcname=@gcname,");
            strSql.Append("datestart=@datestart,");
            strSql.Append("dateend=@dateend,");
            strSql.Append("FormID=@FormID,");
            strSql.Append("ClassName=@ClassName,");
            strSql.Append("Detail=@Detail,");
            strSql.Append("PROJECT_PROTYPE=@PROJECT_PROTYPE,");
            strSql.Append("CHECK_TYPE=@CHECK_TYPE,");
            strSql.Append("SEND_TYPE=@SEND_TYPE,");
            strSql.Append("UPDATE_ON=@UPDATE_ON,");
            strSql.Append("TB_MEMBER=@TB_MEMBER");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@gcname", OleDbType.VarChar,50),
					new OleDbParameter("@datestart", OleDbType.Date),
					new OleDbParameter("@dateend", OleDbType.Date),
					new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ClassName", OleDbType.VarChar,50),
					new OleDbParameter("@Detail", OleDbType.VarChar,0),
					new OleDbParameter("@PROJECT_PROTYPE", OleDbType.VarChar,255),
					new OleDbParameter("@CHECK_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@SEND_TYPE", OleDbType.VarChar,255),
					new OleDbParameter("@UPDATE_ON", OleDbType.Date),
					new OleDbParameter("@TB_MEMBER", OleDbType.VarChar,0),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = gcname;
            parameters[1].Value = datestart;
            parameters[2].Value = dateend;
            parameters[3].Value = FormID;
            parameters[4].Value = ClassName;
            parameters[5].Value = Detail;
            parameters[6].Value = PROJECT_PROTYPE;
            parameters[7].Value = CHECK_TYPE;
            parameters[8].Value = SEND_TYPE;
            parameters[9].Value = UPDATE_ON;
            parameters[10].Value = TB_MEMBER;
            parameters[11].Value = ID;

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
            strSql.Append("delete from [TB_Project] ");
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
            strSql.Append("select gcname,datestart,dateend,FormID,ClassName,Detail,PROJECT_PROTYPE,CHECK_TYPE,SEND_TYPE,UPDATE_ON,TB_MEMBER,ID ");
            strSql.Append(" FROM [TB_Project] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["gcname"] != null && ds.Tables[0].Rows[0]["gcname"].ToString() != "")
                {
                    this.gcname = ds.Tables[0].Rows[0]["gcname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["datestart"] != null && ds.Tables[0].Rows[0]["datestart"].ToString() != "")
                {
                    this.datestart = DateTime.Parse(ds.Tables[0].Rows[0]["datestart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dateend"] != null && ds.Tables[0].Rows[0]["dateend"].ToString() != "")
                {
                    this.dateend = DateTime.Parse(ds.Tables[0].Rows[0]["dateend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FormID"] != null && ds.Tables[0].Rows[0]["FormID"].ToString() != "")
                {
                    this.FormID = int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassName"] != null && ds.Tables[0].Rows[0]["ClassName"].ToString() != "")
                {
                    this.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Detail"] != null && ds.Tables[0].Rows[0]["Detail"].ToString() != "")
                {
                    this.Detail = ds.Tables[0].Rows[0]["Detail"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PROJECT_PROTYPE"] != null && ds.Tables[0].Rows[0]["PROJECT_PROTYPE"].ToString() != "")
                {
                    this.PROJECT_PROTYPE = ds.Tables[0].Rows[0]["PROJECT_PROTYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CHECK_TYPE"] != null && ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString() != "")
                {
                    this.CHECK_TYPE = ds.Tables[0].Rows[0]["CHECK_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SEND_TYPE"] != null && ds.Tables[0].Rows[0]["SEND_TYPE"].ToString() != "")
                {
                    this.SEND_TYPE = ds.Tables[0].Rows[0]["SEND_TYPE"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UPDATE_ON"] != null && ds.Tables[0].Rows[0]["UPDATE_ON"].ToString() != "")
                {
                    this.UPDATE_ON = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATE_ON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TB_MEMBER"] != null && ds.Tables[0].Rows[0]["TB_MEMBER"].ToString() != "")
                {
                    this.TB_MEMBER = ds.Tables[0].Rows[0]["TB_MEMBER"].ToString();
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
            strSql.Append(" FROM [TB_Project] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

