using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DAL
{
    /// <summary>
    /// 类TB_Value。
    /// </summary>
    public class TB_Value
    {
        public TB_Value()
        { }
        #region Model
        private int? _valid;
        private int _pid;
        private int _itemid;
        private string _value;
        private string _companyid;
        /// <summary>
        /// 
        /// </summary>
        public int? ValID
        {
            set { _valid = value; }
            get { return _valid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PID
        {
            set { _pid = value; }
            get { return _pid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ItemID
        {
            set { _itemid = value; }
            get { return _itemid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            set { _value = value; }
            get { return _value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyID
        {
            set { _companyid = value; }
            get { return _companyid; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ValID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Value");
            strSql.Append(" where ValID=" + ValID + " ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ValID", OleDbType.Integer,4)				};
            parameters[0].Value = ValID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Value(");
            strSql.Append("PID,ItemID,[Value],CompanyID)");
            strSql.Append(" values (");
            strSql.Append("@PID,@ItemID,@Value,@CompanyID)");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ValID", OleDbType.Integer,4),
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@ItemID", OleDbType.Integer,4),
					new OleDbParameter("@Value", OleDbType.VarChar,0),
					new OleDbParameter("@CompanyID", OleDbType.VarChar,50)};
            //parameters[0].Value = ValID;
            parameters[0].Value = PID;
            parameters[1].Value = ItemID;
            parameters[2].Value = Value;
            parameters[3].Value = CompanyID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Value set ");
            //strSql.Append("ValID=@ValID,");
            strSql.Append("PID=@PID,");
            strSql.Append("ItemID=@ItemID,");
            strSql.Append("Value=@Value,");
            strSql.Append("CompanyID=@CompanyID");
            strSql.Append(" where ValID=" + ValID + " ");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ValID", OleDbType.Integer,4),
					new OleDbParameter("@PID", OleDbType.Integer,4),
					new OleDbParameter("@ItemID", OleDbType.Integer,4),
					new OleDbParameter("@Value", OleDbType.VarChar,0),
					new OleDbParameter("@CompanyID", OleDbType.VarChar,50)};
            //parameters[0].Value = ValID;
            parameters[0].Value = PID;
            parameters[1].Value = ItemID;
            parameters[2].Value = Value;
            parameters[3].Value = CompanyID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ValID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Value ");
            strSql.Append(" where ValID=" + ValID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ValID", OleDbType.Integer,4)				};
            parameters[0].Value = ValID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ValID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ValID,PID,ItemID,Value,CompanyID ");
            strSql.Append(" FROM TB_Value ");
            strSql.Append(" where ValID=" + ValID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ValID", OleDbType.Integer,4)				};
            parameters[0].Value = ValID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ValID"].ToString() != "")
                {
                    ValID = int.Parse(ds.Tables[0].Rows[0]["ValID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PID"].ToString() != "")
                {
                    PID = int.Parse(ds.Tables[0].Rows[0]["PID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ItemID"].ToString() != "")
                {
                    ItemID = int.Parse(ds.Tables[0].Rows[0]["ItemID"].ToString());
                }
                Value = ds.Tables[0].Rows[0]["Value"].ToString();
                CompanyID = ds.Tables[0].Rows[0]["CompanyID"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ValID],[PID],[ItemID],[Value],[CompanyID] ");
            strSql.Append(" FROM TB_Value ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}