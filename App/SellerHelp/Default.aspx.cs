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
                    SetSession("tb_username", userGetResponse.User.Nick);
                    SetSession("top_session", GetQueryString("top_session"));
                    SetSession("subscribe_code", GetSubscribe(userGetResponse.User.Nick));
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
            TaobaoUtil.CommonUtil commonUtil = new TaobaoUtil.CommonUtil();
            userGetResponse = commonUtil.GetLoginUser(GetQueryString("top_session"));
        }
        else
        {
            userGetResponse = null;
        }
        return verify;
    }

    protected string GetSubscribe(string nick)
    {
        List<ArticleUserSubscribe> articleUserSubscribes = TaobaoUtil.CommonUtil.GetVasSubscribeGetResponse(nick, "ts-13815");
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