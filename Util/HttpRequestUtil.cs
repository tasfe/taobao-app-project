using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace Shop
{
    public class HttpRequestUtil
    {
        public CookieContainer cc = new CookieContainer();
        public string Cookiesstr = string.Empty;
        public HttpRequestUtil()
        {
        }
        public HttpRequestUtil(CookieContainer cookieContainer, string cookiesStr)
        {
            cc = cookieContainer;
            Cookiesstr = cookiesStr;
        }

        public string DoPostRequest(string postUrl, string postDate, string refererUrl)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            string gethost = string.Empty;
            
            //第一次POST请求
            string postdata = postDate;//模拟请求数据，数据样式可以用FireBug插件得到。人人网POST数据时，用户名邮箱中的“@”变为“%40”，所以我们也要作此变化
            string LoginUrl = postUrl;
            request = (HttpWebRequest)WebRequest.Create(LoginUrl);//实例化web访问类
            request.Method = "POST";//数据提交方式为POST
            //模拟头
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] postdatabytes = Encoding.GetEncoding("GB2312").GetBytes(postdata);
            request.ContentLength = postdatabytes.Length;
            request.Referer = refererUrl;
            request.AllowAutoRedirect = true;
            request.CookieContainer = cc;
            request.Headers.Add("Cookie:" + Cookiesstr); 
            request.KeepAlive = true;

            if ("1" == "1")
            {
                WebProxy proxy = new WebProxy("202.38.134.170", 8080);
                proxy.Credentials = new NetworkCredential("e-microsoft2@csvw.com", "123svw");
                request.Proxy = proxy;
            }

            //提交请求
            Stream stream;
            stream = request.GetRequestStream();
            stream.Write(postdatabytes, 0, postdatabytes.Length);
            stream.Close();
            //接收响应
            response = (HttpWebResponse)request.GetResponse();
            //保存返回cookie
            response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
            CookieCollection cook = response.Cookies;
            string strcrook = request.CookieContainer.GetCookieHeader(request.RequestUri);
            Cookiesstr = strcrook;
            //取第一次GET跳转地址
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            
            response.Close();

            return content;
        }


        public string DoGetRequest(string postUrl, string refererUrl)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            string gethost = string.Empty;

            //第一次POST请求
           string LoginUrl = postUrl;
            request = (HttpWebRequest)WebRequest.Create(LoginUrl);//实例化web访问类
            request.Method = "GET";//数据提交方式为POST
            //模拟头
            request.ContentType = "application/x-www-form-urlencoded";
            request.Referer = refererUrl;
            request.AllowAutoRedirect = true;
            request.CookieContainer = cc;
            request.Headers.Add("Cookie:" + Cookiesstr);
            request.KeepAlive = true;

            //if ("1" == "1")
            //{
            //    WebProxy proxy = new WebProxy("202.38.134.170", 8080);
            //    proxy.Credentials = new NetworkCredential("e-microsoft2@csvw.com", "123svw");
            //    request.Proxy = proxy;
            //}

            //提交请求
            //Stream stream;
            //stream = request.GetRequestStream();
            //stream.Write(postdatabytes, 0, postdatabytes.Length);
            //stream.Close();
            //接收响应
            response = (HttpWebResponse)request.GetResponse();
            //保存返回cookie
            response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
            CookieCollection cook = response.Cookies;
            string strcrook = request.CookieContainer.GetCookieHeader(request.RequestUri);
            Cookiesstr = strcrook;
            //取第一次GET跳转地址
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            response.Close();
            //string[] substr = content.Split(new char[] { '"' });
            //gethost = substr[1];

            return content;
        }

        public string GetCookie(string key)
        {
            string[] cookies = Cookiesstr.Split(';');
            string cookieValue="";

            foreach (string cookie in cookies)
            {
                if (cookie.Split('=').Length == 2)
                {
                    if (cookie.Split('=')[0] == key)
                    {
                        cookieValue = cookie.Split('=')[1];
                    }
                }
            }

            return cookieValue;
        }
    }
}
