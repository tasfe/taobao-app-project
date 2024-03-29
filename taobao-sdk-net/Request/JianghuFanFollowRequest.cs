using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jianghu.fan.follow
    /// </summary>
    public class JianghuFanFollowRequest : ITopRequest<JianghuFanFollowResponse>
    {
        /// <summary>
        /// 掌柜的id，被关注者的id
        /// </summary>
        public Nullable<long> ShopOwnerId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jianghu.fan.follow";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("shop_owner_id", this.ShopOwnerId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shop_owner_id", this.ShopOwnerId);
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
