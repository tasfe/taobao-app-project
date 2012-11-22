using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AutoWeibo_sian : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string from = Request.QueryString["from"];
        if (from == "sina")
        {
            if (!string.IsNullOrEmpty(Request.QueryString["error_code"]))
            {
                if (Request.QueryString["error_code"] == "21330")
                {
                    Response.Redirect("Error.aspx?detail=" + Server.UrlEncode("您拒绝了新浪微博的授权,绑定账户失败！"));
                }
            }


            NetDimension.Weibo.OAuth oauth = new NetDimension.Weibo.OAuth(ShopUtil.XmlCOM.ReadConfig("SinaAppKey"),
            ShopUtil.XmlCOM.ReadConfig("SinaAppSecret"),
            ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl"));

            NetDimension.Weibo.AccessToken accessToken = new NetDimension.Weibo.AccessToken();
            try
            {
                accessToken = oauth.GetAccessTokenByAuthorizationCode(Request.QueryString["code"]);
                //Session["accessToken"] = accessToken.Token;
            }
            catch (NetDimension.Weibo.WeiboException ex)
            {
                Response.Redirect("Error.aspx?detail=" + Server.UrlEncode("绑定新浪微博的账户失败，请确认您开通了新浪微博帐号<a href='http://www.weibo.com' target='_blank'>点击我去看看有没开通吧</a>！"));
            }

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
                access_weibo.user_id = 0;
                access_weibo.weibo_id = 2;
                access_weibo.weibo_name = user.ScreenName;
                access_weibo.weibo_url = "http://www.weibo.com/" + accessToken.UID;

                access_weibo.Add();
            }
            else
            {
                access_weibo.Update();
            }
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        NetDimension.Weibo.OAuth oauth = new NetDimension.Weibo.OAuth(ShopUtil.XmlCOM.ReadConfig("SinaAppKey"),
          ShopUtil.XmlCOM.ReadConfig("SinaAppSecret"),
          ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl"));
        //第一步获取新浪授权页面的地址
        Response.Redirect(oauth.GetAuthorizeURL());
    }
    protected void btnGetWeibo_Click(object sender, EventArgs e)
    {
        //1297451584
        weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
        access_weibo.GetModelBySinaUID("1297451584");


        NetDimension.Weibo.OAuth oauth = new NetDimension.Weibo.OAuth(ShopUtil.XmlCOM.ReadConfig("SinaAppKey"),
               ShopUtil.XmlCOM.ReadConfig("SinaAppSecret"),
               ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl"));
        oauth.AccessToken = access_weibo.AccessToken;


        NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(oauth);
        NetDimension.Weibo.Entities.status.Collection user = Sina.API.Statuses.UserTimeline("1297451584", "", "", "", 10, 1, false, 0, false);

        foreach( NetDimension.Weibo.Entities.status.Entity entity in user.Statuses)
        {
            weibo.DataAccess.tb_sianweibo sina = new weibo.DataAccess.tb_sianweibo();

            //created_at	string	微博创建时间
            //id	int64	微博ID
            //mid	int64	微博MID
            //idstr	string	字符串型的微博ID
            //text	string	微博信息内容
            //source	string	微博来源
            //favorited	boolean	是否已收藏，true：是，false：否
            //truncated	boolean	是否被截断，true：是，false：否
            //in_reply_to_status_id	string	回复ID
            //in_reply_to_user_id	string	回复人UID
            //in_reply_to_screen_name	string	回复人昵称
            //thumbnail_pic	string	缩略图片地址，没有时不返回此字段
            //bmiddle_pic	string	中等尺寸图片地址，没有时不返回此字段
            //original_pic	string	原始图片地址，没有时不返回此字段
            //geo	object	地理信息字段
            //user	object	微博作者的用户信息字段
            //reposts_count	int	转发数
            //comments_count	int	评论数
            //attitudes_count	int	表态数
            //mlevel	int	暂未支持
            //visible	object	微博的可见性及指定可见分组信息

            //return DateTime.ParseExact("Tue May 03 09:30:23 +0800 2011", "ddd MMM dd HH:mm:ss zzz yyyy", provider);
            System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
            sina.CreatedAt = DateTime.ParseExact(entity.CreatedAt, "ddd MMM dd HH:mm:ss zzz yyyy", provider);

            sina.ID = Convert.ToDouble (entity.ID);
            sina.MID = Convert.ToDouble(entity.MID);
            sina.Text = entity.Text;
            sina.Source = entity.Source;
            sina.Favorited = entity.Favorited.ToString();
            sina.Truncated = entity.Truncated.ToString();
            sina.InReplyToStuatusID = entity.InReplyToStuatusID;
            sina.InReplyToUserID = entity.InReplyToUserID;
            sina.InReplyToScreenName = entity.InReplyToScreenName;
            sina.ThumbnailPictureUrl = entity.ThumbnailPictureUrl;
            sina.MiddleSizePictureUrl = entity.MiddleSizePictureUrl;
            sina.OriginalPictureUrl = entity.OriginalPictureUrl;
            //sina.GEO = entity.GEO.ToString();

            sina.Add();
        }
    }
}