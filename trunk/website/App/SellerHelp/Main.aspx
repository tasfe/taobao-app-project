<%@ Page Title="" Language="C#" MasterPageFile="~/app/SellerHelp/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="SellerHelp_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
.tb-list{ width:100%;}
.tb-list td{ border-bottom-style:solid 1px #ccc;}
.view-task-status{ display:none;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <div class="wrapper mainb main">
    <div class="left">
    <div class="category add_weibo">
    淘翻天卖家助手_进阶版订购：<br />
    1个月：<a href="http://fuwu.taobao.com/ser/detail.htm?spm=a1z13.2196609.2196609.20.tT2t0m&service_code=ts-13815"  target="_blank">订购</a><br />
    3个月：<a href="http://fuwu.taobao.com/ser/detail.htm?spm=a1z13.2196609.2196609.20.tT2t0m&service_code=ts-13815"  target="_blank">订购</a><br />
    6个月：<a href="http://fuwu.taobao.com/ser/detail.htm?spm=a1z13.2196609.2196609.20.tT2t0m&service_code=ts-13815"  target="_blank">订购</a><br />
    12个月：<a href="http://fuwu.taobao.com/ser/detail.htm?spm=a1z13.2196609.2196609.20.tT2t0m&service_code=ts-13815"  target="_blank">订购</a>
    </div>
    <div class="category">
   
    </div>

     <div class="category tip">
    
    </div>
    </div>
    <div class="right">
    <div class="listpage">
     <h2 class="hbline hbline1"><strong>导出任务列表</strong></h2>
    <table class="tb-list">
     <tr>
     <th>导出交易开始时间</th> <th>导出交易结束时间</th> <th>任务创建时间</th> <th>查看状态</th>
     </tr>
   
            <asp:Repeater ID="rptTask" runat="server">
             
            <ItemTemplate>
            <tr>
                <td><%#Eval("StartDate","{0:d}") %></td> 
                <td><%#Eval("EndDate", "{0:d}")%></td>
                <td><%#Eval("updateon")%></td> 
                <td><a class="task-status" tid="<%#Eval("TaskId") %>" href="javascript:void(0)">查看状态</a><div class="view-task-status"><img src="static/images/ajax-loader.gif" /></div></td>
                </tr>
                
            </ItemTemplate>
            </asp:Repeater>
        </table>
    <h2 class="hbline hbline1"><strong>交易列表</strong></h2>
    <div id="search">
        交易起始时间:<asp:TextBox ID="tbStartTDate" CssClass="text datepicker dtstart" runat="server"></asp:TextBox>
        交易结束时间：<asp:TextBox ID="tbEndDate" CssClass="text datepicker dtend" runat="server"></asp:TextBox>
        每页显示记录数：<asp:TextBox ID="tbPageSize"  CssClass="pagesize" runat="server" Text="50"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="tbPageSize" ErrorMessage="请输入1-100的数字" MaximumValue="100" 
            MinimumValue="1" Display="Dynamic" Type="Integer"></asp:RangeValidator>
      
        <asp:Button ID="btnSearch" runat="server" Text="查询" onclick="btnSearch_Click" CssClass="btnsearch" />
        <br />
         <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
         <div> <asp:Button ID="btnImport3" runat="server" Text="一键导出近3个月的交易" 
                 CssClass="btn-import-3" onclick="btnImport3_Click" /></div>
        <div>
        <br/>
        为了可以减少甚至避免超时问题，您可以：<br/>
        1. 每次返回100条以下，时间跨度小于半个小时 <br/>
        2. 避开交易高峰期上午9:30-11:00，下午14:00-17:00，晚上20:00-22:30 <br/>
        3. 交易是必须在3个月以内,可以为空。<br/>
        4. 导出近3个月内交易的任务的执行时段01:00~23:00，通常情况下每半小时执行一次任务，执行结束时间依据订单条数大小而定，通常在30~60分钟可以完成任务
         </div>
        </div>
         <div id="Div1">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "?p=<#page#>&s=" + tbStartTDate.Text + "|" + tbEndDate.Text + "|" + tbPageSize.Text)%>
        </div>
        <ul id="list">
        <li class="first-item">
        <input  type="checkbox" class="chk-all" />全选 
        <input type='button' value='批量导出交易信息' class='btn-all'/>
      
        </li>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li>
                <div class="fl">
                <%#Container.ItemIndex+1%>.
                <input  type="checkbox" class="chk-item"  value="<%#Eval("tid")%>" /></div>
                <div class="item-t">
                 旺旺：<%#Eval("buyernick")%><a  target="_blank" href="http://amos.im.alisoft.com/msg.aw?v=2&uid=<%#Eval("buyernick")%>&site=cntaobao&s=1&charset=utf-8" ><img border="0" src="http://amos.im.alisoft.com/online.aw?v=2&uid=<%#Eval("buyernick")%>&site=cntaobao&s=1&charset=utf-8" alt="点击这里给我发消息" /></a>购买时间：<%#Eval("created")%>付款金额：<%#Eval("payment")%>收货地址：<%#Eval("receiverstate")%><%#Eval("receivercity")%><%#Eval("receiverdistrict")%><%#Eval("receiveraddress")%><%#Eval("receivername")%><%#Eval("receiverzip")%>联系方式：<%#Eval("receivermobile")%><%#Eval("receiverphone")%></div>
                <div class="pic"><%#DisplayOrders(((Top.Api.Domain.Trade)Container.DataItem).Orders) %></div>
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
 <div>导出格式： <input  type="radio" name="import_format" class="import_format"  value="csv" checked="checked"/>
 <img src="static/images/exticons/xlsx.gif" />EXCEL 
  <input  type="radio" name="import_format" class="import_format"  value="txt"/>
  <img src="static/images/exticons/txt.gif" />TXT
  </div>
  <div style="display:none;">评价内容： <input  type="radio" name="import_rate" class="import_rate"  value="all" checked="checked"/>所有
  <input  type="radio" name="import_rate" class="import_rate"  value="good"/>好评
  <input  type="radio" name="import_rate" class="import_rate"  value="neutral"/>中评
  <input  type="radio" name="import_rate" class="import_rate"  value="bad"/>差评
 </div>
 </div>
</div>  
 <script>
     $(".task-status").click(function () {
         $(this).next().toggle();
     })
 </script>
</asp:Content>

