<%@ WebHandler Language="C#" Class="aqi" %>
using System;
using System.Web;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

public class aqi : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";

        AQIModel aqi = new AQIModel();

        object cacheModel= context.Cache.Get("AQIModel");
        if (cacheModel == null)
        {
            aqi = GetAQI();
            context.Cache.Add("AQIModel", aqi, null, DateTime.MaxValue, TimeSpan.FromSeconds(30), System.Web.Caching.CacheItemPriority.High, null);
        }
        else
        {
            aqi = (AQIModel)cacheModel;
            if (aqi.PublishTime != DateTime.Now.ToString("yyyy年MM月dd日 HH时"))
            {
                aqi = GetAQI();
                context.Cache.Add("AQIModel", aqi, null, DateTime.Now.AddHours(1), TimeSpan.FromSeconds(30), System.Web.Caching.CacheItemPriority.High, null);
            }
        }
        
        string output = JavaScriptConvert.SerializeObject(aqi);
        context.Response.Write("jsonpcallback(" + output+")");
    }

    protected AQIModel GetAQI()
    {
        AQIModel aqi = new AQIModel();


        Shop.HttpRequestUtil httpRequestUtil = new Shop.HttpRequestUtil();
        string aqiContent = httpRequestUtil.DoGetRequest("http://www.semc.gov.cn/aqi/home/Index.aspx", "");

        Regex reg = new Regex("<span class='big' style=\"font-size:72px;\">(.*?)</span>");
        if (reg.Match(aqiContent).Groups.Count > 1)
        {
            aqi.AQIValue = reg.Match(aqiContent).Groups[1].Value;
        }

        //reg = new Regex("<td align=\"left\"><span style=\"font-size:16px;font-family:'微软雅黑'; font-weight:bold;\">(.*?)</span></td>");
        MatchCollection mc = Regex.Matches(aqiContent, "<td align=\"left\"><span style=\"font-size:16px;font-family:'微软雅黑'; font-weight:bold;\">(.*?)</span></td>", RegexOptions.None);
        if (mc.Count > 1)
        {
            aqi.AQIQuality = mc[0].Groups[1].Value;
            aqi.AQILevel = mc[1].Groups[1].Value;
        }

        mc = Regex.Matches(aqiContent, "<td >(.*?)</td>", RegexOptions.None);
        if (mc.Count > 2)
        {
            aqi.PremierContaminants = mc[0].Groups[1].Value;
            aqi.ImpactOnHealth = mc[1].Groups[1].Value;
            aqi.MeasuresProposed = mc[2].Groups[1].Value;
        }

        mc = Regex.Matches(aqiContent, "<div style=\"width:100%;text-align:center; line-height:15px;\">(.*?)</div>", RegexOptions.None);
        if (mc.Count > 0)
        {
            aqi.PublishTime = mc[0].Groups[1].Value;
        }
        return aqi;
    }
    
    public bool IsReusable {
        get {
            return false;
        }
    }

}

public class AQIModel
{
    //<span class='big' style="font-size:72px;">(.*?)</span>
    private string _AQIValue;
    public string AQIValue
    {
        get { return _AQIValue; }
        set { _AQIValue = value; }
    }

    private string _AQILevel;

    //<td align="left"><span style="font-size:16px;font-family:'微软雅黑'; font-weight:bold;">二级</span></td>
    public string AQILevel
    {
        get { return _AQILevel; }
        set { _AQILevel = value; }
    }
    private string _AQIQuality;

    public string AQIQuality
    {
        get { return _AQIQuality; }
        set { _AQIQuality = value; }
    }

    //<td >(.*?)</td>
    private string _PremierContaminants;

    public string PremierContaminants
    {
        get { return _PremierContaminants; }
        set { _PremierContaminants = value; }
    }

    private string _ImpactOnHealth;

    public string ImpactOnHealth
    {
        get { return _ImpactOnHealth; }
        set { _ImpactOnHealth = value; }
    }

    private string _MeasuresProposed;

    public string MeasuresProposed
    {
        get { return _MeasuresProposed; }
        set { _MeasuresProposed = value; }
    }

    private string _PublishTime;

    //<div style="width:100%;text-align:center; line-height:15px;">(.*?)</div>
    public string PublishTime
    {
        get { return _PublishTime; }
        set { _PublishTime = value; }
    }
}