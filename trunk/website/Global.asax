<%@ Application Language="C#" %>

<script runat="server">

    void Application_BeginRequest(object sender, EventArgs e)
    {
        //Response.Write("通用注入检查");
        bool result = false;

        /*if (Request.RequestType.ToUpper() == "POST")
        {
            result = SQLInjectionHelper.ValidUrlPostData();//Post数据检查
        }
        else
        {
            result = SQLInjectionHelper.ValidUrlGetData();//Get数据检查
        }

        if (result)
        {
            Response.Write("<div style='width:100%;font-size:20px;font-weight:bold;text-align:center;'>");
            Response.Write("您提交的数据有不合法字符！<a href='javascript:history.go(-1)'>返回</a>");
            Response.Write("</div>");
            Response.End();
        }*/
    }

    public class SQLInjectionHelper
    {
        /// <summary>
        /// 获取Post的数据
        /// </summary>
        public static bool ValidUrlPostData()
        {
            bool result = false;

            for (int i = 0; i < HttpContext.Current.Request.Form.Count; i++)
            {
                if (HttpContext.Current.Request.Form.GetKey(i) == "__VIEWSTATE"
                    ||HttpContext.Current.Request.Form.GetKey(i)=="__EVENTVALIDATION"
                ) 
                    continue;

                result = ValidData(HttpContext.Current.Request.Form[i].ToString());
                if (result)
                {
                    break;
                }//如果检测存在漏洞
            }
            return result;
        }

        /// <summary>
        /// 获取QueryString中的数据
        /// </summary>
        public static bool ValidUrlGetData()
        {
            bool result = false;

            for (int i = 0; i < HttpContext.Current.Request.QueryString.Count; i++)
            {
                result = ValidData(HttpContext.Current.Request.QueryString[i].ToString());
                if (result)
                {
                    break;
                }//如果检测存在漏洞
            }
            return result;
        }

        /// <summary>
        /// 验证是否存在注入代码
        /// </summary>
        /// <param name="inputData"></param>
        public static bool ValidData(string inputData)
        {
            //里面定义恶意字符集合
            //验证inputData是否包含恶意集合
            if (Regex.IsMatch(inputData.ToLower(), GetRegexString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取正则表达式
        /// </summary>
        /// <param name="queryConditions"></param>
        /// <returns></returns>
        private static string GetRegexString()
        {
            //构造SQL的注入关键字符
            string[] strBadChar = {"and"
    ,"exec"
    ,"insert"
    ,"select"
    ,"delete"
    ,"update"
    ,"count"
    ,"from"
    ,"drop"
    ,"asc"
    ,"char"
    ,"or"
    //,"*"
    ,"%"
    ,";"
    ,":"
    ,"\'"
    ,"\""
    ,"-"
    ,"chr"
    ,"mid"
    ,"master"
    ,"truncate"
    ,"char"
    ,"declare"
    ,"SiteName"
    ,"net user"
    ,"xp_cmdshell"
    ,"/add"
    ,"exec master.dbo.xp_cmdshell"
    ,"net localgroup administrators"};

            //构造正则表达式
            string str_Regex = ".*(";
            for (int i = 0; i < strBadChar.Length - 1; i++)
            {
                str_Regex += strBadChar[i] + "|";
            }
            str_Regex += strBadChar[strBadChar.Length - 1] + ").*";

            return str_Regex;
        }
    }
</script>
