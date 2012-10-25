<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageShare.aspx.cs" Inherits="MvcWebApi.Manage.WebForm1" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="plList" runat="server" Width="100%">
        <table width="100%">
            <tbody>
                <tr>
                    <td valign="top">
                        <table class="ListTable" width="100%">
                            <tbody>
                                <tr>
                                    <td>
                                        <b>管理</b>
                                    </td>
                                    <td align="center" width="150">
                                        &nbsp;
                                        <asp:Button ID="btnDelete" OnClick="btnDelete_Click1" runat="server" OnClientClick="return confirm('确认删除吗？')"
                                            Text="删除" CssClass="submitimg"></asp:Button>&nbsp;
                                        <input id="Button2" type="button" value="添加" class="submitimg" onclick="location.href='?t=add'" />
                                    </td>
                                    <th width="80">
                                        搜索条件
                                    </th>
                                    <td >
                                   
                                        <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>&nbsp;
                                        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="搜索" CssClass="submitimg">
                                        </asp:Button>
                                    </td>
                                    <th width="60">
                                        
                                    </th>
                                    <td>
                                        &nbsp;&nbsp;<asp:Label ID="lblPos" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td valign="middle">
                        <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="ListTable" PageSize="12"
                            OnRowCommand="GridView1_RowCommand" EmptyDataText="暂无相关信息" OnRowDataBound="GridView1_RowDataBound"
                            BorderWidth="1px" DataKeyNames="id" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField HeaderText="选择" ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </EditItemTemplate>
                                    <ItemStyle BorderWidth="1px" />
                                    <HeaderStyle BorderWidth="1px" Width="30px" />
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="内容">
                                    <ItemStyle BorderWidth="1px" />
                                    <HeaderStyle BorderWidth="1px" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="content" runat="server" NavigateUrl='#' Text='<%# Eval("content") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="分类">
                                    <ItemStyle BorderWidth="1px" />
                                    <HeaderStyle BorderWidth="1px" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='#' Text='<%# Eval("category_title") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="图片/视频地址">
                                    <ItemStyle BorderWidth="1px" />
                                    <HeaderStyle BorderWidth="1px" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="resource" runat="server" NavigateUrl='#' Text='<%# Eval("resource") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
            
                                <asp:TemplateField HeaderText="发布时间">
                                    <ItemStyle BorderWidth="1px" />
                                    <HeaderStyle BorderWidth="1px" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="create_date" runat="server" NavigateUrl='#' Text='<%# Eval("create_date") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="操作">
                                    <ItemStyle BorderWidth="1px" HorizontalAlign="Center" />
                                    <HeaderStyle BorderWidth="1px" Width="60px" HorizontalAlign="Center" />
                                    <ItemTemplate>
                                        <asp:HyperLink ID="linkMod" runat="server" NavigateUrl='<%#"?t=mod&id="+ Eval("id") %>'
                                            Text="查看/修改"></asp:HyperLink>
                                              
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <th align="right" 
                        style="font-size: 12px; background-color: #f3f7ff">
                        <webdiyer:AspNetPager ID="CtrlPager" runat="server" 
                            CustomInfoHTML="&lt;table &gt;&lt;tr&gt;&lt;td height='25px' valign='middle'&gt;共%PageCount%页，当前为第%CurrentPageIndex%页，每页%PageSize%条,共%RecordCount%条记录&lt;/td&gt;&lt;/tr&gt;&lt;/table&gt;" 
                            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" 
                            OnPageChanged="AspNetPager1_PageChanged" PageIndexBoxType="DropDownList" 
                            PrevPageText="上一页" ShowCustomInfoSection="Left" ShowPageIndexBox="Always" 
                            SubmitButtonText="Go" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" 
                            Visible="False">
                        </webdiyer:AspNetPager>
                    </th>
                </tr>
                <tr>
                    <td rowspan="1">
                        <table class="ListTable">
                            <tr>
                                <td>
                                    <input id="chkall" onclick="CheckAll(this.form)" type="checkbox" />全选/反选 &nbsp;
                                    &nbsp; &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
   
    </asp:Panel>

 
    <asp:Panel ID="plEdit" runat="server" Visible="false" Width="100%">
        <table cellspacing="1" cellpadding="0" width="100%" class="ListTable" align="center"
            border="0">
            <tbody>
                <tr>
                    <th align="right" width="100" bgcolor="white" height="16">
                        内容:
                    </th>
                    <td bgcolor="white" align="left">
                        <asp:TextBox ID="content"  runat="server" Width="300px" BorderStyle="Groove" 
                            Height="73px"></asp:TextBox>
                       
                    </td>
                </tr>
                 <tr>
                    <th align="right" width="100" bgcolor="white" height="16">
                        分类:
                    </th>
                    <td bgcolor="white" align="left">
                        <asp:TextBox ID="category_title" runat="server" Width="300px" 
                            BorderStyle="Groove"></asp:TextBox>
                      
                    </td>
                </tr>
                <tr>
                    <th align="right">
                        资源:
                    </th>
                    <td align="left">
                       <asp:TextBox ID="resource" runat="server" Width="300px" BorderStyle="Groove" 
                            Height="66px"></asp:TextBox>
                      
                    </td>
                </tr>
          
              
                <tr>
                    <td class="Boxtitle1" valign="middle" align="left">
                    </td>
                    <td>
                        <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="保存" CausesValidation="false" CssClass="submitimg" />
                        <input id="btnBack" type="button" value="返回" class="submitimg" onclick="location.href='?t=list'" />
                    </td>
                </tr>
            </tbody>
        </table>
        

    </asp:Panel>
    </form>
    </form>
</body>
</html>
