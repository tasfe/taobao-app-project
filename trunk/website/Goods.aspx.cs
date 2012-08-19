using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Domain;

public partial class Goods : System.Web.UI.Page
{
    protected TaobaokeItemDetail taobaokeItemDetail;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetTaoBaoKeFormApi("14897281171");
    }

    protected void GetTaoBaoKeFormApi(string numiid)
    {
        Top.Api.ITopClient client =ShopUtil.OpenTaobaoUtil.GetDefaultTopClient();

        TaobaokeItemsDetailGetRequest taobaokeItemsDetailGetRequest = new TaobaokeItemsDetailGetRequest();
        
        taobaokeItemsDetailGetRequest.Fields = "click_url,shop_click_url,seller_cids,desc,title,price,pic_url,volume,seller_credit_score,post_fee,ems_fee,express_fee,freight_payer,location.city,nick,num_iid,item_imgs";
        taobaokeItemsDetailGetRequest.NumIids = numiid;
        taobaokeItemsDetailGetRequest.Nick = "shenjinkui1984";
        TaobaokeItemsDetailGetResponse response=  client.Execute(taobaokeItemsDetailGetRequest);

        taobaokeItemDetail = response.TaobaokeItemDetails[0];
        if (taobaokeItemDetail != null)
        {
            this.Title = taobaokeItemDetail.Item.Title + "[BiuBiu街]";

            ((HtmlMeta)this.Master.FindControl("keywords")).Content = taobaokeItemDetail.Item.Title + " 买家 评价 购物体验";
            ((HtmlMeta)this.Master.FindControl("description")).Content = ShopUtil.Strings.Left(ShopUtil.Strings.NoHTML(taobaokeItemDetail.Item.Desc), 100) + "[来自买家的真实评价]"; 
 
            //ltlTitle.Text = TaobaokeItemDetail.Item.Title;
            //ltlPrice.Text = TaobaokeItemDetail.Item.Price;
            //ltlPrice1.Text = BaseFunction.GetMarketPrice(decimal.Parse(TaobaokeItemDetail.Item.Price)).ToString();
            //ltlImg.Text = TaobaokeItemDetail.Item.PicUrl;
            //ltlDetail.Text = TaobaokeItemDetail.Item.Desc;
            //ltlShopUrl.Text = TaobaokeItemDetail.ShopClickUrl;
            //ltlClickUrl.Text = TaobaokeItemDetail.ClickUrl;
            //ltlSumary.Text = BaseFunction.cutString(BaseFunction.NoHTML(TaobaokeItemDetail.Item.Desc), 300);
            //ltlNumId.Text = "";//taoBaoKe.NumIid;
            //ltlCategory.Text = "0";// taoBaoKe.Category;

            //ltlPath.Text = ColumnCommon.GetColumnPath(ltlCategory.Text);
            //ltlCity.Text = TaobaokeItemDetail.Item.Location.City;
            //ltlPostFee.Text = "平邮：￥" + TaobaokeItemDetail.Item.PostFee + " EMS：￥" + TaobaokeItemDetail.Item.EmsFee + " 快递：￥" + TaobaokeItemDetail.Item.ExpressFee;
            //SetPageTitle(this, new string[] { TaobaokeItemDetail.Item.Title, TaobaokeItemDetail.Item.Title, ltlSumary.Text });
        }
        else
        {
            //ltlCategory.Text = "00010010";
            //ltlNumId.Text = "0";
        }
    }
}