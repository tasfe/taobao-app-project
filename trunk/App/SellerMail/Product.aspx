<%@ Page Title="" Language="C#" MasterPageFile="~/app/SellerMail/MasterPage/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="pages_Default" %>
<%@ Register Assembly="JCmsLibs.FCKeditorV2" Namespace="JCmsLibs.FCKeditorV2" TagPrefix="FCKeditorV2" %>
  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper mainb main">
    <div class="left">
    <div class="category add_weibo">
  
    <br />
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div class="category msg-red">
    </div>
    <div class="category">
     
   
    </div>

     <div class="category tip">
     <div>
     </div>
    </div>
    </div>
    <div class="right">
    <div class="listpage">
    <h2 class="hbline hbline1"><strong>第二部：选择要推广宝贝</strong></h2>
        <ul id="list">
        <li class="first-item" style=" "><input  type="checkbox" class="chk-all" />全选 <input type='button' value='生成推广邮件预览' onclick="GenFCK()" class=''/></li>
           
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li class="mailitem">
                <div class="fl">
                <input  type="checkbox" class="chk-item"/> <%#Container.ItemIndex+1%>. </div>
                <div class="fl pic"><img class="img" src="<%#Eval("PicUrl") %>" alt="<%#Eval("title") %>"/></div>
                <div class="fl item-t"><a class="link" href="http://item.taobao.com/item.htm?id=<%#Eval("numiid") %>" target="_blank"><%#Eval("title") %></a> ￥<span class="price"><%#Eval("price") %></span><br/>
              </div>
                </li>
            </ItemTemplate>
            </asp:Repeater>
        </ul>
        <div id="pager">
        <%=ShopUtil.HtmlPager.GetPageBar(3, "html", 1,(int) count, 10, currPage, "?tids="+GetQueryString("tids")+"&p=<#page#>")%>
        </div>
    </div>

        </div>
</div>
 <div id="msg"><div class="msg-body"></div></div>
   
 <div id="editer">
 <div>老客户邮箱列表：请勿改变邮箱地址的格式，如需手动添加，请按照【"昵称"&lt;xxx@xxx.com&gt;;】格式添加
 <asp:TextBox Width="650px" TextMode="MultiLine" Height="50px" ID="txtMail" CssClass="txtmail" Text="正在获取客户邮箱信息，请稍候..." runat="server"></asp:TextBox>
 </div>
<div>邮件主题：<asp:TextBox ID="txtSubject" Text="小店又上新货了，老客户88折优惠哦,欢迎光临" runat="server" CssClass="txtsubject"
         Width="650px"></asp:TextBox></div>
 <div>邮件内容：
 <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" 
         ToolbarSet="Jumbot" Height="300px" Width="100%" 
         BasePath="~/SellerMail//fckeditor/">
     </FCKeditorV2:FCKeditor></div>


     <input  type="hidden"  name="fckhtml" id="fckhtml"/>

     <div>
         <asp:Button ID="btnSendMail" runat="server" Text="发送邮件" OnClientClick="SetFCKHtml();" />
      
</div>
 </div> 
 <script type="text/javascript">
  function getEditorContents()
  {
    var oEditor = FCKeditorAPI.GetInstance("<%=FCKeditor1.ClientID %>");
    return oEditor.GetXHTML(true);
  }

  function SetFCKHtml()
  {
         var qqNO= $("#editer .qqno").val();
         var qqPwd= $("#editer .qqpwd").val();

         SendMail("");

        /*$.ajax({
             url: "?action=loginqq&qq="+qqNO+"&pwd="+qqPwd,
             type: "get",
             dataType: "json",
             cache: false,
             beforeSend:function(){
                ShowMsg("正在登录QQ邮箱...<br/>")
             },
             error: function (e) {
                 alert("网络中断，登录QQ邮箱出错，请刷新重试。");
             },
             success: function (data) {     
                 if(data.result=="yes")
                 {      
                     //alert(data.info);
                     ShowMsg("登录邮箱成功，准备发送邮件...<br/>")
                     SendMail(data.info);
                 }
                 else if(data.result=="fail")
                 {
                     ShowMsg("登录邮箱失败，请检查QQ号码和密码是否正确，邮箱功能是否开通...<br/>")
                 }
                 else
                 {
                    alert("网络中断，登录QQ邮箱出错，请刷新重试。");
                 }
            }
        })*/

    //document.getElementById("fckhtml").value= getEditorContents();
    //return false;
  }
   $('#msg').dialog({
        title: "提示",
        modal: true,
        autoOpen: false,
        width: 400,
        maxHeight: 400
    });
    function ShowMsg(msg) {
        $("#msg .msg-body").html( $("#msg .msg-body").html()+msg);
        $('#msg').dialog('open');
    }
  function SendMail(cookie)
  {
        var postData="action=sendmail&cookie="+cookie+"&to="+ encodeURIComponent( $(".txtmail").val())+"&subject="+ encodeURIComponent($(".txtsubject").val())+"&content="+ encodeURIComponent(getEditorContents());
     $.ajax({
             url: "?",
             type: "post",
             dataType: "json",
             cache: false,
             beforeSend:function(){
                ShowMsg("正在发送...<br/>");
             },
             data:postData,
             error: function (e) {
                 alert("网络中断，发送邮件出错，请刷新重试。");
             },
             success: function (data) {     
                 if(data.result=="yes")
                 {      
                     //alert(data.info);
                     ShowMsg("发送邮件成功！<br/>")
                 }
                 else
                 {
                    alert("网络中断，发送邮件出错，请刷新重试。");
                 }
            }
        })
  }

//向编辑器插入指定代码
function insertHTMLToEditor(codeStr)
{
   var oEditor = FCKeditorAPI.GetInstance("<%=FCKeditor1.ClientID %>");
   if (oEditor.EditMode==FCK_EDITMODE_WYSIWYG){
     oEditor.InsertHtml(codeStr);
   }else{
     return false;
   }
}

function GenFCK()
{
        if ($("#list .chk-item:checked").length == 0) {
            alert("请至少选择一个宝贝来生成邮件");
        }
        else{
            $("#editer").dialog("open");

            $("#editer").parent().appendTo($("form:first")); 

                var itemList="";
                var itemTemplate="<div style='clear:both;'><a href=\"{3}\" target=\"_blank\"><img style=\"height:100px;width:100px;\" src=\"{0}\"/> ￥{1}{2}</a><br/></div>";
                $(".mailitem").each(function(){
                if($(this).find(".chk-item:checked").length>0)
                {
                    itemList+=itemTemplate.replace("{0}",$(this).find(".img").attr("src"))
                    .replace("{1}",$(this).find(".price").html())
                    .replace("{2}",$(this).find(".link").html())
                    .replace("{3}",$(this).find(".link").attr("href"))
                }
            })
            insertHTMLToEditor(getEditorContents()+itemList);
        }
}

     $(function () {
      $("#editer .rdoqq").live("click",function(){
        var qqinfo=$(this).val();
        $("#editer .qqno").val(qqinfo.split("|")[0]);
        $("#editer .qqpwd").val(qqinfo.split("|")[1]);
      })

       $("#editer .delqq").click(function(){
            var qqId=$(this).attr("qqid");
            var qqItem=$(this);

            if(confirm("确认删除？"))
            {
                  $.ajax({
             url: "?action=delqq&qqid="+qqId,
             type: "get",
             dataType: "json",
             cache: false,
             error: function (e) {
                 alert("网络中断，删除QQ信息出错，请刷新重试。");
             },
             success: function (data) {     
                 if(data.result=="yes")
                 {      
                     $(qqItem).parent().remove();
                 }
                 else
                 {
                    alert("删除QQ信息出错，请重试。");
                 }
            }
         })
            }
       })

      $("#saveQQ").click(function(){
         var qqNO= $("#editer .qqno").val();
         var qqPwd= $("#editer .qqpwd").val();
       
        $.ajax({
             url: "?action=addqq&qq="+qqNO+"&pwd="+qqPwd,
             type: "get",
             dataType: "json",
             cache: false,
             error: function (e) {
                 alert("网络中断，保存QQ信息出错，请刷新重试。");
             },
             success: function (data) {     
                 if(data.result=="yes")
                 {          
                    $("#qqlist").append("<div><input type='radio' class='rdoqq' name='qq' value='"+qqNO+"|"+qqPwd+"' />"+qqNO+"</div>");
                 }
                 else
                 {
                    alert("保存QQ信息出错，请刷新重试。");
                 }
             }
         })
      })

     $("#editer").dialog({
                    title: "生成邮件预览",
                    modal: true,
                    autoOpen: false,
                    width: 700
                    })
         $.ajax({
             url: "Main.aspx?action=import&tids=<%=GetQueryString("tids") %>",
             type: "get",
             dataType: "json",
             cache: false,
             error: function (e) {
                 alert("网络中断，获取邮箱信息出错，请刷新页面重试。");
             },
             success: function (result) {     
                 var mailTemplat="{1};";
                 var mailList="";
                 for(var i=0;i< result.result.length;i++)
                 {
                    mailList+=mailTemplat.replace("{0}",result.result[i].nick).replace("{1}",result.result[i].email);
                 }      
                 // $("#maillist").html(mailList) ;
                  $(".txtmail").val(mailList)  
                 //alert(result.result)
             }
         })
     })
 </script>
</asp:Content>