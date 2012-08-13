<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="pages_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>欢迎使用淘翻天微博推广平台</title>
    <link href="static/css/default.css" rel="stylesheet" type="text/css" />
    <script src="static/js/jquery-1.6.2.min.js" type="text/javascript"></script>
    <script src="static/js/dialog/js/jquery-ui-1.8.14.custom.min.js" type="text/javascript"></script>
    <link href="static/js/dialog/css/cupertino/jquery-ui-1.8.14.custom.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper head">
    <h1>淘翻天微博推广平台R</h1>
    <div class="headurl">
    <a  href="?">首页</a> | 
    <a  href="help/help.aspx">帮助</a> | 
    <a  href="?a=logout" onclick="if(confirm('确认退出?')){return true;}else{return false;}">退出</a> | 
      <a  href="help/help.aspx" >有问题？联系我</a> 
    </div>
    
    </div>
    <div class="wrapper"  style="display:none;">   <span class="msg-red">2011-07-23升级提示：1.增加了绑定多个账户功能。2.增加了保存模板功能。3.请老用户重新绑定帐号，感谢您的支持！</span>
    </div>
     <div class="wrapper upgrade" id="upgrade" style="">
   免费用户<a href="http://seller.taobao.com/fuwu/service.htm?service_id=12485" target="_blank">点此
     <img alt="升级" class="uimg" longdesc="升级" src="static/images/hp-update.gif" />
     </a>升级享受更多的服务
   <%--  <a href="#" class="usertypea">区别呢?</a>
--%>
     <div >
     <table class="usertype">
     <tr>
     <th>用户类型</th><th>发微博数量</th><th>绑定帐号个数</th><th>保存自定义模版</th>
     </tr>
     <tr>
     <td>免费用户:</td><td>每天10个</td> <td>可绑定2个账户</td><td>不可以</td>
     </tr>
     <tr>
     <td>
     收费用户:</td> <td>无限制</td> <td>无限制</td> <td>可以</td>
     </tr>
     </table>
     </div>
     
     </div>
    <div class="wrapper nav">
   
    <ul><li><a href="#"><%=nick %>你好，欢迎使用淘翻天微博推广平台</a></li><li><a href=""></a></li></ul>
<span class="navR">发微博从此轻松啦......</span>
</div>
<div class="wrapper mainb main">
    <div class="left">
    <div class="category add_weibo">
    <input type='button' value='添加微博帐号' id='add_weibo'/>
    <br />
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="category msg-red"><%if (nick == "shenjinkui1984") { 
                            %>
                            这是一个自动发送推广淘宝产品的到新浪微博的小工具，用户登录后可以获取自己产品信息，根据模版生成微博内容，对自己的淘宝产品进行微博推广，带来流量。
                            <%} %></div>
    <div class="category">
     <asp:Repeater ID="rptAccessWeibo" runat="server">
            <ItemTemplate>
             <h3>
                 
             <img src="<%#Eval("logo_url") %>" alt="<%#Eval("platform_name") %>" />  
             <a class="link-accessweibo" href="?a=unbind&id=<%#Eval("access_weibo_id") %>">取消绑定<%#Eval("platform_name") %></a>
             <br />
             <a href="<%#Eval("access_weibo_url")%>" target="_blank"><%#Eval("weibo_name")%></a></h3>
             </ItemTemplate>
            </asp:Repeater>
   
    </div>

     <div class="category tip">
     <div>
     说明：由于各个微博平台对自动发微博数量的限制，如果你发现微博失败的情况，请稍等片刻后，再重新发送。</div>
    </div>
    </div>
    <div class="right">
    <div class="listpage">
    <h2 class="hbline hbline1"><strong>推广产品列表</strong></h2>
        <ul id="list">
        <li class="first-item" style=" display:none;"><input  type="checkbox" class="chk-all" />全选 <input type='button' value='批量发微博' class='btn-all'/></li>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                <div class="fl"><input  type="checkbox" class="chk-item"/></div><div class="fl"><img class="pic" src="<%#Eval("PicUrl") %>" alt="<%#Eval("title") %>"/></div>
                <div class="fl item-t"><a class="link" href="http://item.taobao.com/item.htm?id=<%#Eval("numiid") %>" target="_blank"><%#Eval("title") %></a> ￥<span class="price"><%#Eval("price") %></span><br/><input type='button' value='发微博' class='btnt'/></div></li>
            </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="pager">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1,(int) count, 10, currPage, "?p=<#page#>")%>
        </div>
    </div>

        </div>
</div>
 <div class="wrapper foot">Copyright &copy; 1998-2011 taofantian All Rights Reserved</div>
 <div id="msg"><div class="msg-body"></div></div>
 <div id="dialog">
 <div class="w-templeate">
 <ul>
 <li>系统模板</li>
 <asp:Repeater ID="template1" runat="server">
 <ItemTemplate>
 <li class="sys-t">
 <input type="radio" class="t" name="r-temp" value="<%#Eval("template")%>" checked="checked"/>
 <span><%#Eval("template") %></span>
 </li></ItemTemplate>
 </asp:Repeater>
 <li id="save-t">保存过的模版
 </li>
 <li class="cus-t-null" style="display:none;">
 <input type="radio" class="t" name="r-temp"   value=""/><span></span><a title="" href="#">删除</a>
 </li>
 <asp:Repeater ID="template2" runat="server">
 <ItemTemplate>
 <li class="cus-t">
 <input type="radio" class="t" name="r-temp"  value="<%#Eval("template") %>"/>
 <%#Eval("template") %><a href="javascript:void(0)" title="<%#Eval("id") %>" class="del-t">删除</a>
 </li></ItemTemplate>
 </asp:Repeater>
 
 <li><input type="radio" class="t r-custom" name="r-temp" />自定义:<input type="text" class="t-custom" value="新品[标题]包邮哦,超低价[价格]点击查看[链接]" /><input id="save-template" value="保存模版" type="button"/></li>
 <li>
 提示：微博模板中的[标题][价格][链接]会被自动替换成要推广产品的相关信息。
 </li>
 </ul>
 </div>
 <div>
 <asp:Repeater ID="rptWeibo" runat="server">
 <ItemTemplate>
 <input  type="radio" id="weibo-<%#Eval("id") %>" title="<%#Eval("platform_name") %>" class="bind-weibo" checked="checked" name="weibo" value="<%#Eval("accesskey") %>|<%#Eval("accesssecret") %>"/><%#Eval("platform_name") %>【<%#Eval("weibo_name") %>】
 </ItemTemplate>
 </asp:Repeater>
 </div>
</div>  
 <div id="add_weibo_dialog">
     <asp:Repeater ID="rptWeiboAccount" runat="server">
         <ItemTemplate>
            <a href="?a=addweibo&id=<%#Eval("id") %>" style="<%#Eval("platform_name").ToString().IndexOf("新浪")==-1?"display:none":"" %> " >
            <img src="<%#Eval("logo_url") %>" alt="<%#Eval("platform_name") %>" /> 
            添加<%#Eval("platform_name") %>  帐号</a> 
         </ItemTemplate>
 </asp:Repeater>
 </div>
    </form>
</body>
</html>
