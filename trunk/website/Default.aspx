<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
.category{border-bottom:1px dashed #ccc;padding-top:10px;width:100%;}
.category a{text-align:center;border:1px solid #ccc;-webkit-border-radius:12px;-moz-border-radius:12px;border-radius:12px;float:left;white-space:nowrap;height:20px;line-height:20px;margin-right:5px;margin-bottom:10px;background:#EAECEB;_line-height:21px;padding:0 8px;}
.category a.active{color:#fff;background:#FE73AB;border:1px solid #FCBFD4;}.rec_nav .category a.active:hover{color:#fff;}
#maincontent { margin:20px 0;}
.bigtitle{position:absolute; padding:5px;top:450px; font-size:24px; font-weight:bold; color:#FF75A4;}
.pict{ width:100%;}
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
<div  style="width:1200px;margin:40px auto; overflow:hidden;">
<%=topTaobaoContent%>
<%--<iframe name="alimamaifrm" frameborder="0" marginheight="0" marginwidth="0" border="0" scrolling="no" width="1200" height="574" src="http://top.taobao.com/interface_v2.php?pid=mm_17112190_2418515_10858599&type=x&f=html&ie=utf8&from=taoke&unid=&name=BiuBiu%E8%A1%97%E7%BD%91%E8%B4%AD%E9%A3%8E%E5%90%91%E6%A0%87&trtp=1&up=true&goodsFilter=all&sw=1200&sh=574&sn=14&rn=7&pn=5&ls=4&rs=4&bgc=FFFFFF&bc=D9D9D9&fc=404040&tc=404040&cat_ids=TR_FS%2CTR_HZP" ></iframe>
--%>
<style>
			body,div,ol{margin:0 auto;padding:0;}
			abody{font:12px/1.5 Tahoma,Helvetica,Arial,'宋体',sans-serif;overflow:hidden}
			img{border:0}
			:focus{outline:0}
			.topx-hd{height:25px;overflow:hidden;width:11500px}
			.topx-hd .topic{float:left;padding:0 15px;font-weight:700;font-size:14px;line-height:25px}
			.topx-hd ol{float:left;list-style:none}
			.topx-hd li{float:left;padding:3px 8px;font-weight:700;color:#666;height:18px;cursor:pointer;*position:relative}
			.topx-hd li.hover{border:solid #f78613;border-width:1px 1px 0 1px;background-color:#fff}
			.line{margin-top:-1px;border-top:1px solid #f78613;height:10px;font-size:0;line-height:0}
			.topx-bd ol{border:solid #ccc;list-style:none;border-width:1px 1px 0 1px}
			.topx-bd ol.dis{display:block}
			.topx-bd ol.undis{display:none}
			.topx-bd ol:after,.topx-ft:after{content:".";display:block;height:0;clear:both;visibility:hidden}
			.topx-bd ol,.topx-ft{*+height:1%}
			.topx-bd li{float:left;border-bottom:1px solid #ccc}
			.topx-bd li .unit{width:160px;height:240px;position:relative}
			.topx-bd li .unit a:hover,a:link,a:visited{text-decoration:none}
			.topx-bd li .unit span {display:block}
			.topx-bd li .unit .pic{display:table-cell;*font-size:120px;overflow:hidden;width:160px;height:160px;line-height:160px;background-color:#fff;text-align:center}
			.topx-bd li .unit .pic img{vertical-align:middle}
			.topx-bd li .unit .price{color:#a2a2a2}
			.topx-bd li .unit .price em{font-style:normal;font-weight:700;color:#f78613}
			.topx-bd li .unit .sales{color:#808080}
			.topx-bd li s{padding-right:15px;width:15px;height:30px;font-weight:700;text-decoration:none;text-align:center;color:#fff;background:url(http://img01.taobaocdn.com/tps/i1/T1L3ifXgXcXXXXXXXX-90-30.gif) no-repeat -30px 0;position:absolute;top:0;left:0}
			.topx-bd li s.fst{background-position: 0 0}
			.topx-ft {padding:0 5px;border:solid #ccc;border-width:0 1px 1px 1px;height:35px;font-weight:700;font-size:14px;overflow:hidden}
			.topx-ft a {color:#f78613}
			.topx-ft .tb-top{float:left;padding:7px 15px 7px 35px;background:url(http://img01.taobaocdn.com/tps/i1/T1L3ifXgXcXXXXXXXX-90-30.gif) no-repeat -60px 5px}
			.topx-ft .more{float:right;padding:7px 15px}

			 body{width:1200px}
			.topx-hd .topic{color:#404040}
			.topx-bd li .title{color:#404040;height:36px}
			.topx-bd ol{border-color:#D9D9D9}
			.topx-bd li{padding:10px 5px 0;border-bottom-color:#D9D9D9;width:160px;}
			.topx-bd li.first{padding-left:9px}
			.topx-bd li.last{padding-right:9px}
			.topx-ft{border-color:#D9D9D9}
			.topx-bd,.topx-ft{background-color:#FFFFFF}
		</style>
</div>
</asp:Content>

