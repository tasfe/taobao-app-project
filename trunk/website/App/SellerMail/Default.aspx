<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="pages_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>淘翻天-邮件推广</title>
    <link href="static/css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <%if (from == "unknow")
      { %>  
    <div class="login">
       <div class="msg-red">正在跳转到淘宝官方授权登录页面<br/>我们不会保存您帐户相关信息</div>
       
       <a href='javascript:void(0)' onclick='if(confirm("确定离开?")){window.close();}'>离开</a>
    </div>
    <script>
         setTimeout(function () {
             window.location = '<%=ShopUtil.XmlCOM.ReadConfig("TaobaoOAthorUrl")%>';
         }, 3000)
    </script>
    <%}
      else
      { %>
  <div class="jump msg-green">
           <div> 正在跳转淘翻天邮件推广,请稍后......</div>
            <a href="<%=jumpUrl %>">等不及了</a>
    </div>
    <script>
        setTimeout(function () {
            window.location = '<%=jumpUrl %>';
        }, 3000)
    </script>
    <%}%>
    
    </form>
</body>
</html>
