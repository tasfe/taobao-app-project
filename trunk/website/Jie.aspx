﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Jie.aspx.cs" Inherits="Jie" %>

<%@ Register src="UserCtrl/HotSearch.ascx" tagname="HotSearch" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="static/css/page_guang.css" rel="stylesheet" type="text/css" />
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
            <div class="poster_grid poster_wall pins" twitter_id="365824987" twitter_author_uid="2207513"
                twitter_source_tid="0" twitter_show_type="7" like_twitter_id="365824987" style="position: absolute;
                top: 0px; left: 240px;">
                <div class="new_poster">
                    <div class="np_pic">
                        <a class="pic_load" href="http://www.meilishuo.com/share/365824987?wzz=p0r0c0" target="_blank">
                            <img class="goods_pic" width="200" height="300" src="./guang_files/77498f6b41c030efdc5a83e3355e_500_750.jpeg"
                                title="美丽说推荐 小清新系列 白色激光瞳孔镂空手柄编织女包大包包单肩" alt="美丽说推荐 小清新系列 白色激光瞳孔镂空手柄编织女包大包包单肩"></a>
                        <div class="like_merge">
                            <a class="hw46 right_f poster_comment" href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_comm">&nbsp;</em>评论</a> <a class="hw73 left_f poster_forward"
                                href="javascript:void(0)"><span class="plm_bgr"></span><em class="lm_shouji">&nbsp;</em>收进杂志</a>
                            <a class="hw46 left_f poster_like " href="javascript:void(0)"><span class="plm_bgr">
                            </span><em class="lm_love">&nbsp;</em>喜欢</a>
                        </div>
                    </div>
                    <div class="comm_box">
                        <p class="l18_f posterContent">
                            不错的一款白色大包包，款式超大方呢，很有气质的款式，编织的包带非常好看，美啊</p>
                        <p class="comm_num">
                            <span><b>265</b> 收进杂志</span> <span><b>1292</b> 喜欢</span> <span><b>19</b> 评论</span></p>
                    </div>
                    <div class="np_share">
                        <a class="avatar32_f trans07" href="http://www.meilishuo.com/person/u/2207513" user_id="2207513"
                            target="_blank">
                            <img src="./guang_files/8efa579f69ce8ba015f2c9f3014e_500_500.jpg"></a>
                        <p class="ml40_f">
                            <a class="fb_f" href="http://www.meilishuo.com/person/u/2207513" target="_blank">百利滋</a>
                            <span>分享到</span><a href="http://www.meilishuo.com/group/15087582" target="_blank">#♣包♣大人#</a>&nbsp;&nbsp;
                        </p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share">
                        <a class="avatar32_f trans07" user_id="19022539" href="http://www.meilishuo.com/person/u/19022539"
                            target="_blank">
                            <img src="./guang_files/ff7f3898027343ec9603c97e9764_193_193.jpg"></a>
                        <p class="ml40_f">
                            <a class="fb_f" href="http://www.meilishuo.com/person/u/19022539" target="_blank">最后之舞_qq917</a><span
                                class="gray_f">蛮好看的</span></p>
                        <div class="clear_f">
                        </div>
                    </div>
                    <div class="comm_share c_f">
                        <a href="http://www.meilishuo.com/share/365824987" target="_blank">查看全部19条评论...</a>
                    </div>
                    <div class="poster_cmt none_f">
                        <a class="avatar32_f" href="http://www.meilishuo.com/person/u/0" user_id="0" target="_blank">
                            <img src="./guang_files/0.gif"></a>
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
         
        </div>
        <div class="goods_banner">
            <a href="http://www.meilishuo.com/welcome" target="_blank"></a>
        </div>
        <div class="spinner botSpinner none_f" style="display: block;">
        </div>
        <div class="clear_f">
        </div>
        <div class="paging_panel c_f none_f">
            <div class="pageNav bgcnt">
                <a class="currentpage" href="http://www.meilishuo.com/guang?page=0">1</a> <a href="http://www.meilishuo.com/guang?page=1">
                    2</a> <a href="http://www.meilishuo.com/guang?page=2">3</a> <a href="http://www.meilishuo.com/guang?page=3">
                        4</a> <a href="http://www.meilishuo.com/guang?page=4">5</a> <a href="http://www.meilishuo.com/guang?page=5">
                            6</a> <a href="http://www.meilishuo.com/guang?page=6">7</a> <a href="http://www.meilishuo.com/guang?page=7">
                                8</a> <a href="http://www.meilishuo.com/guang?page=8">9</a> <a href="http://www.meilishuo.com/guang?page=9">
                                    10</a> <i>...</i> <a href="http://www.meilishuo.com/guang?page=144">145</a>
                <a class="pageNext" href="http://www.meilishuo.com/guang?page=1">下一页&gt;</a> <a style="background: none;
                    border: none; height: 58px; width: 55px; position: absolute; right: 0; top: 0;"
                    href="http://www.meilishuo.com/guang?page=1"></a>
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

