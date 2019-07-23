<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="T-Shirts.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/shop.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style="margin-top:100px;">
   

    <div class="row"  >
<%--<ul class="breadcrumb" style=" background:#fff">
  <li><a href="#">Home</a></li>
  <li><a href="#">Pictures</a></li>
  <li><a href="#">Summer 15</a></li>
  <li>Italy</li>
</ul> --%>   
     <div class="col-sm-2 left-side" style="box-shadow: 2px 2px 2px 2px #ddd; width:200px">
      
     <div class="row" style="margin-left:-70px; margin-bottom:30px" >
         <ul >
           <li><a href="#" style=""><span style=" "><img src="img/icons8-back-96.png" width="17px" height="20px" /></span>Shop</a></li>
           <li><a href="#"><span style=" "><img src="img/icons8-back-96.png" width="17px" height="20px" /></span>Men's Clothing</a></li>
           <li><a href="#"><span style=" margin-left:25px; font-weight:bolder ">T-Shirts</span></a></li>
         </ul>        
      </div>

    
            <div class="row">
      <h5>Kapdawala Fashion</h5>
      <asp:CheckBox ID="chktopbrand"  runat="server" Text="Top Brands"/>
      </div>
      <div class="row">
      <h5>Price   
         <span style="margin-left:100px;"> <asp:LinkButton ID="lnkbtnclear" runat="server" 
              Text="Clear" onclick="lnkbtnclear_Click"/></span></h5>
      <ul>
       <li><asp:CheckBox ID="chkunder500" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkunder500_CheckedChanged" Text="Under &#8377;500"/></li>
       <li><asp:CheckBox ID="chk500" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chk500_CheckedChanged" Text="&#8377;500 - &#8377;800"/></li>
       <li><asp:CheckBox ID="chk800" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chk800_CheckedChanged" Text="&#8377;800 - &#8377;1200"/></li>
       <li><asp:CheckBox ID="chk1200" class="checkbox" runat="server" AutoPostBack="True" 
               oncheckedchanged="chk1200_CheckedChanged" Text="Over&#8377;1200"/></li>
      </ul> 
      </div>
      <div class="row">
      <h5>Size</h5>
      <ul>
       <li><asp:CheckBox ID="chksizel" class="checkbox" runat="server" AutoPostBack="True" 
               oncheckedchanged="chksizel_CheckedChanged" Text="L" /></li>
       <li><asp:CheckBox ID="chksizem" class="checkbox" runat="server" AutoPostBack="True" 
               oncheckedchanged="chksizem_CheckedChanged" Text="M"/></li>
       <li><asp:CheckBox ID="chksizexl" class="checkbox" runat="server" Text="XL"/></li>
       <li><asp:CheckBox ID="chksizexxl" class="checkbox" runat="server" Text="XXL"/></li>
      </ul>
      </div>
      <div class="row">
      <h5>Brands</h5>
      <ul>
       <li><asp:CheckBox ID="chkbrandpepe" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkbrandpepe_CheckedChanged" Text="Pepe Jeans"/></li>
       <li><asp:CheckBox ID="chkbrankbasics" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkbrankbasics_CheckedChanged" Text="Basics"/></li>
       <li><asp:CheckBox ID="chkbranklevis" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkbranklevis_CheckedChanged" Text="Levi's"/></li>
       <li><asp:CheckBox ID="chkbrankkiller" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkbrankkiller_CheckedChanged" Text="Killer"/></li>
       <li class="disabled"><asp:CheckBox ID="chkbrankredtape" class="checkbox" runat="server" Text="Red Tape" /></li>
       <li><asp:CheckBox ID="chkbranklee" class="checkbox" runat="server" Text="Lee"/></li>
       <li><asp:CheckBox ID="chkbrankwrangler" class="checkbox" runat="server" Text="Wrangler"/></li>
       <li><asp:CheckBox ID="chkbrankmufti" class="checkbox" runat="server" Text="Mufti"/></li>
       
      </ul>
     
      </div>
      <div class="row color">
      <h5>Colours</h5>
      <ul>
       <li><asp:CheckBox ID="chkcolorblack" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkcolorblack_CheckedChanged" /><span style=" background:#000;width:20px;height:10px;color:black;border:1px solid silver">44</span><label style="margin-left:5px"> Black</label></li>
       <li><asp:CheckBox ID="chkcolorwhite" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkcolorwhite_CheckedChanged"/><span style=" background:#fff;width:20px;height:10px; color:white;border:1px solid silver">44</span><label style="margin-left:5px">White</label></li>
       <li><asp:CheckBox ID="chkcolorred" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkcolorred_CheckedChanged"/><span style=" background:#ff0000;width:20px;height:10px; color:red;border:1px solid silver">44</span><label style="margin-left:5px">Red</label></li>
       <li><asp:CheckBox ID="chkcolorblue" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkcolorblue_CheckedChanged"/><span style=" background:#0000ff;width:20px;height:10px; color:blue;border:1px solid silver">44</span><label style="margin-left:5px">Blue</label></li>
       <li><asp:CheckBox ID="chkcoloryellow" class="checkbox" runat="server" 
               oncheckedchanged="chkcoloryellow_CheckedChanged" AutoPostBack="True" /><span style=" background:#ffff00;width:20px;height:10px; color:yellow;border:1px solid silver">44</span><label style="margin-left:5px">Yellow</label></li>
       <li><asp:CheckBox ID="chkcolorsilver" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkcolorsilver_CheckedChanged"/><span style=" background:#cccccc;width:20px;height:10px; color:#cccccc;border:1px solid silver">44</span><label style="margin-left:5px">Silver</label></li>
      </ul>
      </div>
      <div class="row">
      <h5>Discount</h5>
       <ul>
       <li><asp:CheckBox ID="chkdiscount10" class="checkbox" runat="server" 
               Text="10% Off or more" AutoPostBack="True" 
               oncheckedchanged="chkdiscount10_CheckedChanged"/></li>
       <li><asp:CheckBox ID="chkdiscount25" class="checkbox" runat="server" 
               Text="25% Off or more" AutoPostBack="True" 
               oncheckedchanged="chkdiscount25_CheckedChanged"/></li>
       <li><asp:CheckBox ID="chkdiscount35" class="checkbox" runat="server" 
               AutoPostBack="True" oncheckedchanged="chkdiscount35_CheckedChanged" Text="35% Off or more"/></li>
       <li><asp:CheckBox ID="chkdiscount50" class="checkbox" runat="server" 
               Text="50% Off or more" AutoPostBack="True" 
               oncheckedchanged="chkdiscount50_CheckedChanged"/></li>
      </ul>
      </div>
      <div class="row">
      <h5>Availability</h5>
       <ul>
       <li><asp:CheckBox ID="chkoutofstock" class="checkbox" runat="server" Text="Include Out of stock"/></li>
       </ul>
      </div>

     </div>

     <div class="col-sm-10" style=" margin:20px 0px 0px 10px">
       <div class="row">
       <div class="col-sm-12 " style="padding-right:0px;">
       <label class="sortbyddl">Sort by :</label><asp:DropDownList ID="DropDownList1"  
               class=" form-control input-group-addon" runat="server" Width="150px" 
               Height="34px" AutoPostBack="True" 
               onselectedindexchanged="DropDownList1_SelectedIndexChanged">
         <asp:ListItem Value="0">Relevance</asp:ListItem>
         <asp:ListItem Value="1">Price Low to High</asp:ListItem>
         <asp:ListItem Value="2">Price High To Low</asp:ListItem>
         <asp:ListItem Value="3">Discount</asp:ListItem>
         <asp:ListItem></asp:ListItem>
  </asp:DropDownList>
       
       </div>
       </div>
         
       <div class="row repeaterul" id="clickdiv"  style="border-top:1px solid #00000026; margin:10px 0px 0px 10px; width:1200px; height:500px;">
       <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" 
               onitemdatabound="Repeater1_ItemDataBound">
          <ItemTemplate>
                        
                 <div class="col-sm-3 " style=" margin-top:20px;box-shadow: 2px 2px 2px 2px #ddd">
                    <ul class="repeaterul" >
                               
                    <li><asp:ImageButton ID="ImageButton1" class="productimg" runat="server" ImageUrl='<%# Bind("Product_Image") %>' Height="200" Width="100" /></li>
                    <li><asp:LinkButton ID="product_name" runat="server" class="lblproductname"  Text='<%# Bind("Product_Name") %>' /></li>
                    <li><span class="lblproductbrand"> by <asp:Label ID="product_brand" runat="server" Text='<%# Bind("Product_Brand") %>'/></span></li>
                    <li><em>&#8377;<asp:LinkButton ID="product_price" class="lblproductprice" runat="server" Text='<%# Bind("Product_Price") %>'/></em> <del><asp:Label ID="lblrupeeicon" runat="server">&#8377;</asp:Label><asp:LinkButton ID="Label3" class=" lblproductname" runat="server" Text='<%# Bind("Product_Dis_Price") %>'/></del><em><asp:LinkButton ID="Label1" class="Label1"  style="margin-left:10px;"  runat="server" Text='<%# Bind("Product_Discount") %>'/>
                    <asp:Label ID ="lbloff" runat="server">&#37;Off</asp:Label></em></li>
                    </ul>
                    

                     <asp:Label ID="lbldetail" runat="server" CommandName="ViewDetail" Text='<%# Bind("Product_Id") %>' Visible="False"></asp:Label>
                    </div>
  
       </ItemTemplate> 
            </asp:Repeater>

<%--       <div class="col-sm-3"> 
       <ul>
        <li><asp:Image ID="Image2" runat="server"  Height="200" Width="200" /></li>
        <li><a href="#"><asp:Label ID="lblproductname" runat="server" Text="" Width="150px"></asp:Label></a></li>
          <li> <a href="#"><asp:Label ID="lblproductbrand" runat="server" Text=""></asp:Label></a></li>
          <li><a href="#"><em>&#8377;<asp:Label ID="lblproductrate" runat="server" Text=""/></em> <del style="margin-left:5px">&#8377;<asp:Label ID="Label6" runat="server" Text="200"/></del></a></li>
       </ul>
       </div>

<div class="col-sm-3" >
<ul>
        <li><asp:Image ID="Image3" runat="server"  Height="200" Width="200" /></li>
        <li><a href="#"><asp:Label ID="Label4" runat="server" Text="" Width="150px"></asp:Label></a></li>
          <li> <a href="#"><asp:Label ID="Label5" runat="server" Text=""></asp:Label></a></li>
          <li><a href="#"><asp:Label ID="Label7" runat="server" Text=""><em>&#8377;</em></asp:Label> <asp:Label ID="Label8" runat="server" Text=""><del>&#8377;299</del></asp:Label></a></li>
       </ul>
       
       </div>

<div class="col-sm-3" >
<ul>
        <li><asp:Image ID="Image4" runat="server"  Height="200" Width="200" /></li>
        <li><a href="#"><asp:Label ID="Label9" runat="server" Text="" Width="150px"></asp:Label></a></li>
          <li> <a href="#"><asp:Label ID="Label10" runat="server" Text=""></asp:Label></a></li>
          <li><a href="#"><asp:Label ID="Label11" runat="server" Text=""><em>&#8377;</em></asp:Label> <asp:Label ID="Label12" runat="server" Text=""><del>&#8377;299</del></asp:Label></a></li>
       </ul>
       
       </div>--%>
       <asp:Label ID="lbldatanotfound"  class="lbldatanotfound" runat="server" Text="Data not found" Visible="false"></asp:Label>
           <asp:Button ID="btndatanotfound" class="btndatanotfound" runat="server" Text="Continue" Visible="false" 
               onclick="btndatanotfound_Click" />
       </div>
             
     </div>

    
    </div>
   <!--End Slider-->                    
   <!--meddle div-->

      
   <!--End meddle div-->
   </div>
</asp:Content>

