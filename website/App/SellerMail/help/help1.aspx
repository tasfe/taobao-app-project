<%@ Page Language="C#" AutoEventWireup="true" CodeFile="help1.aspx.cs" Inherits="pages_help_help" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>淘翻天推广平台使用帮助</title>
    <link href="../static/css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper head">
    <h1>淘翻天微博推广平台</h1>
    <div class="headurl">
    <a  href="../Main.aspx">首页</a> | 
    <a  href="?">帮助</a> | 
    </div>
    </div>
    <div class="wrapper nav">
    <ul><li><a href="#">欢迎使用淘翻天微博推广平台</a></li><li><a href=""></a></li></ul>
<span class="navR">发微博从此轻松啦......</span>
</div>
<div class="wrapper mainb help">
<div class="mail">有问题？联系我
<asp:TextBox ID="txtMail" runat="server" Text="留下您的邮箱" Width="120px"></asp:TextBox><asp:RegularExpressionValidator
    ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="您的邮箱格式不正确哦" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ControlToValidate="txtMail" Display="Dynamic"></asp:RegularExpressionValidator>
<asp:TextBox ID="txtContent"    runat="server" Width="498px" Text="描述下您的问题,我们会及时答复您"></asp:TextBox>
<asp:Button ID="btnSendMail"    runat="server" Text="发送" 
        onclick="btnSendMail_Click" />
        <br /><asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
</div>
<p>
    <img src="images/1.jpg" />
    <img src="images/2.jpg" />
    <img src="images/12.jpg" />
     <img src="images/13.jpg" />
    <img src="images/4.jpg" />
    <img src="images/5.jpg" />
    <img src="images/15.jpg" />
    <img src="images/7.jpg" /> 
    <img src="images/14.jpg" />
    <img src="images/8.jpg" />
    <img src="images/11.jpg" />
    <img src="images/10.jpg" />
    </p>
</div>
 <div class="wrapper foot">Copyright &copy; 1998-2011 taofantian All Rights Reserved</div>
    </form>
</body>
</html>
