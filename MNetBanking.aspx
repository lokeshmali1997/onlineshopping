<%@ Page Title="" Language="C#" MasterPageFile="~/MakePayment.master" AutoEventWireup="true" CodeFile="MNetBanking.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
 .savecontinue{width:200px; height:45px; background:#e86109; color:#fff;font-size:18px; font-family: arial; box-shadow:2px 2px 2px 2px #eee;
          border:none; border-radius:5px; padding:10px; margin:0px 0px 0px 100px;border:1px solid silver; opacity:0.8}
.container-fluid>ul{ list-style-type:none}
.container-fluid>ul>li{  margin-top:40px}
.drop{ margin-left:100px; width:200px; margin-top:-30px}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style="">
<ul class="">
 <li style=" margin-bottom:50px; border-bottom:1px solid #ddd; padding-bottom:5px">Pay Using Net Banking</li>
 <li><span>
     <asp:Label ID="Label1" runat="server" Text="Select Bank"/></span>
     <asp:DropDownList ID="DropDownList1" runat="server" class=" form-control drop">
      <asp:ListItem>------select-----Bank------</asp:ListItem>
     </asp:DropDownList>
 </li>
   <li><asp:Button ID="Button1" runat="server" class=" savecontinue" Text="PAY" /></li>
</ul>

</div>
</asp:Content>

