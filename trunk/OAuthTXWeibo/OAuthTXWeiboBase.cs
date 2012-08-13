using System;
using System.Collections.Generic;
using System.Text;

namespace OAuthTXWeibo
{
    public class OAuthTXWeiboBase
    {
        string requestAuthorizeUrl = "https://open.t.qq.com/cgi-bin/oauth2/authorize?client_id={0}&response_type=code&redirect_uri={1}";
        string requestAccessTokenUrl = "https://open.t.qq.com/cgi-bin/oauth2/access_token?client_id={0}&client_secret={1}&redirect_uri={2}&grant_type=authorization_code&code={3}";
        
        public string GetRequestCodeUrl(string client_id,string redirect_uri)
        {
            return string.Format(requestAuthorizeUrl, client_id,redirect_uri);
        }

        public AccessToken GetAccessToken(string code, string client_id, string client_secret, string redirect_uri)
        {
            string requestUrl = string.Format(requestAccessTokenUrl, client_id, client_secret, redirect_uri, code);

            WebUtils webUtils = new WebUtils();
            string result=webUtils.DoGet(requestUrl, null);
            //access_token=37e1a2ae977d9d82ac47ae731ff42881&expires_in=1209600&refresh_token=eb4841797dee1ef27bf57550eb6ea70b&name=twriter_

            AccessToken accessToken = new AccessToken();
            string[] items = result.Split('&');
            foreach (string s in items)
            {
                string[] item = s.Split('=');
                Type t = accessToken.GetType();
                System.Reflection.PropertyInfo propertyInfo = t.GetProperty(item[0]);
                Type t1= propertyInfo.PropertyType;
                propertyInfo.SetValue(accessToken, Convert.ChangeType(item[1],t1), null);
            }

            return accessToken;
        }
    }
}
