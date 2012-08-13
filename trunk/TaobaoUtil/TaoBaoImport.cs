using System;
using System.Collections.Generic;
using System.Text;

using Top.Api.Domain; 
using Top.Api.Request;
using Top.Api.Response;

namespace TaobaoUtil
{
    public class TaoBaoImport
    {

        public int ImportSellerCat(string nick)
        {
            List<SellerCat> sellerCats = GetSellerCat(nick);
            int catCount = 0;
            if (sellerCats != null && sellerCats.Count > 0)
            {
                //TB_SELLERCAT tb_sellercat = new TB_SELLERCAT();
                //foreach (SellerCat sellerCat in sellerCats)
                //{
                //    tb_sellercat.GetModelByCid(sellerCat.Cid.ToString());
                //    tb_sellercat.cid = sellerCat.Cid.ToString();
                //    tb_sellercat.name = sellerCat.Name;
                //    tb_sellercat.parent_cid = sellerCat.ParentCid.ToString();
                //    tb_sellercat.pic_url = sellerCat.PicUrl;
                //    tb_sellercat.type = sellerCat.Type;
                //    tb_sellercat.sort_order = (int)sellerCat.SortOrder;
                //    tb_sellercat.nick = nick;
                //    tb_sellercat.UpdateON = DateTime.Now;

                //    if (tb_sellercat.ID > 0)
                //    {
                //        tb_sellercat.Update();
                //    }
                //    else
                //    {
                //        tb_sellercat.Add();
                //    }
                //    catCount++;
                //}
            }

            return catCount;
        }

        public int ImportTaoItem(string nick)
        {
            int catCount = 0;
            //int allCount = 0;
            //int pageCount = 1;
            //int pageSize = 40;

            //ItemsGetRequest itemsGetRequest = new ItemsGetRequest();
            //itemsGetRequest.PageSize = pageSize;
            //itemsGetRequest.Fields = "num_iid";
            //itemsGetRequest.Nicks = nick;

            //ItemsGetResponse itemsGetResponse;
            //ItemGetRequest itemGetRequest=new ItemGetRequest();
            //itemGetRequest.Fields = "num_iid,location,desc,title,nick,pic_url,cid,price,type,delist_time,post_fee,ems_fee,express_fee,score,volume,detailurl";

            //for (int i = 0; i < pageCount; i++)
            //{
            //    itemsGetRequest.PageNo = i + 1;
            //    itemsGetResponse = DefaultTopClient.GetDefaultTopClient().Execute(itemsGetRequest);
            //    allCount = (int)itemsGetResponse.TotalResults;
            //    pageCount = allCount % pageSize == 0 ? allCount / pageSize : allCount / pageSize + 1;

            //    foreach (Item item in itemsGetResponse.Items)
            //    {
            //        //itemGetRequest.NumIid = item.NumIid;
            //        //Item itemDetail = DefaultTopClient.GetDefaultTopClient().Execute(itemGetRequest).Item;

            //        //TB_TAOBAO_ITEM TaoBaoKe = new TB_TAOBAO_ITEM();
            //        //TaoBaoKe.GetModelByNumiid(item.NumIid.ToString());
            //        //TaoBaoKe.Category = itemDetail.Cid.ToString();
            //        //TaoBaoKe.City = itemDetail.Location.City;//taobaokeItem.ItemLocation;
            //        //TaoBaoKe.ClickUrl = "";
            //        //TaoBaoKe.Commission =0;
            //        //TaoBaoKe.Desc = itemDetail.Desc;
            //        //TaoBaoKe.EmsFee = decimal.Parse(itemDetail.EmsFee);
            //        //TaoBaoKe.ExpressFee = decimal.Parse(itemDetail.ExpressFee);
            //        //TaoBaoKe.FreightPayer = itemDetail.FreightPayer;
            //        //TaoBaoKe.Pic_Url = itemDetail.PicUrl;
            //        //TaoBaoKe.ItemImgs = "";
            //        //TaoBaoKe.Nick = itemDetail.Nick;
            //        //TaoBaoKe.NumIid = itemDetail.NumIid.ToString();
            //        //TaoBaoKe.PostFee = decimal.Parse(itemDetail.PostFee);
            //        //TaoBaoKe.Price = decimal.Parse(itemDetail.Price);
            //        //TaoBaoKe.PropImgs = "";// taoBaoKe.PropImgs;

            //        //TaoBaoKe.SellerCreditScore = 0;
            //        //TaoBaoKe.ShopClickUrl = "";
            //        //TaoBaoKe.Title = itemDetail.Title;
            //        //TaoBaoKe.Volume =0;
            //        //TaoBaoKe.UpdateOn = DateTime.Now;
            //        //TaoBaoKe.TopCategory = "0";

            //        //catCount++;

            //        //if (TaoBaoKe.ID > 0)
            //        //{
            //        //    TaoBaoKe.Update();
            //        //    Console.WriteLine(catCount+":Update:" + TaoBaoKe.Title);
            //        //}
            //        //else
            //        //{
            //        //    TaoBaoKe.Add();
            //        //    Console.WriteLine(catCount + ":Add:" + TaoBaoKe.Title);
            //        //}

            //        System.Threading.Thread.Sleep(5000);
            //    }
            //}

            return catCount;
        }

        public List<Item> GetItems(string nick, int pageSize, int pageNo, out int count)
        {
            //ItemsGetRequest req = new ItemsGetRequest();
            //req.Fields = "num_iid,title,nick,pic_url,cid,price,type,delist_time,post_fee,score,volume,detailurl";
            //req.Nicks = nick;
            //req.PageSize = pageSize;
            //req.PageNo = pageNo;
            //req.OrderBy = "delist_time:desc";
            //ItemsGetResponse response = DefaultTopClient.GetDefaultTopClient().Execute(req);
            //count = (int)response.TotalResults;

            //return response.Items;
            count = 0;
            return new List<Item>();
        }

        public Item GetItem(long numIid)
        {
            ItemGetRequest req = new ItemGetRequest();
            req.Fields = "num_iid,desc,title,nick,pic_url,cid,price,type,delist_time,post_fee,score,volume,detailurl";
            req.NumIid = numIid;
            ItemGetResponse response = DefaultTopClient.GetDefaultTopClient().Execute(req);

            return response.Item;
        }
        protected List<SellerCat> GetSellerCat(string nick)
        {
            SellercatsListGetRequest sellercatsListGetRequest = new SellercatsListGetRequest();
            sellercatsListGetRequest.Nick = nick;

            SellercatsListGetResponse sellercatsListGetResponse = DefaultTopClient.GetDefaultTopClient().Execute(sellercatsListGetRequest);

            return sellercatsListGetResponse.SellerCats;
        }
    }
}
