using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//请先添加引用
namespace Taobaoke.DAL
{
    /// <summary>
    /// 类TB_Shop。
    /// </summary>
    public class TB_Shop
    {
        public TB_Shop()
        { }
        #region Model
        private int _shop_id;
        private string _bulletin;
        private string _cid;
        private string _created;
        private string _desc;
        private string _modified;
        private string _nick;
        private string _picpath;
        private string _remaincount;
        private string _shopscore;
        private string _sid;
        private string _title;
        private string _click_url;
        private DateTime _updateon;
        private int _sellercreditscore;
        /// <summary>
        /// 
        /// </summary>
        public int Shop_ID
        {
            set { _shop_id = value; }
            get { return _shop_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Bulletin
        {
            set { _bulletin = value; }
            get { return _bulletin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cid
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Created
        {
            set { _created = value; }
            get { return _created; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Desc
        {
            set { _desc = value; }
            get { return _desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Modified
        {
            set { _modified = value; }
            get { return _modified; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nick
        {
            set { _nick = value; }
            get { return _nick; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PicPath
        {
            set { _picpath = value; }
            get { return _picpath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RemainCount
        {
            set { _remaincount = value; }
            get { return _remaincount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopScore
        {
            set { _shopscore = value; }
            get { return _shopscore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sid
        {
            set { _sid = value; }
            get { return _sid; }
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
        public string Click_Url
        {
            set { _click_url = value; }
            get { return _click_url; }
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
        public int SellerCreditScore
        {
            set { _sellercreditscore = value; }
            get { return _sellercreditscore; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TB_Shop(int Shop_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Shop_ID],[Bulletin],[Cid],[Created],[Desc],[Modified],[Nick],[PicPath],[RemainCount],[ShopScore],[Sid],[Title],[Click_Url],[UpdateOn],[SellerCreditScore] ");
            strSql.Append(" FROM TB_Shop ");
            strSql.Append(" where Shop_ID=@Shop_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Shop_ID", OleDbType.Integer,4)};
            parameters[0].Value = Shop_ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Shop_ID"].ToString() != "")
                {
                    Shop_ID = int.Parse(ds.Tables[0].Rows[0]["Shop_ID"].ToString());
                }
                Bulletin = ds.Tables[0].Rows[0]["Bulletin"].ToString();
                Cid = ds.Tables[0].Rows[0]["Cid"].ToString();
                Created = ds.Tables[0].Rows[0]["Created"].ToString();
                Desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                Modified = ds.Tables[0].Rows[0]["Modified"].ToString();
                Nick = ds.Tables[0].Rows[0]["Nick"].ToString();
                PicPath = ds.Tables[0].Rows[0]["PicPath"].ToString();
                RemainCount = ds.Tables[0].Rows[0]["RemainCount"].ToString();
                ShopScore = ds.Tables[0].Rows[0]["ShopScore"].ToString();
                Sid = ds.Tables[0].Rows[0]["Sid"].ToString();
                Title = ds.Tables[0].Rows[0]["Title"].ToString();
                Click_Url = ds.Tables[0].Rows[0]["Click_Url"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SellerCreditScore"].ToString() != "")
                {
                    SellerCreditScore = int.Parse(ds.Tables[0].Rows[0]["SellerCreditScore"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Shop_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Shop");
            strSql.Append(" where Shop_ID=@Shop_ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@Shop_ID", OleDbType.Integer,4)};
            parameters[0].Value = Shop_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Shop(");
            strSql.Append("[Bulletin],[Cid],[Created],[Desc],[Modified],[Nick],[PicPath],[RemainCount],[ShopScore],[Sid],[Title],[Click_Url],[UpdateOn],[SellerCreditScore])");
            strSql.Append(" values (");
            strSql.Append("@Bulletin,@Cid,@Created,@Desc,@Modified,@Nick,@PicPath,@RemainCount,@ShopScore,@Sid,@Title,@Click_Url,@UpdateOn,@SellerCreditScore)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Bulletin", OleDbType.VarChar,50),
					new OleDbParameter("@Cid", OleDbType.VarChar,50),
					new OleDbParameter("@Created", OleDbType.VarChar,50),
					new OleDbParameter("@Desc", OleDbType.VarChar,50),
					new OleDbParameter("@Modified", OleDbType.VarChar,50),
					new OleDbParameter("@Nick", OleDbType.VarChar,50),
					new OleDbParameter("@PicPath", OleDbType.VarChar,0),
					new OleDbParameter("@RemainCount", OleDbType.VarChar,50),
					new OleDbParameter("@ShopScore", OleDbType.VarChar,50),
					new OleDbParameter("@Sid", OleDbType.VarChar,50),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@Click_Url", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@SellerCreditScore", OleDbType.Integer,4)};
            parameters[0].Value = Bulletin;
            parameters[1].Value = Cid;
            parameters[2].Value = Created;
            parameters[3].Value = Desc;
            parameters[4].Value = Modified;
            parameters[5].Value = Nick;
            parameters[6].Value = PicPath;
            parameters[7].Value = RemainCount;
            parameters[8].Value = ShopScore;
            parameters[9].Value = Sid;
            parameters[10].Value = Title;
            parameters[11].Value = Click_Url;
            parameters[12].Value = UpdateOn;
            parameters[13].Value = SellerCreditScore;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Shop set ");
            strSql.Append("[Bulletin]=@Bulletin,");
            strSql.Append("[Cid]=@Cid,");
            strSql.Append("[Created]=@Created,");
            strSql.Append("[Desc]=@Desc,");
            strSql.Append("[Modified]=@Modified,");
            strSql.Append("[Nick]=@Nick,");
            strSql.Append("[PicPath]=@PicPath,");
            strSql.Append("[RemainCount]=@RemainCount,");
            strSql.Append("[ShopScore]=@ShopScore,");
            strSql.Append("[Sid]=@Sid,");
            strSql.Append("[Title]=@Title,");
            strSql.Append("[Click_Url]=@Click_Url,");
            strSql.Append("[UpdateOn]=@UpdateOn,");
            strSql.Append("[SellerCreditScore]=@SellerCreditScore");
            strSql.Append(" where [Shop_ID]=@Shop_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Bulletin", OleDbType.VarChar,50),
					new OleDbParameter("@Cid", OleDbType.VarChar,50),
					new OleDbParameter("@Created", OleDbType.VarChar,50),
					new OleDbParameter("@Desc", OleDbType.VarChar,50),
					new OleDbParameter("@Modified", OleDbType.VarChar,50),
					new OleDbParameter("@Nick", OleDbType.VarChar,50),
					new OleDbParameter("@PicPath", OleDbType.VarChar,0),
					new OleDbParameter("@RemainCount", OleDbType.VarChar,50),
					new OleDbParameter("@ShopScore", OleDbType.VarChar,50),
					new OleDbParameter("@Sid", OleDbType.VarChar,50),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@Click_Url", OleDbType.VarChar,0),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@SellerCreditScore", OleDbType.Integer,4),
                    new OleDbParameter("@Shop_ID", OleDbType.Integer,4)};

            parameters[0].Value = Bulletin;
            parameters[1].Value = Cid;
            parameters[2].Value = Created;
            parameters[3].Value = Desc;
            parameters[4].Value = Modified;
            parameters[5].Value = Nick;
            parameters[6].Value = PicPath;
            parameters[7].Value = RemainCount;
            parameters[8].Value = ShopScore;
            parameters[9].Value = Sid;
            parameters[10].Value = Title;
            parameters[11].Value = Click_Url;
            parameters[12].Value = UpdateOn;
            parameters[13].Value = SellerCreditScore;
            parameters[14].Value = Shop_ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int Shop_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Shop ");
            strSql.Append(" where Shop_ID=@Shop_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Shop_ID", OleDbType.Integer,4)};
            parameters[0].Value = Shop_ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int Shop_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Shop_ID],[Bulletin],[Cid],[Created],[Desc],[Modified],[Nick],[PicPath],[RemainCount],[ShopScore],[Sid],[Title],[Click_Url],[UpdateOn],[SellerCreditScore] ");
            strSql.Append(" FROM TB_Shop ");
            strSql.Append(" where Shop_ID=@Shop_ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Shop_ID", OleDbType.Integer,4)};
            parameters[0].Value = Shop_ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Shop_ID"].ToString() != "")
                {
                    this.Shop_ID = int.Parse(ds.Tables[0].Rows[0]["Shop_ID"].ToString());
                }
                this.Bulletin = ds.Tables[0].Rows[0]["Bulletin"].ToString();
                this.Cid = ds.Tables[0].Rows[0]["Cid"].ToString();
                this.Created = ds.Tables[0].Rows[0]["Created"].ToString();
                this.Desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                this.Modified = ds.Tables[0].Rows[0]["Modified"].ToString();
                this.Nick = ds.Tables[0].Rows[0]["Nick"].ToString();
                this.PicPath = ds.Tables[0].Rows[0]["PicPath"].ToString();
                this.RemainCount = ds.Tables[0].Rows[0]["RemainCount"].ToString();
                this.ShopScore = ds.Tables[0].Rows[0]["ShopScore"].ToString();
                this.Sid = ds.Tables[0].Rows[0]["Sid"].ToString();
                this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                this.Click_Url = ds.Tables[0].Rows[0]["Click_Url"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SellerCreditScore"].ToString() != "")
                {
                    this.SellerCreditScore = int.Parse(ds.Tables[0].Rows[0]["SellerCreditScore"].ToString());
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
            strSql.Append(" FROM TB_Shop ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

