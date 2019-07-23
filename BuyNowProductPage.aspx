<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="BuyNowProductPage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
.col-sm-8>.col-sm-4>ul{ list-style-type:none; margin-top:30px;}
.col-sm-8>.col-sm-4>ul>li{ margin-top:5px;}
.pname{ font-family:Open Sans; font-size:15px;}
.pcolor{ font-family:Open Sans; font-size:15px;}
.pprice{ font-family:Open Sans; font-size:15px; color:Black; margin-RIGHT:10PX;}
.pdprice{ font-family:Open Sans; font-size:14px;margin-RIGHT:10PX;}
.pdis{ font-family:Open Sans; font-size:12px;margin-RIGHT:3PX; color:Black}
.pdisoff{color:Red;margin-left:2PX;}
.savecontinue{width:200px; height:45px; background:#e86109; color:#fff;font-size:18px; font-family: arial; box-shadow:2px 2px 2px 2px #eee;
          border:none; border-radius:5px; padding:10px; margin:0px 0px 0px 0px;border:1px solid silver; opacity:0.8}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container-fluid" style=" margin-top:100px">

<div class="row">
<h3 style=" color:#000; margin-bottom:80px; margin-top:50px;">REVIEW ORDER</h3>
<div class="col-sm-8" style=" box-shadow: 0px 0px 35px 10px #EEE; padding:10px;">
 
<div class="col-sm-2">
    <asp:Image ID="imgproductimg" ImageUrl='<%# Bind("Product_Image") %>' runat="server" width="90px" Height="130px" /></div>
<div class="col-sm-4">
     <ul>
      <li><asp:Label ID="lblproductname" class="pname" runat="server" Text='<%# Bind("Product_Name") %>'/></li>
      <li><label></label><asp:Label ID="lblproductcolour" class="pcolor" runat="server" Text='<%# Bind("Product_Colour") %>'/></li>
      <li><asp:Label ID="lblproductprice" class="pprice" runat="server" Text='<%# Bind("Product_Price") %>'/><span><del><asp:Label ID="lblproductdisprice" class="pdprice" runat="server" Text='<%# Bind("Product_Dis_Price") %>'/></del></span><span><asp:Label ID="lblproductdiscount" class="pdis" runat="server" Text='<%# Bind("Product_Discount") %>'/>&#37;<span class="pdisoff">Off</span></span></li>
     </ul>
    </div>
<div class="col-sm-2">
    <asp:DropDownList style=" margin-top:30px; height:30px; padding:5px 2px 5px 10px; width:50px" 
        ID="DropDownList1" runat="server" class=" dropbtnn" AutoPostBack="True" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem >1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
    </asp:DropDownList>
</div>
<div class="col-sm-4"><label class="pname" style=" margin-top:30px">Delivery in 3-4 days</label></div>


</div>
<div class="col-sm-4">
 <ul>
  <li></li>
  <li><asp:Label ID="lblProductnamee" class="pname" runat="server" Text='<%# Bind("Product_Name") %>'/></li>
  <li><asp:Label ID="Label1" class="pdis" runat="server" Text="Quantity : "/><span><asp:Label ID="lblquantity" class="pdis" runat="server" Text="1"/></span><span><asp:Label ID="lblproductpricee" class="pprice" runat="server" Text='<%# Bind("Product_Price") %>'/></span></li>
  <li><asp:Label ID="Label2" class="pname" runat="server" Text="Total : "/><span><asp:Label ID="lbltotal" class="pname" runat="server" Text=""/></span></li>
  <li><asp:Label ID="Label3" class="pname" runat="server" Text="Delivery Charges : "/><span><asp:Label ID="Label4" class="pname" runat="server" Text="Free"/></span></li>
  <li><asp:Label ID="Label5" class="pname" runat="server" Text="You Pay : "/><span><asp:Label ID="lblpay" class="pname" runat="server" Text=""/></span></li>
  <li><asp:Button ID="Button1" runat="server" class=" savecontinue" Text="Continue" 
          onclick="Button1_Click" /></li>
 </ul>
</div>


</div>

</div>

</asp:Content>

