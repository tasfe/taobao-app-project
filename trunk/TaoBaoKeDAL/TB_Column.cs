using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//请先添加引用
namespace Taobaoke.DAL
{
    /// <summary>
    /// 类TB_Column。
    /// </summary>
    public class TB_Column
    {
        public TB_Column()
        { }
        #region Model
        private string _id;
        private string _title;
        private string _parentid;
        private DateTime _updatetime;
        private string _code;
        private int _isurl;
        private string _url;
        private string _shortname;
        private string _transid;
        private short _isvisible;
        private string _toppic;
        /// <summary>
        /// 
        /// </summary>
        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParentId
        {
            set { _parentid = value; }
            get { return _parentid; }
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
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isUrl
        {
            set { _isurl = value; }
            get { return _isurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shortName
        {
            set { _shortname = value; }
            get { return _shortname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string transId
        {
            set { _transid = value; }
            get { return _transid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public short IsVisible
        {
            set { _isvisible = value; }
            get { return _isvisible; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TopPic
        {
            set { _toppic = value; }
            get { return _toppic; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_Column(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Title,ParentId,updateTime,Code,isUrl,url,shortName,transId,IsVisible,TopPic ");
            strSql.Append(" FROM TB_Column ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Id = ds.Tables[0].Rows[0]["Id"].ToString();
                Title = ds.Tables[0].Rows[0]["Title"].ToString();
                ParentId = ds.Tables[0].Rows[0]["ParentId"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                Code = ds.Tables[0].Rows[0]["Code"].ToString();
                if (ds.Tables[0].Rows[0]["isUrl"].ToString() != "")
                {
                    isUrl = int.Parse(ds.Tables[0].Rows[0]["isUrl"].ToString());
                }
                url = ds.Tables[0].Rows[0]["url"].ToString();
                shortName = ds.Tables[0].Rows[0]["shortName"].ToString();
                transId = ds.Tables[0].Rows[0]["transId"].ToString();
                IsVisible = 1;// ds.Tables[0].Rows[0]["IsVisible"].ToString();
                TopPic = ds.Tables[0].Rows[0]["TopPic"].ToString();
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Column");
            strSql.Append(" where Id=@Id ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Column(");
            strSql.Append("Id,Title,ParentId,updateTime,Code,isUrl,url,shortName,transId,IsVisible,TopPic)");
            strSql.Append(" values (");
            strSql.Append("@Id,@Title,@ParentId,@updateTime,@Code,@isUrl,@url,@shortName,@transId,@IsVisible,@TopPic)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@ParentId", OleDbType.VarChar,50),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@Code", OleDbType.VarChar,0),
					new OleDbParameter("@isUrl", OleDbType.Integer,4),
					new OleDbParameter("@url", OleDbType.VarChar,0),
					new OleDbParameter("@shortName", OleDbType.VarChar,50),
					new OleDbParameter("@transId", OleDbType.VarChar,0),
					new OleDbParameter("@IsVisible", OleDbType.SmallInt),
					new OleDbParameter("@TopPic", OleDbType.VarChar,50)};
            parameters[0].Value = Id;
            parameters[1].Value = Title;
            parameters[2].Value = ParentId;
            parameters[3].Value = updateTime;
            parameters[4].Value = Code;
            parameters[5].Value = isUrl;
            parameters[6].Value = url;
            parameters[7].Value = shortName;
            parameters[8].Value = transId;
            parameters[9].Value = IsVisible;
            parameters[10].Value = TopPic;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Column set ");
            strSql.Append("Id=@Id,");
            strSql.Append("Title=@Title,");
            strSql.Append("ParentId=@ParentId,");
            strSql.Append("updateTime=@updateTime,");
            strSql.Append("Code=@Code,");
            strSql.Append("isUrl=@isUrl,");
            strSql.Append("url=@url,");
            strSql.Append("shortName=@shortName,");
            strSql.Append("transId=@transId,");
            strSql.Append("IsVisible=@IsVisible,");
            strSql.Append("TopPic=@TopPic");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@ParentId", OleDbType.VarChar,50),
					new OleDbParameter("@updateTime", OleDbType.Date),
					new OleDbParameter("@Code", OleDbType.VarChar,0),
					new OleDbParameter("@isUrl", OleDbType.Integer,4),
					new OleDbParameter("@url", OleDbType.VarChar,0),
					new OleDbParameter("@shortName", OleDbType.VarChar,50),
					new OleDbParameter("@transId", OleDbType.VarChar,0),
					new OleDbParameter("@IsVisible", OleDbType.SmallInt),
					new OleDbParameter("@TopPic", OleDbType.VarChar,50)};
            parameters[0].Value = Id;
            parameters[1].Value = Title;
            parameters[2].Value = ParentId;
            parameters[3].Value = updateTime;
            parameters[4].Value = Code;
            parameters[5].Value = isUrl;
            parameters[6].Value = url;
            parameters[7].Value = shortName;
            parameters[8].Value = transId;
            parameters[9].Value = IsVisible;
            parameters[10].Value = TopPic;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Column ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Title,ParentId,updateTime,Code,isUrl,url,shortName,transId,IsVisible,TopPic ");
            strSql.Append(" FROM TB_Column ");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.VarChar,50)};
            parameters[0].Value = Id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Id = ds.Tables[0].Rows[0]["Id"].ToString();
                this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                this.ParentId = ds.Tables[0].Rows[0]["ParentId"].ToString();
                if (ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    this.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                this.Code = ds.Tables[0].Rows[0]["Code"].ToString();
                if (ds.Tables[0].Rows[0]["isUrl"].ToString() != "")
                {
                    this.isUrl = int.Parse(ds.Tables[0].Rows[0]["isUrl"].ToString());
                }
                this.url = ds.Tables[0].Rows[0]["url"].ToString();
                this.shortName = ds.Tables[0].Rows[0]["shortName"].ToString();
                this.transId = ds.Tables[0].Rows[0]["transId"].ToString();
                //this.IsVisible=ds.Tables[0].Rows[0]["IsVisible"].ToString();
                this.TopPic = ds.Tables[0].Rows[0]["TopPic"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TB_Column ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

