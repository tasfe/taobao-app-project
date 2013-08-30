using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace TaobaoApp.DataAccess
{
    /// <summary>
    /// 类tb_task。
    /// </summary>
    [Serializable]
    public partial class tb_task
    {
        public tb_task()
        { }
        #region Model
        private int _id;
        private string _taskid;
        private DateTime? _startdate;
        private DateTime? _enddate;
        private string _taobaonick;
        private string _status;
        private string _downloadurl;
        private DateTime? _updateon;
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
        public string TaskId
        {
            set { _taskid = value; }
            get { return _taskid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StartDate
        {
            set { _startdate = value; }
            get { return _startdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EndDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TaobaoNick
        {
            set { _taobaonick = value; }
            get { return _taobaonick; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DownLoadUrl
        {
            set { _downloadurl = value; }
            get { return _downloadurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_task(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TaskId,StartDate,EndDate,TaobaoNick,Status,DownLoadUrl,UpdateOn ");
            strSql.Append(" FROM [tb_task] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskId"] != null && ds.Tables[0].Rows[0]["TaskId"].ToString() != "")
                {
                    this.TaskId = ds.Tables[0].Rows[0]["TaskId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["StartDate"] != null && ds.Tables[0].Rows[0]["StartDate"].ToString() != "")
                {
                    this.StartDate = DateTime.Parse(ds.Tables[0].Rows[0]["StartDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndDate"] != null && ds.Tables[0].Rows[0]["EndDate"].ToString() != "")
                {
                    this.EndDate = DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaobaoNick"] != null && ds.Tables[0].Rows[0]["TaobaoNick"].ToString() != "")
                {
                    this.TaobaoNick = ds.Tables[0].Rows[0]["TaobaoNick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Status"] != null && ds.Tables[0].Rows[0]["Status"].ToString() != "")
                {
                    this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DownLoadUrl"] != null && ds.Tables[0].Rows[0]["DownLoadUrl"].ToString() != "")
                {
                    this.DownLoadUrl = ds.Tables[0].Rows[0]["DownLoadUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UpdateOn"] != null && ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tb_task]");
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
            strSql.Append("insert into [tb_task] (");
            strSql.Append("TaskId,StartDate,EndDate,TaobaoNick,Status,DownLoadUrl,UpdateOn)");
            strSql.Append(" values (");
            strSql.Append("@TaskId,@StartDate,@EndDate,@TaobaoNick,@Status,@DownLoadUrl,@UpdateOn)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@TaskId", OleDbType.VarChar,255),
					new OleDbParameter("@StartDate", OleDbType.Date),
					new OleDbParameter("@EndDate", OleDbType.Date),
					new OleDbParameter("@TaobaoNick", OleDbType.VarChar,255),
					new OleDbParameter("@Status", OleDbType.VarChar,255),
					new OleDbParameter("@DownLoadUrl", OleDbType.VarChar,255),
					new OleDbParameter("@UpdateOn", OleDbType.Date)};
            parameters[0].Value = TaskId;
            parameters[1].Value = StartDate;
            parameters[2].Value = EndDate;
            parameters[3].Value = TaobaoNick;
            parameters[4].Value = Status;
            parameters[5].Value = DownLoadUrl;
            parameters[6].Value = UpdateOn;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_task] set ");
            strSql.Append("TaskId=@TaskId,");
            strSql.Append("StartDate=@StartDate,");
            strSql.Append("EndDate=@EndDate,");
            strSql.Append("TaobaoNick=@TaobaoNick,");
            strSql.Append("Status=@Status,");
            strSql.Append("DownLoadUrl=@DownLoadUrl,");
            strSql.Append("UpdateOn=@UpdateOn");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@TaskId", OleDbType.VarChar,255),
					new OleDbParameter("@StartDate", OleDbType.Date),
					new OleDbParameter("@EndDate", OleDbType.Date),
					new OleDbParameter("@TaobaoNick", OleDbType.VarChar,255),
					new OleDbParameter("@Status", OleDbType.VarChar,255),
					new OleDbParameter("@DownLoadUrl", OleDbType.VarChar,255),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = TaskId;
            parameters[1].Value = StartDate;
            parameters[2].Value = EndDate;
            parameters[3].Value = TaobaoNick;
            parameters[4].Value = Status;
            parameters[5].Value = DownLoadUrl;
            parameters[6].Value = UpdateOn;
            parameters[7].Value = ID;

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
            strSql.Append("delete from [tb_task] ");
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
            strSql.Append("select ID,TaskId,StartDate,EndDate,TaobaoNick,Status,DownLoadUrl,UpdateOn ");
            strSql.Append(" FROM [tb_task] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskId"] != null && ds.Tables[0].Rows[0]["TaskId"].ToString() != "")
                {
                    this.TaskId = ds.Tables[0].Rows[0]["TaskId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["StartDate"] != null && ds.Tables[0].Rows[0]["StartDate"].ToString() != "")
                {
                    this.StartDate = DateTime.Parse(ds.Tables[0].Rows[0]["StartDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndDate"] != null && ds.Tables[0].Rows[0]["EndDate"].ToString() != "")
                {
                    this.EndDate = DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaobaoNick"] != null && ds.Tables[0].Rows[0]["TaobaoNick"].ToString() != "")
                {
                    this.TaobaoNick = ds.Tables[0].Rows[0]["TaobaoNick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Status"] != null && ds.Tables[0].Rows[0]["Status"].ToString() != "")
                {
                    this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DownLoadUrl"] != null && ds.Tables[0].Rows[0]["DownLoadUrl"].ToString() != "")
                {
                    this.DownLoadUrl = ds.Tables[0].Rows[0]["DownLoadUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UpdateOn"] != null && ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
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
            strSql.Append(" FROM [tb_task] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

