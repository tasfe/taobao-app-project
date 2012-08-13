using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Shop.DBUtility;//Please add references
namespace Taobaoke.DAL
{
    /// <summary>
    /// 类TB_SELLERCAT。
    /// </summary>
    public partial class TB_SELLERCAT
    {
        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelByCid(string cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cid,name,parent_cid,pic_url,type,nick,sort_order,UpdateON,ID ");
            strSql.Append(" FROM [TB_SELLERCAT] ");
            strSql.Append(" where cid=@cid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@cid", OleDbType.VarChar)};
            parameters[0].Value = cid;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["cid"] != null && ds.Tables[0].Rows[0]["cid"].ToString() != "")
                {
                    this.cid = ds.Tables[0].Rows[0]["cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["name"] != null && ds.Tables[0].Rows[0]["name"].ToString() != "")
                {
                    this.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["parent_cid"] != null && ds.Tables[0].Rows[0]["parent_cid"].ToString() != "")
                {
                    this.parent_cid = ds.Tables[0].Rows[0]["parent_cid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pic_url"] != null && ds.Tables[0].Rows[0]["pic_url"].ToString() != "")
                {
                    this.pic_url = ds.Tables[0].Rows[0]["pic_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    this.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["nick"] != null && ds.Tables[0].Rows[0]["nick"].ToString() != "")
                {
                    this.nick = ds.Tables[0].Rows[0]["nick"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_order"] != null && ds.Tables[0].Rows[0]["sort_order"].ToString() != "")
                {
                    this.sort_order = int.Parse(ds.Tables[0].Rows[0]["sort_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpdateON"] != null && ds.Tables[0].Rows[0]["UpdateON"].ToString() != "")
                {
                    this.UpdateON = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateON"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
            }
        }

        #endregion  Method
    }
}

