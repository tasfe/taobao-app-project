using System;
using System.Collections.Generic;
using System.Text;

namespace OAuthTXWeibo
{
    public class t : tBase
    {
        string add_pic_url = "http://open.t.qq.com/api/t/add_pic_url";

        /// <summary>用图片URL发表带图片的微博
        /// 
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="clientip">The clientip.</param>
        /// <param name="jing">The jing.</param>
        /// <param name="wei">The wei.</param>
        /// <param name="pic">The pic.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public string AddPicUrl(string content, string jing,
                        string wei, string pic_url)
        {
            Dictionary<string, string> parameters = baseParameter();

            parameters.Add("format", "json");
            parameters.Add("content", content);
            //parameters.Add("clientip", clientip);
            parameters.Add("jing", jing);
            parameters.Add("wei", wei);
            parameters.Add("pic_url", pic_url);
            parameters.Add("syncflag", "0");

            WebUtils webUtils = new WebUtils();
            return webUtils.DoPost(add_pic_url, parameters);
        }

        /// <summary>发表一条带图片的微博
        /// 
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="clientip">The clientip.</param>
        /// <param name="jing">The jing.</param>
        /// <param name="wei">The wei.</param>
        /// <param name="pic">The pic.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public string add_pic(string content, string clientip, string jing,
                        string wei, string pic)
        {
            List<Parameter> paras = new List<Parameter>();
            List<Parameter> files = new List<Parameter>();

            paras.Add(new Parameter("format", "xml"));
            paras.Add(new Parameter("content", content));
            paras.Add(new Parameter("clientip", clientip));
            paras.Add(new Parameter("jing", jing));
            paras.Add(new Parameter("wei", wei));

            files.Add(new Parameter("pic", pic));


            WebUtils webUtils = new WebUtils();
            return webUtils.HttpPostWithFile("", "", files);
        }
    }
}
