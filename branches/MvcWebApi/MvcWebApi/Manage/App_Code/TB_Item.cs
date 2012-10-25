using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using SASCMS.DBUtility;//请先添加引用
namespace SASCMS.DAL
{
    /// <summary>
    /// 类TB_Item。
    /// </summary>
    public class TB_Item
    {
        public TB_Item()
        { }
        #region Model
        private int _itemid;
        private string _itemname;
        private string _itemtype;
        private int _itemorder;
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
        public string ItemName
        {
            set { _itemname = value; }
            get { return _itemname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ItemType
        {
            set { _itemtype = value; }
            get { return _itemtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ItemOrder
        {
            set { _itemorder = value; }
            get { return _itemorder; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ItemID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Item");
            strSql.Append(" where ItemID=" + ItemID + " ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ItemID", OleDbType.Integer,4)				};
            parameters[0].Value = ItemID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Item(");
            strSql.Append("ItemName,ItemType,ItemOrder)");
            strSql.Append(" values (");
            strSql.Append("@ItemName,@ItemType,@ItemOrder)");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ItemID", OleDbType.Integer,4),
					new OleDbParameter("@ItemName", OleDbType.VarChar,0),
					new OleDbParameter("@ItemType", OleDbType.VarChar,0),
					new OleDbParameter("@ItemOrder", OleDbType.Integer,4)};
            //parameters[0].Value = ItemID;
            parameters[0].Value = ItemName;
            parameters[1].Value = ItemType;
            parameters[2].Value = ItemOrder;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Item set ");
            //strSql.Append("ItemID=@ItemID,");
            strSql.Append("ItemName=@ItemName,");
            strSql.Append("ItemType=@ItemType,");
            strSql.Append("ItemOrder=@ItemOrder");
            strSql.Append(" where ItemID=" + ItemID + " ");
            OleDbParameter[] parameters = {
					//new OleDbParameter("@ItemID", OleDbType.Integer,4),
					new OleDbParameter("@ItemName", OleDbType.VarChar,0),
					new OleDbParameter("@ItemType", OleDbType.VarChar,0),
					new OleDbParameter("@ItemOrder", OleDbType.Integer,4)};
            //parameters[0].Value = ItemID;
            parameters[0].Value = ItemName;
            parameters[1].Value = ItemType;
            parameters[2].Value = ItemOrder;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ItemID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_Item ");
            strSql.Append(" where ItemID=" + ItemID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ItemID", OleDbType.Integer,4)				};
            parameters[0].Value = ItemID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ItemID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ItemID,ItemName,ItemType,ItemOrder ");
            strSql.Append(" FROM TB_Item ");
            strSql.Append(" where ItemID=" + ItemID + " ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ItemID", OleDbType.Integer,4)				};
            parameters[0].Value = ItemID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ItemID"].ToString() != "")
                {
                    ItemID = int.Parse(ds.Tables[0].Rows[0]["ItemID"].ToString());
                }
                ItemName = ds.Tables[0].Rows[0]["ItemName"].ToString();
                ItemType = ds.Tables[0].Rows[0]["ItemType"].ToString();
                if (ds.Tables[0].Rows[0]["ItemOrder"].ToString() != "")
                {
                    ItemOrder = int.Parse(ds.Tables[0].Rows[0]["ItemOrder"].ToString());
                }
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ItemID],[ItemName],[ItemType],[ItemOrder] ");
            strSql.Append(" FROM TB_Item ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

