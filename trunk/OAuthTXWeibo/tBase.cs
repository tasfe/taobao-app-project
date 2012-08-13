using System;
using System.Collections.Generic;
using System.Text;

namespace OAuthTXWeibo
{
    public class tBase
    {
        //appkey
        public string oauth_consumer_key { get; set; }

        //授权获得的accesstoken
        public string access_token { get; set; }

        //授权获取的openid
        public string openid { get; set; }

        //客户端的ip
        public string clientip { get; set; }

        //版本号，必须为2.a
        public string oauth_version { get; set; }

        //请求权限范围（默认“all”）
        public string scope { get; set; }

        public Dictionary<string, string> baseParameter()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("oauth_consumer_key", oauth_consumer_key);
            param.Add("access_token", access_token);
            param.Add("openid", openid);
            param.Add("clientip", clientip);
            oauth_version = "2.a";
            param.Add("oauth_version", oauth_version);
            scope = "all";
            param.Add("scope", scope);

            return param;
        }

    }
}
