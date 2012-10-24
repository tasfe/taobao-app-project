using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sharejoy.Model;
using sharejoy.BLL;

namespace MvcWebApi.Controllers
{
    public class SharejoyController : ApiController
    {
        /// <summary>
        /// 返回所有
        /// </summary>
        /// <returns>返回一个枚举类型为</returns>
        public IEnumerable<share> GetAllProducts()
        {
            shareBll bll = new shareBll();
            //bll.GetList("1=1");
            return new List<share>();
        }
    }
}
