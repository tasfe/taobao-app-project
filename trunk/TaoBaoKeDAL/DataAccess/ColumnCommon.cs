using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace Shop.DataAccess
{
    /// <summary>
    /// ColumnCommon 的摘要说明
    /// </summary>
    public class ColumnCommon
    {
        public ColumnCommon()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        static Shop.BLL.TB_ColumnBll columnBll = new Shop.BLL.TB_ColumnBll();
        public static DataTable GetColumn(string where, int titleLength)
        {
            DataTable dt = columnBll.GetList(where).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["title"] = Shop.BaseFunction.cutString(dt.Rows[i]["title"].ToString(), titleLength);
            }
            return dt;
        }

        public static string GetFirstChildID(string colID)
        {
            DataTable dt = columnBll.GetList(" parentId='"+colID+"' order by code").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }
            else
            {
                return colID;
            }
        }
        //public static List<KeyValuePair<string,string>> GetColumnList(string colId)
        //{
        //    List<KeyValuePair<string, string>> categoryList = new List<KeyValuePair<string, string>>();
        //    DataTable dt = GetProductCategory();
        //    DataRow[] dr = dt.Select("id='" + colId + "'");

        //    if (dr.Length > 0)
        //    {
        //        string tempId = dr[0]["id"].ToString();
        //        categoryList.Add(new KeyValuePair<string,string>(tempId,dr[0]["title"].ToString()));

        //        string tempPId = dr[0]["parentid"].ToString();
        //        if (tempPId != "0")
        //        {
        //            categoryList.Add(GetColumnList(tempPId)[0]);
        //        }
        //    }

        //    return categoryList;
        //}

        //public static string GetColumnPath(string colId)
        //{
        //    string pathHtml = ""; 
        //    List<KeyValuePair<string, string>> categoryList = ColumnCommon.GetColumnList(colId);
        //    for (int i = 1; i <= categoryList.Count; i++)
        //    {
        //        pathHtml += "<a href=\"Category_" + categoryList[categoryList.Count - i].Key + ".aspx\" target=_blank>" + categoryList[categoryList.Count - i].Value + "</a> &gt";
        //    }
        //    return pathHtml;
        //}

        //public static DataTable GetProductCategory(string code)
        //{
        //    DataTable  categoryCache =(DataTable)CacheCustom.Get("CategoryCache" + code);
        //    if (categoryCache== null || categoryCache.Rows.Count==0)
        //    {
        //        string strWhere = " Code like '"+code+"%' order by code";
        //        categoryCache = columnBll.GetList(strWhere).Tables[0];
        //        CacheCustom.Insert("CategoryCache"+code, categoryCache);
        //    }
        //    return categoryCache;
        //}

        //public static DataTable GetProductCategory()
        //{
        //    DataTable categoryCache = (DataTable)CacheCustom.Get("CategoryCache");
        //    if (categoryCache == null)
        //    {
        //        string strWhere = " 1=1 order by code";
        //        categoryCache = columnBll.GetList(strWhere).Tables[0];
        //        CacheCustom.Insert("CategoryCache", categoryCache);
        //    }
        //    return (DataTable)categoryCache;
        //}
    }
}
