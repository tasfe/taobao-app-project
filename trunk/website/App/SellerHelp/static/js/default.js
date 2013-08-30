$(function () {
    $('#dialog').dialog({
        title: "请选择要导出的信息",
        modal: true,
        autoOpen: false,
        width: 600,
        buttons: {
            "确认导出": function () {
                var tradeIds = "";
                $("#list .chk-item:checked").each(function () {
                    tradeIds += $(this).val() + ",";
                });

                var import_cols = "";
                $("#import .import_col:checked").each(function () {
                    import_cols += $(this).val() + ",";
                });

                var impoartFormat = $("#import .import_format:checked").val();
                var impoartRate = $("#import .import_rate:checked").val();

                var postDataTemp = "action=import&tids={0}&cols={1}&format={2}&rate={3}";
                var postData = postDataTemp.replace("{0}", tradeIds).replace("{1}", import_cols).replace("{2}", impoartFormat).replace("{3}", impoartRate)
                ShowMsg("文件正在生成中......请稍后<img src='static/images/ajax-loader.gif'/>【请不要关闭窗口】");
                postData = encodeURI(postData);

                var getImport = function () {
                    $.ajax({
                        url: "main.aspx",
                        type: "POST",
                        dataType: "json",
                        cache: false,
                        data: postData,
                        error: function (e) {
                            ShowMsg("网络中断，文件导出失败，请重试");
                        },
                        success: function (result) {
                            //alert(result.result)
                            if (result.result == "ok") {
                                ShowMsg("文件导出成功，<a href='" + result.path + "' class='download' target='_blank'>点击下载</a>");
                            } else if (result.result == "waiting") {
                                postData = postDataTemp
                                .replace("{0}", "")
                                .replace("{1}", import_cols)
                                .replace("{2}", impoartFormat)
                                .replace("{3}", impoartRate)
                                + "&taskid=" + result.msg

                                setTimeout(function () { getImport(); }, 2000);
                            }
                            else if (result.result == "error") {
                                ShowMsg(result.msg);
                            }
                            else {
                                ShowMsg("网络中断，文件导出失败，请重试");
                            }
                        }
                    })
                }
                getImport();
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

    $(".btn-all").click(function () {
        if ($("#list .chk-item:checked").length == 0) {
            ShowMsg("请至少选择一个交易记录");
        }
        else {
            $('#dialog').dialog('open');
        }
    })

    $(".btn-rateimport").click(function () {
        if ($(this).attr("isfreeuser") != "0") {
            ShowMsg("亲，免费用户不能导出哦，赶紧<a style='color:red' target='_blank' href='http://fuwu.taobao.com/ser/detail.htm?service_code=ts-13815'>点击</a>订购吧");
        }
        else if ($("#list .chk-item:checked").length == 0) {
            ShowMsg("请至少选择一个交易记录");
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

    $.datepicker.regional['zh-CN'] =
     {
         clearText: '清除', clearStatus: '清除已选日期',
         closeText: '关闭', closeStatus: '不改变当前选择',
         prevText: '&lt;上月', prevStatus: '显示上月',
         nextText: '下月&gt;', nextStatus: '显示下月',
         currentText: '今天', currentStatus: '显示本月',
         monthNames: ['一月', '二月', '三月', '四月', '五月', '六月',
         '七月', '八月', '九月', '十月', '十一月', '十二月'],
         monthNamesShort: ['一', '二', '三', '四', '五', '六',
         '七', '八', '九', '十', '十一', '十二'],
         monthStatus: '选择月份', yearStatus: '选择年份',
         weekHeader: '周', weekStatus: '年内周次',
         dayNames: ['星期日', '星期一', '星期二', '星期三', '星期四', '星期五', '星期六'],
         dayNamesShort: ['周日', '周一', '周二', '周三', '周四', '周五', '周六'],
         dayNamesMin: ['日', '一', '二', '三', '四', '五', '六'],
         dayStatus: '设置 DD 为一周起始', dateStatus: '选择 m月 d日, DD',
         dateFormat: 'yy-mm-dd', firstDay: 1,
         initStatus: '请选择日期', isRTL: false
     };

    $.datepicker.setDefaults($.datepicker.regional['zh-CN']);

    $("#search .datepicker").each(function () {
        $(this).datepicker();
    })

    $("#search .btnsearch").click(function () {
        var start = $("#search .dtstart").val();
        var end = $("#search .dtend").val();

        if (Date.parse(start.replace("-", "/")) - Date.parse(end.replace("-", "/")) >= 0) {
            ShowMsg("开始时间必须小于结束时间!");
            return false;
        }

    })

    $(".ad").show();

    $('#rate').dialog({
        title: "请输入评价的信息",
        modal: true,
        autoOpen: false,
        width: 600,
        buttons: {
            "确认评价": function () {
                var ids = "";
                $("#list .chk-item:checked").each(function () {
                    var item = $(this).parent().parent().find(".pic .orderitem");
                    ids += item.attr("tid") + "," + item.attr("oid") + "," + item.attr("et") + "|";
                });

                var result = $("#rate-result .result:checked").val();
                var content = $("#rate-result .rate-content").val()
                $.cookie('rate-content', content, { expires: 360 });
                var toids = ids.split("|");
                //alert(ids);
                var index = 0;

                var postDataTemplate = "action=rate&tid={0}&oid={1}&result={2}&content={3}&et={4}";
                var toid = "";

                ShowMsg("正在评价中......【请不要关闭窗口】<div id='rate-return'></div>");

                function RateBat() {
                    if (toids[index].length > 0) {

                        toid = toids[index].split(",");
                        var postData = postDataTemplate.replace("{0}", toid[0]).replace("{1}", toid[1])
                        .replace("{2}", result)
                        .replace("{3}", content)
                        .replace("{4}", toid[2]);

                        postData = encodeURI(postData);
                        $.ajax({
                            url: "?",
                            type: "POST",
                            dataType: "json",
                            cache: false,
                            data: postData,
                            error: function (e) {
                                ShowMsg("网络中断，评价失败，请重试");
                            },
                            success: function (result) {
                                //alert(postData);                    
                                // alert(result.result)
                                //alert($("#list .orderitem").eq(index).attr("t"))
                                if (result.result == "ok") {
                                    $("#rate-return").html($("#rate-return").html() + $("#list .orderitem").eq(index).attr("t") + "--<span class='green'>评价成功！</span><br/>");
                                    index++;
                                    RateBat();
                                }
                                else {
                                    $("#rate-return").html($("#rate-return").html() + $("#list .orderitem").eq(index).attr("t") + "--" + result.detail + "--<span class='red'>评价失败！</span><br/>");
                                    //RefreshPage();
                                }
                            }
                        })
                    }
                    else {
                        RefreshPage();
                    }
                }

                RateBat();
            }
        }
    });

    function RefreshPage() {
        setTimeout(function () {
            window.location = window.location;
        }, 3000);
    }

    $(".btn-rate").click(function () {
        if ($("#list .chk-item:checked").length == 0) {
            ShowMsg("请至少选择一个交易记录");
        }
        else {
            $('#rate').dialog('open');
        }
    })

    $("input.btn-import-3").click(function () {
        var start = $("#search .dtstart").val();
        var end = $("#search .dtend").val();
        if (start.length == 0 || end.length == 0) {
            ShowMsg("请选择要导出的交易起始时间和交易结束时间!");
            return false;
        }
        if (Date.parse(start.replace("-", "/")) - Date.parse(end.replace("-", "/")) >= 0) {
            ShowMsg("开始时间必须小于结束时间!");
            return false;
        }
        if (confirm("选择交易的时间越长，交易记录越多，导出等待的时间越长\n请在导出任务列表中及时查看任务状态，任务完成后下载导出的文件，确定继续？")) {
            return true;
        }
    })
})