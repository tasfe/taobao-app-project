using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Threading;

using Taobaoke.DAL;
using Top.Api;
using Top.Api.Domain;
using Top.Api.Parser;
using Top.Api.Request;
public partial class Manage_ImportData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string key = Request.QueryString["k"];
        string catId = Request.QueryString["c"];
        string topCatId = Request.QueryString["tc"];
        if (topCatId != null && topCatId != null && topCatId!=null&&topCatId.Length > 0 && key.Length > 0 && catId.Length > 0)
        {
            //Thread.Sleep(2000);
            string result = "";
            try
            {
                ImprotTbk(key, catId, topCatId);
                result = "<div class='c3'>" + DateTime.Now + " : " + "Successed..." + key + "</div>";
            }
            catch( Exception ex)
            {
                result = "<div class='c1'>" + DateTime.Now + " : " + ex.ToString() + "</div>";
            }
            Response.Write(result);
            Response.End();
        }
        else
        {
            Shop.BLL.TB_ColumnBll columnBll = new Shop.BLL.TB_ColumnBll();
            DataTable dtCol = columnBll.GetList("1=1 order by code").Tables[0];

            rptCol.DataSource = dtCol;
            rptCol.DataBind();
        }
    }

    protected void ImprotTbk(string Keyword,string catID,string topCatID)
    {
        //TopXmlRestClient client = new TopXmlRestClient("http://gw.api.taobao.com/router/rest", "12082147", "16d11b54940058660ee9dc4b5d37a004");

        List<TaobaokeItem> taobaokeItems = new List<TaobaokeItem>();
        TaobaokeItemsGetRequest taobaokeItemsGetRequest = new TaobaokeItemsGetRequest();
        taobaokeItemsGetRequest.Fields = "pic_url,num_iid,commission,title,price,shop_click_url,seller_credit_score,click_url";
        taobaokeItemsGetRequest.Keyword = Keyword;
        taobaokeItemsGetRequest.Nick = "shenjinkui1984";
        taobaokeItemsGetRequest.StartCommissionRate = "0.2";
        taobaokeItemsGetRequest.PageNo = 0;
        taobaokeItemsGetRequest.PageSize = 40;
        taobaokeItemsGetRequest.StartTotalnum = "30";
        taobaokeItemsGetRequest.EndTotalnum = "300000";
        taobaokeItemsGetRequest.Sort = "commissionNum_desc";
        taobaokeItems = ShopUtil.OpenTaobaoUtil.GetTopClientInatance().Execute(taobaokeItemsGetRequest).TaobaokeItems; //client.TaobaokeItemsGet(taobaokeItemsGetRequest);
        //TaobaokeItem taobaokeItem = 
        List<TaobaokeItem> filterItem = FilterItem(taobaokeItems);

        foreach (TaobaokeItem taobaokeItem in filterItem)
        {

            if (taobaokeItem != null)
            {
                TB_TaoBaoKe TaoBaoKe = new TB_TaoBaoKe();

                TaobaokeItemsDetailGetRequest taobaokeItemsDetailGetRequest = new TaobaokeItemsDetailGetRequest();
                taobaokeItemsDetailGetRequest.Fields = "seller_cids,desc,title,price,pic_url,volume,seller_credit_score,post_fee,ems_fee,express_fee,freight_payer,location.city,nick,num_iid,item_imgs";
                taobaokeItemsDetailGetRequest.NumIids = taobaokeItem.NumIid + "";
                taobaokeItemsDetailGetRequest.Nick = "shenjinkui1984";
                List<TaobaokeItemDetail> TaobaokeItemDetail = ShopUtil.OpenTaobaoUtil.GetTopClientInatance().Execute(taobaokeItemsDetailGetRequest).TaobaokeItemDetails;
                TaobaokeItemDetail taobaokeItemDetail = TaobaokeItemDetail[0];

                TaoBaoKe.Category = catID;
                TaoBaoKe.City = taobaokeItemDetail.Item.Location.City;//taobaokeItem.ItemLocation;
                TaoBaoKe.ClickUrl = taobaokeItem.ClickUrl;
                TaoBaoKe.Commission = decimal.Parse(taobaokeItem.Commission);
                TaoBaoKe.Desc = taobaokeItemDetail.Item.Desc;
                TaoBaoKe.EmsFee = decimal.Parse(taobaokeItemDetail.Item.EmsFee);
                TaoBaoKe.ExpressFee = decimal.Parse(taobaokeItemDetail.Item.ExpressFee);
                TaoBaoKe.FreightPayer = taobaokeItemDetail.Item.FreightPayer;
                TaoBaoKe.Pic_Url = taobaokeItemDetail.Item.PicUrl;
                List<ItemImg> itemImgs = taobaokeItemDetail.Item.ItemImgs;
                string itemImgsUrl = "";
                //foreach (ItemImg itemImg in itemImgs)
                //{
                //    itemImgsUrl += itemImg.Url + "," + itemImg.Position + "|";
                //}
                TaoBaoKe.ItemImgs = itemImgsUrl;

                TaoBaoKe.Nick = taobaokeItemDetail.Item.Nick;
                TaoBaoKe.NumIid = taobaokeItemDetail.Item.NumIid.ToString();
                TaoBaoKe.PostFee = decimal.Parse(taobaokeItemDetail.Item.PostFee);
                TaoBaoKe.Price = decimal.Parse(taobaokeItemDetail.Item.Price);

                List<PropImg> propImgs = taobaokeItemDetail.Item.PropImgs;
                string propImgsUrl = "";
                //foreach (PropImg itemImg in propImgs)
                //{
                //    propImgsUrl += itemImg.Url + "," + itemImg.Position + "|";
                //}
                TaoBaoKe.PropImgs = propImgsUrl;

                TaoBaoKe.SellerCreditScore = taobaokeItem.SellerCreditScore;
                TaoBaoKe.ShopClickUrl = taobaokeItem.ShopClickUrl;
                TaoBaoKe.Title = taobaokeItem.Title;// taobaokeItemDetail.Item.Title;
                TaoBaoKe.Volume = taobaokeItemDetail.Item.Volume;
                TaoBaoKe.UpdateOn = DateTime.Now;
                TaoBaoKe.TopCategory = topCatID;

                TaoBaoKe.Add();
            }
        }
    }

    protected List<TaobaokeItem> FilterItem(List<TaobaokeItem> taobaokeItems)
    {
        List<TaobaokeItem> filterTaobaokeItem = new List<TaobaokeItem>();
        foreach (TaobaokeItem taobaokeItem1 in taobaokeItems)
        {
            if (decimal.Parse(taobaokeItem1.Price) > 20 && (!CheckExist(taobaokeItem1.Title)) && (!CheckKey(taobaokeItem1.Title)))
            {
                filterTaobaokeItem.Add(taobaokeItem1);
            }
        }
        return filterTaobaokeItem;
    }

    protected bool CheckExist(string title)
    {
        int count = Shop.DataAccess.TaoBaoKeCommon.GetTaoBaoKe(" title ='" + title + "'", 0, 1).Rows.Count;
        return count == 0 ? false : true;
        //return false;
    }

    protected bool CheckKey(string title)
    {
        string[] keys = new string[] { "愚人视觉", "网站设计" };
        foreach (string s in keys)
        {
            if (title.IndexOf(s) >= 0)
                return true;
        }
        return false;
    }
}
