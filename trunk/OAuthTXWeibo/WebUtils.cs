using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace OAuthTXWeibo
{
    /// <summary>
    /// 网络工具类。
    /// </summary>
    public sealed class WebUtils
    {
        private int _timeout = 100000;

        /// <summary>
        /// 请求与响应的超时时间
        /// </summary>
        public int Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        /// <summary>
        /// 执行HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public string DoPost(string url, IDictionary<string, string> parameters)
        {
            HttpWebRequest req = GetWebRequest(url, "POST");
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters));
            System.IO.Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        /// <summary>
        /// 执行HTTP GET请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>HTTP响应</returns>
        public string DoGet(string url, IDictionary<string, string> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }

            HttpWebRequest req = GetWebRequest(url, "GET");
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.Default; //Encoding.GetEncoding(rsp.CharacterSet);
            return GetResponseAsString(rsp, encoding);
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <returns>HTTP响应</returns>
        //public string DoPost(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams)
        //{
        //    // 如果没有文件参数，则走普通POST请求
        //    if (fileParams == null || fileParams.Count == 0)
        //    {
        //        return DoPost(url, textParams);
        //    }

        //    string boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线

        //    HttpWebRequest req = GetWebRequest(url, "POST");
        //    req.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;

        //    System.IO.Stream reqStream = req.GetRequestStream();
        //    byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
        //    byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

        //    // 组装文本请求参数
        //    string textTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
        //    IEnumerator<KeyValuePair<string, string>> textEnum = textParams.GetEnumerator();
        //    while (textEnum.MoveNext())
        //    {
        //        string textEntry = string.Format(textTemplate, textEnum.Current.Key, textEnum.Current.Value);
        //        byte[] itemBytes = Encoding.UTF8.GetBytes(textEntry);
        //        reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
        //        reqStream.Write(itemBytes, 0, itemBytes.Length);
        //    }

        //    // 组装文件请求参数
        //    string fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
        //    IEnumerator<KeyValuePair<string, FileItem>> fileEnum = fileParams.GetEnumerator();
        //    while (fileEnum.MoveNext())
        //    {
        //        string key = fileEnum.Current.Key;
        //        FileItem fileItem = fileEnum.Current.Value;
        //        string fileEntry = string.Format(fileTemplate, key, fileItem.GetFileName(), fileItem.GetMimeType());
        //        byte[] itemBytes = Encoding.UTF8.GetBytes(fileEntry);
        //        reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
        //        reqStream.Write(itemBytes, 0, itemBytes.Length);

        //        byte[] fileBytes = fileItem.GetContent();
        //        reqStream.Write(fileBytes, 0, fileBytes.Length);
        //    }

        //    reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
        //    reqStream.Close();

        //    HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
        //    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
        //    return GetResponseAsString(rsp, encoding);
        //}

        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        { //直接确认，否则打不开
            return true;
        }

        public HttpWebRequest GetWebRequest(string url, string method)
        {
            HttpWebRequest req = null;
            if (url.Contains("https"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                req = (HttpWebRequest)WebRequest.Create(url);
            }

            req.ServicePoint.Expect100Continue = false;
            req.Method = method;
            req.KeepAlive = true;
            req.UserAgent = "Top4Net";
            req.Timeout = this._timeout;

            return req;
        }

        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        public string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            System.IO.Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }

        /// <summary>
        /// 组装GET请求URL。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <returns>带参数的GET请求URL</returns>
        public string BuildGetUrl(string url, IDictionary<string, string> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                if (url.Contains("?"))
                {
                    url = url + "&" + BuildQuery(parameters);
                }
                else
                {
                    url = url + "?" + BuildQuery(parameters);
                }
            }
            return url;
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> parameters)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;

            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }

                    postData.Append(name);
                    postData.Append("=");
                    postData.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
                    hasParam = true;
                }
            }

            return postData.ToString();
        }


        //同步方式发起http post请求，可以同时上传文件
        public string HttpPostWithFile(string url, string queryString, List<Parameter> files)
        {
            Stream requestStream = null;
            StreamReader responseReader = null;
            string responseData = null;
            string boundary = DateTime.Now.Ticks.ToString("x");
            url += '?' + queryString;
            HttpWebRequest webRequest = WebRequest.Create(url) as HttpWebRequest;
            webRequest.ServicePoint.Expect100Continue = false;
            webRequest.Timeout = 20000;
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            webRequest.Method = "POST";
            webRequest.KeepAlive = true;
            webRequest.Credentials = CredentialCache.DefaultCredentials;

            try
            {
                Stream memStream = new MemoryStream();

                byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";

                List<Parameter> listParams = HttpUtil.GetQueryParameters(queryString);

                foreach (Parameter param in listParams)
                {
                    string formitem = string.Format(formdataTemplate, param.Name, param.Value);
                    byte[] formitembytes = Encoding.UTF8.GetBytes(formitem);
                    memStream.Write(formitembytes, 0, formitembytes.Length);
                }

                memStream.Write(boundarybytes, 0, boundarybytes.Length);

                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: \"{2}\"\r\n\r\n";

                foreach (Parameter param in files)
                {
                    string name = param.Name;
                    string filePath = param.Value;
                    string file = Path.GetFileName(filePath);
                    string contentType = HttpUtil.GetContentType(file);

                    string header = string.Format(headerTemplate, name, file, contentType);
                    byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);

                    memStream.Write(headerbytes, 0, headerbytes.Length);

                    FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] buffer = new byte[1024];
                    int bytesRead = 0;

                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        memStream.Write(buffer, 0, bytesRead);
                    }

                    memStream.Write(boundarybytes, 0, boundarybytes.Length);
                    fileStream.Close();
                }

                webRequest.ContentLength = memStream.Length;

                requestStream = webRequest.GetRequestStream();

                memStream.Position = 0;
                byte[] tempBuffer = new byte[memStream.Length];
                memStream.Read(tempBuffer, 0, tempBuffer.Length);
                memStream.Close();
                requestStream.Write(tempBuffer, 0, tempBuffer.Length);
                requestStream.Close();
                requestStream = null;

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                responseData = responseReader.ReadToEnd();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (requestStream != null)
                {
                    requestStream.Close();
                    requestStream = null;
                }

                if (responseReader != null)
                {
                    responseReader.Close();
                    responseReader = null;
                }

                webRequest.GetResponse().GetResponseStream().Close();
                webRequest = null;
            }

            return responseData;
        }
    }
}
