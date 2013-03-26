using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;
using Top.Api.Parser;
using Top.Api.Response;
using Top.Api.Util;

public partial class pages_Ajax : UI.PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {      
        string action = GetQueryString("a").ToString();
        if (action == "1")
        {
            int page = 1;
            int.TryParse(Request.QueryString["p"], out page);
            Response.Write(GetTaobaoItemJson(page));
        }
        else if (action == "2")
        {
            AddPic(GetQueryString("c"), GetQueryString("p"));
        }
        else if (action == "3")
        {
            AddSina(GetQueryString("c"), GetQueryString("p"));
        }
        else if (action == "4")
        {
            AddOrDelTemplate(GetQueryString("t"), 0);
        }
        else if (action == "5")
        {
            AddOrDelTemplate("", GetQueryInt("tid"));
        }
        Response.End();
    }
    private string GetTaobaoItemJson(int pageNo)
    {
        //int pageSize = 10;
        //ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "12082147", "16d11b54940058660ee9dc4b5d37a004", "json");
        //ItemsGetRequest req = new ItemsGetRequest();
        //req.Fields = "num_iid,title,nick,pic_url,cid,price,type,delist_time,post_fee,score,volume,detailurl";
        //req.Nicks = "shenjinkui1984";
        //req.PageSize = pageSize;
        //req.PageNo = pageNo;
        //ItemsGetResponse response = client.Execute(req);

        //int pageCount=(int)response.TotalResults/pageSize;
        
        //return response.Body;
        return "";
    }

    protected void AddPic(string content, string pic)
    {
        try
        {
            string key=GetQueryString("k");
            if (CheckDaySend(key))
            {
                //QQAPIUtil qqUtil = new QQAPIUtil("", "", "");

                //qqUtil.accessKey = key; //Session["tx_key"].ToString();
                //qqUtil.accessSecret = GetQueryString("s");// Session["tx_secret"].ToString();
                //List<string> t = new List<string>();
                //t.Add(content);
                //t.Add(Request.UserHostAddress);
                //t.Add("");
                //t.Add("");
                //string fileName = DownLoadFile(pic);

                //t.Add(fileName);
                ////System.Threading.Thread.Sleep(5000);
                //string result = qqUtil.QQTAddPic(t);
                //Response.Write(result);
                //weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                //access_weibo.UpdateDaySend(key);

                //DeleteFile(fileName);

                OAuthTXWeibo.t t = new OAuthTXWeibo.t();
                t.access_token = GetQueryString("accesstoken");
                t.oauth_consumer_key = ShopUtil.XmlCOM.ReadConfig("TXAppKey");
                t.openid = GetQueryString("k");

                t.clientip = Request.UserHostAddress;//GetClientIP();

                string fileName = "";
                if (pic.Length > 0)
                {
                    fileName = DownLoadFile(pic);
                }
                else
                {
                    fileName = Server.MapPath("~/app/SellerWeibo/static/images/logo/tx.png");
                }

                //QWeiboSDK.OauthKey oauthKey = new QWeiboSDK.OauthKey();
                //oauthKey.customKey = ShopUtil.XmlCOM.ReadConfig("TXAppKey");
                //oauthKey.customSecret = ShopUtil.XmlCOM.ReadConfig("TXAppSecret");
                //oauthKey.tokenKey = key;
                //oauthKey.tokenSecret = GetQueryString("s");
                
                //QWeiboSDK.t t = new QWeiboSDK.t(oauthKey, "json");
                //UTF8Encoding utf8 = new UTF8Encoding();

                //string result = t.add_pic(utf8.GetString(utf8.GetBytes(content)),
                //    utf8.GetString(utf8.GetBytes(Request.UserHostAddress)),
                //    utf8.GetString(utf8.GetBytes("")),
                //    utf8.GetString(utf8.GetBytes("")),
                //    utf8.GetString(utf8.GetBytes(fileName)));

                string result = t.add_pic(content, Request.UserHostAddress, "", "", fileName); //t.AddPicUrl(content, "", "", pic);

                ShopUtil.LogInfo.FileLogPath = Server.MapPath("~/app/Sellerweibo/log");
                ShopUtil.LogInfo.WriteLog("tx_log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", result);
     
                weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                access_weibo.UpdateDaySend(key);
                DeleteFile(fileName);
                //<root><data><id>162090029033472</id><time>1343972664</time></data><errcode>0</errcode><msg>ok</msg><ret>0</ret><seqid>5772319312922313769</seqid></root>
                Response.Write(result);
            }
        }
        catch(Exception e)
        {
            LogInfo.WriteLog(Server.MapPath("~/app/SellerWeibo/log/tx_log.txt"), e.ToString());
            Response.Write("{\"msg\":\"error\",\"detail\":\""+e.ToString()+"\"}");
        }
    }

    protected void AddSina(string content, string pic)
    {
        try
        {
            string key = GetQueryString("k");
            if (CheckDaySend(key))
            {
                //HttpPost httpRequest = HttpRequestFactory.CreateHttpRequest(Method.POST) as HttpPost;
                //httpRequest.Token = key; //Session["sina_key"].ToString();
                //httpRequest.TokenSecret = GetQueryString("s");//Session["sina_secret"].ToString();
                //httpRequest.UserRemoteIP = Request.UserHostAddress;
                //string url = "http://api.t.sina.com.cn/statuses/upload.xml?";

                string fileName = "";
                if (pic.Length > 0)
                {
                    fileName = DownLoadFile(pic);
                }
                else
                {
                    fileName = Server.MapPath("~/pages/static/images/logo/sina.png");
                }
                ////System.Threading.Thread.Sleep(1000);
                //Response.Write(httpRequest.RequestWithPicture(url, "status=" + HttpUtility.UrlEncode(content+"["+DateTime.Now.ToString()+"]"), fileName));

                //weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                //access_weibo.UpdateDaySend(key);

                //DeleteFile(fileName);
                NetDimension.Weibo.OAuth oauth = new NetDimension.Weibo.OAuth(ShopUtil.XmlCOM.ReadConfig("SinaAppKey"),
                ShopUtil.XmlCOM.ReadConfig("SinaAppSecret"),
                ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl"));
                oauth.AccessToken = GetQueryString("accesstoken");

                FileStream fs = new FileStream(fileName, FileMode.Open);//可以是其他重载方法 
                byte[] byData = new byte[fs.Length];
                fs.Read(byData, 0, byData.Length);
                fs.Close();

                NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(oauth);
                NetDimension.Weibo.Entities.status.Entity user = Sina.API.Statuses.Upload(content + "[" + DateTime.Now.ToString() + "]"
                    , byData, 0, 0, "");

                ShopUtil.LogInfo.FileLogPath = Server.MapPath("~/app/Sellerweibo/log");
                ShopUtil.LogInfo.WriteLog("sina_log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", user.ToString());

                DeleteFile(fileName);
                
                weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                access_weibo.UpdateDaySend(key);

                Response.Write(user.ToString());
            }
        }
        catch (Exception e)
        {
            LogInfo.WriteLog(Server.MapPath("~/app/Sellerweibo/log/sina_log.txt"), e.ToString());
            Response.Write("{\"msg\":\"no\",\"detail\":\"出现网络错误，发送失败！\",\"detail1\":\" " + e.ToString().Replace("\r","").Replace("\n","") + "\"}");          
        }
    }

    protected void AddOrDelTemplate(string template,int id)
    {
        try
        {
            if (UserType() > 0)
            {
                weibo.DataAccess.tb_weibo_template weibo_template = new weibo.DataAccess.tb_weibo_template();
                if (id == 0)
                {
                    if (!weibo_template.Exists(template))
                    {
                        weibo_template.template = template;
                        weibo_template.update_on = DateTime.Now;
                        weibo_template.user_id = GetLoginUser().ID;
                        weibo_template.type = 0;
                        id = weibo_template.Add();
                    }
                }
                else
                {
                    weibo_template.Delete(id);
                }
                Response.Write("{\"msg\":\"ok\",\"id\":" + id + "}");
            }
            else
            {
                Response.Write("{\"msg\":\"no\",\"detail\":\"保存失败，确认您是付费用户\"}");
            }
        }
        catch (Exception e)
        {
            Response.Write("{\"msg\":\"error\",\"detail\":\"" + e.ToString() + "\"}");
        }
    }

    protected string DownLoadFile(string url)
    {
        System.Net.WebClient wc = new System.Net.WebClient();
        string fileName = url.Substring(url.LastIndexOf("/") + 1);

        fileName = Server.MapPath("downloadimg") + "\\" + fileName;
        if (!System.IO.File.Exists(fileName))
        {
            wc.DownloadFile(url, fileName);
        }
        return fileName;
    }

    protected void DeleteFile(string fileName)
    {
        try
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
        catch
        {

        }
    }

    protected bool CheckDaySend(string key)
    {
        //return true;
        bool ret = false;
        int userType = UserType();
        if (UserType() == 0)
        {
            weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
            access_weibo.GetModelByKey(key);
            if (access_weibo.day_send >= 3)
            {
                Response.Write("{\"msg\":\"no\",\"detail\":\" 免费用户每天只能发送3条微博，赶快<a href='http://fuwu.taobao.com/item/subsc.htm?items=ts-12485-1:1' target='_blank'>点击我升级</a>吧，只要1毛一天哦 \"}");
                //Response.End();
            }
            else
            {
                ret = true;
            }
        }
        else if (userType == -1)
        {
            Response.Write("{\"msg\":\"no\",\"detail\":\"登录超时，请刷新页面后重新登录 \"}");
            //Response.End();
        }
        else if (userType == 1)
        {
            ret = true;
        }

        return ret;
    }

    private string GetClientIP()
    {
        string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (null == result || result == String.Empty)
        {
            result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }

        if (null == result || result == String.Empty)
        {
            result = HttpContext.Current.Request.UserHostAddress;
        }
        return result;
    }


}

/// <summary>
/// 日志类
/// </summary>
public class LogInfo
{
    /// <summary>
    /// 日志文件大小
    /// </summary>
    private static int fileSize = 2048 * 1024;


    /// <summary>
    /// 日志文件的路径
    /// </summary>
    private static string fileLogPath;


    /// <summary>
    /// 日志文件的名称
    /// </summary>
    private static string logFileName;


    /// <summary>
    /// 构造函数,初始化日志文件大小[2M]
    /// 可以使用相关属性对其进行更改.
    /// </summary>
    public LogInfo()
    {
        //初始化大于2M日志文件将自动删除;
        fileSize = 2048 * 1024;//2M
        //默认路径
        fileLogPath = @"c:\logFils\";
        logFileName = "web日志.txt";
    }

    /// <summary>
    /// 获取或设置定义日志文件大小
    /// </summary>
    public static int FileSize
    {
        set
        {
            fileSize = value;
        }
        get
        {
            return fileSize;
        }
    }


    /// <summary>
    /// 获取或设置日志文件的路径
    /// </summary>
    public static string FileLogPath
    {
        set
        {
            fileLogPath = value;
        }
        get
        {
            return fileLogPath;
        }
    }


    /// <summary>
    /// 获取或设置日志文件的名称
    /// </summary>
    public static string LogFileName
    {
        set
        {
            logFileName = value;
        }
        get
        {
            return logFileName;
        }

    }



    /// <summary>
    /// 向指定目录中的指定的文件中追加日志文件
    /// </summary>
    /// <param name="Message">要写入的内容</param>
    public static void WriteLog(string Message)
    {
        WriteLog(logFileName, Message);
    }



    /// <summary>
    /// 向指定目录中的文件中追加日志文件,日志文件的名称将由传递的参数决定.
    /// </summary>
    /// <param name="LogFileName">日志文件的名称,如:mylog.txt ,如果没有自动创建,如果存在将追加写入日志</param>
    /// <param name="Message">要写入的内容</param>
    public static void WriteLog(string LogFileName, string Message)
    {

        //DirectoryInfo path=new DirectoryInfo(LogFileName);
        //如果日志文件目录不存在,则创建
        //if (!Directory.Exists(fileLogPath))
        //{
        //    Directory.CreateDirectory(fileLogPath);
        //}
        string filePath = LogFileName;//Path.Combine(fileLogPath, LogFileName);
        FileInfo fileInfo = new FileInfo(filePath);

        try
        {
            FileStream fs;
            if (fileInfo.Exists)
            {
                fs = new FileStream(filePath, FileMode.Append);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.Create);
            }
            StreamWriter strwriter = new StreamWriter(fs);
            try
            {

                DateTime d = DateTime.Now;
                strwriter.WriteLine("时间:" + d.ToString());
                strwriter.WriteLine(Message);
                strwriter.WriteLine();
                strwriter.Flush();
            }
            catch (Exception ee)
            {
                Console.WriteLine("日志文件写入失败信息:" + ee.ToString());
            }
            finally
            {
                strwriter.Close();
                strwriter = null;
                fs.Close();
                fs = null;
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine("日志文件没有打开,详细信息如下:" + ee.ToString());

        }
    }
}

