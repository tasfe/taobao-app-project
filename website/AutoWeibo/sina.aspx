<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sina.aspx.cs" Inherits="AutoWeibo_sian" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="Login" runat="server" Text="Sina Login" onclick="Login_Click" />
    <div>
    
        <asp:TextBox ID="txtInfo" runat="server" TextMode="MultiLine" Height="211px" 
            Width="481px"></asp:TextBox>
    
        <asp:Button ID="btnGetWeibo" runat="server" Text="user_timeline" 
            onclick="btnGetWeibo_Click" />
    
    </div>
    </form>
</body>
</html>
