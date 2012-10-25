using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Maticsoft.DBUtility;

namespace SASCMS
{
    /// <summary>
    /// Summary description for BaseFunction
    /// </summary>
    public class BaseFunction
    {
        public BaseFunction()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        /// <summary>
        /// 获得逐级缩进的栏目名
        /// </summary>
        /// <param name="sName">栏目名</param>
        /// <param name="sCode">栏目code</param>
        /// <returns>逐级缩进的栏目名</returns>
        public static string getColumnListName(string sName, string sCode)
        {
            int Level = (sCode.Length / 4 - 1) * 2;
            string sStr = sCode.Length == 4 ? "" : "├";
            if (Level > 0)
            {
                for (int i = 0; i < Level; i++)
                    sStr += "－";
            }
            return sStr + sName;
        }
        /// <summary>
        /// 获得xml文件节点值
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="xmlFilePath"></param>
        /// <returns></returns>
        public  static string  GetXmlNodeValue(string rootNodeName,string nodeName,string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(xmlFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode(rootNodeName).ChildNodes;//获取systemConfig节点的所有子节点
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    if (xn.Name == nodeName)
                    {
                        return xn.InnerText;
                    }
                }

                return "没有此节点！";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// 获得xml文件节点值
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="xmlFilePath"></param>
        /// <returns></returns>
        public static void BindDllByCnfig(string xmlFilePath, string xpath, DropDownList ddl)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(xmlFilePath);
            XmlNodeList nodeList = xmlDoc.SelectNodes(xpath);

            foreach (XmlNode xn in nodeList)//遍历所有子节点
            {
                ListItem li = new ListItem();
                li.Text = xn.InnerText;
                li.Value = xn.InnerText;
                ddl.Items.Add(li);
            }
        }

        /// <summary>
        /// 设置xml文件节点值
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="xmlFilePath"></param>
        /// <returns></returns>
        public static void SetXmlNodeValue(string rootNodeName, string nodeName, string xmlFilePath,string nodeValue)
        {
            XmlDocument xmlDoc = new XmlDocument();
            //try
            //{
                xmlDoc.Load(xmlFilePath);

                XmlNodeList nodeList = xmlDoc.SelectSingleNode(rootNodeName).ChildNodes;//获取systemConfig节点的所有子节点

                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    if (xn.Name == nodeName)
                    {
                        xn.InnerText = nodeValue;
                        //lblMsg.Text = "修改成功";
                        break;
                    }
                }
                xmlDoc.Save(xmlFilePath);//保存
            //}
            //catch (Exception ex)
            //{
            //    //lblMsg.Text = ex.ToString();
            //}
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="TableNames">表名，可以是多个表，但不能用别名</param>
        /// <param name="PrimaryKey">主键，可以为空，但@Order为空时该值不能为</param>
        /// <param name="Fields">要取出的字段，可以是多个表的字段，可以为空，为空表示select *</param>
        /// <param name="PageSize">每页记录数</param>
        /// <param name="CurrentPage">当前页，0表示第1页</param>
        /// <param name="Filter">条件，可以为空，不用填 where</param>
        /// <param name="Group">分组依据，可以为空，不用填 group by</param>
        /// <param name="Order">排序，可以为空，为空默认按主键升序排列，不用填 order by</param>
        /// <returns></returns>
        public static DataSet getDateByPager(string TableNames, string PrimaryKey, string Fields, string PageSize, string CurrentPage, string Filter, string Group, string Order)
        {
            System.Data.SqlClient.SqlParameter[] spParas = new System.Data.SqlClient.SqlParameter[8];

            spParas[0] = new System.Data.SqlClient.SqlParameter("@TableNames", SqlDbType.VarChar, 200);
            spParas[1] = new System.Data.SqlClient.SqlParameter("@PrimaryKey", SqlDbType.VarChar, 200);
            spParas[2] = new System.Data.SqlClient.SqlParameter("@Fields", SqlDbType.VarChar, 200);
            spParas[3] = new System.Data.SqlClient.SqlParameter("@PageSize", SqlDbType.Int);
            spParas[4] = new System.Data.SqlClient.SqlParameter("@CurrentPage", SqlDbType.Int);
            spParas[5] = new System.Data.SqlClient.SqlParameter("@Filter", SqlDbType.VarChar, 200);
            spParas[6] = new System.Data.SqlClient.SqlParameter("@Group", SqlDbType.VarChar, 200);
            spParas[7] = new System.Data.SqlClient.SqlParameter("@Order", SqlDbType.VarChar, 200);

            spParas[0].Value = TableNames;
            spParas[1].Value = PrimaryKey;
            spParas[2].Value = Fields;
            spParas[3].Value = PageSize;
            spParas[4].Value = CurrentPage;
            spParas[5].Value = Filter;
            spParas[6].Value = Group;
            spParas[7].Value = Order;

            return SASCMS.DBUtility.DbHelperSQL.RunProcedure("usp_PagingLarge", spParas, "dtPage");

        }
        public static DataSet getDateByPager(string TableNames, string PrimaryKey, string Fields, string PageSize, string CurrentPage, string Filter, string Group, string Order,bool isSql)
        {
            int topNum = int.Parse(PageSize) * int.Parse(CurrentPage);

            string sql = "";
            if (topNum == 0)
            {
                sql = "select " + Fields + " from " + TableNames + " where " + Filter + " order by " + Order + " LIMIT " + PageSize;
            }
            else
            {
                sql = "select " + Fields + " from " + TableNames + " where " + Filter + "and  " + PrimaryKey + " not in(select top " + topNum + " " + PrimaryKey + " from " + TableNames + " where " + Filter + "order by " + Order + ") order by " + Order + " LIMIT " + PageSize;
            }
            //return SASCMS.DBUtility.DbHelperSQL.RunProcedure("usp_PagingLarge", spParas, "dtPage");
            //return SASCMS.DBUtility.DbHelperSQL.Query(sql);
            return Maticsoft.DBUtility.DbHelperMySQL.Query(sql);
        }
        public static DataSet getDateByPager(string TableNames, string PrimaryKey, string Fields, string PageSize, string CurrentPage, string Filter, string Group, string Order, out int recordCount)
        {
            int topNum = int.Parse(PageSize) * int.Parse(CurrentPage);
            recordCount = SASCMS.DBUtility.DbHelperSQL.ExecuteSqlNum("select count(" + PrimaryKey + ") from " + TableNames + " where " + Filter);
            string sql = "";
            if (topNum <= 0)
            {
                sql = "select top " + PageSize + " " + Fields + " from " + TableNames + " where " + Filter + " order by " + Order;
            }
            else
            {
                sql = "select top " + PageSize + " " + Fields + " from " + TableNames + " where " + Filter + "and  " + PrimaryKey + " not in(select top " + topNum + " " + PrimaryKey + " from " + TableNames + " where " + Filter + "order by " + Order + ") order by " + Order;
            }
            //return SASCMS.DBUtility.DbHelperSQL.RunProcedure("usp_PagingLarge", spParas, "dtPage");
            //return SASCMS.DBUtility.DbHelperSQL.Query(sql);
            return Maticsoft.DBUtility.DbHelperMySQL.Query(sql);
        }
        //获得session信息
        public static string GetSessinValueByName(System.Web.UI.Page page,string sessionName)
        {
            string sessionInfos = page.Session["LoginInfo"].ToString();
            string[] sessionInfo=sessionInfos.Split('|');

            for (int i = 0; i < sessionInfo.Length; i++)
            {
                if (sessionInfo[i].Split('=')[0] == sessionName)
                {
                    return sessionInfo[i].Split('=')[1];
                }
            }

            return "NoSession";
        }

        static string N_no = "drop|--|=|;|'|*|%|and|20%and20%|master20%master20%|exec|insert|select|delete|count|chr|mid|truncate|char|declare|and|update|master|or|join|cmd";
        //检测输入参数
        public static void CheckInPut(string str, System.Web.UI.Page page)
        {
            string[] N_noarray = N_no.Split(new char[] { '|' });
            for (int i = 0; i < N_noarray.Length; i++)
            {
                if (str.IndexOf(N_noarray[i]) >= 0)
                {
                    WriteParamError(page.Request, page.Response, N_noarray[i]);
                }
            }
        }

        //MD5加密16位
        public static string ToMd5Str16(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string pwd = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str)), 4, 8);
            pwd = pwd.Replace("-", "");
            return pwd;
        }

        //根据系统时间生成文件夹名称
        public static string getFolderName()
        {
            DateTime dt = DateTime.Now;

            string folderName = dt.Year.ToString() + dt.Month.ToString();

            return folderName;
        }

        //根据系统时间生成文件夹名称
        public static string getFileName()
        {
            DateTime dt = DateTime.Now;

            string fileName = dt.Year.ToString() + getTwoNum(dt.Month) + getTwoNum(dt.Day) + getTwoNum(dt.Hour) + getTwoNum(dt.Minute) + getTwoNum(dt.Second);

            return fileName;
        }

        //时间日期为个位时，补0
        public static string getTwoNum(int num)
        {
            if (num < 10)
            {
                return "0" + num.ToString();
            }
            else
            {
                return num.ToString();
            }
        }

        //弹出信息
        public static void alert(System.Web.UI.Page page, string msg)
        {
            page.RegisterClientScriptBlock("", "<script>alert('" + msg + "！');</script>");
        }

        //截取一定长度的字符串
        public static string cutString(string str,int lenth)
        {
            if (lenth != 0)
            {
                if (str.Length < lenth)
                {
                    return str;
                }
                else
                {
                    return str.Substring(0, lenth) + "";
                }
            }
            else
            {
                return str;
            }
        }

        //检测输入参数
        public static bool CheckSqlStr(string str)
        {
            string[] N_noarray = N_no.Split(new char[] { '|' });
            for (int i = 0; i < N_noarray.Length; i++)
            {
                if (str.IndexOf(N_noarray[i]) >= 0)
                {
                    return false;
                }
            }
            return true;
        }
        ///   <summary>   
        ///   去除HTML标记   
        ///   </summary>   
        ///   <param   name="NoHTML">包括HTML的源码   </param>   
        ///   <returns>已经去除后的文字</returns>   
        public static string NoHTML(string Htmlstring)
        {
            //删除脚本   
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            //删除HTML   
            Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);

            Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", "   ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);

            Htmlstring.Replace("<", "");
            Htmlstring.Replace(">", "");
            Htmlstring.Replace("\r\n", "");
            Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();

            return Htmlstring;
        }

        public static DateTime GetCurrDT()
        {
            return DateTime.Now;
        }

        public static string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool GetBool(string strBool)
        {
            Boolean boolean = false;
            if (strBool != null && strBool.Length > 0)
            {
                 Boolean.TryParse(strBool,out boolean);
                 return boolean;
            }
            else
            {
                return boolean;
            }
        }

        public static void WriteParamError(System.Web.HttpRequest Request, System.Web.HttpResponse Response,string  errorParam)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("<table align=center><tr><td><span style='font-size:12px'>参数错误!系统做了如下记录:<br>");
            sb.Append("操作IP：" + Request.ServerVariables["REMOTE_ADDR"] + "<br>");
            sb.Append("操作时间：" + DateTime.Now + "<br>");
            sb.Append("操作页面：" + Request.ServerVariables["URL"].ToLower() + "<br>");
            sb.Append("提交数据：" + errorParam + "</span><td><tr><table>");
            LogparamInfo(NoHTML(sb.ToString()));
            Response.Write(sb.ToString());
            Response.End();
        }

        public static void LogparamInfo(string errorInfo)
        {
            SASCMS.BaseFunction.LogInfo("~/log/", "paramError.txt", errorInfo);
        }
        public static void LogInfo(string path, string fileName, string errorInfo)
        {
            SASCMS.Log.LogInfo logInfo = new SASCMS.Log.LogInfo();
            logInfo.FileLogPath = System.Web.HttpContext.Current.Server.MapPath(path);
            logInfo.WriteLog(fileName, errorInfo);
        }

        public static string GetUserStatus(int status)
        {
            string strStatus = "";

            switch(status)
            {
                case 0:
                    strStatus= "<span class='red'>未审核</span>";
                    break;
                case 1:
                    strStatus = "<span class='green'>已审核</span>";
                    break;
                case 2:
                    strStatus = "<span class='nopass'>未通过</span>";
                    break;
            }

            return strStatus;
        }
    }
}
