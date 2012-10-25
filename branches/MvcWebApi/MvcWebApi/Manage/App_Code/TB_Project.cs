using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DAL
{
    /// <summary>
    /// 类TB_Project。
    /// </summary>
    public class TB_Project
    {
        public TB_Project()
        { }
        #region Model
        private int _id;
        private string _gcname;
        private DateTime _datestart;
        private DateTime _dateend;
        private int _formid;
        private string _classname;
        private string _detail;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
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
        public int FormID
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
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Project");
            strSql.Append(" where ID=" + ID + " ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)				};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Project(");
            strSql.Append("gcname,datestart,dateend,FormID,ClassName,Detail)");
            strSql.Append(" values (");
            strSql.Append("@gcname,@datestart,@dateend,@FormID,@ClassName,@Detail)");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@gcname", OleDbType.VarChar,50),
					new OleDbParameter("@datestart", OleDbType.Date),
					new OleDbParameter("@dateend", OleDbType.Date),
					new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ClassName", OleDbType.VarChar,50),
					new OleDbParameter("@Detail", OleDbType.VarChar,0)};
            //parameters[0].Value = ID;
            parameters[0].Value = gcname;
            parameters[1].Value = datestart;
            parameters[2].Value = dateend;
            parameters[3].Value = FormID;
            parameters[4].Value = ClassName;
            parameters[5].Value = Detail;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Project set ");
            //strSql.Append("ID=@ID,");
            strSql.Append("gcname=@gcname,");
            strSql.Append("datestart=@datestart,");
            strSql.Append("dateend=@dateend,");
            strSql.Append("FormID=@FormID,");
            strSql.Append("ClassName=@ClassName,");
            strSql.Append("Detail=@Detail");
            strSql.Append(" where ID=" + ID + " ");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@gcname", OleDbType.VarChar,50),
					new OleDbParameter("@datestart", OleDbType.Date),
					new OleDbParameter("@dateend", OleDbType.Date),
					new OleDbParameter("@FormID", OleDbType.Integer,4),
					new OleDbParameter("@ClassName", OleDbType.VarChar,50),
					new OleDbParameter("@Detail", OleDbType.VarChar,0)};
            //parameters[0].Value = ID;
            parameters[0].Value = gcname;
            parameters[1].Value = datestart;
            parameters[2].Value = dateend;
            parameters[3].Value = FormID;
            parameters[4].Value = ClassName;
            parameters[5].Value = Detail;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Project ");
            strSql.Append(" where ID=" + ID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)				};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,gcname,datestart,dateend,FormID,ClassName,Detail ");
            strSql.Append(" FROM TB_Project ");
            strSql.Append(" where ID=" + ID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)				};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                gcname = ds.Tables[0].Rows[0]["gcname"].ToString();
                if (ds.Tables[0].Rows[0]["datestart"].ToString() != "")
                {
                    datestart = DateTime.Parse(ds.Tables[0].Rows[0]["datestart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dateend"].ToString() != "")
                {
                    dateend = DateTime.Parse(ds.Tables[0].Rows[0]["dateend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FormID"].ToString() != "")
                {
                    FormID = int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
                }
                ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                Detail = ds.Tables[0].Rows[0]["Detail"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[gcname],[datestart],[dateend],[FormID],[ClassName],[Detail] ");
            strSql.Append(" FROM TB_Project ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法

    }
}

