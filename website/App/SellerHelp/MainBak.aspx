<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainBak.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>欢迎使用淘翻天卖家助手</title>
    <link href="static/css/default.css" rel="stylesheet" type="text/css" />
    <script src="static/js/jquery-1.6.2.min.js" type="text/javascript"></script>
    <script src="static/js/dialog/js/jquery-ui-1.8.14.custom.min.js" type="text/javascript"></script>
    <script src="static/js/default.js" type="text/javascript"></script>
    <link href="static/js/dialog/css/cupertino/jquery-ui-1.8.14.custom.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper head">
    <h1>淘翻天卖家助手</h1>
    <div class="headurl">
    <a  href="?">首页</a> | 
    <a  href="help/help.aspx">帮助</a> | 
    <a  href="?a=logout" onclick="if(confirm('确认退出?')){return true;}else{return false;}">退出</a> | 
      <a  href="help/help.aspx" >有问题？联系我</a> 
    </div>
    
    </div>
    <%--<div class="wrapper">
    <span class="msg-red"> </span><br/>
    </div>
     <div class="wrapper upgrade" id="upgrade">
     
     </div>--%>
    <div class="wrapper nav">
   
    <ul><li><a href="#"><%=nick %>你好，欢迎使用淘翻天卖家助手</a></li><li><a href=""></a></li></ul>
<span class="navR">做卖家从此轻松啦......</span>
</div>
<div class="wrapper mainb main">
    <div class="left">
    <div class="category add_weibo">
    <br />
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="category">
   
    </div>

     <div class="category tip">
    
    </div>
    </div>
    <div class="right">
    <div class="listpage">
    <h2 class="hbline hbline1"><strong>交易列表</strong></h2>
        <ul id="list">
        <li class="first-item"><input  type="checkbox" class="chk-all" />全选 <input type='button' value='批量导出交易信息' class='btn-all'/></li>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                <div class="fl"><input  type="checkbox" class="chk-item"  value="<%#Eval("tid")%>" /></div>
                <div class="item-t">
                购买时间：<%#Eval("created")%>
                付款金额：<%#Eval("payment")%>
                旺旺：<%#Eval("buyernick")%>
                收货地址：<%#Eval("receiverstate")%><%#Eval("receivercity")%><%#Eval("receiverdistrict")%><%#Eval("receiveraddress")%> <%#Eval("receivername")%> <%#Eval("receiverzip")%>
                联系方式：<%#Eval("receivermobile")%> <%#Eval("receiverphone")%>
                </div>
                <div class="pic"><%#DisplayOrders(((Top.Api.Domain.Trade)Container.DataItem).Orders) %></div>
                </li>
            </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="pager">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, 10, currPage, "?p=<#page#>")%>
        </div>
    </div>

        </div>
</div>
 <div class="wrapper foot">Copyright &copy; 1998-2011 taofantian All Rights Reserved</div>
 <div id="msg"><div class="msg-body"></div></div>
 <div id="dialog">
 <div id="import">
 <ul>
 <li>
 <input  type="checkbox" class="import_col"  value="交易时间|created" checked="checked" />交易时间
 </li>
 <li>
 <input  type="checkbox" class="import_col"  value="交易金额|payment" checked="checked"/>交易金额
 </li>
 <li>
 <input  type="checkbox" class="import_col"  value="收货信息|[receiver_state-receiver_city-receiver_district-receiver_address-receiver_name-receiver_zip]" checked="checked"/>收货信息
 </li>
 <li>
 <input  type="checkbox" class="import_col"  value="旺旺|buyer_nick" checked="checked"/>旺旺
 </li>
 <li>
 <input  type="checkbox" class="import_col"  value="手机 电话|[receiver_mobile-receiver_phone]" checked="checked"/>手机,电话
 </li>
 <li>
 <input  type="checkbox" class="import_col"  value="邮箱|buyer_email" checked="checked"/>邮箱
 </li>
 </ul>
 导出格式： <input  type="radio" name="import_format" class="import_format"  value="csv" checked="checked"/>
 <img src="static/images/exticons/xlsx.gif" />EXCEL 
  <input  type="radio" name="import_format" class="import_format"  value="txt"/>
  <img src="static/images/exticons/txt.gif" />TXT
 </div>
</div>  
 <div id="add_weibo_dialog">

 </div>
    </form>
</body>
</html>
