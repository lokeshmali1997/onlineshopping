<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
    .row>.col-sm-6>ul{ list-style-type:none}
    .row>.col-sm-6>ul>li{ margin-top:30px}
    .btnlogin{width:200px; height:45px; background:#e86109; color:#212121;font-size:14px; font-family: arial; box-shadow:2px 2px 2px 2px #eee;border:none; border-radius:5px; margin:-10px 0px 20px 100px;border:1px solid silver; opacity:0.8}
.txtname{ margin-left:100px; margin-top:-30px}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style=" margin-top:100px;">
<div class="row">
<div class="col-sm-12">
<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d274050.13447751926!2d73.06859780357257!3d25.16404000475043!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3942ecb539703b3f%3A0x2dae06e0f7ff7f6e!2sSumerpur%2C+Rajasthan!5e0!3m2!1sen!2sin!4v1517810749328" width="1450" height="400" frameborder="0" style="border:0" allowfullscreen></iframe>
</div>
</div>
<div class=" row" style=" margin-top:50px">
<div class="col-sm-6">
<ul>
<li>
   <span><asp:Label ID="Label1" runat="server" Text="Name : "/></span><asp:TextBox ID="txtcontactname" class=" txtname form-control" runat="server" Width="400px"></asp:TextBox></li>
<li>
   <span><asp:Label ID="Label2" runat="server" Text="Email : "/></span><asp:TextBox ID="TextBox1" class=" txtname form-control" runat="server" Width="400px"></asp:TextBox></li>
   <li>
   <span><asp:Label ID="Label3" runat="server" Text="Message : "/></span><asp:TextBox ID="TextBox2" class=" form-control txtname " runat="server" Rows="5" Columns="50" TextMode="MultiLine" Width="400px"></asp:TextBox></li>
   <li><asp:Button ID="btnsignup" class="btnlogin" runat="server" Text="SEND"/></li>
</ul>
</div>
<div class="col-sm-6"></div>
</div>
</div>
</asp:Content>

