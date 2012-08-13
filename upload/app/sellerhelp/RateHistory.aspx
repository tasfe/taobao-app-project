<%@ Page Title="" Language="C#" MasterPageFile="~/app/SellerHelp/masterpage/MasterPage.master" AutoEventWireup="true" CodeFile="RateHistory.aspx.cs" Inherits="SellerHelp_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>

</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper mainb main">
    <div class="left">
    <div class="category add_weibo">
    淘翻天卖家助手_进阶版订购：<br />
    1个月：￥3，<a href="http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-3:1"  target="_blank">订购</a><br />
    3个月：￥8，<a href="http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-3:3"  target="_blank">订购</a><br />
    6个月：￥16，<a href="http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-3:6"  target="_blank">订购</a><br />
    12个月：￥30<a href="http://fuwu.taobao.com/item/subsc.htm?items=ts-13815-3:12"  target="_blank">订购</a>
    </div>
    <div class="category">
   
    </div>

     <div class="category tip">
    
    </div>
    </div>
    <div class="right">
    <div class="listpage">
    <h2 class="hbline hbline1"><strong>评价列表</strong></h2>
    <div id="search">
        交易起始时间:<asp:TextBox ID="tbStartTDate" CssClass="text datepicker dtstart" runat="server"></asp:TextBox>
        交易结束时间：<asp:TextBox ID="tbEndDate" CssClass="text datepicker dtend" runat="server"></asp:TextBox>
        每页显示记录数：<asp:TextBox ID="tbPageSize"  CssClass="pagesize" runat="server" Text="50"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="tbPageSize" ErrorMessage="请输入1-50的数字" MaximumValue="50" 
            MinimumValue="1" Display="Dynamic" Type="Integer">
            </asp:RangeValidator>
            评价结果：<asp:DropDownList                ID="ddlResult" runat="server">
                <asp:ListItem>--</asp:ListItem>
                <asp:ListItem Value="good">好评</asp:ListItem>
                <asp:ListItem Value="neutral">中评</asp:ListItem>
                <asp:ListItem Value="bad">差评</asp:ListItem>
           
            </asp:DropDownList>
        <asp:Button ID="btnSearch" runat="server" Text="查询" onclick="btnSearch_Click" CssClass="btnsearch" />
        <br />
         <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
        <div>
        <br/>
        为了可以减少甚至避免超时问题，您可以：<br/>
        1. 每次返回50条以下，时间跨度小于半个小时 <br/>
        2. 避开交易高峰期上午9:30-11:00，下午14:00-17:00，晚上20:00-22:30 <br/>
        3. 只能查询近3个月的评价。
         </div>
        </div>
         <div id="Div1">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "?p=<#page#>&s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text + "|" + ddlResult.SelectedValue)%>
        </div>
        <ul id="list">
        <li class="first-item">
        <input  type="checkbox" class="chk-all" />全选 
    
         <input type='button' value='批量导出已评价买家联系方式' isfreeuser='<%=IsFreeUser()?"1":"0" %>' class='btn-rateimport'/><span class="red">(赶紧通过买家手机，邮箱，挽救您宝贵的评价吧)</span>
        </li>
           
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                <div class="fl">
                <%#Container.ItemIndex+1%>.
                <input  type="checkbox" class="chk-item"  value="<%#Eval("tid")%>" /></div>
                <div class="item-t">
                购买时间：<%#Eval("created")%>商品标题:<%#Eval("itemtitle")%>付款金额：<%#Eval("itemprice")%><br/>评价结果：<%# GetResult(Eval("result").ToString())%>评价内容:<%#Eval("content")%>评价解释:<%#Eval("reply")%><br/>
                旺旺：<%#Eval("nick")%>
                     <a  target="_blank" href="http://amos.im.alisoft.com/msg.aw?v=2&uid= <%#Eval("nick")%>&site=cntaobao&s=1&charset=utf-8" ><img border="0" src="http://amos.im.alisoft.com/online.aw?v=2&uid= <%#Eval("nick")%>&site=cntaobao&s=1&charset=utf-8" alt="点击这里给我发消息" /></a>
               </div>
                <div class="pic"></div>
                   
                </li>
            </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="pager">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "?p=<#page#>&s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text+"|"+ddlResult.SelectedValue)%>
        </div>
    </div>

        </div>
</div>
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
<script type="text/javascript">
    $(function () {

    })
</script>
</asp:Content>
