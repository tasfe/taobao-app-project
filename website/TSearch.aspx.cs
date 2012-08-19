using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Domain;


public partial class Jie : System.Web.UI.Page
{
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 28;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["p"]))
        {
            int.TryParse(Request.QueryString["p"], out currPage);
        }


        ((HtmlMeta)this.Master.FindControl("keywords")).Content = ((HtmlMeta)this.Master.FindControl("keywords")).Content + Request.QueryString["k"];
        ((HtmlMeta)this.Master.FindControl("description")).Content =((HtmlMeta)this.Master.FindControl("description")).Content+ Request.QueryString["k"]; 
 

        BindList();
    }

    protected void BindList()
    {
        Top.Api.ITopClient client = ShopUtil.OpenTaobaoUtil.GetDefaultTopClient();

        TaobaokeItemsGetRequest taobaokeItemsGetRequest = new TaobaokeItemsGetRequest();
        taobaokeItemsGetRequest.Fields = "pic_url,num_iid,commission,title,price,shop_click_url,seller_credit_score,click_url";
        taobaokeItemsGetRequest.Keyword = Request.QueryString["k"];
        taobaokeItemsGetRequest.Nick = "shenjinkui1984";
        taobaokeItemsGetRequest.PageSize = pageSize;
        //if (startPrice != "-1")
        //    taobaokeItemsGetRequest.StartPrice = startPrice;
        //if (endPrice != "-1")
        //    taobaokeItemsGetRequest.EndPrice = endPrice;
        //if (StartCommissionRate != "-1")
        //    taobaokeItemsGetRequest.StartCommissionRate = StartCommissionRate;
        //if (EndCommissionRate != "-1")
            //taobaokeItemsGetRequest.EndCommissionRate = EndCommissionRate;
        taobaokeItemsGetRequest.PageNo = currPage;
        //taobaokeItemsGetRequest.Sort = Sort;
        TaobaokeItemsGetResponse response = client.Execute(taobaokeItemsGetRequest);
        count = response.TotalResults;
        rptList.DataSource = response.TaobaokeItems;
        rptList.DataBind();
    }
}