$(function () {
    $('#dialog').dialog({
        title: "请选择微博模板",
        modal: true,
        autoOpen: false,
        width: 600,
        buttons: {
            "确认发送": function () {
                var checkedItem = $("#list .chk-item:checked");
                ShowMsg("<div class='send-msg'><div>");

                var bindItem = $("#dialog .bind-weibo:checked");
                var key_secret = bindItem.val();
                var key = key_secret.split("|")[0];
                var secret = key_secret.split("|")[1];
                var accesstoken = key_secret.split("|")[2];

                if (bindItem.attr("title").indexOf("腾讯") != -1) {
                    itemIndex = 0;
                    SendTx(checkedItem, key, secret,accesstoken);
                } else if (bindItem.attr("title").indexOf("新浪") != -1) {
                    itemIndex = 0;
                    SendSina(checkedItem, key, secret,accesstoken);
                }
            }
        }
    });
    $('#msg').dialog({
        title: "提示",
        modal: true,
        autoOpen: false,
        width: 400,
        maxHeight: 400
    });
    $(".btnt").each(function () {
        $(this).click(function () {
            $("#list .chk-item").attr("checked", false);
            $(this).parent().parent().children().eq(0).find("input").attr("checked", true);
            $('#dialog').dialog('open');
        })
    })
    $(".btn-all").click(function () {
        if ($("#list .chk-item:checked").length == 0) {
            ShowMsg("请至少选择一个产品推广");
        }
        else {
            $('#dialog').dialog('open');
        }
    })

    $("#list .chk-all").click(function () {
        $("#list .chk-item").attr("checked", $(this).attr("checked") ? true : false);
    })

    function ShowMsg(msg) {
        $("#msg .msg-body").html(msg);
        $('#msg').dialog('open');
    }

    var itemIndex = 0;
    function SendTx(checkedItem, key, secret,accesstoken) {
        if (itemIndex <= checkedItem.length - 1) {
            var wTemplate = $("#dialog .t:checked").val();
            if ($("#dialog .r-custom").attr("checked")) {
                wTemplate = $("#dialog .t-custom").val();
            }

            var pic = $(checkedItem[itemIndex]).parent().parent().find(".pic");
            var title = pic.attr("alt");
            var picPath = pic.attr("src");
            var link = $(checkedItem[itemIndex]).parent().parent().find(".link").attr("href");
            var price = $(checkedItem[itemIndex]).parent().parent().find(".price").text();
            wTemplate = wTemplate.replace("[标题]", title).replace("[价格]", price).replace("[链接]", link);

            $.ajax({
                url: "ajax.aspx",
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    $("#msg .send-msg").append("<div class='sending'>[" + (itemIndex + 1) + "]" + wTemplate + "正在发送中......</div>");
                },
                data: "a=2&c=" + encodeURIComponent(wTemplate) + "&p=" + encodeURIComponent(picPath) + "&k=" + key + "&s=" + secret+"&accesstoken="+accesstoken,
                success: function (result) {
                    itemIndex++;
                    if (result.msg == "ok") {
                        $("#msg .send-msg").append("<div class='msg-green'>发送到腾讯微博成功!</div>");
                        setTimeout(function () { SendTx(checkedItem, key, secret, accesstoken) }, 5000);
                    }
                    else if (result.msg == "server error") {
                        if (result.errcode == 10) {
                            $("#msg .send-msg").append("<div class='msg-red'>发送到腾讯微博失败,发送频率太快,请稍后再试!</div>")
                        }
                        else {
                            $("#msg .send-msg").append("<div class='msg-red'>发送到腾讯微博失败!</div>")
                        }
                    }
                    else if (result.msg == "no") {
                        $("#msg .send-msg").append("<div class='msg-red'>" + result.detail + "</div>")
                    }
                    else {
                        $("#msg .send-msg").append("<div class='msg-red'>发送到腾讯微博失败!</div>")
                    }
                }
            })
        }
    }

    function SendSina(checkedItem, key, secret,accesstoken) {
        if (itemIndex <= checkedItem.length - 1) {
            var wTemplate = $("#dialog .t:checked").val();
            if ($("#dialog .r-custom").attr("checked")) {
                wTemplate = $("#dialog .t-custom").val();
            }

            var pic = $(checkedItem[itemIndex]).parent().parent().find(".pic");
            var title = pic.attr("alt");
            var picPath = pic.attr("src");
            var link = $(checkedItem[itemIndex]).parent().parent().find(".link").attr("href");
            var price = $(checkedItem[itemIndex]).parent().parent().find(".price").text();
            wTemplate = wTemplate.replace("[标题]", title).replace("[价格]", price).replace("[链接]", link);

            $.ajax({
                url: "ajax.aspx",
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    $("#msg .send-msg").append("<div class='sending'>[" + (itemIndex + 1) + "]" + wTemplate + "正在发送中......</div>");
                },
                data: "a=3&c=" + encodeURIComponent(wTemplate) + "&p=" + encodeURIComponent(picPath) + "&k=" + key + "&s=" + secret+"&accesstoken="+accesstoken,
                success: function (result) {
                    //alert(result.msg)
                    itemIndex++;
                    var retID = 0;
                    try {
                        retID = result.id ; 
                    }
                    catch (e) {
                        retID = 0;
						$("#msg .send-msg").append("<div class='msg-green'>新浪微博服务器正忙，请等待30到60分钟后再试!</div>");
                    }
		            if (retID&&retID > 0) {
                        $("#msg .send-msg").append("<div class='msg-green'>发送到新浪微博成功!</div>");

                        setTimeout(function () { SendSina(checkedItem, key, secret,accesstoken) }, 5000);
                    }
                    else {
                        //eval("var errorJson=" + result);
                        if (result.msg == "no") {
                            $("#msg .send-msg").append("<div class='msg-red'>" + result.detail + "</div>")
                        }
                    }
                }
            })
        }
    }

    $("#save-template").click(function () {
        var template = $("#dialog .t-custom").val();
        $.ajax({
            url: "ajax.aspx",
            dataType: "json",
            cache: false,
            data: "a=4&t=" + encodeURIComponent(template),
            success: function (result) {
                if (result.msg == "ok") {
                    ShowMsg("保存成功");
                    var t = $("#dialog .cus-t-null").clone(true).css("display", "block").removeClass("cus-t-null").addClass("cus-t");
                    $("input", t).val(template);
                    $("span", t).text(template);
                    $("a", t).attr("title", result.id).click(function () {
                        DelTemplate($(this));
                    });
                    //alert(t.html())
                    $(t).insertAfter("#dialog #save-t");
                }
                else if (result.msg == "no") {
                    ShowMsg(result.detail);
                }
                else {
                    ShowMsg("保存失败，请确认您是付费用户");
                }
            }
        })
    })

    function DelTemplate(obj) {
        if (confirm("确认删除？")) {

            $.ajax({
                url: "ajax.aspx",
                dataType: "json",
                data: "a=5&tid=" + $(obj).attr("title"),
                success: function (result) {
                    if (result.msg == "ok") {
                        ShowMsg("删除成功");

                        $(obj).parent().remove();
                    }
                    else {
                        ShowMsg("删除失败，请重试");
                    }
                }
            })
        }
    }
    $("#dialog .del-t").click(function () {
        DelTemplate($(this));
    })

    $('#add_weibo_dialog').dialog({
        title: "添加微博帐号",
        modal: true,
        autoOpen: false,
        width: 400
    });

    $("#add_weibo").click(function () {
        $('#add_weibo_dialog').dialog('open');
    })

    $("a.link-accessweibo").each(function () {
        $(this).click(function () {
            if (confirm("确认次操作吗?")) {
                return true;
            }
            else {
                return false;
            }
        })
    })

    $("#upgrade .usertypea").mouseover(function () {
        $("#upgrade .usertype").css("display", "block");
    }).mouseout(function () {
        $("#upgrade .usertype").css("display", "none");
    })

    $(".ad").show();
})