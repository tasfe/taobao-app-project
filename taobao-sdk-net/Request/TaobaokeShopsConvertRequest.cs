using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.shops.convert
    /// </summary>
    public class TaobaokeShopsConvertRequest : ITopRequest<TaobaokeShopsConvertResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokeShop淘宝客商品结构体中的user_id,shop_title,click_url,commission_rate;字段之间用","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.如果不传值,则默认是false.
        /// </summary>
        public Nullable<bool> IsMobile { get; set; }

        /// <summary>
        /// 推广者的淘宝会员昵称.注：这里指的是淘宝的登录会员名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 用户的pid,必须是mm_xxxx_0_0这种格式中间的"xxxx". 注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准,且pid的最大长度是20
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// 卖家昵称串.最大输入10个.格式如:"value1,value2,value3" 用" , "号分隔。  注意：sids和seller_nicks两个参数任意必须输入一个，如果同时输入，则以seller_nicks为准
        /// </summary>
        public string SellerNicks { get; set; }

        /// <summary>
        /// 店铺id串.最大输入10个.格式如:"value1,value2,value3" 用" , "号分隔店铺id.  注意：sids和seller_nicks两个参数任意必须输入一个，如果同时输入，则以seller_nicks为准
        /// </summary>
        public string Sids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.shops.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("is_mobile", this.IsMobile);
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("pid", this.Pid);
            parameters.Add("seller_nicks", this.SellerNicks);
            parameters.Add("sids", this.Sids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("seller_nicks", this.SellerNicks, 10);
            RequestValidator.ValidateMaxListSize("sids", this.Sids, 10);
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
