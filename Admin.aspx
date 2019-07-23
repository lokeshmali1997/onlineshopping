<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lbllo" runat="server" Text="Label"></asp:Label>
      <div class="row" style=" margin-top:100px;    ">
       <div class="col-sm-4">
       </div>
       <div class="col-sm-4">

           <table class="nav-justified">
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Name</td>
                   <td>
                       <asp:TextBox ID="txtProductname" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Image</td>
                   <td>
                       <asp:FileUpload ID="ProductImageUpload" runat="server" />
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Price</td>
                   <td>
                       <asp:TextBox ID="txtproductprice" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product 
                       Discount Price</td>
                   <td>
                       <asp:TextBox ID="txtproductdisprice" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Size</td>
                   <td>
                       <asp:TextBox ID="txtproductsize" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Brands</td>
                   <td>
                       <asp:TextBox ID="txtproductbrand" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Colour</td>
                   <td>
                       <asp:TextBox ID="txtproductcolour" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       Product Discount</td>
                   <td>
                       <asp:TextBox ID="txtproductdiscount" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       <asp:Button ID="btninsert" runat="server" Text="Insert" 
                           onclick="btninsert_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
           </table>
       </div>
       <div class="col-sm-4">
       </div>
    
    </div>
    
</asp:Content>

