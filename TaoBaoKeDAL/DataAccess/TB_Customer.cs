using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//请先添加引用
namespace Shop.DataAccess
{
    /// <summary>
    /// 类TB_Customer。
    /// </summary>
    public class TB_Customer
    {
        public TB_Customer()
        { }
        #region Model
        private int _bbsuserid;
        private DateTime _startdate;
        private DateTime _enddate;
        private string _pagetitle;
        private string _pagekeywords;
        private string _pagedescription;
        private string _tbkkeys;
        private string _pagebody;
        private DateTime _updateon;
        private int _customtype;
        private string _tbk_pid;
        private string _tbk_nick;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public int BBSUserID
        {
            set { _bbsuserid = value; }
            get { return _bbsuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate
        {
            set { _startdate = value; }
            get { return _startdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageTitle
        {
            set { _pagetitle = value; }
            get { return _pagetitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageKeywords
        {
            set { _pagekeywords = value; }
            get { return _pagekeywords; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageDescription
        {
            set { _pagedescription = value; }
            get { return _pagedescription; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TBKKeys
        {
            set { _tbkkeys = value; }
            get { return _tbkkeys; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PageBody
        {
            set { _pagebody = value; }
            get { return _pagebody; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CustomType
        {
            set { _customtype = value; }
            get { return _customtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TBK_PID
        {
            set { _tbk_pid = value; }
            get { return _tbk_pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TBK_Nick
        {
            set { _tbk_nick = value; }
            get { return _tbk_nick; }
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
        public TB_Customer(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [BBSUserID],[StartDate],[EndDate],[PageTitle],[PageKeywords],[PageDescription],[TBKKeys],[PageBody],[UpdateOn],[CustomType],[TBK_PID],[TBK_Nick],[ID] ");
            strSql.Append(" FROM TB_Customer ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["BBSUserID"].ToString() != "")
                {
                    BBSUserID = int.Parse(ds.Tables[0].Rows[0]["BBSUserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StartDate"].ToString() != "")
                {
                    StartDate = DateTime.Parse(ds.Tables[0].Rows[0]["StartDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndDate"].ToString() != "")
                {
                    EndDate = DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
                }
                PageTitle = ds.Tables[0].Rows[0]["PageTitle"].ToString();
                PageKeywords = ds.Tables[0].Rows[0]["PageKeywords"].ToString();
                PageDescription = ds.Tables[0].Rows[0]["PageDescription"].ToString();
                TBKKeys = ds.Tables[0].Rows[0]["TBKKeys"].ToString();
                PageBody = ds.Tables[0].Rows[0]["PageBody"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomType"].ToString() != "")
                {
                    CustomType = int.Parse(ds.Tables[0].Rows[0]["CustomType"].ToString());
                }
                TBK_PID = ds.Tables[0].Rows[0]["TBK_PID"].ToString();
                TBK_Nick = ds.Tables[0].Rows[0]["TBK_Nick"].ToString();
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
            strSql.Append("select count(1) from TB_Customer");
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
            strSql.Append("insert into TB_Customer(");
            strSql.Append("[BBSUserID],[StartDate],[EndDate],[PageTitle],[PageKeywords],[PageDescription],[TBKKeys],[PageBody],[UpdateOn],[CustomType],[TBK_PID],[TBK_Nick])");
            strSql.Append(" values (");
            strSql.Append("@BBSUserID,@StartDate,@EndDate,@PageTitle,@PageKeywords,@PageDescription,@TBKKeys,@PageBody,@UpdateOn,@CustomType,@TBK_PID,@TBK_Nick)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@BBSUserID", OleDbType.Integer,4),
					new OleDbParameter("@StartDate", OleDbType.Date),
					new OleDbParameter("@EndDate", OleDbType.Date),
					new OleDbParameter("@PageTitle", OleDbType.VarChar,0),
					new OleDbParameter("@PageKeywords", OleDbType.VarChar,0),
					new OleDbParameter("@PageDescription", OleDbType.VarChar,0),
					new OleDbParameter("@TBKKeys", OleDbType.VarChar,0),
					new OleDbParameter("@PageBody", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@CustomType", OleDbType.Integer,4),
					new OleDbParameter("@TBK_PID", OleDbType.VarChar,255),
					new OleDbParameter("@TBK_Nick", OleDbType.VarChar,255)};
            parameters[0].Value = BBSUserID;
            parameters[1].Value = StartDate;
            parameters[2].Value = EndDate;
            parameters[3].Value = PageTitle;
            parameters[4].Value = PageKeywords;
            parameters[5].Value = PageDescription;
            parameters[6].Value = TBKKeys;
            parameters[7].Value = PageBody;
            parameters[8].Value = UpdateOn;
            parameters[9].Value = CustomType;
            parameters[10].Value = TBK_PID;
            parameters[11].Value = TBK_Nick;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_Customer] set ");
            strSql.Append("[BBSUserID]=@BBSUserID,");
            strSql.Append("[StartDate]=@StartDate,");
            strSql.Append("[EndDate]=@EndDate,");
            strSql.Append("[PageTitle]=@PageTitle,");
            strSql.Append("[PageKeywords]=@PageKeywords,");
            strSql.Append("[PageDescription]=@PageDescription,");
            strSql.Append("[TBKKeys]=@TBKKeys,");
            strSql.Append("[PageBody]=@PageBody,");
            strSql.Append("[UpdateOn]=@UpdateOn,");
            strSql.Append("[CustomType]=@CustomType,");
            strSql.Append("[TBK_PID]=@TBK_PID,");
            strSql.Append("[TBK_Nick]=@TBK_Nick");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@BBSUserID", OleDbType.Integer,4),
					new OleDbParameter("@StartDate", OleDbType.Date),
					new OleDbParameter("@EndDate", OleDbType.Date),
					new OleDbParameter("@PageTitle", OleDbType.VarChar,0),
					new OleDbParameter("@PageKeywords", OleDbType.VarChar,0),
					new OleDbParameter("@PageDescription", OleDbType.VarChar,0),
					new OleDbParameter("@TBKKeys", OleDbType.VarChar,0),
					new OleDbParameter("@PageBody", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@CustomType", OleDbType.Integer,4),
					new OleDbParameter("@TBK_PID", OleDbType.VarChar,255),
					new OleDbParameter("@TBK_Nick", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = BBSUserID;
            parameters[1].Value = StartDate;
            parameters[2].Value = EndDate;
            parameters[3].Value = PageTitle;
            parameters[4].Value = PageKeywords;
            parameters[5].Value = PageDescription;
            parameters[6].Value = TBKKeys;
            parameters[7].Value = PageBody;
            parameters[8].Value = UpdateOn;
            parameters[9].Value = CustomType;
            parameters[10].Value = TBK_PID;
            parameters[11].Value = TBK_Nick;
            parameters[12].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Customer ");
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
            strSql.Append("select [BBSUserID],[StartDate],[EndDate],[PageTitle],[PageKeywords],[PageDescription],[TBKKeys],[PageBody],[UpdateOn],[CustomType],[TBK_PID],[TBK_Nick],[ID] ");
            strSql.Append(" FROM TB_Customer ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["BBSUserID"].ToString() != "")
                {
                    this.BBSUserID = int.Parse(ds.Tables[0].Rows[0]["BBSUserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StartDate"].ToString() != "")
                {
                    this.StartDate = DateTime.Parse(ds.Tables[0].Rows[0]["StartDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndDate"].ToString() != "")
                {
                    this.EndDate = DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
                }
                this.PageTitle = ds.Tables[0].Rows[0]["PageTitle"].ToString();
                this.PageKeywords = ds.Tables[0].Rows[0]["PageKeywords"].ToString();
                this.PageDescription = ds.Tables[0].Rows[0]["PageDescription"].ToString();
                this.TBKKeys = ds.Tables[0].Rows[0]["TBKKeys"].ToString();
                this.PageBody = ds.Tables[0].Rows[0]["PageBody"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomType"].ToString() != "")
                {
                    this.CustomType = int.Parse(ds.Tables[0].Rows[0]["CustomType"].ToString());
                }
                this.TBK_PID = ds.Tables[0].Rows[0]["TBK_PID"].ToString();
                this.TBK_Nick = ds.Tables[0].Rows[0]["TBK_Nick"].ToString();
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
            strSql.Append(" FROM TB_Customer ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

