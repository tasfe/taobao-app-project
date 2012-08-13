<%@ Page Title="" Language="C#" MasterPageFile="~/app/SellerMail/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="help.aspx.cs" Inherits="SellerHelp_help_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper mainb help">
<div class="mail">有问题？联系我
<asp:TextBox ID="txtMail" runat="server" Text="留下您的邮箱" Width="120px" CssClass="email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="*" ControlToValidate="txtMail" Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator
    ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="您的邮箱格式不正确哦" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ControlToValidate="txtMail" Display="Dynamic"></asp:RegularExpressionValidator>
<asp:TextBox ID="txtContent"    runat="server" Width="498px" Text="描述下您的问题,我们会及时答复您" class="content"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="*" ControlToValidate="txtContent" Display="Dynamic"></asp:RequiredFieldValidator>
<asp:Button ID="btnSendMail"    runat="server" Text="发送" class="btnSendMail"
        onclick="btnSendMail_Click" />
        <br /><asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
</div>
<p>

  <br/>
<span class="msg-red">2011-09-18.批量评价功能上线啦，赶快<a href="../Rate.aspx">试试</a>吧 </span><br/>
 <img src="images/r11.gif" />
  <img src="images/r22.gif" />
   <img src="images/r3.gif" />
    <img src="images/r33.gif" />
    <br/>
    <span class="msg-red"> </span><br/>
    <img src="images/1.jpg" />
    <img src="images/2.jpg" />
      <img src="images/8-31.gif" />
    <img src="images/1.gif" />
   <img src="images/2.gif" />
   <img src="images/3.gif" />
   <img src="images/4.gif" />
   <img src="images/5.gif" />
   <img src="images/6.gif" />
    </p>
</div>
<script>
    $(function () {
        $(".btnSendMail").click(function () {

            if (ValidatorOnSubmit()) {
                var postData = "action=sendmail&e={1}&c={2}";
                var btn = $(this);
                $(this).attr("disabled", true).val("正在发送中...");
                postData = postData.replace("{1}", $(".email").val()).replace("{2}", $(".content").val())
                postData = encodeURI(postData);

                $.ajax({
                    url: "?",
                    type: "POST",
                    dataType: "json",
                    cache: false,
                    data: postData,
                    error: function (e) {
                        alert("网络中断，发送邮件失败，请重试");
                        $(btn).attr("disabled", false).val("发送");
                    },
                    success: function (result) {
                        if (result.result == "ok") {
                            alert("发送邮件成功，我们会尽快回复您，感谢您的支持！");
                        }
                        else {
                            alert("网络中断，发送邮件失败，请重试");
                            $(btn).attr("disabled", false).val("发送");
                        }
                    }
                })
            }

            return false;
        })
    })
</script>
</asp:Content>

