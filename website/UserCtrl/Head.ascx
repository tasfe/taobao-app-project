﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Head.ascx.cs" Inherits="UserCtrl_Head" %>
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

            <span class="ipt1">
                <input id="searchKey" class="searchKey" name="searchKey" type="text" autocomplete="off"
                    value="秋季新品" placeholder="搜宝贝、用户名、杂志..."></span>
            <input id="searchType" type="hidden" value="1" name="searchType">
            <input id="filter" type="hidden" value="goods" name="filter">
            <span class="ipt2">
                <input type="submit" id="fm_hd_btm_shbx_bttn" onclick="window.location='TSearch_'+encodeURIComponent(document.getElementById('searchKey').value)+'.aspx';return false;" value=""></span>
            
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
                        <a class="racks1 f12_f" href="TSearch_30.aspx">
                            衣服</a> <a class="racks1 f12_f" href="TSearch_34.aspx">
                                鞋子</a> <a class="racks1 f12_f" href="TSearch_316.aspx">
                                    包包</a> <a class="racks1 f12_f" href="TSearch_340.aspx">
                                        配饰</a> <a class="racks1 f12_f" href="TSearch_40.aspx">
                                            家居</a> <a class="racks1 f12_f" href="TSearch_20.aspx">
                                                美容</a> </li>
                    <li>
                         <a
                        class="racks1 f12_f" href="/">团购</a> <a class="racks1 f12_f"
                            href="/">好店</a>    </li>
                    <li>
                             <a class="racks1 f12_f"
                            href="TopSearch.aspx">BiuBiu街推荐</a>
                            <a class="racks1 f12_f" href="TSearch_%E7%A7%8B%E5%AD%A3%E6%96%B0%E5%93%81.aspx"><h3>秋季新品</h3></a>
                 
                            </li>
                </ul>
            </div>
        </div>
    </div>
    <script>
    
    </script>