using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.onlineitems.get
    /// </summary>
    public class SimbaAdgroupOnlineitemsGetRequest : ITopRequest<SimbaAdgroupOnlineitemsGetResponse>
    {
        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 排序，true:降序， false:升序
        /// </summary>
        public Nullable<bool> OrderBy { get; set; }

        /// <summary>
        /// 排序字段，starts：按开始时间排序bidCount:按销量排序
        /// </summary>
        public string OrderField { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页尺寸，最大200
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.onlineitems.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("order_field", this.OrderField);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
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
