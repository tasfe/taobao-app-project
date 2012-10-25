using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;
namespace SASCMS.DataAccess
{
    /// <summary>
    /// 类Tb_Products。
    /// </summary>
    public class Tb_Products
    {
        public Tb_Products()
        { }
        #region Model
        private string _name;
        private string _caizhi;
        private string _guige;
        private string _color;
        private string _price;
        private string _count;
        private string _factory;
        private string _contact;
        private string _tel;
        private DateTime _updateon;
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Caizhi
        {
            set { _caizhi = value; }
            get { return _caizhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Guige
        {
            set { _guige = value; }
            get { return _guige; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Count
        {
            set { _count = value; }
            get { return _count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Factory
        {
            set { _factory = value; }
            get { return _factory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Contact
        {
            set { _contact = value; }
            get { return _contact; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
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
        public Tb_Products(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Name],[Caizhi],[Guige],[Color],[Price],[Count],[Factory],[Contact],[Tel],[UpdateOn],[ID] ");
            strSql.Append(" FROM Tb_Products ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Name = ds.Tables[0].Rows[0]["Name"].ToString();
                Caizhi = ds.Tables[0].Rows[0]["Caizhi"].ToString();
                Guige = ds.Tables[0].Rows[0]["Guige"].ToString();
                Color = ds.Tables[0].Rows[0]["Color"].ToString();
                Price = ds.Tables[0].Rows[0]["Price"].ToString();
                Count = ds.Tables[0].Rows[0]["Count"].ToString();
                Factory = ds.Tables[0].Rows[0]["Factory"].ToString();
                Contact = ds.Tables[0].Rows[0]["Contact"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
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
            strSql.Append("select count(1) from Tb_Products");
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
            strSql.Append("insert into Tb_Products(");
            strSql.Append("[Name],[Caizhi],[Guige],[Color],[Price],[Count],[Factory],[Contact],[Tel],[UpdateOn])");
            strSql.Append(" values (");
            strSql.Append("@Name,@Caizhi,@Guige,@Color,@Price,@Count,@Factory,@Contact,@Tel,@UpdateOn)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Caizhi", OleDbType.VarChar,255),
					new OleDbParameter("@Guige", OleDbType.VarChar,255),
					new OleDbParameter("@Color", OleDbType.VarChar,255),
					new OleDbParameter("@Price", OleDbType.VarChar,255),
					new OleDbParameter("@Count", OleDbType.VarChar,255),
					new OleDbParameter("@Factory", OleDbType.VarChar,255),
					new OleDbParameter("@Contact", OleDbType.VarChar,255),
					new OleDbParameter("@Tel", OleDbType.VarChar,255),
					new OleDbParameter("@UpdateOn", OleDbType.Date)};
            parameters[0].Value = Name;
            parameters[1].Value = Caizhi;
            parameters[2].Value = Guige;
            parameters[3].Value = Color;
            parameters[4].Value = Price;
            parameters[5].Value = Count;
            parameters[6].Value = Factory;
            parameters[7].Value = Contact;
            parameters[8].Value = Tel;
            parameters[9].Value = UpdateOn;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Tb_Products] set ");
            strSql.Append("[Name]=@Name,");
            strSql.Append("[Caizhi]=@Caizhi,");
            strSql.Append("[Guige]=@Guige,");
            strSql.Append("[Color]=@Color,");
            strSql.Append("[Price]=@Price,");
            strSql.Append("[Count]=@Count,");
            strSql.Append("[Factory]=@Factory,");
            strSql.Append("[Contact]=@Contact,");
            strSql.Append("[Tel]=@Tel,");
            strSql.Append("[UpdateOn]=@UpdateOn");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,255),
					new OleDbParameter("@Caizhi", OleDbType.VarChar,255),
					new OleDbParameter("@Guige", OleDbType.VarChar,255),
					new OleDbParameter("@Color", OleDbType.VarChar,255),
					new OleDbParameter("@Price", OleDbType.VarChar,255),
					new OleDbParameter("@Count", OleDbType.VarChar,255),
					new OleDbParameter("@Factory", OleDbType.VarChar,255),
					new OleDbParameter("@Contact", OleDbType.VarChar,255),
					new OleDbParameter("@Tel", OleDbType.VarChar,255),
					new OleDbParameter("@UpdateOn", OleDbType.Date),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = Name;
            parameters[1].Value = Caizhi;
            parameters[2].Value = Guige;
            parameters[3].Value = Color;
            parameters[4].Value = Price;
            parameters[5].Value = Count;
            parameters[6].Value = Factory;
            parameters[7].Value = Contact;
            parameters[8].Value = Tel;
            parameters[9].Value = UpdateOn;
            parameters[10].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tb_Products ");
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
            strSql.Append("select [Name],[Caizhi],[Guige],[Color],[Price],[Count],[Factory],[Contact],[Tel],[UpdateOn],[ID] ");
            strSql.Append(" FROM Tb_Products ");
            strSql.Append(" where [ID]=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                this.Caizhi = ds.Tables[0].Rows[0]["Caizhi"].ToString();
                this.Guige = ds.Tables[0].Rows[0]["Guige"].ToString();
                this.Color = ds.Tables[0].Rows[0]["Color"].ToString();
                this.Price = ds.Tables[0].Rows[0]["Price"].ToString();
                this.Count = ds.Tables[0].Rows[0]["Count"].ToString();
                this.Factory = ds.Tables[0].Rows[0]["Factory"].ToString();
                this.Contact = ds.Tables[0].Rows[0]["Contact"].ToString();
                this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                if (ds.Tables[0].Rows[0]["UpdateOn"].ToString() != "")
                {
                    this.UpdateOn = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateOn"].ToString());
                }
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
            strSql.Append(" FROM Tb_Products ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top "+top+" * ");
            strSql.Append(" FROM Tb_Products ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  成员方法
    }
}

