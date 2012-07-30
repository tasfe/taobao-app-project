using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

using Top.Api;
using Top.Api.Response;
using Top.Api.Request;

public partial class pages_Default : Shop.ShopUI.BasePage
{
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 10;
    protected string nick = "";
    protected string shopName="";
    protected string shopUrl = "http://store.taobao.com/?shop_id={0}";

    int mailCount = 100;

    protected void Page_Load(object sender, EventArgs e)
    {
        CheckLogin();
        nick = GetSessionString("tb_username");
        DoAction();
        
        currPage = GetQueryInt("p");
        currPage = currPage == 0 ? 1 : currPage;
        BindProduct(currPage);
        GetShop();
    }

    protected void GetShop()
    {
        Shop.DataAccess.tb_user tb_user = new Shop.DataAccess.tb_user();
        tb_user.GetModelByNick(nick);
        shopName = tb_user.tx_key;
        shopUrl = string.Format(shopUrl, tb_user.tx_secret);
        if (Response.Cookies["mailtitle"] != null)
        {
            txtSubject.Text = Response.Cookies["mailtitle"].Value;
        }
        else
        {
            txtSubject.Text = string.Format("小店又上新货了，老客户88折优惠哦,欢迎光临【{0}】", shopName);
        }

        FCKeditor1.Value = string.Format("<a href='{0}' target='_blank'>{1}</a><br/>", shopUrl, shopName);
    }

    protected void BindProduct(int pageNo)
    {
        ITopClient client = TaobaoUtil.DefaultTopClient.GetDefaultTopClient();
        ItemsGetRequest req = new ItemsGetRequest();
        req.Fields = "num_iid,title,nick,pic_url,cid,price,type,delist_time,post_fee,score,volume,detailurl";
        req.Nicks = nick;
        req.PageSize = pageSize;
        req.PageNo = pageNo;
        req.OrderBy = "delist_time:desc";
        ItemsGetResponse response = client.Execute(req);
        count = response.TotalResults;
        Repeater1.DataSource = response.Items;
        Repeater1.DataBind();
    }

    protected void DoAction()
    {
        string action = GetQueryString("action");
        if (string.IsNullOrEmpty(action))
        {
            action = GetFormString("action");
        }
        if (action == "sendmail")
        {
            Response.Write(SendMail());
            Response.End();
        }
    }

    public void CheckLogin()
    {
        if (GetSession("tb_username") == null)
        {
            Response.Redirect("Default.aspx?from=timeout");
        }
    }

    protected string SendMail()
    {
        string result = "{\"result\":\"{0}\",\"msg\":\"{1}\",\"info\":\"{2}\"}";
        try
        {
            Shop.DataAccess.tb_user tb_user = new Shop.DataAccess.tb_user();
            tb_user.GetModelByNick(nick);
            if (int.Parse(tb_user.sina_secret) > mailCount)
            {
                return result.Replace("{0}", "no").Replace("{1}", "你当月已发送了" + tb_user.sina_secret + "个邮件地址，不能再发送了。").Replace("{2}", "");
            }

            string content = Request.Form["content"];
            string toList = Request.Form["to"];
            string subject = Request.Form["subject"];
            Response.SetCookie(new HttpCookie("mailtitle", subject));

            string[] toAddr = toList.Split(';');
            Random radom = new Random();
            int r = radom.Next(1, 9);
            string sendFrom = string.Format("edm{0}@taofantian.net",r);
            string sendPwd = string.Format("password{0}", r);

            int sendCount = 0;
            string sendResult = SendGMail(toAddr, subject, content, sendFrom, sendPwd, out sendCount);
            if (sendCount > 0)
            {
                
                tb_user.Update();
            }

            return result.Replace("{0}", "yes").Replace("{1}", "").Replace("{2}", sendResult);
        }
        catch (Exception e)
        {
            return result.Replace("{0}", "no").Replace("{1}", e.ToString()).Replace("{2}", e.ToString());
        }
    }

    public string SendGMail(string[] to, string subject, string content, string sendFrom, string sendPwd,out int sendCount)
    {
        MailMessage onemail = new MailMessage();
        string myEmail = sendFrom; //发送邮件的邮箱地址
        string myPwd = sendPwd; //发送邮件的邮箱密码
        onemail.BodyEncoding = System.Text.Encoding.UTF8;
        onemail.IsBodyHtml = true;
        onemail.From = new MailAddress(myEmail);

        Regex mailRegex = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", RegexOptions.IgnoreCase);

        foreach (string thisAdd in to)
        {
            if (mailRegex.Match(thisAdd).Success)
            {
                onemail.Bcc.Add(new MailAddress(thisAdd));
            }
        }
        sendCount = onemail.Bcc.Count;

        onemail.Subject = subject;
        onemail.Body = content;
        SmtpClient clint = new SmtpClient("smtp.gmail.com", 587);//发送邮件的服务器
        clint.Credentials = new System.Net.NetworkCredential(myEmail, myPwd);
        clint.EnableSsl = true;
        clint.Timeout = 15000;
        try
        {
            clint.Send(onemail);
            Shop.Log.LogInfo.FileLogPath = Server.MapPath("~/sellermail/log");
            Shop.Log.LogInfo.LogFileName = "sendmail.log";
            Shop.Log.LogInfo.WriteLog(string.Format("【{0}】【{1}】\r{2}", myEmail, myPwd, onemail.To.ToString()));
        }
        catch (Exception ex)
        {
            Shop.Log.LogInfo.FileLogPath = Server.MapPath("~/sellermail/log");
            Shop.Log.LogInfo.LogFileName = "failedmail.log";
            Shop.Log.LogInfo.WriteLog(string.Format("【{0}】【{1}】---\r{2}", myEmail, myPwd, ex.ToString()));
            return ex.ToString();
        }
        return "";
    }

}