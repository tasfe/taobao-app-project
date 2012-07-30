using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Reflection;

using Top.Api;
using Top.Api.Domain;
using Top.Api.Response;
using Top.Api.Request;

public partial class SellerHelp_Main : Shop.ShopUI.BasePage
{
    protected int currPage = 1;
    protected long count = 0;
    protected int pageSize = 20;

    protected string nick = "";

    protected DateTime dtStart = new DateTime();
    protected DateTime dtEnd = new DateTime();

    protected string subscribeCode = "ts-13815-4";

    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Text = "";

        nick = GetSessionString("tb_username");
        CheckLogin();
        DoAction();

        currPage = GetQueryInt("p");
        currPage = currPage == 0 ? 1 : currPage;

        if (!Page.IsPostBack)
        {
            SetSearch();
            BindProduct(currPage);
        }
    }

    protected void BindProduct(int pageNo)
    {
        TradesSoldGetRequest tradesSoldGetRequest = new TradesSoldGetRequest();
        tradesSoldGetRequest.Fields = @"tid,buyer_nick,title, created ,payment,receiver_name,
             receiver_state, receiver_city, receiver_district, receiver_address, 
             receiver_zip, receiver_mobile, receiver_phone,end_time,
             orders.title,orders.pic_path,orders.price,orders.num_iid";

        tradesSoldGetRequest.PageNo = pageNo;

        if (!IsFreeUser())
        {
            if (tbStartTDate.Text.Length > 0)
            {
                DateTime.TryParse(tbStartTDate.Text, out dtStart);
                tradesSoldGetRequest.StartCreated = dtStart;

                if (dtStart < DateTime.Now.AddMonths(-3))
                {
                    lblMsg.Text = "开始时间必须在3个月以内";
                    return;
                }
            }
            if (tbEndDate.Text.Length > 0)
            {
                DateTime.TryParse(tbEndDate.Text, out dtEnd);
                tradesSoldGetRequest.EndCreated = dtEnd;

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

        }
        tradesSoldGetRequest.PageSize = pageSize;
        //tradesSoldGetRequest.BuyerNick = "shenjinkui1984sand1";
        TradesSoldGetResponse tradesSoldGetResponse = TaobaoUtil.DefaultTopClient.GetDefaultTopClient().Execute(tradesSoldGetRequest, GetSessionString("top_session"));
        count = tradesSoldGetResponse.TotalResults;
        Repeater1.DataSource = tradesSoldGetResponse.Trades;
        Repeater1.DataBind();

        //taobao.trade.fullinfo.get 
    }

    protected void DoAction()
    {
        string action = GetFormString("action");
        if (string.IsNullOrEmpty(action))
        {
            action = GetQueryString("action");
        }
        if (!string.IsNullOrEmpty(action))
        {
            if (action == "import")
            {
                Response.Write(Import());
                Response.End();
            }
            if (action == "logout")
            {
                Response.Redirect("default.aspx");
            }
        }
    }

    protected string DisplayOrders(List<Order> orders)
    {
        StringBuilder sb = new StringBuilder();
        foreach (Order order in orders)
        {
            sb.Append(string.Format("<div class=\"orderitem\"><img src=\"{0}\"/> <a target=\"_blank\" href=\"http://item.taobao.com/item.htm?id={3}\">{1}</a> ￥{2}</div>",
                order.PicPath,
                order.Title,
                order.Price,
                order.NumIid));
        }
        return sb.ToString();
    }

    protected string Import()
    {
        string result = "{\"result\":\"{0}\",\"msg\":\"{1}\",\"path\":\"{2}\"}";
        try
        {
            string tradeIds = GetFormString("tids");
            if (tradeIds.EndsWith(","))
            {
                tradeIds = tradeIds.Substring(0, tradeIds.Length - 1);
            }

            string cols = GetFormString("cols");
            string importCols = "";
            string importColsName = "";
            foreach (string col in cols.Split(','))
            {
                if (col.IndexOf('|') > 0)
                {
                    string[] colInfo = col.Split('|');
                    importCols += colInfo[1] + ",";
                    importColsName += colInfo[0] + ",";
                }
            }

            if (importCols.EndsWith(","))
            {
                importCols = importCols.Substring(0, importCols.Length - 1);
            }

            if (importColsName.EndsWith(","))
            {
                importColsName = importColsName.Substring(0, importColsName.Length - 1);
            }

            string topSession = GetSessionString("top_session");
            string rate = GetFormString("rate");

            List<Trade> trades = new List<Trade>();
            foreach (string tid in tradeIds.Split(','))
            {
                if (rate != "all")
                {
                    if(CheckRate(long.Parse(tid),rate))
                    {
                        trades.Add(TaobaoUtil.CommonUtil.GetTrade(importCols.Replace("[", "").Replace("]", "").Replace("-", ","), long.Parse(tid), topSession));
                    }
                }
                else
                {
                    trades.Add(TaobaoUtil.CommonUtil.GetTrade(importCols.Replace("[", "").Replace("]", "").Replace("-", ","), long.Parse(tid), topSession));
                }
            }

            string format = GetFormString("format");

            string importText = GetImportRow(importColsName.Split(','), importCols.Split(','), trades);
            string filePath = Server.MapPath("~/app/SellerHelp/temp");
            string fileName = GetSessionString("tb_username") + "-" + DateTime.Now.ToString("yyyyMMddhhmmss") + "." + format;

            if (WriteFile(Path.Combine(filePath, fileName), importText))
            {
                result = result.Replace("{0}", "ok").Replace("{1}", "成功").Replace("{2}", "temp/" + fileName);
            }
            else
            {
                result = result.Replace("{0}", "no").Replace("{1}", "文件写入失败").Replace("{2}", "temp/" + fileName);
            }

            return result;
        }
        catch (Exception e)
        {
            return result.Replace("{0}", "no").Replace("{1}", e.ToString()).Replace("{2}", "");
        }
    }

    protected bool CheckRate(long tid,string result)
    {
        TraderatesGetRequest TraderatesGetRequest = new TraderatesGetRequest();
        TraderatesGetRequest.Fields = "tid,result";
        TraderatesGetRequest.RateType = "get";
        TraderatesGetRequest.Role = "buyer";
        TraderatesGetRequest.Tid = tid;
        //TraderatesGetRequest.Result = result;

        TraderatesGetResponse traderatesGetResponse = TaobaoUtil.DefaultTopClient.GetDefaultTopClient().Execute(TraderatesGetRequest, GetSessionString("top_session"));

        if (traderatesGetResponse.TotalResults > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected string GetImportRow(string[] rowName, string[] cols, List<Trade> trades)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(string.Join(",", rowName) + "\r\n");

        StringBuilder row = new StringBuilder();
        Type objType = typeof(Trade);
        PropertyInfo propertyInfo;
        PropertyInfo[] propertyInfos = objType.GetProperties();

        foreach (Trade trade in trades)
        {
            row.Remove(0, row.Length);
            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].IndexOf('[') == -1)
                {
                    propertyInfo = GetPropertyInfo(propertyInfos, cols[i].Replace("_", ""));
                    if (propertyInfo != null)
                    {
                        object objValue = propertyInfo.GetValue(trade, null);
                        if (objValue != null)
                        {
                            row.Append(objValue.ToString());
                        }
                    }
                }
                else
                {
                    string[] subCols = cols[i].Replace("[", "").Replace("]", "").Split('-');
                    for (int j = 0; j < subCols.Length; j++)
                    {
                        propertyInfo = GetPropertyInfo(propertyInfos, subCols[j].Replace("_", ""));
                        if (propertyInfo != null)
                        {
                            object objValue = propertyInfo.GetValue(trade, null);
                            if (objValue != null)
                            {
                                row.Append(objValue.ToString());
                            }
                        }
                        if (j < subCols.Length - 1)
                        {
                            row.Append(" ");
                        }
                    }
                }
                if (i < cols.Length - 1)
                {
                    row.Append(",");
                }

            }
            sb.Append(row);
            sb.Append("\r\n");
        }

        return sb.ToString();
    }

    protected PropertyInfo GetPropertyInfo(PropertyInfo[] propertyInfos, string name)
    {
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {
            if (propertyInfo.Name.ToLower() == name.ToLower())
            {
                return propertyInfo;
            }
        }
        return null;
    }

    public bool WriteFile(string fileName, string Message)
    {
        bool ret = false;
        FileStream fs = new FileStream(fileName, FileMode.Create);
        //StreamWriter strwriter = new StreamWriter(fs,Encoding.UTF8);
        try
        {
            byte[] buffer = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding("GB2312"), Encoding.UTF8.GetBytes(Message));
            //byte[] outBuffer = new byte[buffer.Length + 3];
            //outBuffer[0] = (byte)0xEF;//有BOM,解决乱码
            //outBuffer[1] = (byte)0xBB;
            //outBuffer[2] = (byte)0xBF;
            //Array.Copy(buffer, 0, outBuffer, 3, buffer.Length);

            fs.Write(buffer, 0, buffer.Length);
            //strwriter.WriteLine(System.Text.Encoding.GetEncoding("utf-8").GetString(buffer));  
            //strwriter.Flush();
            ret = true;
        }
        catch (Exception ee)
        {

        }
        finally
        {
            //strwriter.Close();
            //strwriter = null;
            fs.Close();
            fs = null;
        }
        return ret;
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
        if (!IsFreeUser())
        {
            currPage = 0;
            BindProduct(currPage);
        }
        else
        {
            lblMsg.Text = string.Format("亲，免费用户不能自定义查询哦，赶快<a href='{0}' target='_blank'>点此订购</a>吧，只要￥5元",
                "http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-4:1");
        }
    }

    protected void SetSearch()
    {
        string searchKey = GetQueryString("s");
        string[] searchKeys = searchKey.Split('|');
        if (searchKeys.Length > 2)
        {
            tbStartTDate.Text=searchKeys[0];
            tbEndDate.Text = searchKeys[1];
            tbPageSize.Text = searchKeys[2];
        }
    }

    protected string GetSearchString()
    {
        string search = "s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text+"|"+"";

        return search;
    }

    protected bool IsFreeUser()
    {
        return GetSessionString("subscribe_code") == subscribeCode ? false : true;
    }
}