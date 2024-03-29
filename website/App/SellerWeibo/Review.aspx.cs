﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using Top.Api;
using Top.Api.Response;
using Top.Api.Request;
using Top.Api.Domain;


public partial class pages_Default : UI.PageBase
{
    protected string qqOauthTokenUrl = "http://open.t.qq.com/cgi-bin/authorize?oauth_token={0}";
    protected string sinaOauthTokenUrl = "";
    //protected bool txBind = false;
    //protected bool sinaBind = false;
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 10;
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckLogin();
        DoAction();
        //txBind = CheckTXKey();
        //sinaBind = CheckSinaKey();
        currPage = GetQueryInt("p");
        currPage = currPage == 0 ? 1 : currPage;
        BindProduct(currPage);
        BindTemplate();
        BindWeibo();
        BindAccessWeibo();
    }

    protected void BindProduct(int pageNo)
    {
        //ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", Util.XmlCOM.ReadConfig("TaobaoAppKey"), Util.XmlCOM.ReadConfig("TaobaoAppSecret"), "json");
        //ItemsListGetRequest req = new ItemsListGetRequest();
        //req.Fields = "num_iid,title,nick,pic_url,cid,price,type,delist_time,post_fee,score,volume,detailurl";
        //req.Nicks = nick;
        //req.PageSize = pageSize;
        //req.PageNo = pageNo;
        //req.OrderBy = "delist_time:desc";
        //ItemsGetResponse response = client.Execute(req);
        //count = response.TotalResults;
        //Repeater1.DataSource = response.Items;
        //Repeater1.DataBind();
    }

    protected void BindTemplate()
    {
        weibo.DataAccess.tb_weibo_template weibo_template = new weibo.DataAccess.tb_weibo_template();
        System.Data.DataTable dt = weibo_template.GetTemplate(GetLoginUser().ID);

        template1.DataSource = new DataView(dt,"type=1","", DataViewRowState.CurrentRows); 
        template1.DataBind();

        template2.DataSource = new DataView(dt, "user_id>0", "", DataViewRowState.CurrentRows); 
        template2.DataBind();
    }

    protected void BindWeibo()
    {
        weibo.DataAccess.tb_weibo weibo = new weibo.DataAccess.tb_weibo();
        DataTable dt = weibo.GetList(" 1=1 order by id").Tables[0];

        rptWeiboAccount.DataSource = dt;
        rptWeiboAccount.DataBind();
    }

    protected void BindAccessWeibo()
    {
        weibo.DataAccess.tb_access_weibo weibo = new weibo.DataAccess.tb_access_weibo();
        DataTable dt=weibo.GetAccessList(GetLoginUser().ID).Tables[0];

        rptWeibo.DataSource = dt;
        rptWeibo.DataBind();

        rptAccessWeibo.DataSource = dt;
        rptAccessWeibo.DataBind();
    }
    protected void DoAction()
    {
        string action = GetQueryString("a");
        if (!string.IsNullOrEmpty(action))
        {
            if(action=="unbindtx")
            {
                weibo.DataAccess.tb_user tb_user = new weibo.DataAccess.tb_user();
                tb_user.tb_nick = GetSession("tb_nick").ToString();
                tb_user.UpdateByNick(string.Format("tx_key='{0}',tx_secret='{1}'", "", ""));
                SetSession("tx_key", null);
            }
            else if(action=="unbindsina")
            {
                weibo.DataAccess.tb_user tb_user = new weibo.DataAccess.tb_user();
                tb_user.tb_nick = GetSession("tb_nick").ToString();
                tb_user.UpdateByNick(string.Format("sina_key='{0}',sina_secret='{1}'", "", ""));
                SetSession("sina_key", null);
            }
            else if (action == "addweibo")
            {
                if (CheckUserWeiBoCount())
                {
                    string id = GetQueryString("id");
                    if (id == "1")
                    {
                        RedirectTX();
                    }
                    else if (id == "2")
                    {
                        RedirectSina();
                    }
                }
                else
                {
                    lblMsg.Text = "亲，只能添加1个帐号哦，请先解除绑定吧：）";
                }
            }
            else if (action == "unbind")
            {
                string id = GetQueryString("id");
                weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
                access_weibo.Delete(int.Parse(id));
            }
            else if (action == "logout")
            {
                SetSession("tb_user", null);
                CheckLogin();
            }
        }
    }
    protected bool CheckTXKey()
    {
        object otx_key = GetSession("tx_key");
        bool ret = false;
        //not bind tx
        if (otx_key == null || string.IsNullOrEmpty(otx_key.ToString()))
        {
            QQAPIUtil qqAPIUtil = new QQAPIUtil("", "", ShopUtil.XmlCOM.ReadConfig("TXCallbackUrl"));
            qqAPIUtil.GetRequestToken();
            qqOauthTokenUrl = string.Format(qqOauthTokenUrl, qqAPIUtil.tokenKey);
            SetSession("tokenKey", qqAPIUtil.tokenKey);
            SetSession("tokenSecret", qqAPIUtil.tokenSecret);
        }
        else
        {
            ret = true;
        }
        return ret;
    }

    //protected bool CheckSinaKey()
    //{
    //    object sian_key = GetSession("sina_key");
    //    bool ret = false;
    //    //not bind sina
    //    if (sian_key == null || string.IsNullOrEmpty(sian_key.ToString()))
    //    {
    //        HttpGet httpRequest = HttpRequestFactory.CreateHttpRequest(Method.GET) as HttpGet;
    //        httpRequest.GetRequestToken();
    //        string url = httpRequest.GetAuthorizationUrl();
    //        SetSession("oauth_token", httpRequest.Token);
    //        SetSession("oauth_token_secret", httpRequest.TokenSecret);
    //        sinaOauthTokenUrl = url + "&oauth_callback=" + ShopUtil.XmlCOM.ReadConfig("SinaCallbackUrl");
    //    }
    //    else
    //    {
    //        ret = true;
    //    }
    //    return ret;
    //}

    protected void RedirectTX()
    {
        //QQAPIUtil qqAPIUtil = new QQAPIUtil("", "", ShopUtil.XmlCOM.ReadConfig("TXCallbackUrl"));
        //qqAPIUtil.GetRequestToken();
        //SetSession("tokenKey", qqAPIUtil.tokenKey);
        //SetSession("tokenSecret", qqAPIUtil.tokenSecret);
        //qqOauthTokenUrl = string.Format(qqOauthTokenUrl, qqAPIUtil.tokenKey);
        //Response.Redirect(qqOauthTokenUrl);
    }

    protected void RedirectSina()
    {
        //HttpGet httpRequest = HttpRequestFactory.CreateHttpRequest(Method.GET) as HttpGet;
        //httpRequest.GetRequestToken();
        //string url = httpRequest.GetAuthorizationUrl();
        //SetSession("oauth_token", httpRequest.Token);
        //SetSession("oauth_token_secret", httpRequest.TokenSecret);
        //sinaOauthTokenUrl = url + "&oauth_callback=" + "http://bmw027118.chinaw3.com/pages/default.aspx?from=sinareview";

        //Response.Redirect(sinaOauthTokenUrl);
    }

    protected bool CheckUserWeiBoCount()
    {
        bool ret = false;
        if (0 == 0)
        {
            
            weibo.DataAccess.tb_access_weibo access_weibo = new weibo.DataAccess.tb_access_weibo();
            if (access_weibo.GetAccessList(GetLoginUser().ID).Tables[0].Rows.Count >= 1)
            {
                
                ret = false;
            }
            else
            {
                ret = true;
            }
        }
        else
        {
            ret = true;
        }
        return ret;
    }
}