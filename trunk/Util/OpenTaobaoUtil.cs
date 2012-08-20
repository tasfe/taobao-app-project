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
            req.Fields = "user_id,nick";

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
    }
}
