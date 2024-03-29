using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jianghu.fan.check
    /// </summary>
    public class JianghuFanCheckRequest : ITopRequest<JianghuFanCheckResponse>
    {
        /// <summary>
        /// 粉丝的id
        /// </summary>
        public Nullable<long> FollowerId { get; set; }

        /// <summary>
        /// 达人的id值
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jianghu.fan.check";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("follower_id", this.FollowerId);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("follower_id", this.FollowerId);
            RequestValidator.ValidateRequired("user_id", this.UserId);
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
