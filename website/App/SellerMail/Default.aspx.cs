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
                    string subscribeCirlce="";
                    string subscribeCode= GetSubscribe(userGetResponse.User.Nick,out subscribeCirlce);
                    SetSession("subscribe_code", subscribeCode);

                    Shop.DataAccess.tb_user tb_user = new Shop.DataAccess.tb_user();
                    tb_user.GetModelByNick(userGetResponse.User.Nick);

                    //Response.Write("subscribeCode:" + subscribeCode);
                    //new customer
                    if (string.IsNullOrEmpty(tb_user.tb_nick))
                    {
                        Top.Api.Domain.Shop shop = GetShop(userGetResponse.User.Nick);

                        tb_user.tb_nick = userGetResponse.User.Nick;
                        tb_user.tb_userid = userGetResponse.User.Uid;
                        tb_user.tx_key = shop.Title;
                        tb_user.tx_secret = shop.Sid.ToString();
                        tb_user.sina_key = subscribeCirlce;
                        tb_user.sina_secret = "0";
                        tb_user.tb_subscribe = subscribeCode;
                        tb_user.updateon = DateTime.Now;
                        tb_user.ID = tb_user.Add();
                    }
                    else
                    {
                        //更新计费周期
                        if (subscribeCirlce != tb_user.sina_key)
                        {
                            tb_user.UpdateByNick("sina_key='" + subscribeCirlce + "',sina_secret='0'");
                            //tb_user.tb_subscribe = subscribeCode;
                        }
                    }
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

    protected Top.Api.Domain.Shop GetShop(string nick)
    {
        Top.Api.Request.ShopGetRequest shopGetRequest = new Top.Api.Request.ShopGetRequest();
        shopGetRequest.Nick = nick;
        shopGetRequest.Fields = "sid,title";
        return TaobaoUtil.DefaultTopClient.GetDefaultTopClient().Execute(shopGetRequest).Shop;
    }

    protected string GetSubscribe(string nick,out string subscribeCircle)
    {
        subscribeCircle="";

        List<ArticleUserSubscribe> articleUserSubscribes = ShopUtil.OpenTaobaoUtil.GetVasSubscribeGetResponse(nick, "ts-13815").ArticleUserSubscribes;
        if (articleUserSubscribes != null && articleUserSubscribes.Count > 0)
        {
            DateTime dt = DateTime.Parse(articleUserSubscribes[0].Deadline);
            DateTime dtStart = new DateTime(DateTime.Now.Year,DateTime.Now.Month,dt.Day,dt.Hour,dt.Minute,dt.Second);
            subscribeCircle = dtStart.ToString("yyyyMMddhhmmss") + dtStart.AddMonths(1).ToString("yyyyMMddhhmmss");
            return articleUserSubscribes[0].ItemCode;
        }
        else
        {
            return "";
        }
    }
}