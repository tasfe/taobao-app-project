using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web;
using System.IO;
namespace ShopUtil
{
    public static class XmlCOM
    {
        public static DataSet ReadXml(string path)
        {
            DataSet ds = new DataSet();
            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs, System.Text.Encoding.UTF8);
                ds.ReadXml(reader);
                return ds;
            }
            finally
            {
                fs.Close();
                reader.Close();
            }
        }
        /// <summary>
        /// 读取Config参数
        /// </summary>
        public static string ReadConfig(string name, string key)
        {
            System.Xml.XmlDocument xd = new System.Xml.XmlDocument();
            xd.Load(name);
            System.Xml.XmlNodeList xnl = xd.GetElementsByTagName(key);
            if (xnl.Count == 0)
                return "";
            else
            {
                System.Xml.XmlNode mNode = xnl[0];
                return mNode.InnerText;
            }
        }
        /// <summary>
        /// 读取Config参数
        /// </summary>
        public static string ReadConfig(string key)
        {
            string filePath = "~/SellerHelp/config/site.config";

            if (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["ConfigFile"]))
            {
                filePath = System.Configuration.ConfigurationManager.AppSettings["ConfigFile"];
            }

            return ReadConfig(System.Web.HttpContext.Current.Server.MapPath(filePath), key);
        }
        /// <summary>
        /// 保存Config参数
        /// </summary>
        public static void UpdateConfig(string name, string nKey, string nValue)
        {
            if (ReadConfig(name, nKey) != "")
            {
                System.Xml.XmlDocument XmlDoc = new System.Xml.XmlDocument();
                XmlDoc.Load(name);
                System.Xml.XmlNodeList elemList = XmlDoc.GetElementsByTagName(nKey);
                System.Xml.XmlNode mNode = elemList[0];
                mNode.InnerText = nValue;
                System.Xml.XmlTextWriter xw = new System.Xml.XmlTextWriter(new System.IO.StreamWriter(HttpContext.Current.Server.MapPath(name + ".config")));
                xw.Formatting = System.Xml.Formatting.Indented;
                XmlDoc.WriteTo(xw);
                xw.Close();
            }
        }
    }
}
