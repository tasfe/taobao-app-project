using System;
using System.Collections.Generic;
using System.Text;

namespace OAuthTXWeibo
{
    public class AccessToken
    {
        //access_token=37e1a2ae977d9d82ac47ae731ff42881&expires_in=1209600&refresh_token=163cccbfa0fbf7ba330ebd4ee5625ee5&name=twriter_&nick=娌堥噾濂
        //访问第三方资源的凭证
        public string access_token{get;set;}
        
        //accesstoken过期时间，以返回的时间的准，单位为秒，注意过期时提醒用户重新授权
        public int expires_in{get;set;}

        //刷新token
        public string refresh_token{get;set;}

        public string name{get;set;}
    }
}
