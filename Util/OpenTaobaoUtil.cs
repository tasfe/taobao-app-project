using System;
using System.Collections.Generic;
using System.Text;

using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;
using Top.Api.Parser;
using Top.Api.Response;
using Top.Api.Util;
namespace ShopUtil
{
    public class OpenTaobaoUtil
    {
        //static ITopClient client;
        public OpenTaobaoUtil()
        {
            //client = new DefaultTopClient(ShopUtil.XmlCOM.ReadConfig("TaobaoRestUrl"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppKey"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppSecret"), "json"); 
        }
        public UserGetResponse GetLoginUser(string top_session)
        {
            UserGetRequest req = new UserGetRequest();
            req.Fields = "nick";

            return GetDefaultTopClient().Execute(req, top_session);
        }

        //ts-12485
        public static VasSubscribeGetResponse GetVasSubscribeGetResponse(string nick)
        {
            return GetVasSubscribeGetResponse(nick, "ts-12485");
        }

        public static VasSubscribeGetResponse GetVasSubscribeGetResponse(string nick, string articleCode)
        {
            VasSubscribeGetRequest vasSubscribeGetRequest = new VasSubscribeGetRequest();
            vasSubscribeGetRequest.ArticleCode = articleCode;
            vasSubscribeGetRequest.Nick = nick;

            return GetDefaultTopClient().Execute(vasSubscribeGetRequest);
        }

        //static ITopClient topClient;
        public static ITopClient GetDefaultTopClient()
        {

            return new DefaultTopClient(ShopUtil.XmlCOM.ReadConfig("TaobaoRestUrl"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppKey"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppSecret"), "json");
        }

        //static ITopClient topClient;
        public static ITopClient GetTopClientInatance()
        {
            return new DefaultTopClient(ShopUtil.XmlCOM.ReadConfig("TaobaoRestUrl"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppKey"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppSecret"), "json");
        }

        public static Trade GetTrade(string fields, long tid, string top_session)
        {
            TradeFullinfoGetRequest tradeFullinfoGetRequest = new TradeFullinfoGetRequest();
            tradeFullinfoGetRequest.Tid = tid;
            tradeFullinfoGetRequest.Fields = fields;

            TradeFullinfoGetResponse tfgr = GetDefaultTopClient().Execute(tradeFullinfoGetRequest, top_session);
            if (tfgr.IsError)
            {
                throw new Exception(tfgr.ErrMsg);
            }
            return tfgr.Trade;
        }

        public static long GetAtsTrade(string fields, string tids, string top_session)
        {
            //List<Trade> trades = new List<Trade>();

            TopatsTradesFullinfoGetRequest topatsTradesFullinfoGetRequest = new Top.Api.Request.TopatsTradesFullinfoGetRequest();

            topatsTradesFullinfoGetRequest.Tids = tids;
            topatsTradesFullinfoGetRequest.Fields = fields;

            TopatsTradesFullinfoGetResponse tfgr = GetDefaultTopClient().Execute(topatsTradesFullinfoGetRequest, top_session);
            long taskId = 0;
            if (tfgr.IsError && tfgr.SubErrCode == "isv.task-duplicate")
            {
                long.TryParse(tfgr.SubErrMsg.Replace("相同的任务已经存在：TaskId=", "").Trim(), out taskId);
            }
            else
            {
                //throw new Exception(tfgr.ErrMsg);
            }

            if (tfgr.Task!=null)
                taskId = tfgr.Task.TaskId;


            return taskId; 
        }

        public static string  GetAtsTrade(long taskId,out List<Trade> trades)
        {
             trades = new List<Trade>();

            TopatsResultGetRequest req = new TopatsResultGetRequest();
  
            req.TaskId = taskId;

            TopatsResultGetResponse rsp = GetDefaultTopClient().Execute(req);

            if (rsp.Task.Status == "done")
            {
                foreach (Subtask subtask in rsp.Task.Subtasks)
                {
                    TopJsonParser parser = new TopJsonParser();
                    TradeFullinfoGetResponse tradeRsp = parser.Parse<TradeFullinfoGetResponse>(subtask.SubTaskResult);
                    if (tradeRsp.IsError)
                    {
                        //Console.WriteLine("错误处理...");
                        Trade t = new Trade();
                        t.BuyerNick = tradeRsp.ErrMsg;
                        trades.Add(t);
                    }
                    else
                    {
                        trades.Add(tradeRsp.Trade);
                    }
                }
            }

            return rsp.Task.Status; 
        }

        public static long GetTopatsTradesSold(string fields, DateTime start_time, DateTime end_time, string top_session, out string message)
        {
            TopatsTradesSoldGetRequest topatsTradesSoldGetRequest = new TopatsTradesSoldGetRequest();
            topatsTradesSoldGetRequest.Fields = fields;
            topatsTradesSoldGetRequest.StartTime = start_time.ToString("yyyyMMdd");
            topatsTradesSoldGetRequest.EndTime = end_time.ToString("yyyyMMdd");
            message = "";

            TopatsTradesSoldGetResponse TopatsTradesSoldGetResponse = GetDefaultTopClient().Execute(topatsTradesSoldGetRequest, top_session);

            long taskId = 0;
            if (TopatsTradesSoldGetResponse.IsError && TopatsTradesSoldGetResponse.SubErrCode == "isv.task-duplicate")
            {
                long.TryParse(TopatsTradesSoldGetResponse.SubErrMsg.Replace("相同的任务已经存在：TaskId=", "").Trim(), out taskId);
            }
            else if (TopatsTradesSoldGetResponse.IsError)
            {
                taskId = -1;
                message = TopatsTradesSoldGetResponse.ErrMsg + "-"+TopatsTradesSoldGetResponse.SubErrMsg;
            }

            if (TopatsTradesSoldGetResponse.Task != null)
                taskId = TopatsTradesSoldGetResponse.Task.TaskId;


            return taskId; 
        }
    }
}
