using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DAL
{
    /// <summary>
    /// 类TB_Company。
    /// </summary>
    [Serializable]
    public partial class TB_Company
    {
        public TB_Company()
        { }
        #region Model
        private string _id;
        private string _username;
        private string _zzzz;
        private string _qyzz;
        private string _qyyz;
        private string _xmjl;
        private string _xmjldj;
        private string _xmjlyj;
        private string _wdy;
        private string _bzxx;
        private string _gcmc;
        private DateTime? _adddate;
        private int? _gcid = 0;
        private string _flownum;
        private int? _member_id;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zzzz
        {
            set { _zzzz = value; }
            get { return _zzzz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qyzz
        {
            set { _qyzz = value; }
            get { return _qyzz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qyyz
        {
            set { _qyyz = value; }
            get { return _qyyz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xmjl
        {
            set { _xmjl = value; }
            get { return _xmjl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xmjldj
        {
            set { _xmjldj = value; }
            get { return _xmjldj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string xmjlyj
        {
            set { _xmjlyj = value; }
            get { return _xmjlyj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string wdy
        {
            set { _wdy = value; }
            get { return _wdy; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bzxx
        {
            set { _bzxx = value; }
            get { return _bzxx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gcmc
        {
            set { _gcmc = value; }
            get { return _gcmc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? gcID
        {
            set { _gcid = value; }
            get { return _gcid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FlowNum
        {
            set { _flownum = value; }
            get { return _flownum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MEMBER_ID
        {
            set { _member_id = value; }
            get { return _member_id; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_Company(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,username,zzzz,qyzz,qyyz,xmjl,xmjldj,xmjlyj,wdy,bzxx,gcmc,AddDate,gcID,FlowNum,MEMBER_ID ");
            strSql.Append(" FROM [TB_Company] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar,50)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = ds.Tables[0].Rows[0]["ID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["username"] != null && ds.Tables[0].Rows[0]["username"].ToString() != "")
                {
                    this.username = ds.Tables[0].Rows[0]["username"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zzzz"] != null && ds.Tables[0].Rows[0]["zzzz"].ToString() != "")
                {
                    this.zzzz = ds.Tables[0].Rows[0]["zzzz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qyzz"] != null && ds.Tables[0].Rows[0]["qyzz"].ToString() != "")
                {
                    this.qyzz = ds.Tables[0].Rows[0]["qyzz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qyyz"] != null && ds.Tables[0].Rows[0]["qyyz"].ToString() != "")
                {
                    this.qyyz = ds.Tables[0].Rows[0]["qyyz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjl"] != null && ds.Tables[0].Rows[0]["xmjl"].ToString() != "")
                {
                    this.xmjl = ds.Tables[0].Rows[0]["xmjl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjldj"] != null && ds.Tables[0].Rows[0]["xmjldj"].ToString() != "")
                {
                    this.xmjldj = ds.Tables[0].Rows[0]["xmjldj"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjlyj"] != null && ds.Tables[0].Rows[0]["xmjlyj"].ToString() != "")
                {
                    this.xmjlyj = ds.Tables[0].Rows[0]["xmjlyj"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wdy"] != null && ds.Tables[0].Rows[0]["wdy"].ToString() != "")
                {
                    this.wdy = ds.Tables[0].Rows[0]["wdy"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bzxx"] != null && ds.Tables[0].Rows[0]["bzxx"].ToString() != "")
                {
                    this.bzxx = ds.Tables[0].Rows[0]["bzxx"].ToString();
                }
                if (ds.Tables[0].Rows[0]["gcmc"] != null && ds.Tables[0].Rows[0]["gcmc"].ToString() != "")
                {
                    this.gcmc = ds.Tables[0].Rows[0]["gcmc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AddDate"] != null && ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    this.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gcID"] != null && ds.Tables[0].Rows[0]["gcID"].ToString() != "")
                {
                    this.gcID = int.Parse(ds.Tables[0].Rows[0]["gcID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FlowNum"] != null && ds.Tables[0].Rows[0]["FlowNum"].ToString() != "")
                {
                    this.FlowNum = ds.Tables[0].Rows[0]["FlowNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_ID"] != null && ds.Tables[0].Rows[0]["MEMBER_ID"].ToString() != "")
                {
                    this.MEMBER_ID = int.Parse(ds.Tables[0].Rows[0]["MEMBER_ID"].ToString());
                }
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [TB_Company]");
            strSql.Append(" where ID=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar,50)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [TB_Company] (");
            strSql.Append("ID,username,zzzz,qyzz,qyyz,xmjl,xmjldj,xmjlyj,wdy,bzxx,gcmc,AddDate,gcID,FlowNum,MEMBER_ID)");
            strSql.Append(" values (");
            strSql.Append("@ID,@username,@zzzz,@qyzz,@qyyz,@xmjl,@xmjldj,@xmjlyj,@wdy,@bzxx,@gcmc,@AddDate,@gcID,@FlowNum,@MEMBER_ID)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar,50),
					new OleDbParameter("@username", OleDbType.VarChar,0),
					new OleDbParameter("@zzzz", OleDbType.VarChar,0),
					new OleDbParameter("@qyzz", OleDbType.VarChar,0),
					new OleDbParameter("@qyyz", OleDbType.VarChar,0),
					new OleDbParameter("@xmjl", OleDbType.VarChar,0),
					new OleDbParameter("@xmjldj", OleDbType.VarChar,0),
					new OleDbParameter("@xmjlyj", OleDbType.VarChar,0),
					new OleDbParameter("@wdy", OleDbType.VarChar,0),
					new OleDbParameter("@bzxx", OleDbType.VarChar,0),
					new OleDbParameter("@gcmc", OleDbType.VarChar,0),
					new OleDbParameter("@AddDate", OleDbType.Date),
					new OleDbParameter("@gcID", OleDbType.Integer,4),
					new OleDbParameter("@FlowNum", OleDbType.VarChar,50),
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;
            parameters[1].Value = username;
            parameters[2].Value = zzzz;
            parameters[3].Value = qyzz;
            parameters[4].Value = qyyz;
            parameters[5].Value = xmjl;
            parameters[6].Value = xmjldj;
            parameters[7].Value = xmjlyj;
            parameters[8].Value = wdy;
            parameters[9].Value = bzxx;
            parameters[10].Value = gcmc;
            parameters[11].Value = AddDate;
            parameters[12].Value = gcID;
            parameters[13].Value = FlowNum;
            parameters[14].Value = MEMBER_ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_Company] set ");
            strSql.Append("username=@username,");
            strSql.Append("zzzz=@zzzz,");
            strSql.Append("qyzz=@qyzz,");
            strSql.Append("qyyz=@qyyz,");
            strSql.Append("xmjl=@xmjl,");
            strSql.Append("xmjldj=@xmjldj,");
            strSql.Append("xmjlyj=@xmjlyj,");
            strSql.Append("wdy=@wdy,");
            strSql.Append("bzxx=@bzxx,");
            strSql.Append("gcmc=@gcmc,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("gcID=@gcID,");
            strSql.Append("FlowNum=@FlowNum,");
            strSql.Append("MEMBER_ID=@MEMBER_ID");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@username", OleDbType.VarChar,0),
					new OleDbParameter("@zzzz", OleDbType.VarChar,0),
					new OleDbParameter("@qyzz", OleDbType.VarChar,0),
					new OleDbParameter("@qyyz", OleDbType.VarChar,0),
					new OleDbParameter("@xmjl", OleDbType.VarChar,0),
					new OleDbParameter("@xmjldj", OleDbType.VarChar,0),
					new OleDbParameter("@xmjlyj", OleDbType.VarChar,0),
					new OleDbParameter("@wdy", OleDbType.VarChar,0),
					new OleDbParameter("@bzxx", OleDbType.VarChar,0),
					new OleDbParameter("@gcmc", OleDbType.VarChar,0),
					new OleDbParameter("@AddDate", OleDbType.Date),
					new OleDbParameter("@gcID", OleDbType.Integer,4),
					new OleDbParameter("@FlowNum", OleDbType.VarChar,50),
					new OleDbParameter("@MEMBER_ID", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.VarChar,50)};
            parameters[0].Value = username;
            parameters[1].Value = zzzz;
            parameters[2].Value = qyzz;
            parameters[3].Value = qyyz;
            parameters[4].Value = xmjl;
            parameters[5].Value = xmjldj;
            parameters[6].Value = xmjlyj;
            parameters[7].Value = wdy;
            parameters[8].Value = bzxx;
            parameters[9].Value = gcmc;
            parameters[10].Value = AddDate;
            parameters[11].Value = gcID;
            parameters[12].Value = FlowNum;
            parameters[13].Value = MEMBER_ID;
            parameters[14].Value = ID;

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
        public bool Delete(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [TB_Company] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar,50)};
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
        public void GetModel(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,username,zzzz,qyzz,qyyz,xmjl,xmjldj,xmjlyj,wdy,bzxx,gcmc,AddDate,gcID,FlowNum,MEMBER_ID ");
            strSql.Append(" FROM [TB_Company] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.VarChar,50)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = ds.Tables[0].Rows[0]["ID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["username"] != null && ds.Tables[0].Rows[0]["username"].ToString() != "")
                {
                    this.username = ds.Tables[0].Rows[0]["username"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zzzz"] != null && ds.Tables[0].Rows[0]["zzzz"].ToString() != "")
                {
                    this.zzzz = ds.Tables[0].Rows[0]["zzzz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qyzz"] != null && ds.Tables[0].Rows[0]["qyzz"].ToString() != "")
                {
                    this.qyzz = ds.Tables[0].Rows[0]["qyzz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["qyyz"] != null && ds.Tables[0].Rows[0]["qyyz"].ToString() != "")
                {
                    this.qyyz = ds.Tables[0].Rows[0]["qyyz"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjl"] != null && ds.Tables[0].Rows[0]["xmjl"].ToString() != "")
                {
                    this.xmjl = ds.Tables[0].Rows[0]["xmjl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjldj"] != null && ds.Tables[0].Rows[0]["xmjldj"].ToString() != "")
                {
                    this.xmjldj = ds.Tables[0].Rows[0]["xmjldj"].ToString();
                }
                if (ds.Tables[0].Rows[0]["xmjlyj"] != null && ds.Tables[0].Rows[0]["xmjlyj"].ToString() != "")
                {
                    this.xmjlyj = ds.Tables[0].Rows[0]["xmjlyj"].ToString();
                }
                if (ds.Tables[0].Rows[0]["wdy"] != null && ds.Tables[0].Rows[0]["wdy"].ToString() != "")
                {
                    this.wdy = ds.Tables[0].Rows[0]["wdy"].ToString();
                }
                if (ds.Tables[0].Rows[0]["bzxx"] != null && ds.Tables[0].Rows[0]["bzxx"].ToString() != "")
                {
                    this.bzxx = ds.Tables[0].Rows[0]["bzxx"].ToString();
                }
                if (ds.Tables[0].Rows[0]["gcmc"] != null && ds.Tables[0].Rows[0]["gcmc"].ToString() != "")
                {
                    this.gcmc = ds.Tables[0].Rows[0]["gcmc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["AddDate"] != null && ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    this.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["gcID"] != null && ds.Tables[0].Rows[0]["gcID"].ToString() != "")
                {
                    this.gcID = int.Parse(ds.Tables[0].Rows[0]["gcID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FlowNum"] != null && ds.Tables[0].Rows[0]["FlowNum"].ToString() != "")
                {
                    this.FlowNum = ds.Tables[0].Rows[0]["FlowNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MEMBER_ID"] != null && ds.Tables[0].Rows[0]["MEMBER_ID"].ToString() != "")
                {
                    this.MEMBER_ID = int.Parse(ds.Tables[0].Rows[0]["MEMBER_ID"].ToString());
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
            strSql.Append(" FROM [TB_Company] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

