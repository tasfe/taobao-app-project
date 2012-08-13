using System;
using System.Collections.Generic;
using System.Text;
using Top.Api;

namespace TaobaoUtil
{
    public class DefaultTopClient
    {
        public static ITopClient GetDefaultTopClient()
        {
            return new Top.Api.DefaultTopClient(ShopUtil.XmlCOM.ReadConfig("ServerUrl"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppKey"), ShopUtil.XmlCOM.ReadConfig("TaobaoAppSecret"));
        }    
    }
}
