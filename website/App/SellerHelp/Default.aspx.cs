using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

using Top.Api.Response;
using Top.Api.Domain;

public partial class pages_Default : Shop.ShopUI.BasePage
{
    protected string jumpUrl = "Main.aspx";
    protected string from = "unknow";
    protected void Page_Load(object sender, EventArgs e)
    {
        from = GetQueryString("from");

        if (!string.IsNullOrEmpty(from)) 
        {
            if (from == "tb")
            {
                UserGetResponse userGetResponse = new UserGetResponse();
                //taobao open login
                if (CheckOpenTaobaoLogin(out userGetResponse))             
                {
                    SetFromCookie("tb_username", userGetResponse.User.Nick);
                    SetFromCookie("top_session", GetQueryString("top_session"));
                    SetFromCookie("subscribe_code", GetSubscribe(userGetResponse.User.Nick));
                    jumpUrl = jumpUrl + "?top_session=" + GetQueryString("top_session");
                }
                else
                {
                    from = "unknow";
                }
            }
            else if (from == "timeout")
            {
                from = "unknow";
            }
        }
        else
        {
            from = "unknow";
        }
    }

    protected bool CheckOpenTaobaoLogin(out UserGetResponse userGetResponse)
    {
        string callBackUrl = Request.Url.ToString();
        bool verify = Top.Api.Util.TopUtils.VerifyTopResponse(callBackUrl, ShopUtil.XmlCOM.ReadConfig("TaobaoAppSecret"));
        if (verify)
        {
            ShopUtil.OpenTaobaoUtil commonUtil = new ShopUtil.OpenTaobaoUtil();
            userGetResponse = commonUtil.GetLoginUser(GetQueryString("top_session"));

            if (userGetResponse.IsError)
            {
                ShopUtil.Mail.SendMail("29738637@qq.com", "淘翻天卖家助手", userGetResponse.Body);
                ShopUtil.LogInfo.FileLogPath = Server.MapPath("~/app/Sellerhelp/log");
                ShopUtil.LogInfo.WriteLog("top_log_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", userGetResponse.ErrMsg + "|" + userGetResponse.Body + "|");
            }
        }
        else
        {
            userGetResponse = null;
        }
        return verify;
    }

    protected string GetSubscribe(string nick)
    {
        List<ArticleUserSubscribe> articleUserSubscribes = ShopUtil.OpenTaobaoUtil.GetVasSubscribeGetResponse(nick, "ts-13815").ArticleUserSubscribes;//TaobaoUtil.CommonUtil.GetVasSubscribeGetResponse(nick, "ts-13815");
        if (articleUserSubscribes != null && articleUserSubscribes.Count > 0)
        {
            return articleUserSubscribes[0].ItemCode;
        }
        else
        {
            return "";
        }
    }
}