<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="ViewProduct.aspx.cs" Inherits="_Default"  %>
<%@ MasterType VirtualPath="~/KapdeWala.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/product_detail.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container-fluid" style="margin-top:150px;">
<asp:Label ID ="lblid" runat ="server" Visible ="false"></asp:Label>


 <div class="row ">



  <div class="col-sm-5">
  <ul>
   <li>
       <asp:Image ID="imgproductimg" class="imgproductimg" runat="server"  Width="250px" Height="400px" />
   </li>
   <li><span><asp:Button ID="btnaddtocart" class="btnaddtocart" runat="server" 
           Text="ADD TO CART" onclick="btnaddtocart_Click" /></span><span>
       <asp:Button ID="btnbuynow" class="btnbuynow" runat="server" Text="BUY NOW" 
           onclick="btnbuynow_Click" /></span></li>
  </ul>
  
  </div>    
  <div class="col-sm-7">
        <ul>
      <li><asp:Label ID="lblproductname" class="lblli" runat="server" Text="Label"/></li>
      <li><del>Rs.<asp:Label ID="lblproductdisprice" runat="server" Text="Label" style=""/></del><span class="spandic">(<asp:Label ID="lblproductdiscount" runat="server" Text="Label"/>&#37;OFF)</span></li>
      <li><span style="font-size:17px">Rs. </span><asp:Label ID="lblproductprice" runat="server" Text="Label"/></li>
      <li class=" divider"><span class=" lblli1">Including tax may apply; charged at checkout</span></li>
      <li  style="border-bottom:1px dotted #ddd; margin-top:20px"></li>
      <li><h4 class="selectsize">Select Size</h4></li>
     <li style="margin-top:20px;"><a   class="size" href="#" >L</a><a class="size3" href="#">M</a><a class="size2"  href="#">XL</a><a class="size1"  href="#">XLL</a></span></li>
     <li style=" margin-top:80px; font-weight:bold">Check Delivery Options</li>
     <li > <h5 style="color:silver; font-size:16px; font-family: Arial">
        Tax: Applicable tax on the basis of exact location & discount will be </br> charged 
        at the time of checkout100% Original Products</h5>
        <h5 style="color:silver; font-size:16px; font-family: Arial" >
        Free Delivery on order above Rs. 49
        </h5>
        <h5 style="color:silver; font-size:16px; font-family: Arial">
        Cash on delivery might be available
        </h5>
        <h5 style="color:silver; font-size:16px; font-family: Arial">
        Easy 30 days returns & 30 days exchanges
        </h5>
        <h5 style="color:silver; font-size:16px; font-family: Arial">
        Try & Buy might be available</h5></li>   
    </ul>
  </div>
  </div>

  </div>
</asp:Content>

