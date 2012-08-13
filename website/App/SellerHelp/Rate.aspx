<%@ Page Title="" Language="C#" MasterPageFile="~/app/SellerHelp/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Rate.aspx.cs" Inherits="SellerHelp_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="static/js/jquery.cookie.js" type="text/javascript"></script>
    <style type="text/css">
        .style1
        {
            width: 41px;
            height: 27px;
        }
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
    <h2 class="hbline hbline1"><strong>交易列表(只显示交易成功且未评价的交易)</strong></h2>
    <div id="search">
        交易起始时间:<asp:TextBox ID="tbStartTDate" CssClass="text datepicker dtstart" runat="server"></asp:TextBox>
        交易结束时间：<asp:TextBox ID="tbEndDate" CssClass="text datepicker dtend" runat="server"></asp:TextBox>
        每页显示记录数：<asp:TextBox ID="tbPageSize"  CssClass="pagesize" runat="server" Text="50"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="tbPageSize" ErrorMessage="请输入1-50的数字" MaximumValue="50" 
            MinimumValue="1" Display="Dynamic" Type="Integer"></asp:RangeValidator>
        <asp:Button ID="btnSearch" runat="server" Text="查询" onclick="btnSearch_Click" CssClass="btnsearch" />
        <br />
         <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
        <div>
        <br/>
        为了可以减少甚至避免超时问题，您可以：<br/>
        1. 每次返回50条以下，时间跨度小于半个小时 <br/>
        2. 避开交易高峰期上午9:30-11:00，下午14:00-17:00，晚上20:00-22:30 <br/>
        3. 交易结束是必须在15天以内才可以评价。
         </div>
        </div>
         <div id="Div1">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "?p=<#page#>&s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text)%>
        </div>
        <ul id="list">
        <li class="first-item">
        <input  type="checkbox" class="chk-all" />全选 
        <input type='button' value='批量评价' class='btn-rate'/>
        <a href="RateHistory.aspx"> 查看历史评价 <img alt=""  src="static/images/new.gif" /></a>
        </li>
           
           <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                <div class="fl">
                <%#Container.ItemIndex+1%>.
                <input  type="checkbox" class="chk-item"  value="<%#Eval("tid")%>" /></div>
                <div class="item-t">
                购买时间：<%#Eval("created")%>付款金额：<%#Eval("payment")%>旺旺：<%#Eval("buyernick")%>收货地址：<%#Eval("receiverstate")%><%#Eval("receivercity")%><%#Eval("receiverdistrict")%><%#Eval("receiveraddress")%><%#Eval("receivername")%><%#Eval("receiverzip")%>联系方式：<%#Eval("receivermobile")%><%#Eval("receiverphone")%></div>
                <div class="pic"><%#DisplayOrders(((Top.Api.Domain.Trade)Container.DataItem).Orders, Eval("tid").ToString(), Eval("endtime").ToString())%></div>
                </li>
            </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="pager">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "?p=<#page#>&s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text)%>
        </div>
    </div>

        </div>
</div>
 <div id="rate">
 <div id="rate-result">
 评价结果设置：
 <input  type="radio" name="result" class="result"  value="good" checked="checked"/>
好评 
  <input  type="radio" name="result" class="result"  value="neutral"/>
中评
  <input  type="radio" name="result" class="result"  value="bad"/>
差评
<div class="">
评价内容：<input type="text" class="rate-content" value="感谢您的惠顾，欢迎下次光临，嘻嘻" /></div>
 </div>
</div>  
<script type="text/javascript">
    $(function () {
        //$.cookie('rate-content', '感谢您的惠顾，欢迎下次光临，嘻嘻', { expires: 360 });
        var rate = $.cookie('rate-content');
        if (rate && rate.length > 0) {
            $(".rate-content").val(rate);
        }
    })
</script>
</asp:Content>

