<%@ Page Language="C#" AutoEventWireup="true" CodeFile="weibo_access.aspx.cs" Inherits="pages_database_weibo_access" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            DataSourceID="AccessDataSource1" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
            DataKeyNames="ID">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="weibo_id" HeaderText="weibo_id" 
                    SortExpression="weibo_id" />
                <asp:BoundField DataField="user_id" HeaderText="user_id" 
                    SortExpression="user_id" />
                <asp:BoundField DataField="accesskey" HeaderText="accesskey" 
                    SortExpression="accesskey" />
                <asp:BoundField DataField="accesssecret" HeaderText="accesssecret" 
                    SortExpression="accesssecret" />
                <asp:BoundField DataField="updateOn" HeaderText="updateOn" 
                    SortExpression="updateOn" />
                <asp:BoundField DataField="lastOperateOn" HeaderText="lastOperateOn" 
                    SortExpression="lastOperateOn" />
                <asp:BoundField DataField="day_send" HeaderText="day_send" 
                    SortExpression="day_send" />
                <asp:BoundField DataField="weibo_name" HeaderText="weibo_name" 
                    SortExpression="weibo_name" />
                <asp:BoundField DataField="weibo_url" HeaderText="weibo_url" 
                    SortExpression="weibo_url" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="ID" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/app/sellerWeibo/database/data.mdb" 
            SelectCommand="SELECT * FROM [tb_access_weibo]">
        </asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
