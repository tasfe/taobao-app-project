using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sharejoy.Model;
using sharejoy.BLL;
using System.Data;

namespace MvcWebApi.Controllers
{
    public class SharejoyController : ApiController
    {
        /// <summary>
        /// 返回所有
        /// </summary>
        /// <returns>返回一个枚举类型为</returns>
        public IEnumerable<share> GetAllShares()
        {
            shareBll bll = new shareBll();
            DataTable dt= bll.GetList("1=1").Tables[0];

            return DBUtility.BuildModel.BuildModelListByTable<share>(dt);       
        }
    }
}
