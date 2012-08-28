<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Jie.aspx.cs" Inherits="Jie" %>

<%@ Register src="UserCtrl/HotSearch.ascx" tagname="HotSearch" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="static/css/page_guang.css" rel="stylesheet" type="text/css" />
    <style>
    .pageNav ul li{ float:left;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="content_fluid" style="width: 1200px;">
        <div class="ads_banner ads_top none_f" style="display: block;">
            <div class="boxImg">
                <ul class="_img" style="width: 100%; position: absolute; top: 0px;">
                    <li style="float: left; display: block; width: 100%; top: 400px;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/e4/7d/3a1db168a75fb1042ff414eb5820_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBV3-N%3Ffrm%3Dsenma01&sid=2&mid=683&adid=bc2fe9905a9bfee5330971ea59fcc912"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgst-dl.meiliworks.com/img/_o/8e/0a/79067d8c019d8166f9b8010a2518_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBR2va%3Ffrm%3Dhongkong&sid=2&mid=951&adid=44c83a1506457988f457cb126d82294e"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/f8/9d/9f5d6939226bf892d3d75096c4f3_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBYdwS%3Ffrm%3Dfangcaoji01&sid=2&mid=1007&adid=69bdc470fab736b4586ff71d5713bca0"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/69/a3/ceefc0765b3d37d649e4eaa5a9b6_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBYgwA%3Ffrm%3Dreke04&sid=2&mid=1026&adid=6a1f2b5245c30d7cef4fc93bbfe60385"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                </ul>
            </div>
            <div class="_num adType1">
                <a class="current"><span class="none_f">1</span></a><a class=""><span class="none_f">2</span></a><a
                    class=""><span class="none_f">3</span></a><a class=""><span class="none_f">4</span></a></div>
        </div>
        <div class="cata_title">
            <h2>
                24小时最热</h2>
        </div>
        <div class="clear_f">
        </div>
        <div class="goods_wall mlsWall" style="position: relative;">
            <div class="corner_notic">
          <uc1:HotSearch ID="HotSearch1" runat="server" />
<h2 class="mt14_f f14_f">
                    推荐杂志</h2>
                <div class="groupBox">
                    <div class="groupCon">
                        <div class="gc_title">
                            <h4>
                                <a target="_blank" href="http://www.meilishuo.com/group/13973799">BeYour ...</a></h4>
                            <p>
                                411</p>
                        </div>
                        <a target="_blank" href="http://www.meilishuo.com/group/13973799" class="imgBox">
                            <img src="./guang_files/cf0514784fa51fe44af862974362.jpg" class="maxpic">
                            <div class="clear_f">
                            </div>
                        </a>
                        <div class="infoBox c_f">
                            <span class="addGroupFollow red_follow" groupid="13973799">加关注</span>
                            <div class="clear_f">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="groupBox">
                    <div class="groupCon">
                        <div class="gc_title">
                            <h4>
                                <a target="_blank" href="http://www.meilishuo.com/group/14004985">透心蓝</a></h4>
                            <p>
                                148</p>
                        </div>
                        <a target="_blank" href="http://www.meilishuo.com/group/14004985" class="imgBox">
                            <img src="./guang_files/f65f041c31fdd092d081b03c79e9.jpg" class="maxpic">
                            <div class="clear_f">
                            </div>
                        </a>
                        <div class="infoBox c_f">
                            <span class="addGroupFollow red_follow" groupid="14004985">加关注</span>
                            <div class="clear_f">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="groupBox">
                    <div class="groupCon">
                        <div class="gc_title">
                            <h4>
                                <a target="_blank" href="http://www.meilishuo.com/group/14495723">白色蕾丝梦</a></h4>
                            <p>
                                201</p>
                        </div>
                        <a target="_blank" href="http://www.meilishuo.com/group/14495723" class="imgBox">
                            <img src="./guang_files/fb0035938a99e1620ff71c994a08.jpg" class="maxpic">
                            <div class="clear_f">
                            </div>
                        </a>
                        <div class="infoBox c_f">
                            <span class="addGroupFollow red_follow" groupid="14495723">加关注</span>
                            <div class="clear_f">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="groupBox">
                    <div class="groupCon">
                        <div class="gc_title">
                            <h4>
                                <a target="_blank" href="http://www.meilishuo.com/group/14459463">薇紫地平线</a></h4>
                            <p>
                                200</p>
                        </div>
                        <a target="_blank" href="http://www.meilishuo.com/group/14459463" class="imgBox">
                            <img src="./guang_files/7aee50a6c2f11a030ffa4231cc45.jpg" class="maxpic">
                            <div class="clear_f">
                            </div>
                        </a>
                        <div class="infoBox c_f">
                            <span class="addGroupFollow red_follow" groupid="14459463">加关注</span>
                            <div class="clear_f">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="groupBox">
                    <div class="groupCon">
                        <div class="gc_title">
                            <h4>
                                <a target="_blank" href="http://www.meilishuo.com/group/14232122">绿色°</a></h4>
                            <p>
                                615</p>
                        </div>
                        <a target="_blank" href="http://www.meilishuo.com/group/14232122" class="imgBox">
                            <img src="./guang_files/f8a3ec027a58a8c6545a746eb8d7.jpg" class="maxpic">
                            <div class="clear_f">
                            </div>
                        </a>
                        <div class="infoBox c_f">
                            <span class="addGroupFollow red_follow" groupid="14232122">加关注</span>
                            <div class="clear_f">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           <div class="poster_grid poster_wall pins"  style="">
          <asp:Repeater ID="rptList1" runat="server">
                <ItemTemplate>
                <div class="poster_grid poster_wall pins"  style="">
                <div class="new_poster">
                    <div class="np_pic">
                        <a class="pic_load" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">
                            <img class="goods_pic" width="200"  src="<%#Eval("Pic_Url") %>"
                                title="BiuBiu街推荐 <%#Eval("Title") %>" alt="BiuBiu街推荐 <%#Eval("Title") %>"></a>
                        <div class="like_merge">
                            <a class="hw46 right_f poster_comment" href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_comm">&nbsp;</em>评论</a> <a class="hw73 left_f poster_forward"
                                href="javascript:void(0)"><span class="plm_bgr"></span><em class="lm_shouji">&nbsp;</em>收进杂志</a>
                            <a class="hw46 left_f poster_like " href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_love">&nbsp;</em>喜欢</a>
                        </div>
                    </div>
                    <div class="comm_box none_f">
                        <p class="l18_f posterContent">
                             </p>
                        <p class="comm_num">
                            <span><b>265</b> 收进杂志</span> <span><b>1292</b> 喜欢</span> <span><b>19</b> 评论</span></p>
                    </div>
                    <div class="np_share none_f">
                        <a class="avatar32_f trans07" href="#" user_id="2207513"
                            target="_blank">
                            </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="#" target="_blank"></a>
                            <span>分享到</span><a href="#" target="_blank"></a>&nbsp;&nbsp;
                        </p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share">
                    <span><b>推荐理由：</b> </span>
                        <a class="trans07"href="Goods_<%#Eval("NumIid") %>.aspx"
                            target="_blank">
                            <%#Eval("ItemImgs")%>
                          </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank"></a><span
                                class="gray_f"></span></p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share c_f">
                        <a href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">查看全部评论...</a>
                    </div>
                    <div class="poster_cmt none_f">
                        <a class="avatar32_f" href="#" user_id="0" target="_blank">
                          
                        <div class="cmt_r">
                            <textarea class="poster_textarea"></textarea>
                            <div class="clear_f">
                            </div>
                            <p class="discuss">
                                <a class="pl_btn poster_comment_btn" href="javascript:void(0);">评论</a><a class="share_smileys">表情</a>
                            </p>
                        </div>
                        <div class="clear_f">
                        </div>
                    </div>
                </div>
            </div>
                </ItemTemplate>
                </asp:Repeater>
           </div>
           <div class="poster_grid poster_wall pins"  style="">
          <asp:Repeater ID="rptList2" runat="server">
                <ItemTemplate>
                <div class="poster_grid poster_wall pins"  style="">
                <div class="new_poster">
                    <div class="np_pic">
                        <a class="pic_load" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">
                            <img class="goods_pic" width="200"  src="<%#Eval("Pic_Url") %>"
                                title="BiuBiu街推荐 <%#Eval("Title") %>" alt="BiuBiu街推荐 <%#Eval("Title") %>"></a>
                        <div class="like_merge">
                            <a class="hw46 right_f poster_comment" href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_comm">&nbsp;</em>评论</a> <a class="hw73 left_f poster_forward"
                                href="javascript:void(0)"><span class="plm_bgr"></span><em class="lm_shouji">&nbsp;</em>收进杂志</a>
                            <a class="hw46 left_f poster_like " href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_love">&nbsp;</em>喜欢</a>
                        </div>
                    </div>
                    <div class="comm_box none_f">
                        <p class="l18_f posterContent">
                             </p>
                        <p class="comm_num">
                            <span><b>265</b> 收进杂志</span> <span><b>1292</b> 喜欢</span> <span><b>19</b> 评论</span></p>
                    </div>
                    <div class="np_share none_f">
                        <a class="avatar32_f trans07" href="#" user_id="2207513"
                            target="_blank">
                            </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="#" target="_blank"></a>
                            <span>分享到</span><a href="#" target="_blank"></a>&nbsp;&nbsp;
                        </p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share">
                    <span><b>推荐理由：</b> </span>
                        <a class="trans07"href="Goods_<%#Eval("NumIid") %>.aspx"
                            target="_blank">
                            <%#Eval("ItemImgs")%>
                          </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank"></a><span
                                class="gray_f"></span></p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share c_f">
                        <a href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">查看全部评论...</a>
                    </div>
                    <div class="poster_cmt none_f">
                        <a class="avatar32_f" href="#" user_id="0" target="_blank">
                          
                        <div class="cmt_r">
                            <textarea class="poster_textarea"></textarea>
                            <div class="clear_f">
                            </div>
                            <p class="discuss">
                                <a class="pl_btn poster_comment_btn" href="javascript:void(0);">评论</a><a class="share_smileys">表情</a>
                            </p>
                        </div>
                        <div class="clear_f">
                        </div>
                    </div>
                </div>
            </div>
                </ItemTemplate>
                </asp:Repeater>
           </div>
           <div class="poster_grid poster_wall pins"  style="">
           <asp:Repeater ID="rptList3" runat="server">
                <ItemTemplate>
                <div class="poster_grid poster_wall pins"  style="">
                <div class="new_poster">
                    <div class="np_pic">
                        <a class="pic_load" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">
                            <img class="goods_pic" width="200"  src="<%#Eval("Pic_Url") %>"
                                title="BiuBiu街推荐 <%#Eval("Title") %>" alt="BiuBiu街推荐 <%#Eval("Title") %>"></a>
                        <div class="like_merge">
                            <a class="hw46 right_f poster_comment" href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_comm">&nbsp;</em>评论</a> <a class="hw73 left_f poster_forward"
                                href="javascript:void(0)"><span class="plm_bgr"></span><em class="lm_shouji">&nbsp;</em>收进杂志</a>
                            <a class="hw46 left_f poster_like " href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_love">&nbsp;</em>喜欢</a>
                        </div>
                    </div>
                    <div class="comm_box none_f">
                        <p class="l18_f posterContent">
                             </p>
                        <p class="comm_num">
                            <span><b>265</b> 收进杂志</span> <span><b>1292</b> 喜欢</span> <span><b>19</b> 评论</span></p>
                    </div>
                    <div class="np_share none_f">
                        <a class="avatar32_f trans07" href="#" user_id="2207513"
                            target="_blank">
                            </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="#" target="_blank"></a>
                            <span>分享到</span><a href="#" target="_blank"></a>&nbsp;&nbsp;
                        </p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share">
                    <span><b>推荐理由：</b> </span>
                        <a class="trans07"href="Goods_<%#Eval("NumIid") %>.aspx"
                            target="_blank">
                            <%#Eval("ItemImgs")%>
                          </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank"></a><span
                                class="gray_f"></span></p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share c_f">
                        <a href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">查看全部评论...</a>
                    </div>
                    <div class="poster_cmt none_f">
                        <a class="avatar32_f" href="#" user_id="0" target="_blank">
                          
                        <div class="cmt_r">
                            <textarea class="poster_textarea"></textarea>
                            <div class="clear_f">
                            </div>
                            <p class="discuss">
                                <a class="pl_btn poster_comment_btn" href="javascript:void(0);">评论</a><a class="share_smileys">表情</a>
                            </p>
                        </div>
                        <div class="clear_f">
                        </div>
                    </div>
                </div>
            </div>
                </ItemTemplate>
                </asp:Repeater>
           </div>
           <div class="poster_grid poster_wall pins"  style="">
           <asp:Repeater ID="rptList4" runat="server">
                <ItemTemplate>
                <div class="poster_grid poster_wall pins"  style="">
                <div class="new_poster">
                    <div class="np_pic">
                        <a class="pic_load" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">
                            <img class="goods_pic" width="200"  src="<%#Eval("Pic_Url") %>"
                                title="BiuBiu街推荐 <%#Eval("Title") %>" alt="BiuBiu街推荐 <%#Eval("Title") %>"></a>
                        <div class="like_merge">
                            <a class="hw46 right_f poster_comment" href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_comm">&nbsp;</em>评论</a> <a class="hw73 left_f poster_forward"
                                href="javascript:void(0)"><span class="plm_bgr"></span><em class="lm_shouji">&nbsp;</em>收进杂志</a>
                            <a class="hw46 left_f poster_like " href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_love">&nbsp;</em>喜欢</a>
                        </div>
                    </div>
                    <div class="comm_box none_f">
                        <p class="l18_f posterContent">
                             </p>
                        <p class="comm_num">
                            <span><b>265</b> 收进杂志</span> <span><b>1292</b> 喜欢</span> <span><b>19</b> 评论</span></p>
                    </div>
                    <div class="np_share none_f">
                        <a class="avatar32_f trans07" href="#" user_id="2207513"
                            target="_blank">
                            </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="#" target="_blank"></a>
                            <span>分享到</span><a href="#" target="_blank"></a>&nbsp;&nbsp;
                        </p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share">
                    <span><b>推荐理由：</b> </span>
                        <a class="trans07"href="Goods_<%#Eval("NumIid") %>.aspx"
                            target="_blank">
                            <%#Eval("ItemImgs")%>
                          </a>
                        <p class="ml40_f">
                            <a class="fb_f" href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank"></a><span
                                class="gray_f"></span></p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share c_f">
                        <a href="Goods_<%#Eval("NumIid") %>.aspx" target="_blank">查看全部评论...</a>
                    </div>
                    <div class="poster_cmt none_f">
                        <a class="avatar32_f" href="#" user_id="0" target="_blank">
                          
                        <div class="cmt_r">
                            <textarea class="poster_textarea"></textarea>
                            <div class="clear_f">
                            </div>
                            <p class="discuss">
                                <a class="pl_btn poster_comment_btn" href="javascript:void(0);">评论</a><a class="share_smileys">表情</a>
                            </p>
                        </div>
                        <div class="clear_f">
                        </div>
                    </div>
                </div>
            </div>
                </ItemTemplate>
                </asp:Repeater>
           </div>
                
           
         
        </div>
        <div class="goods_banner">
            <a href="http://www.meilishuo.com/welcome" target="_blank"></a>
        </div>
        <div class="spinner botSpinner none_f" style="display: block;">
        </div>
        <div class="clear_f">
        </div>
        <div class="paging_panel">
            <div class="pageNav bgcnt">
                <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1, (int)count, pageSize, currPage, "Jie_"+"0"+"_<#page#>.aspx")%>
       
            </div>
        </div>
        <div class="ads_banner ads_bottom none_f" style="display: block;">
            <div class="boxImg">
                <ul class="_img" style="width: 100%; position: absolute; top: -100px;">
                    <li style="float: left; display: block; width: 100%; top: 400px;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/69/a3/ceefc0765b3d37d649e4eaa5a9b6_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBW85g%3Ffrm%3Dreke03&sid=14&mid=907&adid=4f998fb441a78f39577de55abd2f3df9"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/e9/31/83741c59f5e476947d258aeafd5b_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fwww.meilishuo.com%2Fwbapp%2Fhaibao%2Flancome2%3Ffrm%3Dbanner_lancome03&sid=14&mid=964&adid=4a8a04181d21f6f4b8b790c376cfb02c"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgtest-lx.meilishuo.net/img/_o/f8/9d/9f5d6939226bf892d3d75096c4f3_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBYdwS%3Ffrm%3Dfangcaoji03&sid=14&mid=1018&adid=0f0500211de5c5b03a6c8070fc5adb23"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                    <li style="float: left; display: block; width: 100%;">
                        <div style="position: relative; height: 100px; background: url(http://imgst-dl.meiliworks.com/img/_o/8e/0a/79067d8c019d8166f9b8010a2518_2000_100.jpg) center top no-repeat;">
                            <a target="_blank" href="http://www.meilishuo.com/api/jump?r=http%3A%2F%2Fmeilishuo.com%2Fu%2FEBWai0%3Ffrm%3Dhongkong03&sid=14&mid=909&adid=5bc112bc1ba13ce609cc880833723161"
                                style="top: 0; left: 0; width: 100%; height: 100px; background-position: 0 200px;
                                position: absolute; _font-size: 100px;"></a>
                        </div>
                    </li>
                </ul>
            </div>
            <div class="_num adType1">
                <a class=""><span class="none_f">1</span></a><a class="current"><span class="none_f">2</span></a><a
                    class=""><span class="none_f">3</span></a><a class=""><span class="none_f">4</span></a></div>
        </div>
    </div>

    <div class="clear_f">
    </div>
</asp:Content>

