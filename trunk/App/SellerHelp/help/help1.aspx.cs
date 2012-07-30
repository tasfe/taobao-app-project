using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_help_help : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSendMail_Click(object sender, EventArgs e)
    {
        try
        {
            //Util.Mail.SendMail("29738637@qq.com", "推广平台客服邮件", txtContent.Text + "<br/>" + txtMail.Text);
            lblMsg.Text = "您的邮件我们已经收到，感谢您的支持，我们会在1个工作日答复您。";
        }
        catch
        {
            lblMsg.Text = "网络出现异常，您的邮件可能未发送成功，请重试！";
        }
    }
}
