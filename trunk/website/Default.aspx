<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
.category{border-bottom:1px dashed #ccc;padding-top:10px;width:100%;}
.category a{text-align:center;border:1px solid #ccc;-webkit-border-radius:12px;-moz-border-radius:12px;border-radius:12px;float:left;white-space:nowrap;height:20px;line-height:20px;margin-right:5px;margin-bottom:10px;background:#EAECEB;_line-height:21px;padding:0 8px;}
.category a.active{color:#fff;background:#FE73AB;border:1px solid #FCBFD4;}.rec_nav .category a.active:hover{color:#fff;}
#maincontent { margin:20px 0;}
.bigtitle{position:absolute; padding:5px;top:450px; font-size:24px; font-weight:bold; color:#FF75A4;}
</style>
<link rel="stylesheet" type="text/css" href="static/css/ad/lrtk.css" />
<script type="text/javascript" src="static/js/ad/slide.js"></script>
<script type="text/javascript" src="static/js/ad/slides.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="content_fluid" style="width: 100%;">
<div id="maincontent">
   <asp:Repeater ID="rptList" runat="server">
                <ItemTemplate>
                <div class="element pict main" style="position:relative;">
                <div class="bigtitle"><%#Eval("Title") %></div>
                <a href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank"><img src="<%#Eval("pic_url") %>" alt="<%#Eval("Title") %>"/></a>
               
                </div>
                </ItemTemplate>
                </asp:Repeater>
 <%--   <div class="element pict main"><a href="#"><img src="image/002.jpg"></a></div>--%>
   
    
    <div class="element navi left"><img src="static/images/ad/left.gif" alt="left"></div>
    <div class="element navi right"><img src="static/images/ad/right.gif" alt="right"></div>
</div>
<div class="category" style="border: none;">
                        <a class="" href="TSearch_%E8%BF%9E%E8%A1%A3%E8%A3%99.aspx">连衣裙</a>
                        <a class="" href="TSearch_%E8%A1%AC%E8%A1%AB.aspx">衬衫</a> <a class=""
                            href="TSearch_%E9%95%BF%E8%A3%99.aspx">长裙</a>
                             <a class="" href="TSearch_%E5%B9%B3%E5%BA%95%E5%87%89%E9%9E%8B.aspx">
                                平底凉鞋</a>
                                 <a class="" href="TSearch_%E8%BF%9E%E4%BD%93%E8%A3%A4.aspx">
                                    连体裤</a> <a class="" href="TSearch_%E6%B3%B3%E8%A1%A3.aspx">泳衣</a>
                        <a class="" href="TSearch_%E9%9B%AA%E7%BA%BA.aspx">雪纺</a> <a class=""
                            href="TSearch_%E8%83%8C%E5%BF%83.aspx">背心</a> <a class="" href="TSearch_t%E6%81%A4.aspx">
                                t恤</a> <a class="" href="TSearch_%E7%9F%AD%E8%A3%A4.aspx">短裤</a>
                        <a class="" href="TSearch_%E9%98%B2%E6%99%92%E8%A1%AB.aspx">防晒衫</a>
                        <a class="" href="TSearch_%E6%AC%A7%E7%BE%8E.aspx">欧美</a> <a class=""
                            href="TSearch_%E9%9F%A9%E7%B3%BB.aspx">韩系</a> <a class="" href="TSearch_%E6%97%A5%E7%B3%BB.aspx">
                                日系</a> <a class="" href="TSearch_%E5%87%89%E9%9E%8B.aspx">凉鞋</a>
                        <a class="" href="TSearch_%E5%A4%8D%E5%8F%A4.aspx">复古</a> <a class=""
                            href="TSearch_%E5%8C%85%E8%87%80%E8%A3%99.aspx">包臀裙</a> <a class=""
                                href="TSearch_%E5%93%88%E4%BC%A6%E8%A3%A4.aspx">哈伦裤</a>
                        <a class="" href="TSearch_%E4%B8%AA%E6%80%A7.aspx">个性</a> <a class=""
                            href="TSearch_%E7%94%9C%E7%BE%8E.aspx">甜美</a> 
                            <a class="" href="TSearch_%E7%89%9B%E4%BB%94%E7%9F%AD%E8%A3%A4.aspx">
                                牛仔短裤</a> <a class="" href="TSearch_%E8%A3%99%E8%A3%A4.aspx">裙裤</a>
                        <a class="" href="TSearch_%E6%89%8B%E6%9C%BA%E5%A3%B3.aspx">手机壳</a>
                        <a class="" href="TSearch_%E9%9C%B2%E8%82%A9.aspx">露肩</a> <a class=""
                            href="TSearch_%E6%89%93%E5%BA%95%E8%A3%A4.aspx">打底裤</a> <a class=""
                                href="TSearch_%E5%86%85%E8%A1%A3.aspx">内衣</a> <a class="" href="TSearch_%E9%92%B1%E5%8C%85.aspx">
                                    钱包</a> <a class="" href="TSearch_%E6%AF%94%E5%9F%BA%E5%B0%BC.aspx">
                                        比基尼</a> <a class="" href="TSearch_%E7%BD%A9%E8%A1%AB.aspx">罩衫</a>
                        <a class="" href="TSearch_%E9%AB%98%E8%B7%9F%E9%9E%8B.aspx">高跟鞋</a>
                        <a class="" href="TSearch_%E8%83%8C%E5%B8%A6%E8%A3%A4.aspx">背带裤</a>
                        <a class="" href="TSearch_%E5%8D%8A%E8%BA%AB%E8%A3%99.aspx">半身裙</a>
                        <a class="" href="TSearch_%E5%B8%86%E5%B8%83%E9%9E%8B.aspx">帆布鞋</a>
                        <div class="clear_f">
                        </div>
                    </div>
</div>
</asp:Content>

