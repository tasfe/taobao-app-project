using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//Please add references
namespace Taobaoke.DAL
{
    /// <summary>
    /// 类TB_TAOBAO_ITEM。
    /// </summary>
    [Serializable]
    public partial class TB_TAOBAO_ITEM
    {
        public TB_TAOBAO_ITEM()
        { }
        #region Model
        private string _desc;
        private string _title;
        private string _clickurl;
        private decimal? _commission;
        private decimal? _emsfee;
        private decimal? _expressfee;
        private string _freightpayer;
        private string _city;
        private string _nick;
        private string _numiid;
        private decimal? _postfee;
        private decimal? _price;
        private int? _sellercreditscore;
        private string _shopclickurl;
        private int? _volume;
        private string _itemimgs;
        private string _propimgs;
        private string _category;
        private string _pic_url;
        private string _topcategory;
        private DateTime? _updateon;
        private int _id;
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
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClickUrl
        {
            set { _clickurl = value; }
            get { return _clickurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Commission
        {
            set { _commission = value; }
            get { return _commission; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? EmsFee
        {
            set { _emsfee = value; }
            get { return _emsfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ExpressFee
        {
            set { _expressfee = value; }
            get { return _expressfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FreightPayer
        {
            set { _freightpayer = value; }
            get { return _freightpayer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
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
        public string NumIid
        {
            set { _numiid = value; }
            get { return _numiid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PostFee
        {
            set { _postfee = value; }
            get { return _postfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SellerCreditScore
        {
            set { _sellercreditscore = value; }
            get { return _sellercreditscore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopClickUrl
        {
            set { _shopclickurl = value; }
            get { return _shopclickurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Volume
        {
            set { _volume = value; }
            get { return _volume; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ItemImgs
        {
            set { _itemimgs = value; }
            get { return _itemimgs; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PropImgs
        {
            set { _propimgs = value; }
            get { return _propimgs; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pic_Url
        {
            set { _pic_url = value; }
            get { return _pic_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TopCategory
        {
            set { _topcategory = value; }
            get { return _topcategory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateOn
        {
            set { _updateon = value; }
            get { return _updateon; }
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
        public TB_TAOBAO_ITEM(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Desc,Title,ClickUrl,Commission,EmsFee,ExpressFee,FreightPayer,City,Nick,NumIid,PostFee,Price,SellerCreditScore,ShopClickUrl,Volume,ItemImgs,PropImgs,Category,Pic_Url,TopCategory,UpdateOn,ID ");
            strSql.Append(" FROM [TB_TAOBAO_ITEM] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Desc"] != null && ds.Tables[0].Rows[0]["Desc"].ToString() != "")
                {
                    this.Desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Title"] != null && ds.Tables[0].Rows[0]["Title"].ToString() != "")
                {
                    this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ClickUrl"] != null && ds.Tables[0].Rows[0]["ClickUrl"].ToString() != "")
                {
                    this.ClickUrl = ds.Tables[0].Rows[0]["ClickUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Commission"] != null && ds.Tables[0].Rows[0]["Commission"].ToString() != "")
                {
                    this.Commission = decimal.Parse(ds.Tables[0].Rows[0]["Commission"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmsFee"] != null && ds.Tables[0].Rows[0]["EmsFee"].ToString() != "")
                {
                    this.EmsFee = decimal.Parse(ds.Tables[0].Rows[0]["EmsFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExpressFee"] != null && ds.Tables[0].Rows[0]["ExpressFee"].ToString() != "")
                {
                    this.ExpressFee = decimal.Parse(ds.Tables[0].Rows[0]["ExpressFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FreightPayer"] != null && ds.Tables[0].Rows[0]["FreightPayer"].ToString() != "")
                {
                    this.FreightPayer = ds.Tables[0].Rows[0]["FreightPayer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["City"] != null && ds.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    this.City = ds.Tables[0].Rows[0]["City"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Nick"] != null && ds.Tables[0].Rows[0]["Nick"].ToString() != "")
                {
                    this.Nick = ds.Tables[0].Rows[0]["Nick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["NumIid"] != null && ds.Tables[0].Rows[0]["NumIid"].ToString() != "")
                {
                    this.NumIid = ds.Tables[0].Rows[0]["NumIid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PostFee"] != null && ds.Tables[0].Rows[0]["PostFee"].ToString() != "")
                {
                    this.PostFee = decimal.Parse(ds.Tables[0].Rows[0]["PostFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    this.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SellerCreditScore"] != null && ds.Tables[0].Rows[0]["SellerCreditScore"].ToString() != "")
                {
                    this.SellerCreditScore = int.Parse(ds.Tables[0].Rows[0]["SellerCreditScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShopClickUrl"] != null && ds.Tables[0].Rows[0]["ShopClickUrl"].ToString() != "")
                {
                    this.ShopClickUrl = ds.Tables[0].Rows[0]["ShopClickUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Volume"] != null && ds.Tables[0].Rows[0]["Volume"].ToString() != "")
                {
                    this.Volume = int.Parse(ds.Tables[0].Rows[0]["Volume"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ItemImgs"] != null && ds.Tables[0].Rows[0]["ItemImgs"].ToString() != "")
                {
                    this.ItemImgs = ds.Tables[0].Rows[0]["ItemImgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PropImgs"] != null && ds.Tables[0].Rows[0]["PropImgs"].ToString() != "")
                {
                    this.PropImgs = ds.Tables[0].Rows[0]["PropImgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Category"] != null && ds.Tables[0].Rows[0]["Category"].ToString() != "")
                {
                    this.Category = ds.Tables[0].Rows[0]["Category"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Pic_Url"] != null && ds.Tables[0].Rows[0]["Pic_Url"].ToString() != "")
                {
                    this.Pic_Url = ds.Tables[0].Rows[0]["Pic_Url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TopCategory"] != null && ds.Tables[0].Rows[0]["TopCategory"].ToString() != "")
                {
                    this.TopCategory = ds.Tables[0].Rows[0]["TopCategory"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UpdateOn"] != null && ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
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
            strSql.Append("select count(1) from [TB_TAOBAO_ITEM]");
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
            strSql.Append("insert into [TB_TAOBAO_ITEM] (");
            strSql.Append("[Desc],Title,ClickUrl,Commission,EmsFee,ExpressFee,FreightPayer,City,Nick,NumIid,PostFee,Price,SellerCreditScore,ShopClickUrl,Volume,ItemImgs,PropImgs,Category,Pic_Url,TopCategory,UpdateOn)");
            strSql.Append(" values (");
            strSql.Append("@Desc,@Title,@ClickUrl,@Commission,@EmsFee,@ExpressFee,@FreightPayer,@City,@Nick,@NumIid,@PostFee,@Price,@SellerCreditScore,@ShopClickUrl,@Volume,@ItemImgs,@PropImgs,@Category,@Pic_Url,@TopCategory,@UpdateOn)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Desc", OleDbType.VarChar,0),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@ClickUrl", OleDbType.VarChar,0),
					new OleDbParameter("@Commission", OleDbType.Decimal),
					new OleDbParameter("@EmsFee", OleDbType.Decimal),
					new OleDbParameter("@ExpressFee", OleDbType.Decimal),
					new OleDbParameter("@FreightPayer", OleDbType.VarChar,255),
					new OleDbParameter("@City", OleDbType.VarChar,255),
					new OleDbParameter("@Nick", OleDbType.VarChar,255),
					new OleDbParameter("@NumIid", OleDbType.VarChar,255),
					new OleDbParameter("@PostFee", OleDbType.Decimal),
					new OleDbParameter("@Price", OleDbType.Decimal),
					new OleDbParameter("@SellerCreditScore", OleDbType.Integer,4),
					new OleDbParameter("@ShopClickUrl", OleDbType.VarChar,0),
					new OleDbParameter("@Volume", OleDbType.Integer,4),
					new OleDbParameter("@ItemImgs", OleDbType.VarChar,0),
					new OleDbParameter("@PropImgs", OleDbType.VarChar,0),
					new OleDbParameter("@Category", OleDbType.VarChar,255),
					new OleDbParameter("@Pic_Url", OleDbType.VarChar,255),
					new OleDbParameter("@TopCategory", OleDbType.VarChar,50),
					new OleDbParameter("@UpdateOn", OleDbType.Date)};
            parameters[0].Value = Desc;
            parameters[1].Value = Title;
            parameters[2].Value = ClickUrl;
            parameters[3].Value = Commission;
            parameters[4].Value = EmsFee;
            parameters[5].Value = ExpressFee;
            parameters[6].Value = FreightPayer;
            parameters[7].Value = City;
            parameters[8].Value = Nick;
            parameters[9].Value = NumIid;
            parameters[10].Value = PostFee;
            parameters[11].Value = Price;
            parameters[12].Value = SellerCreditScore;
            parameters[13].Value = ShopClickUrl;
            parameters[14].Value = Volume;
            parameters[15].Value = ItemImgs;
            parameters[16].Value = PropImgs;
            parameters[17].Value = Category;
            parameters[18].Value = Pic_Url;
            parameters[19].Value = TopCategory;
            parameters[20].Value = UpdateOn;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [TB_TAOBAO_ITEM] set ");
            strSql.Append("Desc=@Desc,");
            strSql.Append("Title=@Title,");
            strSql.Append("ClickUrl=@ClickUrl,");
            strSql.Append("Commission=@Commission,");
            strSql.Append("EmsFee=@EmsFee,");
            strSql.Append("ExpressFee=@ExpressFee,");
            strSql.Append("FreightPayer=@FreightPayer,");
            strSql.Append("City=@City,");
            strSql.Append("Nick=@Nick,");
            strSql.Append("NumIid=@NumIid,");
            strSql.Append("PostFee=@PostFee,");
            strSql.Append("Price=@Price,");
            strSql.Append("SellerCreditScore=@SellerCreditScore,");
            strSql.Append("ShopClickUrl=@ShopClickUrl,");
            strSql.Append("Volume=@Volume,");
            strSql.Append("ItemImgs=@ItemImgs,");
            strSql.Append("PropImgs=@PropImgs,");
            strSql.Append("Category=@Category,");
            strSql.Append("Pic_Url=@Pic_Url,");
            strSql.Append("TopCategory=@TopCategory,");
            strSql.Append("UpdateOn=@UpdateOn");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Desc", OleDbType.VarChar,0),
					new OleDbParameter("@Title", OleDbType.VarChar,0),
					new OleDbParameter("@ClickUrl", OleDbType.VarChar,0),
					new OleDbParameter("@Commission", OleDbType.Decimal),
					new OleDbParameter("@EmsFee", OleDbType.Decimal),
					new OleDbParameter("@ExpressFee", OleDbType.Decimal),
					new OleDbParameter("@FreightPayer", OleDbType.VarChar,255),
					new OleDbParameter("@City", OleDbType.VarChar,255),
					new OleDbParameter("@Nick", OleDbType.VarChar,255),
					new OleDbParameter("@NumIid", OleDbType.VarChar,255),
					new OleDbParameter("@PostFee", OleDbType.Decimal),
					new OleDbParameter("@Price", OleDbType.Decimal),
					new OleDbParameter("@SellerCreditScore", OleDbType.Integer,4),
					new OleDbParameter("@ShopClickUrl", OleDbType.VarChar,0),
					new OleDbParameter("@Volume", OleDbType.Integer,4),
					new OleDbParameter("@ItemImgs", OleDbType.VarChar,0),
					new OleDbParameter("@PropImgs", OleDbType.VarChar,0),
					new OleDbParameter("@Category", OleDbType.VarChar,255),
					new OleDbParameter("@Pic_Url", OleDbType.VarChar,255),
					new OleDbParameter("@TopCategory", OleDbType.VarChar,50),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = Desc;
            parameters[1].Value = Title;
            parameters[2].Value = ClickUrl;
            parameters[3].Value = Commission;
            parameters[4].Value = EmsFee;
            parameters[5].Value = ExpressFee;
            parameters[6].Value = FreightPayer;
            parameters[7].Value = City;
            parameters[8].Value = Nick;
            parameters[9].Value = NumIid;
            parameters[10].Value = PostFee;
            parameters[11].Value = Price;
            parameters[12].Value = SellerCreditScore;
            parameters[13].Value = ShopClickUrl;
            parameters[14].Value = Volume;
            parameters[15].Value = ItemImgs;
            parameters[16].Value = PropImgs;
            parameters[17].Value = Category;
            parameters[18].Value = Pic_Url;
            parameters[19].Value = TopCategory;
            parameters[20].Value = UpdateOn;
            parameters[21].Value = ID;

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
            strSql.Append("delete from [TB_TAOBAO_ITEM] ");
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
            strSql.Append("select Desc,Title,ClickUrl,Commission,EmsFee,ExpressFee,FreightPayer,City,Nick,NumIid,PostFee,Price,SellerCreditScore,ShopClickUrl,Volume,ItemImgs,PropImgs,Category,Pic_Url,TopCategory,UpdateOn,ID ");
            strSql.Append(" FROM [TB_TAOBAO_ITEM] ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Desc"] != null && ds.Tables[0].Rows[0]["Desc"].ToString() != "")
                {
                    this.Desc = ds.Tables[0].Rows[0]["Desc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Title"] != null && ds.Tables[0].Rows[0]["Title"].ToString() != "")
                {
                    this.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ClickUrl"] != null && ds.Tables[0].Rows[0]["ClickUrl"].ToString() != "")
                {
                    this.ClickUrl = ds.Tables[0].Rows[0]["ClickUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Commission"] != null && ds.Tables[0].Rows[0]["Commission"].ToString() != "")
                {
                    this.Commission = decimal.Parse(ds.Tables[0].Rows[0]["Commission"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmsFee"] != null && ds.Tables[0].Rows[0]["EmsFee"].ToString() != "")
                {
                    this.EmsFee = decimal.Parse(ds.Tables[0].Rows[0]["EmsFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExpressFee"] != null && ds.Tables[0].Rows[0]["ExpressFee"].ToString() != "")
                {
                    this.ExpressFee = decimal.Parse(ds.Tables[0].Rows[0]["ExpressFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FreightPayer"] != null && ds.Tables[0].Rows[0]["FreightPayer"].ToString() != "")
                {
                    this.FreightPayer = ds.Tables[0].Rows[0]["FreightPayer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["City"] != null && ds.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    this.City = ds.Tables[0].Rows[0]["City"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Nick"] != null && ds.Tables[0].Rows[0]["Nick"].ToString() != "")
                {
                    this.Nick = ds.Tables[0].Rows[0]["Nick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["NumIid"] != null && ds.Tables[0].Rows[0]["NumIid"].ToString() != "")
                {
                    this.NumIid = ds.Tables[0].Rows[0]["NumIid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PostFee"] != null && ds.Tables[0].Rows[0]["PostFee"].ToString() != "")
                {
                    this.PostFee = decimal.Parse(ds.Tables[0].Rows[0]["PostFee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    this.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SellerCreditScore"] != null && ds.Tables[0].Rows[0]["SellerCreditScore"].ToString() != "")
                {
                    this.SellerCreditScore = int.Parse(ds.Tables[0].Rows[0]["SellerCreditScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShopClickUrl"] != null && ds.Tables[0].Rows[0]["ShopClickUrl"].ToString() != "")
                {
                    this.ShopClickUrl = ds.Tables[0].Rows[0]["ShopClickUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Volume"] != null && ds.Tables[0].Rows[0]["Volume"].ToString() != "")
                {
                    this.Volume = int.Parse(ds.Tables[0].Rows[0]["Volume"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ItemImgs"] != null && ds.Tables[0].Rows[0]["ItemImgs"].ToString() != "")
                {
                    this.ItemImgs = ds.Tables[0].Rows[0]["ItemImgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PropImgs"] != null && ds.Tables[0].Rows[0]["PropImgs"].ToString() != "")
                {
                    this.PropImgs = ds.Tables[0].Rows[0]["PropImgs"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Category"] != null && ds.Tables[0].Rows[0]["Category"].ToString() != "")
                {
                    this.Category = ds.Tables[0].Rows[0]["Category"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Pic_Url"] != null && ds.Tables[0].Rows[0]["Pic_Url"].ToString() != "")
                {
                    this.Pic_Url = ds.Tables[0].Rows[0]["Pic_Url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TopCategory"] != null && ds.Tables[0].Rows[0]["TopCategory"].ToString() != "")
                {
                    this.TopCategory = ds.Tables[0].Rows[0]["TopCategory"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UpdateOn"] != null && ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
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
            strSql.Append(" FROM [TB_TAOBAO_ITEM] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

