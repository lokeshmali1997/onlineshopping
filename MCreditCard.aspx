<%@ Page Title="" Language="C#" MasterPageFile="~/MakePayment.master" AutoEventWireup="true" CodeFile="MCreditCard.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
 .savecontinue{width:200px; height:45px; background:#e86109; color:#fff;font-size:18px; font-family: arial; box-shadow:2px 2px 2px 2px #eee;
          border:none; border-radius:5px; padding:10px; margin:0px 0px 0px 100px;border:1px solid silver; opacity:0.8}
.container-fluid>ul{ list-style-type:none}
.container-fluid>ul>li{  margin-top:40px}
.txtcreditnumber{ margin-left:160px; width:200px; margin-top:-30px}
.txtcreditexpirydate{ margin-left:160px;width:200px;margin-top:-30px}
.txtcreditcvvnumber{ margin-left:158px; width:60px;margin-top:-30px}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style="">
<ul class="">
 <li style=" margin-bottom:50px; border-bottom:1px solid #ddd; padding-bottom:5px">Pay Using Credit Card</li>
 <li>
    <span> <asp:Label ID="Label1" runat="server" Text="Card Number"/></span><asp:TextBox ID="txtcreditnumber" class=" form-control txtcreditnumber" runat="server"/></li>
    <li> <span><asp:Label ID="Label2" runat="server" Text="Expiry Date"/></span><asp:TextBox ID="TextBox2" class=" form-control txtcreditexpirydate" runat="server"/></li>
   <li><span><asp:Label ID="Label3" runat="server" Text="CVV"/></span><asp:TextBox ID="TextBox3" class=" form-control txtcreditcvvnumber" runat="server"/></li>
   <li><asp:Button ID="Button1" runat="server" class=" savecontinue" Text="PAY" /></li>
</ul>

</div>
</asp:Content>

