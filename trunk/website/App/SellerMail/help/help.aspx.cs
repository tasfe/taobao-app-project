using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SellerHelp_help_Default : Shop.ShopUI.BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DoAction();
    }

    protected void DoAction()
    {
        string action = GetFormString("action");
        if (string.IsNullOrEmpty(action))
        {
            action = GetQueryString("action");
        }
        if (!string.IsNullOrEmpty(action))
        {
            if (action == "sendmail")
            {
                string result = "{\"result\":\"{0}\",\"msg\":\"{1}\"}";
                try
                {
                    ShopUtil.Mail.SendMail("29738637@qq.com", "推广平台客服邮件", GetFormString("c") + "<br/>" + GetFormString("e"));
                    result = result.Replace("{0}", "ok").Replace("{1}", "ok");
                }
                catch(Exception e)
                {
                    result = result.Replace("{0}", "no").Replace("{1}", e.ToString());
                }
                Response.Write(result);
                Response.End();
            }
        }
    }

    protected void btnSendMail_Click(object sender, EventArgs e)
    {
        try
        {
            ShopUtil.Mail.SendMail("29738637@qq.com", "推广平台客服邮件", txtContent.Text + "<br/>" + txtMail.Text);
            lblMsg.Text = "您的邮件我们已经收到，感谢您的支持，我们会在1个工作日答复您。";
        }
        catch
        {
            lblMsg.Text = "网络出现异常，您的邮件可能未发送成功，请重试！";
        }
    }
}