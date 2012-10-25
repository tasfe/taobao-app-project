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
        /// �������������Ŀ��
        /// </summary>
        /// <param name="sName">��Ŀ��</param>
        /// <param name="sCode">��Ŀcode</param>
        /// <returns>����������Ŀ��</returns>
        public static string getColumnListName(string sName, string sCode)
        {
            int Level = (sCode.Length / 4 - 1) * 2;
            string sStr = sCode.Length == 4 ? "" : "��";
            if (Level > 0)
            {
                for (int i = 0; i < Level; i++)
                    sStr += "��";
            }
            return sStr + sName;
        }
        /// <summary>
        /// ���xml�ļ��ڵ�ֵ
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
                XmlNodeList nodeList = xmlDoc.SelectSingleNode(rootNodeName).ChildNodes;//��ȡsystemConfig�ڵ�������ӽڵ�
                foreach (XmlNode xn in nodeList)//���������ӽڵ�
                {
                    if (xn.Name == nodeName)
                    {
                        return xn.InnerText;
                    }
                }

                return "û�д˽ڵ㣡";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// ���xml�ļ��ڵ�ֵ
        /// </summary>
        /// <param name="nodeName"></param>
        /// <param name="xmlFilePath"></param>
        /// <returns></returns>
        public static void BindDllByCnfig(string xmlFilePath, string xpath, DropDownList ddl)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(xmlFilePath);
            XmlNodeList nodeList = xmlDoc.SelectNodes(xpath);

            foreach (XmlNode xn in nodeList)//���������ӽڵ�
            {
                ListItem li = new ListItem();
                li.Text = xn.InnerText;
                li.Value = xn.InnerText;
                ddl.Items.Add(li);
            }
        }

        /// <summary>
        /// ����xml�ļ��ڵ�ֵ
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

                XmlNodeList nodeList = xmlDoc.SelectSingleNode(rootNodeName).ChildNodes;//��ȡsystemConfig�ڵ�������ӽڵ�

                foreach (XmlNode xn in nodeList)//���������ӽڵ�
                {
                    if (xn.Name == nodeName)
                    {
                        xn.InnerText = nodeValue;
                        //lblMsg.Text = "�޸ĳɹ�";
                        break;
                    }
                }
                xmlDoc.Save(xmlFilePath);//����
            //}
            //catch (Exception ex)
            //{
            //    //lblMsg.Text = ex.ToString();
            //}
        }
        /// <summary>
        /// ��ҳ
        /// </summary>
        /// <param name="TableNames">�����������Ƕ�����������ñ���</param>
        /// <param name="PrimaryKey">����������Ϊ�գ���@OrderΪ��ʱ��ֵ����Ϊ</param>
        /// <param name="Fields">Ҫȡ�����ֶΣ������Ƕ������ֶΣ�����Ϊ�գ�Ϊ�ձ�ʾselect *</param>
        /// <param name="PageSize">ÿҳ��¼��</param>
        /// <param name="CurrentPage">��ǰҳ��0��ʾ��1ҳ</param>
        /// <param name="Filter">����������Ϊ�գ������� where</param>
        /// <param name="Group">�������ݣ�����Ϊ�գ������� group by</param>
        /// <param name="Order">���򣬿���Ϊ�գ�Ϊ��Ĭ�ϰ������������У������� order by</param>
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
        //���session��Ϣ
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
        //����������
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

        //MD5����16λ
        public static string ToMd5Str16(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string pwd = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str)), 4, 8);
            pwd = pwd.Replace("-", "");
            return pwd;
        }

        //����ϵͳʱ�������ļ�������
        public static string getFolderName()
        {
            DateTime dt = DateTime.Now;

            string folderName = dt.Year.ToString() + dt.Month.ToString();

            return folderName;
        }

        //����ϵͳʱ�������ļ�������
        public static string getFileName()
        {
            DateTime dt = DateTime.Now;

            string fileName = dt.Year.ToString() + getTwoNum(dt.Month) + getTwoNum(dt.Day) + getTwoNum(dt.Hour) + getTwoNum(dt.Minute) + getTwoNum(dt.Second);

            return fileName;
        }

        //ʱ������Ϊ��λʱ����0
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

        //������Ϣ
        public static void alert(System.Web.UI.Page page, string msg)
        {
            page.RegisterClientScriptBlock("", "<script>alert('" + msg + "��');</script>");
        }

        //��ȡһ�����ȵ��ַ���
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

        //����������
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
        ///   ȥ��HTML���   
        ///   </summary>   
        ///   <param   name="NoHTML">����HTML��Դ��   </param>   
        ///   <returns>�Ѿ�ȥ���������</returns>   
        public static string NoHTML(string Htmlstring)
        {
            //ɾ���ű�   
            Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            //ɾ��HTML   
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
            sb.Append("<table align=center><tr><td><span style='font-size:12px'>��������!ϵͳ�������¼�¼:<br>");
            sb.Append("����IP��" + Request.ServerVariables["REMOTE_ADDR"] + "<br>");
            sb.Append("����ʱ�䣺" + DateTime.Now + "<br>");
            sb.Append("����ҳ�棺" + Request.ServerVariables["URL"].ToLower() + "<br>");
            sb.Append("�ύ���ݣ�" + errorParam + "</span><td><tr><table>");
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
                    strStatus= "<span class='red'>δ���</span>";
                    break;
                case 1:
                    strStatus = "<span class='green'>�����</span>";
                    break;
                case 2:
                    strStatus = "<span class='nopass'>δͨ��</span>";
                    break;
            }

            return strStatus;
        }
    }
}
