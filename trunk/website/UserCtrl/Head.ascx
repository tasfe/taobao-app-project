<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Head.ascx.cs" Inherits="UserCtrl_Head" %>
  <div class="header_top" style="margin-bottom: 0px; width: 1200px;">
        <a class="logo_new" href="/"></a>
        <ul class="menu_leo">
            <%--<li><a href="/"><em class="i_sina">&nbsp;</em>微博登录</a></li>
            <li><a href="/"><em class="i_QQ">&nbsp;</em>
                QQ登录</a></li>
            <li><a class="red_f tunder_f" href="/">登录</a></li>
            <li style="border-right: none;"><a class="red_f tunder_f" href="/">
                注册</a></li>--%>
        </ul>
        <div class="ser_n">
            <form id="frame_header_tools_searchBox" action="/search"
            method="get">
            <span class="ipt1">
                <input id="searchKey" class="searchKey" name="searchKey" type="text" autocomplete="off"
                    value="" placeholder="搜宝贝、用户名、杂志..."></span>
            <input id="searchType" type="hidden" value="1" name="searchType">
            <input id="filter" type="hidden" value="goods" name="filter">
            <span class="ipt2">
                <input type="submit" id="fm_hd_btm_shbx_bttn" value=""></span>
            </form>
            <ul id="search_type" class="search_type none_f" style="display: none;">
                <li class="search_bg" stype="goods">搜<samp>"</samp><span class="input_words"></span><samp>"</samp>相关宝贝</li>
                <li stype="user_nickname">搜<samp>"</samp><span class="input_words"></span><samp>"</samp>相关用户</li>
                <li stype="magazine">搜<samp>"</samp><span class="input_words"></span><samp>"</samp>相关杂志</li>
            </ul>
        </div>
    </div>
    <div class="clear">
    </div>
    <div id="navbar" style="position: relative; top: 0px; height: auto; left: 0px;">
        <div class="wheader ">
            <div class="header_b">
                <span class="header_b_left"></span><span class="header_b_right"></span>
                <ul class="nav_new">
                    <li><a class="home f14_f fb_f" href="/">首页<span class="shining none_f"></span></a>
                    </li>
                    <li><a class="group f14_f fb_f" href="/">翻杂志</a>
                    </li>
                    <li><a class="racks_d f14_f fb_f" href="jie.aspx">逛Biubiu街<span class="item_right"></span></a>
                        <a class="racks1 f12_f" href="?2000000000000">
                            衣服</a> <a class="racks1 f12_f" href="?6000000000000">
                                鞋子</a> <a class="racks1 f12_f" href="?5000000000000">
                                    包包</a> <a class="racks1 f12_f" href="?7000000000000">
                                        配饰</a> <a class="racks1 f12_f" href="?9000000000000">
                                            家居</a> <a class="racks1 f12_f" href="?8000000000000">
                                                美容</a> </li>
                    <li><a class="group f14_f fb_f" href="/">搭配</a>
                        <a class="racks1 f12_f" href="/">达人</a>
                    </li>
                    <li><a class="tuangou f14_f fb_f" href="/">福利社</a> <a
                        class="racks1 f12_f" href="/">团购</a> <a class="racks1 f12_f"
                            href="/">好店</a> </li>
                </ul>
            </div>
        </div>
    </div>
