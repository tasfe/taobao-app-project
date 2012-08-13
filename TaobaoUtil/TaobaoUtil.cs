using System;
using System.Collections.Generic;
using System.Text;

using Top.Api;
using Top.Api.Domain;
using Top.Api.Request;
using Top.Api.Parser;
using Top.Api.Response;
using Top.Api.Util;

namespace TaobaoUtil
{
    public class CommonUtil
    {
        public UserGetResponse GetLoginUser(string top_session)
        {
            UserGetRequest req = new UserGetRequest();
            req.Fields = "user_id,uid,nick,sex,buyer_credit,seller_credit,location,created,last_visit,birthday,type,status,alipay_no,alipay_account,alipay_account,email,consumer_protection,alipay_bind";

            return DefaultTopClient.GetDefaultTopClient().Execute(req, top_session);
        }

 
    }
}
