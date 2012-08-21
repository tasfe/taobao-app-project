<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportData.aspx.cs" Inherits="Manage_ImportData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Import data</title>
    <script src="../static/js/jquery-1.6.2.min.js" type="text/javascript"></script>
    <style type="text/css" >
    .c1{ color:Red;}
    .c2{ color:Yellow;}
    .c3{ color:Green;}
    #info{ height:200px; width:100%; overflow-y:scroll;overflow-x:hidden;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" id="test" value="Test"/>
    <input type="button" id="start" value="Start"/>
    <input type="button" id="cancel" value="Cancel"/>
    <input type="button" id="reset" value="Reset"/>
    <div id="info"></div>
    <ul>
        <asp:Repeater ID="rptCol" runat="server" EnableViewState="false">
        <ItemTemplate>
        <li>
            <input type="checkbox" class="<%#(Eval("code").ToString()).Length>4?"subCat":"" %>" id="cb<%#Eval("id") %>" value="<%#Eval("id") %>"/>
            <%#Eval("title") %>
            <input type="text" id="txt<%#Eval("id")%>" class="<%#Eval("parentid") %> catValue" value="<%#Eval("shortname") %>"/>
        </li>
        </ItemTemplate>
        </asp:Repeater>
    </ul>
    </div>
    <script type="text/javascript">
        $(function () {
            $("#reset").click(function () {
                $("input.catValue").each(function () {
                    $(this).attr("value", "");
                })

            });
            $("#start").click(function () {
                var timeOut = 0;
                var step = 3000;
                var cb = $(".subCat:checked"); //.attr("checked", "checked");
                var objKey;
                for (var i = cb.length - 1; i >= 0; i--) {
                    objKey = $("#txt" + $(cb[i]).attr("value"));
                    if (objKey.attr("value").length > 0) {
                        var keySplit = objKey.attr("value").split("/");
                        if (keySplit.length > 1) {
                            for (var j = 0; j < keySplit.length; j++) {
                                setTimeout(_SendRequest(keySplit[j], $(cb[i]).attr("value"), objKey.attr("class")), timeOut);
                                timeOut += step;
                            }
                        }
                        else {
                            setTimeout(_SendRequest(objKey.attr("value"), $(cb[i]).attr("value"), objKey.attr("class")), timeOut);
                            timeOut += step;
                        }
                    }
                }
            })
            function SetInfo(info) {
                $("#info").html($("#info").html() + info + "</br>");
            }

            function SendRequest(key, catId, topCatId) {
                SetInfo(Date() + " : " + "Requesting...   " + key + "</br>");
                $.ajax({
                    url: 'ImportData.aspx',
                    data: 'k=' + encodeURI(key) + '&c=' + catId + '&tc=' + topCatId,
                    cache: false,
                    beforeSend: function () {

                    },
                    success: function (data) {
                        SetInfo(data);
                        $("#info").scrollTop(100000);
                    },
                    error: function () {
                        SetInfo("<div class='c2'>Error..." + key + "</div>");
                    }
                });
            }
            function _SendRequest(key, catId, topCatId) {
                return function () { SendRequest(key, catId, topCatId) };
            }
            $("#cancel").click(function () {
                //SendRequest('玩具', '1', '1')
                window.document.location.href = "?=t" + Date();
                //window.close();
            })
            $("#test").click(function () {
                //SendRequest('玩具', '1', '1')
                //alert($("#info").scrollTop());
                $("#info").scrollTop(100000)
            })
        })
    </script>
    </form>
</body>
</html>
