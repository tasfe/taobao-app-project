<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Goods.aspx.cs" Inherits="Goods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="static/css/global_new.css" rel="stylesheet" type="text/css" />
    <link href="static/css/share_page.css" rel="stylesheet" type="text/css" />
    <link href="static/css/social_active.css" rel="stylesheet" type="text/css" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div class="top box_inset">
		     <div class="top_con box_inset">
		         <a class="hot" href="?" target="_blank">今日最热</a>
		         <a class="dress" href="?cata_id=2000000000000&frm=book_section1" target="_blank">衣服榜</a>
		         <a class="shoes" href="?cata_id=6000000000000&frm=book_section1" target="_blank">鞋子榜</a>
		         <a class="bag" href="?cata_id=5000000000000&frm=book_section1" target="_blank">包包榜</a>
		         <a class="access" href="?cata_id=7000000000000&frm=book_section1" target="_blank">配饰榜</a>
		         <a class="beauty" href="?cata_id=8000000000000&frm=book_section1" target="_blank">美容榜</a>
		         <a class="jiaju" href="?cata_id=9000000000000&frm=book_section1" target="_blank">家居榜</a>
		         </div>
		 </div>
		<div class="clear"></div>
		<div id="main" class="container_12">
			
								<div class="grid_12">
			<div class="grid_9 alpha">
			<div class="box_shadow mt14 p13">
		<div class="singleGoods t_365824987" style="padding-bottom: 0;" id="t365824987">
    <dl class="twitter_top">
      
    </dl>
        <div class="t_usecontent none">BiuBiu街推荐<%=taobaokeItemDetail.Item.Title%> </div>
        <div class="clear"></div>
            <div class="code_pic">

            <a href="<%=taobaokeItemDetail.ClickUrl%>" target="_blank">
                                    <img src="<%=taobaokeItemDetail.Item.PicUrl%>" width="450" alt="<%=taobaokeItemDetail.Item.Title%>"/>
             </a>
            <div id="xiu"></div>
        </div>
        <div class="goodsdetail">
            <div class="break-word">
                            <p class="f14 l22 mb14"><a href="?365824987?frm=out_title" target="_blank" class="goods_title">BiuBiu街推荐<%=taobaokeItemDetail.Item.Title%>
                <span class="i_taobao">&nbsp;</span></a></p>
						<a class="btn_price_go" href="<%=taobaokeItemDetail.ClickUrl%>" target="_blank">
						<span class="pricetag c f20b left white">￥<%=taobaokeItemDetail.Item.Price%></span>
                        <span class="f16 white mt8 left">去购买</span>              
                    </a>
                								<div class="clear"></div>
                            <p class="tui_heart c l22 mt10">
                    <a id="l365824987" class="s_collect red" href="javascript:void(0)" onclick="javascript:forwardMagazine(this,365824987,&#39;forward&#39;);"><span><em class="lm_shouji">&nbsp;&nbsp;</em>收进杂志</span><span>862</span></a>
                                        <a id="l365824987" class="tui_like ml7 red" onclick="javascript:likeMagazine(this,365824987)"><span class="likePanel"><samp class="lm_love">&nbsp;</samp>喜欢</span><span class="likeNum">2852</span></a>
                                    </p>
                <div class="clear"></div>
                                <p class="mt8" style="font-size:12px;display:none;">被<span class="red" style="font-weight:bold;">2852</span>个MM喜欢</p>
                <div class="mt5">
                                             </div>
                                                                                        </div>
        </div>
        
            
        <div class="clear"></div>
        
        <div class="original_pic_ioc" style="display: none;">
        <a href="http://imgtest.meiliworks.com/pic/_o/a0/0e/77498f6b41c030efdc5a83e3355e_500_750.jpeg" target="_blank"></a>
    </div>
    <div class="clear"></div>
	<div style="overflow:hidden;">

    <div class="t_sina">
	</div>
		
    <div class="t_tag r">
        <div class="share left">
                <a href="javascript:void(0)" onclick="return false;"><b class="f14 red" id="r365824987"></b>评论</a>| 分享到:
            </div>
  
       <div class="goods_pic none" type="display:none"></div>
		</div>
    </div>
</div>

<div class="clear"></div>

<ul class="goods_comm">
	<li class="comm_con">
		<div class="comments" id="t_note365824987">
			<div class="icon i2"></div>
            <ul class="pl_list none" id="rate-temp">
             <li class="list_info" >
								<a class="img_face" href="#" target="_blank">
                                <img class="namecard js_processed" alt="" src="{avatar}"></a>
								<p><span class="cgray r">{time}</span><span class="red"><a href="#" target="_blank">{nick}</a></span></p>
								<p>{content}<span class="red" style="padding-left:10px;"><a onclick="return false;" href="javascript:;"></a></span>
																	</p>
							</li>
																																					<li class="list_info">
								
															</ul>
			<div class="note-list">
				<ul class="pl_list" id="rate-list">

																																					<li class="list_info">
								
															</ul>
				<div class="clear"></div>
								<div id="pageNav1">
                                <a class="currentpage">1</a><a href="javascript:void(0)" onclick="twitterItemNote.getNoteList(&#39;1&#39;);">2</a><a href="javascript:void(0)" onclick="twitterItemNote.getNoteList(&#39;2&#39;);">3</a><a href="javascript:void(0)" onclick="twitterItemNote.getNoteList(&#39;3&#39;);">4</a><a href="javascript:void(0)" onclick="twitterItemNote.getNoteList(&#39;1&#39;);" class="pageNext">下一页&gt;</a>
                                </div>
			</div><!-- /.note-list -->
			
			<div class="reply_box mt10 none">
				<textarea class="pl_area answer_text" range="0"></textarea>
			</div>
			<div class="clear"></div>
			<div class="forwarding mt10 none">
				<span onclick="faceTableObj.showFaceIco(365824987);" class="left cursor"><a class="single_face"></a>表情</span>
				<span class="r"><a href="javascript:void(0);" class="pl_btn cursor" onclick="javascript: twitterItemNote.replyButtonClick(2207513, 365824987);return false;">评 论</a></span>
							</div>
			<div class="hint"></div>
			<div class="clear"></div>
		</div><!--/.comments -->
	</li>
</ul>
<div style="height: 48px; background: none repeat scroll 0% 0% rgb(247, 247, 247); padding: 6px 16px 6px 10px;overflow:hidden;">
	<p style="line-height:48px;" class="left">可以在这里买到：</p>
	<a href="<%=taobaokeItemDetail.ClickUrl%>" target="_blank"><img class="avatar48" src="<%=taobaokeItemDetail.Item.PicUrl%>">
	<p class="left cursor" style="font-size:14px;height:48px;line-height:48px;margin-left:8px;width:275px;white-space:nowrap;text-overflow:ellipsis;-o-text-overflow:ellipsis;overflow:hidden;"><%=taobaokeItemDetail.Item.Title%></p>
	<p class="i_taobao left" style="margin-left:3px;margin-top:15px;">&nbsp;</p></a>
	<a style="width: 95px;margin-left:12px;" class="r mt8 c f16 small_btn pr block white cursor" target="_blank" href="<%=taobaokeItemDetail.ClickUrl%>"><em class="small_btnr r pa"></em>去购买</a>
		<a href="<%=taobaokeItemDetail.ClickUrl%>" target="_blank"><span class="red r cursor" style="font-size:20px;line-height:48px;">￥<%=taobaokeItemDetail.Item.Price%></span></a></div>

	</div>
	<%--<div>
    <%=taobaokeItemDetail.Item.Desc%>
    </div>--%>
	<div class="clear"></div>
<h3 class="f16 mt14">也许你还喜欢</h3>
	
<div class="clear"></div>
	<h3 class="f16 mt14">猜你喜欢 </h3>

<div class="clear"></div>

	

	</div>





			</div>
					
						<div class="clear"></div>
	</div><!-- main -->
    <script type="text/javascript">
        var maxPage = 1;
        function jsonp_reviews_list(rate) {
            //alert(rate.comments[0].content)
            var template = $("#rate-temp").html();
            var html = "";
            if (rate.comments) {
                maxPage = rate.maxPage;
                for (var i = 0; i < rate.comments.length; i++) {
                    html += template
            .replace("{content}", rate.comments[i].content)
            .replace("{time}", rate.comments[i].date)
            .replace("{nick}", rate.comments[i].user.nick)
            .replace("{avatar}", rate.comments[i].user.avatar)
                }

                $("#rate-list").html(html)
            }
        }
</script>
<script src="http://a.tbcdn.cn/apps/top/x/sdk.js?appkey=21121786"></script>
<script>

    var userID = "";
    $(function () {
        TOP.api({
            method: 'taobao.taobaoke.widget.shops.convert',
            seller_nicks: '<%=taobaokeItemDetail.Item.Nick %>',
            fields: 'user_id'
        }, function (resp) {
            var userID = resp.taobaoke_shops.taobaoke_shop[0].user_id;
            maxPage
            //var url = "http://rate.taobao.com/feedRateList.htm?userNumId=899955988&auctionNumId=17902891727&currentPageNum=1&rateType=&orderType=sort_weight&showContent=1&attribute=&callback=jsonp_reviews_list";
            maxPage
            GetRate(userID, 1)
        })

    })

    function GetRate(userid, page) {
        $.getScript("http://rate.taobao.com/feedRateList.htm?userNumId=" + userid + "&auctionNumId=<%=taobaokeItemDetail.Item.NumIid%>&currentPageNum=" + page + "&rateType=&orderType=sort_weight&showContent=1&attribute=&callback=jsonp_reviews_list",
                function () {
                    var pageHtml = "";
                    for (var i = 1; i <= maxPage; i++) {
                        //alert(i);
                        pageHtml += "<a href='javascript:void(0)'";
                        if (i == page) {
                            pageHtml += " class=\"currentpage\" ";
                        }
                        else {
                            pageHtml += " onclick='GetRate(\"" + userid + "\", " + i + ")' ";
                        }

                        pageHtml += ">" + i + "</a>";
                    }

                    $("#pageNav1").html(pageHtml);
                }
            );
    }
</script>



</asp:Content>

