<%@ WebHandler Language="C#" Class="aqi" %>
using System;
using System.Web;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

public class aqi : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";

        AQIModel aqi = new AQIModel();

        Shop.HttpRequestUtil httpRequestUtil = new Shop.HttpRequestUtil();
        string aqiContent = httpRequestUtil.DoGetRequest("http://www.semc.gov.cn/aqi/home/Index.aspx", "");

        Regex reg = new Regex("<span class='big' style=\"font-size:72px;\">(.*?)</span>");
        if (reg.Match(aqiContent).Groups.Count > 1)
        {
            aqi.AQIValue = reg.Match(aqiContent).Groups[1].Value;
        }
        reg = new Regex("<td align=\"left\"><span style=\"font-size:16px;font-family:'微软雅黑'; font-weight:bold;\">(.*?)</span></td>");
        if (reg.Match(aqiContent).Groups.Count > 1)
        {
            aqi.AQIQuality = reg.Match(aqiContent).Groups[1].Value;
            aqi.AQILevel = reg.Match(aqiContent).Groups[2].Value;
        }
        
        string output = JavaScriptConvert.SerializeObject(aqi);
        context.Response.Write(output);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}

class AQIModel
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