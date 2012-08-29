using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Collections;

using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Domain;


public partial class Jie : System.Web.UI.Page
{
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 40;
    protected string keyWord = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["p"]))
        {
            int.TryParse(Request.QueryString["p"], out currPage);
        }

        keyWord= Request.QueryString["k"];

        if (string.IsNullOrEmpty(keyWord))
        {
            TaoBaoCategoryList taoBaoCategoryList = ((TaoBaoCategoryList)GetTaoBaoCategory()[Request.QueryString["cid"]]);
            keyWord = taoBaoCategoryList.key;
        }

        string pageString = "";
        if (currPage > 0)
        {
            pageString = "第" + (currPage) + "页";
        }
        this.Title = keyWord + "   " + pageString + ">>淘宝热卖商品" + "--BiuBiu街推荐";
        ((HtmlMeta)this.Master.FindControl("keywords")).Content = keyWord + "," + pageString + ",网上购物,购物网站,一口价,拍卖,打折,淘宝热销,淘宝畅销,淘宝热卖,淘宝大全,淘宝店铺,淘宝名店,淘宝排行榜";
        ((HtmlMeta)this.Master.FindControl("description")).Content = keyWord + "," + pageString + ",淘宝热卖商品,销量最高,人气最旺,价格最优惠,信用最有保障的商品.淘宝生活,由此开始,给你推荐淘宝热销商品大全,厂家批发团购,让你第一时间了解淘宝,尽享网上购物乐趣,淘宝热卖排行！";


        ////((HtmlMeta)this.Master.FindControl("keywords")).Content = ((HtmlMeta)this.Master.FindControl("keywords")).Content + keyWord;
        ////((HtmlMeta)this.Master.FindControl("description")).Content = ((HtmlMeta)this.Master.FindControl("description")).Content + keyWord; 
 

        BindList();
    }

    protected void BindList()
    {
        Top.Api.ITopClient client = ShopUtil.OpenTaobaoUtil.GetDefaultTopClient();

        TaobaokeItemsGetRequest taobaokeItemsGetRequest = new TaobaokeItemsGetRequest();
        taobaokeItemsGetRequest.Fields = "pic_url,num_iid,commission,title,price,shop_click_url,seller_credit_score,click_url";
        taobaokeItemsGetRequest.Keyword = keyWord;
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

        List<TaobaokeItem> taobaokeItems = response.TaobaokeItems;

        List<TaobaokeItem> dt1 = new List<TaobaokeItem>();
        List<TaobaokeItem> dt2 = new List<TaobaokeItem>();
        List<TaobaokeItem> dt3 = new List<TaobaokeItem>();
        List<TaobaokeItem> dt4 = new List<TaobaokeItem>();
        for (int i = 0; i < taobaokeItems.Count; i++)
        {
            if (i < 10)
            {
                dt1.Add(taobaokeItems[i]);
            }
            else if (i < 20)
            {
                dt2.Add(taobaokeItems[i]);
            }
            else if (i < 30)
            {
                dt3.Add(taobaokeItems[i]);
            }
            else if (i < 40)
            {
                dt4.Add(taobaokeItems[i]);
            }
        }

        rptList1.DataSource = dt1;
        rptList1.DataBind();

        rptList2.DataSource = dt2;
        rptList2.DataBind();

        rptList3.DataSource = dt3;
        rptList3.DataBind();

        rptList4.DataSource = dt4;
        rptList4.DataBind();
    }

    protected SortedList GetTaoBaoCategory()
    {
        //object catList=SASCMS.CacheCustom.Get("CatList");
        //if (catList != null)
        //{
        //    return (SortedList)catList;
        //}
        //else
        //{
        XmlDocument xd = new XmlDocument();
        xd.Load(Server.MapPath("~/config/TaoBaoCatList.xml"));
        XmlNodeList xnl = xd.SelectNodes("/Categorys/Category/SubCategory");

        SortedList sl = new SortedList();
        foreach (XmlNode xn in xnl)
        {
            sl.Add(xn.Attributes["id"].Value, new TaoBaoCategoryList(xn.Attributes["id"].Value, xn.Attributes["name"].Value, xn.Attributes["key"].Value));
        }
        ShopUtil.CacheCustom.Insert("CatList", sl);
        return sl;
        //}
    }
}

public class TaoBaoCategoryList
{
    public TaoBaoCategoryList()
    {

    }
    public TaoBaoCategoryList(string tid, string tname, string tkey)
    {
        id = tid;
        name = tname;
        key = tkey;
    }
    public string id;
    public string name;
    public string key;
}