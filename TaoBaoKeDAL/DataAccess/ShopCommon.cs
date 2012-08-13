using System;
using System.Data;
using System.Configuration;
using Shop;
/// <summary>
/// Summary description for ShopCommon
/// </summary>
public class ShopCommon
{
    public ShopCommon()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static DataTable GetShop(string where, int titleLength, int topNum)
    {
        string strSql = "select top " + topNum.ToString() + " * from tb_shop where " + where;
        DataTable dt = Shop.DBUtility.DbHelperSQL.Query(strSql).Tables[0];

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt.Rows[i]["title"] = Shop.BaseFunction.cutString(BaseFunction.NoHTML(dt.Rows[i]["title"].ToString()), titleLength);
        }

        return dt;
    }
}
