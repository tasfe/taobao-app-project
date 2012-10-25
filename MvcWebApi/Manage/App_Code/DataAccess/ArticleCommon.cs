using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SASCMS.DataAccess
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

        public static void BindNews(string where, int titleLength, int topNum, Repeater repeater)
        {
            repeater.DataSource = GetArticle(where +" and ispass=1 and isdelete=0 ", titleLength, topNum);
            repeater.DataBind();
        }

        public static DataTable GetArticle(string where,int titleLength)
        {
            SASCMS.BLL.TB_ArticleBll articleBll = new SASCMS.BLL.TB_ArticleBll();
            DataTable dtArticle = articleBll.GetList(where).Tables[0];
            for (int i = 0; i < dtArticle.Rows.Count; i++)
            {
                dtArticle.Rows[i]["TF"] = SASCMS.BaseFunction.cutString(dtArticle.Rows[i]["TF"].ToString(), titleLength);
            }
            return dtArticle; 
        }

        public static DataTable GetArticle(string where, int titleLength ,int topNum)
        {
            string strSql = "select top "+topNum.ToString()+" * from tb_article where " + where +" ORDER BY ADDDATE DESC,qwbs";
            DataTable dtArticle = SASCMS.DBUtility.DbHelperSQL.Query(strSql).Tables[0];
            for (int i = 0; i < dtArticle.Rows.Count; i++)
            {
                dtArticle.Rows[i]["TF"] = SASCMS.BaseFunction.cutString(dtArticle.Rows[i]["TF"].ToString(), titleLength);
            }
            return dtArticle;
        }

        public static void UpdateArticleHits(string id)
        {
            string strSql = "update tb_article set viewnum=viewnum+1 where qwbs='"+id+"'";

            SASCMS.DBUtility.DbHelperSQL.ExecuteSql(strSql);
        }
    }
}
