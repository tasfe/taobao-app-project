<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="pages_database_Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" 
            DataSourceID="AccessDataSource1" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
             <asp:BoundField DataField="tb_subscribe" HeaderText="tb_subscribe" 
                    SortExpression="tb_subscribe" />
                <asp:BoundField DataField="tb_userid" HeaderText="tb_userid" 
                    SortExpression="tb_userid" />
                <asp:BoundField DataField="tb_nick" HeaderText="tb_nick" 
                    SortExpression="tb_nick" />
                <asp:BoundField DataField="tx_key" HeaderText="tx_key" 
                    SortExpression="tx_key" />
                <asp:BoundField DataField="tx_secret" HeaderText="tx_secret" 
                    SortExpression="tx_secret" />
                <asp:BoundField DataField="updateon" HeaderText="updateon" 
                    SortExpression="updateon" />
                <asp:BoundField DataField="sina_key" HeaderText="sina_key" 
                    SortExpression="sina_key" />
                <asp:BoundField DataField="sina_secret" HeaderText="sina_secret" 
                    SortExpression="sina_secret" />
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
            DataFile="~/pages/database/data.mdb" 
            DeleteCommand="DELETE FROM [tb_user] WHERE [ID] = ?" 
            InsertCommand="INSERT INTO [tb_user] ([tb_userid], [tb_nick], [tx_key], [tx_secret], [updateon], [sina_key], [sina_secret], [ID]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" 
            SelectCommand="SELECT * FROM [tb_user]" 
            UpdateCommand="UPDATE [tb_user] SET [tb_userid] = ?, [tb_nick] = ?, [tx_key] = ?, [tx_secret] = ?, [updateon] = ?, [sina_key] = ?, [sina_secret] = ? WHERE [ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="tb_userid" Type="String" />
                <asp:Parameter Name="tb_nick" Type="String" />
                <asp:Parameter Name="tx_key" Type="String" />
                <asp:Parameter Name="tx_secret" Type="String" />
                <asp:Parameter Name="updateon" Type="DateTime" />
                <asp:Parameter Name="sina_key" Type="String" />
                <asp:Parameter Name="sina_secret" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="tb_userid" Type="String" />
                <asp:Parameter Name="tb_nick" Type="String" />
                <asp:Parameter Name="tx_key" Type="String" />
                <asp:Parameter Name="tx_secret" Type="String" />
                <asp:Parameter Name="updateon" Type="DateTime" />
                <asp:Parameter Name="sina_key" Type="String" />
                <asp:Parameter Name="sina_secret" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:AccessDataSource>
    </div>
    </form>
</body>
</html>
