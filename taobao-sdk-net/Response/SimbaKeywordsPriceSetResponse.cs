using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordsPriceSetResponse.
    /// </summary>
    public class SimbaKeywordsPriceSetResponse : TopResponse
    {
        /// <summary>
        /// 成功设置关键词价格的关键词列表
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("keyword")]
        public List<Keyword> Keywords { get; set; }
    }
}
