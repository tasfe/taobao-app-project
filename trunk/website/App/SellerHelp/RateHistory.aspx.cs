using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Top.Api;
using Top.Api.Domain;
using Top.Api.Response;
using Top.Api.Request;

public partial class SellerHelp_Default2 : Shop.ShopUI.BasePage
{
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 5;

    protected string nick = "";

    protected DateTime dtStart = new DateTime();
    protected DateTime dtEnd = new DateTime();

    protected string subscribeCode = "ts-13815-4,ts-13815-3";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "";

        nick = GetSessionString("tb_username");
        CheckLogin();

        currPage = GetQueryInt("p");
        currPage = currPage == 0 ? 1 : currPage;

        if (!Page.IsPostBack)
        {
            SetSearch();
            BindProduct(currPage);
        }
    }
    public void CheckLogin()
    {
        if (GetSession("tb_username") == null)
        {
            Response.Redirect("Default.aspx?from=timeout");
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindProduct(1);
    }

    protected void BindProduct(int pageNo)
    {
        TraderatesGetRequest traderatesGetRequest = new TraderatesGetRequest();
        traderatesGetRequest.Fields = "nick,result,created,item_title,content,reply,item_price,tid";
        traderatesGetRequest.RateType = "get";
        traderatesGetRequest.Role = "buyer";
        if (ddlResult.SelectedValue.Length > 0 && ddlResult.SelectedValue!="--")
        {
            traderatesGetRequest.Result = ddlResult.SelectedValue;
        }
        traderatesGetRequest.PageNo = pageNo;

        if (tbStartTDate.Text.Length > 0)
        {
            DateTime.TryParse(tbStartTDate.Text, out dtStart);
            traderatesGetRequest.StartDate = dtStart;

            if (dtStart < DateTime.Now.AddMonths(-3))
            {
                lblMsg.Text = "开始时间必须在3个月以内";
                return;
            }
        }
        if (tbEndDate.Text.Length > 0)
        {
            DateTime.TryParse(tbEndDate.Text, out dtEnd);
            traderatesGetRequest.EndDate = dtEnd;

            if (dtEnd < DateTime.Now.AddMonths(-3))
            {
                lblMsg.Text = "结束时间必须在3个月以内";
                return;
            }
        }
        if (tbPageSize.Text.Length > 0)
        {
            pageSize = int.Parse(tbPageSize.Text);
        }


        traderatesGetRequest.PageSize = pageSize;

        TraderatesGetResponse traderatesGetResponse = ShopUtil.OpenTaobaoUtil.GetDefaultTopClient().Execute(traderatesGetRequest, GetSessionString("top_session"));
        count = traderatesGetResponse.TotalResults;
        Repeater1.DataSource = traderatesGetResponse.TradeRates;
        Repeater1.DataBind();
    }

    protected void SetSearch()
    {
        string searchKey = GetQueryString("s");
        string[] searchKeys = searchKey.Split('|');
        if (searchKeys.Length > 3)
        {
            tbStartTDate.Text = searchKeys[0];
            tbEndDate.Text = searchKeys[1];
            tbPageSize.Text = searchKeys[2];
            ddlResult.SelectedValue = searchKeys[3];
        }
    }

    protected string GetSearchString()
    {
        string search = "s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text + "|" + "";

        return search;
    }

    protected string GetResult(string result)
    {
        string ret = "";
        switch (result)
        {
            case "good":
                ret = "<img src=\"static/images/result/goodrate.jpg\" />好评";
                break;
            case "neutral":
                ret = "<img src=\"static/images/result/normalrate.jpg\" />中好";
                break;
            case "bad":
                ret = "<img src=\"static/images/result/badrate.jpg\" />差评";
                break;
        }

        return ret;
    }

    protected bool IsFreeUser()
    {
        return subscribeCode.IndexOf(GetSessionString("subscribe_code")) != -1 ? false : true;
    }
}