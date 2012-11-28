using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;
using System.Text;

using Top.Api.Request;
using Top.Api.Response;
using Top.Api.Domain;

public partial class Goods : System.Web.UI.Page
{
    protected TaobaokeItemDetail taobaokeItemDetail;
    //protected TaobaokeShop taobaokeShop=new TaobaokeShop();

    protected void Page_Load(object sender, EventArgs e)
    {
        GetTaoBaoKeFormApi(Request.QueryString["numiid"]);

        string app_key = "21121786";/*填写appkey */
        string secret = "4abd554e6df3e8ed7725d5d82174d0e4";/*填入Appsecret'*/

        DateTime timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
        long a = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;

        string timestamp = a.ToString().PadRight(13, '0');
        string message = secret + "app_key" + app_key + "timestamp" + timestamp + secret;


        string mysign = ComputeHash(message, secret);
        Response.Cookies["timestamp"].Value = timestamp;
        Response.Cookies["sign"].Value=mysign;
    }

    string ComputeHash(string source, string key)
    {
        HMACMD5 hmacmd = new HMACMD5(Encoding.Default.GetBytes(key));
        byte[] inArray = hmacmd.ComputeHash(Encoding.Default.GetBytes(source));
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inArray.Length; i++)
        {
            sb.Append(inArray[i].ToString("X2"));
        }

        hmacmd.Clear();

        return sb.ToString();
    } 

    protected void GetTaoBaoKeFormApi(string numiid)
    {
        Top.Api.ITopClient client = ShopUtil.OpenTaobaoUtil.GetTopClientInatance();

        TaobaokeItemsDetailGetRequest taobaokeItemsDetailGetRequest = new TaobaokeItemsDetailGetRequest();
        
        taobaokeItemsDetailGetRequest.Fields = "click_url,shop_click_url,seller_cids,desc,title,price,pic_url,volume,seller_credit_score,post_fee,ems_fee,express_fee,freight_payer,location.city,nick,num_iid,item_imgs";
        taobaokeItemsDetailGetRequest.NumIids = numiid;
        taobaokeItemsDetailGetRequest.Nick = "shenjinkui1984";
        TaobaokeItemsDetailGetResponse response=  client.Execute(taobaokeItemsDetailGetRequest);

        if (!response.IsError && response.TaobaokeItemDetails != null && response.TaobaokeItemDetails.Count != 0)
        {
            taobaokeItemDetail = response.TaobaokeItemDetails[0];
        }
        else
        {
            Response.Clear();
            Response.StatusCode = 302;
            Response.Redirect("Default.aspx");
        }

        if (taobaokeItemDetail != null)
        {
            this.Title = taobaokeItemDetail.Item.Title + "[BiuBiu街]";

            //TaobaokeShopsConvertRequest taobaokeShopsConvertRequest = new TaobaokeShopsConvertRequest();
            //taobaokeShopsConvertRequest.Fields = "user_id";
            //taobaokeShopsConvertRequest.SellerNicks = taobaokeItemDetail.Item.Nick;
            //taobaokeShopsConvertRequest.Nick = "shenjinkui1984";

            //TaobaokeShopsConvertResponse taobaokeShopsConvertResponse = client.Execute(taobaokeShopsConvertRequest);
            //if (!taobaokeShopsConvertResponse.IsError )
            //{
            //    taobaokeShop = taobaokeShopsConvertResponse.TaobaokeShops[0];
            //}
            ((HtmlMeta)this.Master.FindControl("keywords")).Content = taobaokeItemDetail.Item.Title + "淘宝 买家 真实评价 购物体验";
            ((HtmlMeta)this.Master.FindControl("description")).Content = ShopUtil.Strings.Left(ShopUtil.Strings.NoHTML(taobaokeItemDetail.Item.Desc).Trim(), 100) + "[来自买家的真实评价]";
            //taobaokeItemDetail.Item.NumIid;
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