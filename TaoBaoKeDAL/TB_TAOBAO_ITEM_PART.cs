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
    public partial class TB_TAOBAO_ITEM
    {
        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModelByNumiid(string numid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Desc,Title,ClickUrl,Commission,EmsFee,ExpressFee,FreightPayer,City,Nick,NumIid,PostFee,Price,SellerCreditScore,ShopClickUrl,Volume,ItemImgs,PropImgs,Category,Pic_Url,TopCategory,UpdateOn,ID ");
            strSql.Append(" FROM [TB_TAOBAO_ITEM] ");
            strSql.Append(" where NumIid=@NumIid ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@NumIid", OleDbType.VarChar)};
            parameters[0].Value = numid;

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
       
        #endregion  Method
    }
}

