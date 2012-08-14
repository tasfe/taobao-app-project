using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

using Top.Api.Response;

public partial class pages_Default : UI.PageBase
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
                    weibo.DataAccess.tb_user tb_user = new weibo.DataAccess.tb_user();
                    tb_user.GetModelByNick(userGetResponse.User.Nick);
                    string subscribeCode = GetSubscribe(userGetResponse.User.Nick);
                    //Response.Write("subscribeCode:" + subscribeCode);
                    //new customer
                    if (string.IsNullOrEmpty(tb_user.tb_nick))
                    {
                        tb_user.tb_nick = userGetResponse.User.Nick;
                        tb_user.tb_userid = userGetResponse.User.Uid;
                        tb_user.tx_key = "";
                        tb_user.tx_secret = "";
                        tb_user.sina_key = "";
                        tb_user.sina_secret = "";
                        tb_user.tb_subscribe = subscribeCode;
                        tb_user.updateon = DateTime.Now;
                        tb_user.ID = tb_user.Add();
                    }
                    else
                    {
                        if (subscribeCode != tb_user.tb_subscribe)
                        {
                            tb_user.UpdateByNick("tb_subscribe='" + subscribeCode + "'");
                            tb_user.tb_subscribe = subscribeCode;
                        }
                    }
                    
                    SetSession("tb_user", tb_user);
                }
                else
                {
                    from = "unknow";
                }
            }
            else if (from == "tx")
            {
                CheckLogin();
                //OAuthTXWeibo.OAuthTXWeiboBase oAuthTXWeiboBase = new OAuthTXWeibo.OAuthTXWeiboBase();
                OAuthTXWeibo.AccessToken accessToken = OAuthTXWeibo.OAuthTXWeiboBase.GetAccessToken(Request.QueryString["code"],
               ShopUtil.XmlCOM.ReadConfig("TXAppKey"),
               ShopUtil.XmlCOM.ReadConfig("TXAppSecret"),
               ShopUtil.XmlCOM.ReadConfig("TXCallbackUrl"));

                weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                access_weibo.GetModelByWeiboName(accessToken.name);
                
                access_weibo.AccessToken = accessToken.access_token;
                access_weibo.weibo_name = accessToken.name;
                access_weibo.ExpiresIn = accessToken.expires_in;
                access_weibo.AccessTokenExpires = DateTime.Now.AddSeconds(accessToken.expires_in);

                if (access_weibo.ID<=0)
                {
                    access_weibo.accesskey = Request.QueryString["openid"];
                    access_weibo.accesssecret = Request.QueryString["openkey"];
                    access_weibo.day_send = 0;
                    access_weibo.lastOperateOn = DateTime.Now;
                    access_weibo.updateOn = DateTime.Now;
                    access_weibo.user_id = GetLoginUser().ID;
                    access_weibo.weibo_id = 1;
                    access_weibo.weibo_name = accessToken.name;
                    access_weibo.weibo_url = "http://t.qq.com/" + accessToken.name;

                    access_weibo.Add();
                }
                else
                {
                    access_weibo.Update();
                }

                //QQAPIUtil qqUtil = new QQAPIUtil("", "", "");
                //qqUtil.GetAccessToken(GetQueryString("oauth_verifier"), GetSession("tokenKey").ToString(), GetSession("tokenSecret").ToString());

                //XmlDocument xd = new XmlDocument();
                //xd.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?>"+qqUtil.QQUserInfo());
                //XmlNode xn = xd.SelectSingleNode("root/data/name");
                //weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();

                //access_weibo.accesskey = qqUtil.accessKey;
                //access_weibo.accesssecret = qqUtil.accessSecret;
                //access_weibo.day_send=0;
                //access_weibo.lastOperateOn = DateTime.Now;
                //access_weibo.updateOn = DateTime.Now;
                //access_weibo.user_id = GetLoginUser().ID;
                //access_weibo.weibo_id = 1;
                //access_weibo.weibo_name = xn.InnerText;
                //access_weibo.weibo_url = "http://t.qq.com/" + xn.InnerText;

                //access_weibo.Add();
            }
            else if (from == "sina" || from == "sinareview")
            {
                CheckLogin();

                NetDimension.Weibo.OAuth oauth = new NetDimension.Weibo.OAuth(ShopUtil.XmlCOM.ReadConfig("SinaAppKey"),
                ShopUtil.XmlCOM.ReadConfig("SinaAppSecret"),
                ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl"));

                NetDimension.Weibo.AccessToken accessToken = oauth.GetAccessTokenByAuthorizationCode(Request.QueryString["code"]);
                //Session["accessToken"] = accessToken.Token;


                weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                access_weibo.GetModelBySinaUID(accessToken.UID);
                access_weibo.AccessToken = accessToken.Token;
                access_weibo.SinaUID = accessToken.UID;
                access_weibo.ExpiresIn = accessToken.ExpiresIn;
                access_weibo.AccessTokenExpires = DateTime.Now.AddSeconds(accessToken.ExpiresIn);
                access_weibo.accesskey = accessToken.Token;

                if (!string.IsNullOrEmpty(access_weibo.SinaUID))
                {
                    NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(oauth);
                    NetDimension.Weibo.Entities.user.Entity user = Sina.API.Users.Show(accessToken.UID, "");

                    //access_weibo.accesskey = httpRequest.Token;
                    //access_weibo.accesssecret = httpRequest.TokenSecret;
                    access_weibo.day_send = 0;
                    access_weibo.lastOperateOn = DateTime.Now;
                    access_weibo.updateOn = DateTime.Now;
                    access_weibo.user_id = GetLoginUser().ID;
                    access_weibo.weibo_id = 2;
                    access_weibo.weibo_name = user.ScreenName;
                    access_weibo.weibo_url = "http://www.weibo.com/" + accessToken.UID;

                    access_weibo.Add();
                }
                else
                {
                    access_weibo.Update();
                }

                //HttpGet httpRequest = HttpRequestFactory.CreateHttpRequest(Method.GET) as HttpGet;
                //httpRequest.Token = GetSessionString("oauth_token");
                //httpRequest.TokenSecret = GetSessionString("oauth_token_secret");
                //httpRequest.Verifier = Request["oauth_verifier"];
                //httpRequest.GetAccessToken();

                //string userInfo = httpRequest.RequestUser(httpRequest.UserID); 

                //XmlDocument xd = new XmlDocument();
                //xd.LoadXml(userInfo);
                //XmlNode xn = xd.SelectSingleNode("user/screen_name");

                //weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                //access_weibo.accesskey = httpRequest.Token;
                //access_weibo.accesssecret = httpRequest.TokenSecret;
                //access_weibo.day_send = 0;
                //access_weibo.lastOperateOn = DateTime.Now;
                //access_weibo.updateOn = DateTime.Now;
                //access_weibo.user_id = GetLoginUser().ID;
                //access_weibo.weibo_id = 2;
                //access_weibo.weibo_name = xn.InnerText;
                //access_weibo.weibo_url = "http://www.weibo.com/" + httpRequest.UserID;

                //access_weibo.Add();

                if (from == "sinareview")
                {
                    Response.Redirect("Review.aspx");
                }
            }
            else if (from == "review")
            {
                //for review
                string reviewNick = "shenjinkui1984";
                weibo.DataAccess.tb_user tb_user = new weibo.DataAccess.tb_user();
                tb_user.GetModelByNick(reviewNick);

                SetSession("tb_user", tb_user);
                SetSession("tx_key", tb_user.tx_key);
                SetSession("tx_secret", tb_user.tx_secret);
                SetSession("sina_key", tb_user.sina_key);
                SetSession("sina_secret", tb_user.sina_secret);
                SetSession("tb_nick", reviewNick);
                SetSession("user_id", tb_user.ID);

                Response.Redirect("Review.aspx");
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
            ShopUtil.OpenTaobaoUtil OpenTaobaoUtil = new ShopUtil.OpenTaobaoUtil(); 
            userGetResponse = OpenTaobaoUtil.GetLoginUser(GetQueryString("top_session"));
            SetSession("top_session", GetQueryString("top_session"));
        }
        else
        {
            userGetResponse = null;
        }
        return verify;
    }

    protected string GetSubscribe(string nick)
    {
        VasSubscribeGetResponse vasSubscribeGetResponse = ShopUtil.OpenTaobaoUtil.GetVasSubscribeGetResponse(nick);
        if (vasSubscribeGetResponse.ArticleUserSubscribes!=null&&vasSubscribeGetResponse.ArticleUserSubscribes.Count > 0)
        {
            return vasSubscribeGetResponse.ArticleUserSubscribes[0].ItemCode;
        }
        else
        {
            return "";
        }
    }
}