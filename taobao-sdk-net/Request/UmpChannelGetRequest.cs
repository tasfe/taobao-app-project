using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ump.channel.get
    /// </summary>
    public class UmpChannelGetRequest : ITopRequest<UmpChannelGetResponse>
    {
        /// <summary>
        /// 渠道代码以逗号(半角)隔开，若channel_keys为空，则返回所有已维护的渠道信息。
        /// </summary>
        public string ChannelKeys { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ump.channel.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_keys", this.ChannelKeys);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
