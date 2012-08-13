using System;
using System.Data;
using System.Configuration;

namespace Shop.DataAccess
{
    /// <summary>
    /// ArticleCommon 的摘要说明
    /// </summary>
    public class ArticleCommon
    {
        public ArticleCommon()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public static DataTable GetArticle(string where,int titleLength)
        {
            Shop.BLL.TB_ArticleBll articleBll = new Shop.BLL.TB_ArticleBll();
            DataTable dtArticle = articleBll.GetList(where).Tables[0];
            for (int i = 0; i < dtArticle.Rows.Count; i++)
            {
                dtArticle.Rows[i]["TF"] = Shop.BaseFunction.cutString(dtArticle.Rows[i]["TF"].ToString(), titleLength);
            }
            return dtArticle; 
        }

        public static DataTable GetArticle(string where, int titleLength ,int topNum)
        {
            string strSql = "select top "+topNum.ToString()+" * from tb_article where " + where;
            DataTable dtArticle = Shop.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            for (int i = 0; i < dtArticle.Rows.Count; i++)
            {
                dtArticle.Rows[i]["TF"] = Shop.BaseFunction.cutString(dtArticle.Rows[i]["TF"].ToString(), titleLength);
            }
            return dtArticle;
        }
    }
}
