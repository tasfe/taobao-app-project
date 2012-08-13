using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

using QWeiboSDK;
/// <summary>
/// Summary description for QQAPIUtil
/// </summary>
public class QQAPIUtil
{
    public QQAPIUtil(string customKey, string customSecret, string customUrl)
	{
        appKey = ShopUtil.XmlCOM.ReadConfig("TXAppKey");
        appSecret = ShopUtil.XmlCOM.ReadConfig("TXAppSecret");
        callbackUrl = customUrl;
	}
    private string appKey = null;
    private string appSecret = null;
    private string callbackUrl = null;  
    public string tokenKey = null;
    public string tokenSecret = null;
    public string accessKey = null;
    public string accessSecret = null;
    private string OauthVerify = null;
 
    public bool GetRequestToken()
    {
        string url = "https://open.t.qq.com/cgi-bin/request_token";
        List<Parameter> parameters = new List<Parameter>();
        OauthKey oauthKey = new OauthKey();
        oauthKey.customKey = appKey;
        oauthKey.customSecret = appSecret;
        oauthKey.callbackUrl = callbackUrl;

        QWeiboRequest request = new QWeiboRequest();
        return ParseToken(request.SyncRequest(url, "GET", oauthKey, parameters, null));
    }

    private bool ParseToken(string response)
    {
        if (string.IsNullOrEmpty(response))
        {
            return false;
        }

        string[] tokenArray = response.Split('&');

        if (tokenArray.Length < 2)
        {
            return false;
        }

        string strTokenKey = tokenArray[0];
        string strTokenSecrect = tokenArray[1];

        string[] token1 = strTokenKey.Split('=');
        if (token1.Length < 2)
        {
            return false;
        }
        tokenKey = token1[1];

        string[] token2 = strTokenSecrect.Split('=');
        if (token2.Length < 2)
        {
            return false;
        }
        tokenSecret = token2[1];

        accessKey = tokenKey;
        accessSecret = tokenSecret;

        return true;
    }

    public bool GetAccessToken(string verify, string customTokenKey, string customTokenSecret)
    {
        string url = "https://open.t.qq.com/cgi-bin/access_token";
        List<Parameter> parameters = new List<Parameter>();
        OauthKey oauthKey = new OauthKey();
        oauthKey.customKey = appKey;
        oauthKey.customSecret = appSecret;
        oauthKey.tokenKey = customTokenKey;
        oauthKey.tokenSecret = customTokenSecret;
        oauthKey.verify = verify;

        QWeiboRequest request = new QWeiboRequest();
        return ParseToken(request.SyncRequest(url, "GET", oauthKey, parameters, null));
    }

    public string QQTAdd(List<string> arryValue)
    {
        List<Parameter> parameters = new List<Parameter>();
        OauthKey oauthKey = new OauthKey();
        oauthKey.customKey = appKey;
        oauthKey.customSecret = appSecret;
        oauthKey.tokenKey = accessKey;
        oauthKey.tokenSecret = accessSecret;

        UTF8Encoding utf8 = new UTF8Encoding();

        t twit = new t(oauthKey, "json");
        string ret = twit.add(utf8.GetString(utf8.GetBytes(arryValue[0])),
                      utf8.GetString(utf8.GetBytes(arryValue[1])),
                      utf8.GetString(utf8.GetBytes(arryValue[2])),
                      utf8.GetString(utf8.GetBytes(arryValue[3]))
                     );
        return ret;
    }

    public string QQTAddPic(List<string> arryValue)
    {
        List<Parameter> parameters = new List<Parameter>();
        OauthKey oauthKey = new OauthKey();
        oauthKey.customKey = appKey;
        oauthKey.customSecret = appSecret;
        oauthKey.tokenKey = accessKey;
        oauthKey.tokenSecret = accessSecret;

        UTF8Encoding utf8 = new UTF8Encoding();

        t twit = new t(oauthKey, "json");
        string ret = twit.add_pic(utf8.GetString(utf8.GetBytes(arryValue[0])),
                      utf8.GetString(utf8.GetBytes(arryValue[1])),
                      utf8.GetString(utf8.GetBytes(arryValue[2])),
                      utf8.GetString(utf8.GetBytes(arryValue[3])),
                      utf8.GetString(utf8.GetBytes(arryValue[4]))
                     );
        return ret;
    }

    public string QQUserInfo()
    {
        OauthKey oauthKey = new OauthKey();
        oauthKey.customKey = appKey;
        oauthKey.customSecret = appSecret;
        oauthKey.tokenKey = accessKey;
        oauthKey.tokenSecret = accessSecret;
        user user = new user(oauthKey, "xml");
        return user.info();
    }
}