using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using DBUtility;//请先添加引用
namespace weibo.DataAccess
{
    /// <summary>
    /// 类tb_sianweibo。
    /// </summary>
    [Serializable]
    public partial class tb_sianweibo
    {
        public tb_sianweibo()
        { }
        #region Model
        private int _autoid;
        private DateTime? _createdat;
        private double? _id;
        private string _text;
        private string _source;
        private string _favorited;
        private string _truncated;
        private string _inreplytostuatusid;
        private string _inreplytouserid;
        private string _inreplytoscreenname;
        private string _thumbnailpictureurl;
        private string _middlesizepictureurl;
        private string _originalpictureurl;
        private double? _mid;
        private int? _repostscount;
        private int? _commentscount;
        private string _annotations;
        private string _geo;
        private DateTime? _createon;
        private string _note;
        /// <summary>
        /// 
        /// </summary>
        public int AutoID
        {
            set { _autoid = value; }
            get { return _autoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreatedAt
        {
            set { _createdat = value; }
            get { return _createdat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            set { _text = value; }
            get { return _text; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            set { _source = value; }
            get { return _source; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Favorited
        {
            set { _favorited = value; }
            get { return _favorited; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Truncated
        {
            set { _truncated = value; }
            get { return _truncated; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InReplyToStuatusID
        {
            set { _inreplytostuatusid = value; }
            get { return _inreplytostuatusid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InReplyToUserID
        {
            set { _inreplytouserid = value; }
            get { return _inreplytouserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InReplyToScreenName
        {
            set { _inreplytoscreenname = value; }
            get { return _inreplytoscreenname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ThumbnailPictureUrl
        {
            set { _thumbnailpictureurl = value; }
            get { return _thumbnailpictureurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MiddleSizePictureUrl
        {
            set { _middlesizepictureurl = value; }
            get { return _middlesizepictureurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OriginalPictureUrl
        {
            set { _originalpictureurl = value; }
            get { return _originalpictureurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? MID
        {
            set { _mid = value; }
            get { return _mid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RepostsCount
        {
            set { _repostscount = value; }
            get { return _repostscount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CommentsCount
        {
            set { _commentscount = value; }
            get { return _commentscount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Annotations
        {
            set { _annotations = value; }
            get { return _annotations; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GEO
        {
            set { _geo = value; }
            get { return _geo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateOn
        {
            set { _createon = value; }
            get { return _createon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Note
        {
            set { _note = value; }
            get { return _note; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_sianweibo(int AutoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select AutoID,CreatedAt,ID,Text,Source,Favorited,Truncated,InReplyToStuatusID,InReplyToUserID,InReplyToScreenName,ThumbnailPictureUrl,MiddleSizePictureUrl,OriginalPictureUrl,MID,RepostsCount,CommentsCount,Annotations,GEO,CreateOn,Note ");
            strSql.Append(" FROM [tb_sianweibo] ");
            strSql.Append(" where AutoID=@AutoID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AutoID", OleDbType.Integer,4)};
            parameters[0].Value = AutoID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["AutoID"] != null && ds.Tables[0].Rows[0]["AutoID"].ToString() != "")
                {
                    this.AutoID = int.Parse(ds.Tables[0].Rows[0]["AutoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreatedAt"] != null && ds.Tables[0].Rows[0]["CreatedAt"].ToString() != "")
                {
                    this.CreatedAt = DateTime.Parse(ds.Tables[0].Rows[0]["CreatedAt"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = double.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Text"] != null && ds.Tables[0].Rows[0]["Text"].ToString() != "")
                {
                    this.Text = ds.Tables[0].Rows[0]["Text"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Source"] != null && ds.Tables[0].Rows[0]["Source"].ToString() != "")
                {
                    this.Source = ds.Tables[0].Rows[0]["Source"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Favorited"] != null && ds.Tables[0].Rows[0]["Favorited"].ToString() != "")
                {
                    this.Favorited = ds.Tables[0].Rows[0]["Favorited"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Truncated"] != null && ds.Tables[0].Rows[0]["Truncated"].ToString() != "")
                {
                    this.Truncated = ds.Tables[0].Rows[0]["Truncated"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToStuatusID"] != null && ds.Tables[0].Rows[0]["InReplyToStuatusID"].ToString() != "")
                {
                    this.InReplyToStuatusID = ds.Tables[0].Rows[0]["InReplyToStuatusID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToUserID"] != null && ds.Tables[0].Rows[0]["InReplyToUserID"].ToString() != "")
                {
                    this.InReplyToUserID = ds.Tables[0].Rows[0]["InReplyToUserID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToScreenName"] != null && ds.Tables[0].Rows[0]["InReplyToScreenName"].ToString() != "")
                {
                    this.InReplyToScreenName = ds.Tables[0].Rows[0]["InReplyToScreenName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ThumbnailPictureUrl"] != null && ds.Tables[0].Rows[0]["ThumbnailPictureUrl"].ToString() != "")
                {
                    this.ThumbnailPictureUrl = ds.Tables[0].Rows[0]["ThumbnailPictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MiddleSizePictureUrl"] != null && ds.Tables[0].Rows[0]["MiddleSizePictureUrl"].ToString() != "")
                {
                    this.MiddleSizePictureUrl = ds.Tables[0].Rows[0]["MiddleSizePictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["OriginalPictureUrl"] != null && ds.Tables[0].Rows[0]["OriginalPictureUrl"].ToString() != "")
                {
                    this.OriginalPictureUrl = ds.Tables[0].Rows[0]["OriginalPictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MID"] != null && ds.Tables[0].Rows[0]["MID"].ToString() != "")
                {
                    this.MID = double.Parse(ds.Tables[0].Rows[0]["MID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RepostsCount"] != null && ds.Tables[0].Rows[0]["RepostsCount"].ToString() != "")
                {
                    this.RepostsCount = int.Parse(ds.Tables[0].Rows[0]["RepostsCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CommentsCount"] != null && ds.Tables[0].Rows[0]["CommentsCount"].ToString() != "")
                {
                    this.CommentsCount = int.Parse(ds.Tables[0].Rows[0]["CommentsCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Annotations"] != null && ds.Tables[0].Rows[0]["Annotations"].ToString() != "")
                {
                    this.Annotations = ds.Tables[0].Rows[0]["Annotations"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GEO"] != null && ds.Tables[0].Rows[0]["GEO"].ToString() != "")
                {
                    this.GEO = ds.Tables[0].Rows[0]["GEO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateOn"] != null && ds.Tables[0].Rows[0]["CreateOn"].ToString() != "")
                {
                    this.CreateOn = DateTime.Parse(ds.Tables[0].Rows[0]["CreateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Note"] != null && ds.Tables[0].Rows[0]["Note"].ToString() != "")
                {
                    this.Note = ds.Tables[0].Rows[0]["Note"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int AutoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tb_sianweibo]");
            strSql.Append(" where AutoID=@AutoID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@AutoID", OleDbType.Integer,4)};
            parameters[0].Value = AutoID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tb_sianweibo] (");
            strSql.Append("[CreatedAt],[ID],[Text],[Source],[Favorited],[Truncated],[InReplyToStuatusID],[InReplyToUserID],[InReplyToScreenName],[ThumbnailPictureUrl],[MiddleSizePictureUrl],[OriginalPictureUrl],[MID],[RepostsCount],[CommentsCount],[Annotations],[GEO],[CreateOn],[Note])");
            strSql.Append(" values (");
            strSql.Append("@CreatedAt,@ID,@Text,@Source,@Favorited,@Truncated,@InReplyToStuatusID,@InReplyToUserID,@InReplyToScreenName,@ThumbnailPictureUrl,@MiddleSizePictureUrl,@OriginalPictureUrl,@MID,@RepostsCount,@CommentsCount,@Annotations,@GEO,@CreateOn,@Note)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CreatedAt", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Double),
					new OleDbParameter("@Text", OleDbType.VarChar,255),
					new OleDbParameter("@Source", OleDbType.VarChar,255),
					new OleDbParameter("@Favorited", OleDbType.VarChar,255),
					new OleDbParameter("@Truncated", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToStuatusID", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToUserID", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToScreenName", OleDbType.VarChar,255),
					new OleDbParameter("@ThumbnailPictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@MiddleSizePictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@OriginalPictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@MID", OleDbType.Double),
					new OleDbParameter("@RepostsCount", OleDbType.Integer,4),
					new OleDbParameter("@CommentsCount", OleDbType.Integer,4),
					new OleDbParameter("@Annotations", OleDbType.VarChar,255),
					new OleDbParameter("@GEO", OleDbType.VarChar,255),
					new OleDbParameter("@CreateOn", OleDbType.Date),
					new OleDbParameter("@Note", OleDbType.VarChar,255)};
            parameters[0].Value = CreatedAt;
            parameters[1].Value = ID;
            parameters[2].Value = Text;
            parameters[3].Value = Source;
            parameters[4].Value = Favorited;
            parameters[5].Value = Truncated;
            parameters[6].Value = InReplyToStuatusID;
            parameters[7].Value = InReplyToUserID;
            parameters[8].Value = InReplyToScreenName;
            parameters[9].Value = ThumbnailPictureUrl;
            parameters[10].Value = MiddleSizePictureUrl;
            parameters[11].Value = OriginalPictureUrl;
            parameters[12].Value = MID;
            parameters[13].Value = RepostsCount;
            parameters[14].Value = CommentsCount;
            parameters[15].Value = Annotations;
            parameters[16].Value = GEO;
            parameters[17].Value = CreateOn;
            parameters[18].Value = Note;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tb_sianweibo] set ");
            strSql.Append("CreatedAt=@CreatedAt,");
            strSql.Append("ID=@ID,");
            strSql.Append("Text=@Text,");
            strSql.Append("Source=@Source,");
            strSql.Append("Favorited=@Favorited,");
            strSql.Append("Truncated=@Truncated,");
            strSql.Append("InReplyToStuatusID=@InReplyToStuatusID,");
            strSql.Append("InReplyToUserID=@InReplyToUserID,");
            strSql.Append("InReplyToScreenName=@InReplyToScreenName,");
            strSql.Append("ThumbnailPictureUrl=@ThumbnailPictureUrl,");
            strSql.Append("MiddleSizePictureUrl=@MiddleSizePictureUrl,");
            strSql.Append("OriginalPictureUrl=@OriginalPictureUrl,");
            strSql.Append("MID=@MID,");
            strSql.Append("RepostsCount=@RepostsCount,");
            strSql.Append("CommentsCount=@CommentsCount,");
            strSql.Append("Annotations=@Annotations,");
            strSql.Append("GEO=@GEO,");
            strSql.Append("CreateOn=@CreateOn,");
            strSql.Append("Note=@Note");
            strSql.Append(" where AutoID=@AutoID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CreatedAt", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Double),
					new OleDbParameter("@Text", OleDbType.VarChar,255),
					new OleDbParameter("@Source", OleDbType.VarChar,255),
					new OleDbParameter("@Favorited", OleDbType.VarChar,255),
					new OleDbParameter("@Truncated", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToStuatusID", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToUserID", OleDbType.VarChar,255),
					new OleDbParameter("@InReplyToScreenName", OleDbType.VarChar,255),
					new OleDbParameter("@ThumbnailPictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@MiddleSizePictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@OriginalPictureUrl", OleDbType.VarChar,255),
					new OleDbParameter("@MID", OleDbType.Double),
					new OleDbParameter("@RepostsCount", OleDbType.Integer,4),
					new OleDbParameter("@CommentsCount", OleDbType.Integer,4),
					new OleDbParameter("@Annotations", OleDbType.VarChar,255),
					new OleDbParameter("@GEO", OleDbType.VarChar,255),
					new OleDbParameter("@CreateOn", OleDbType.Date),
					new OleDbParameter("@Note", OleDbType.VarChar,255),
					new OleDbParameter("@AutoID", OleDbType.Integer,4)};
            parameters[0].Value = CreatedAt;
            parameters[1].Value = ID;
            parameters[2].Value = Text;
            parameters[3].Value = Source;
            parameters[4].Value = Favorited;
            parameters[5].Value = Truncated;
            parameters[6].Value = InReplyToStuatusID;
            parameters[7].Value = InReplyToUserID;
            parameters[8].Value = InReplyToScreenName;
            parameters[9].Value = ThumbnailPictureUrl;
            parameters[10].Value = MiddleSizePictureUrl;
            parameters[11].Value = OriginalPictureUrl;
            parameters[12].Value = MID;
            parameters[13].Value = RepostsCount;
            parameters[14].Value = CommentsCount;
            parameters[15].Value = Annotations;
            parameters[16].Value = GEO;
            parameters[17].Value = CreateOn;
            parameters[18].Value = Note;
            parameters[19].Value = AutoID;

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
        public bool Delete(int AutoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tb_sianweibo] ");
            strSql.Append(" where AutoID=@AutoID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AutoID", OleDbType.Integer,4)};
            parameters[0].Value = AutoID;

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
        public void GetModel(int AutoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select AutoID,CreatedAt,ID,Text,Source,Favorited,Truncated,InReplyToStuatusID,InReplyToUserID,InReplyToScreenName,ThumbnailPictureUrl,MiddleSizePictureUrl,OriginalPictureUrl,MID,RepostsCount,CommentsCount,Annotations,GEO,CreateOn,Note ");
            strSql.Append(" FROM [tb_sianweibo] ");
            strSql.Append(" where AutoID=@AutoID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AutoID", OleDbType.Integer,4)};
            parameters[0].Value = AutoID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["AutoID"] != null && ds.Tables[0].Rows[0]["AutoID"].ToString() != "")
                {
                    this.AutoID = int.Parse(ds.Tables[0].Rows[0]["AutoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreatedAt"] != null && ds.Tables[0].Rows[0]["CreatedAt"].ToString() != "")
                {
                    this.CreatedAt = DateTime.Parse(ds.Tables[0].Rows[0]["CreatedAt"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    //this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Text"] != null && ds.Tables[0].Rows[0]["Text"].ToString() != "")
                {
                    this.Text = ds.Tables[0].Rows[0]["Text"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Source"] != null && ds.Tables[0].Rows[0]["Source"].ToString() != "")
                {
                    this.Source = ds.Tables[0].Rows[0]["Source"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Favorited"] != null && ds.Tables[0].Rows[0]["Favorited"].ToString() != "")
                {
                    this.Favorited = ds.Tables[0].Rows[0]["Favorited"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Truncated"] != null && ds.Tables[0].Rows[0]["Truncated"].ToString() != "")
                {
                    this.Truncated = ds.Tables[0].Rows[0]["Truncated"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToStuatusID"] != null && ds.Tables[0].Rows[0]["InReplyToStuatusID"].ToString() != "")
                {
                    this.InReplyToStuatusID = ds.Tables[0].Rows[0]["InReplyToStuatusID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToUserID"] != null && ds.Tables[0].Rows[0]["InReplyToUserID"].ToString() != "")
                {
                    this.InReplyToUserID = ds.Tables[0].Rows[0]["InReplyToUserID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InReplyToScreenName"] != null && ds.Tables[0].Rows[0]["InReplyToScreenName"].ToString() != "")
                {
                    this.InReplyToScreenName = ds.Tables[0].Rows[0]["InReplyToScreenName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ThumbnailPictureUrl"] != null && ds.Tables[0].Rows[0]["ThumbnailPictureUrl"].ToString() != "")
                {
                    this.ThumbnailPictureUrl = ds.Tables[0].Rows[0]["ThumbnailPictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MiddleSizePictureUrl"] != null && ds.Tables[0].Rows[0]["MiddleSizePictureUrl"].ToString() != "")
                {
                    this.MiddleSizePictureUrl = ds.Tables[0].Rows[0]["MiddleSizePictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["OriginalPictureUrl"] != null && ds.Tables[0].Rows[0]["OriginalPictureUrl"].ToString() != "")
                {
                    this.OriginalPictureUrl = ds.Tables[0].Rows[0]["OriginalPictureUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MID"] != null && ds.Tables[0].Rows[0]["MID"].ToString() != "")
                {
                    //this.MID=ds.Tables[0].Rows[0]["MID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RepostsCount"] != null && ds.Tables[0].Rows[0]["RepostsCount"].ToString() != "")
                {
                    this.RepostsCount = int.Parse(ds.Tables[0].Rows[0]["RepostsCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CommentsCount"] != null && ds.Tables[0].Rows[0]["CommentsCount"].ToString() != "")
                {
                    this.CommentsCount = int.Parse(ds.Tables[0].Rows[0]["CommentsCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Annotations"] != null && ds.Tables[0].Rows[0]["Annotations"].ToString() != "")
                {
                    this.Annotations = ds.Tables[0].Rows[0]["Annotations"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GEO"] != null && ds.Tables[0].Rows[0]["GEO"].ToString() != "")
                {
                    this.GEO = ds.Tables[0].Rows[0]["GEO"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateOn"] != null && ds.Tables[0].Rows[0]["CreateOn"].ToString() != "")
                {
                    this.CreateOn = DateTime.Parse(ds.Tables[0].Rows[0]["CreateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Note"] != null && ds.Tables[0].Rows[0]["Note"].ToString() != "")
                {
                    this.Note = ds.Tables[0].Rows[0]["Note"].ToString();
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
            strSql.Append(" FROM [tb_sianweibo] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

