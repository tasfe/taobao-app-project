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
    protected int pageSize = 5;

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
             receiver_zip, receiver_mobile, receiver_phone,end_time,seller_rate,
             orders.title,orders.pic_path,orders.price,orders.num_iid,orders.seller_rate,orders.oid";
        //tradesSoldGetRequest.BuyerNick = "shenjinkui1984sand1";
        tradesSoldGetRequest.RateStatus = "RATE_UNSELLER";
        tradesSoldGetRequest.Status = "TRADE_FINISHED";

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
            if (action == "rate")
            {
                Response.Write(Rate());
                Response.End();
            }
            if (action == "logout")
            {
                Response.Redirect("default.aspx");
            }
        }
    }

    protected string DisplayOrders(List<Order> orders,string tid,string endtime)
    {
        StringBuilder sb = new StringBuilder();
        foreach (Order order in orders)
        {
            sb.Append(string.Format("<div class=\"orderitem\" tid=\"{5}\" oid=\"{6}\" t=\"{1}\" et=\"{7}\"><img src=\"{0}\"/> <a target=\"_blank\" href=\"http://item.taobao.com/item.htm?id={3}\">{1}</a> ￥{2}-{4}</div>",
                order.PicPath,
                order.Title,
                order.Price,
                order.NumIid,
                order.SellerRate ? "<span class='green'>已评价</span>" : "<span class='red'>未评价</span>",
                tid,
                order.Oid,
                endtime
                )
                );
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

            List<Trade> trades = new List<Trade>();
            foreach (string tid in tradeIds.Split(','))
            {
                trades.Add(TaobaoUtil.CommonUtil.GetTrade(importCols.Replace("[", "").Replace("]", "").Replace("-", ","), long.Parse(tid), topSession));
            }

            string format = GetFormString("format");

            string importText = GetImportRow(importColsName.Split(','), importCols.Split(','), trades);
            string filePath = Server.MapPath("~/SellerHelp/temp");
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

    protected string Rate()
    {
        string result = "{\"result\":\"{0}\",\"msg\":\"{1}\",\"detail\":\"{2}\"}";
        try
        {
            if (GetSessionString("subscribe_code") != subscribeCode)
            {
                return result.Replace("{0}", "no").Replace("{1}", "失败").Replace("{2}", string.Format("亲，免费用户不能批量评价哦，赶快<a href='{0}' style='color:red' target='_blank'>点此订购</a>吧，只要￥5元，同时拥有批量评价和交易导出",
                "http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-4:1"));

            }
            string tid = GetFormString("tid");
            string oid = GetFormString("oid");
            string content = GetFormString("content");
            string rateResult = GetFormString("result");
            DateTime endTime = DateTime.Parse(GetFormString("et"));

            if (endTime.AddDays(15) < DateTime.Now)
            {
                result = result.Replace("{0}", "no").Replace("{1}", "失败").Replace("{2}", "交易时间为[" + endTime.ToString()+ "]已超过15天的评价时间");
            }
            else
            {
                TraderateAddRequest traderateAddRequest = new TraderateAddRequest();
                traderateAddRequest.Tid = long.Parse(tid);
                traderateAddRequest.Oid = long.Parse(oid);
                traderateAddRequest.Result = rateResult;
                traderateAddRequest.Role = "seller";
                traderateAddRequest.Content = content;

                TraderateAddResponse traderateAddResponse = TaobaoUtil.DefaultTopClient.GetDefaultTopClient().Execute(traderateAddRequest, GetSessionString("top_session"));

                if (!traderateAddResponse.IsError)
                {
                    result = result.Replace("{0}", "ok").Replace("{1}", "成功").Replace("{2}", "");
                }
                else
                {
                    result = result.Replace("{0}", "no").Replace("{1}", "失败").Replace("{2}", traderateAddResponse.SubErrMsg);
                }
            }
            return result;
        }
        catch (Exception e)
        {
            return result.Replace("{0}", "no").Replace("{1}", e.ToString()).Replace("{2}", e.ToString());
        }
    }
}