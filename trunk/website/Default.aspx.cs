using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading;
public partial class _Default : System.Web.UI.Page
{
    protected string topTaobaoContent="";
    //protected string topTaobaoStyle = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        string filter = " 1=1 ";
        int count = 0;
        DataTable dt = TaoBaoKeDAL.DBUtil.getDateByPager("tb_taobaoke", "tbk_id", "*", "5", "0", filter, "", "UpdateOn desc", out count);//feedBack.GetList("").Tables[0];
        rptList.DataSource = dt;

        rptList.DataBind();

        GetTopTaobao();
    }

    protected void GetTopTaobao()
    {
        Top.Api.Util.WebUtils webUtils = new Top.Api.Util.WebUtils();
        string url = "http://top.taobao.com/interface_v2.php?pid=mm_17112190_2418515_10858599&type=x&f=html&ie=utf8&from=taoke&unid=&name=BiuBiu%E8%A1%97%E7%BD%91%E8%B4%AD%E9%A3%8E%E5%90%91%E6%A0%87&trtp=1&up=true&goodsFilter=all&sw=1200&sh=574&sn=14&rn=7&pn=5&ls=4&rs=4&bgc=FFFFFF&bc=D9D9D9&fc=404040&tc=404040&cat_ids=TR_FS%2CTR_HZP";
        string content = webUtils.GetResponseAsString((System.Net.HttpWebResponse)webUtils.GetWebRequest(url, "get").GetResponse(), System.Text.Encoding.GetEncoding("GB2312"));

        Regex reg = new Regex("(?is)<body[^>]*>(?<body>.*?)</body>");
        //Regex reg1 = new Regex("(?is)<style[^>]*>(?<style>.*?)</style>");
        //topTaobaoStyle = "<style>" + reg1.Match(content).Groups["style"].Value + "</style>";
        topTaobaoContent = reg.Match(content).Groups["body"].Value ;
    }
}