<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="CustomerDetail.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<script type="text/javascript">
    function customervalidation() {

        var cpincode = document.getElementById("txtpincode").value;
        var cmobnumber = document.getElementById("txtmobnumber").value;
        var ccolony = document.getElementById("txtcolony").value;
        var caddtype = document.getElementById("rbhome").checked;
        var cname = document.getElementById("txtname").value;
        var chouse = document.getElementById("txthouse").value;
        var ccity = document.getElementById("txtcity").value;
        var cstate = document.getElementById("txtstate").value;
        var caddtype = document.getElementById("rboffice").checked;
        var numberpatten = /^[0-9]+$/;

        if (cpincode == "") {

            alert("Please Enter PinCode");
            return false;

        }
        if (cmobnumber == "") {

            alert("Please Enter PinCode");
            return false;

        }
    }

</script>


<style type="text/css">
.txtbox{outline:none; margin-top:50px; border:none; border-bottom:1px solid #ddd; width:320px; height:40px; }
.txtbox:focus{border-bottom-color:#ff9801; }
.savecontinue{width:200px; height:45px; background:#e86109; color:#fff;font-size:18px; font-family: arial; box-shadow:2px 2px 2px 2px #eee;
          border:none; border-radius:5px; padding:10px; margin:500px 0px 0px 0px;border:1px solid silver; opacity:0.8}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style="margin-top:100px;">
<asp:Label ID ="lblid" runat ="server" Visible ="false"></asp:Label>
<div class="row">
<div class="col-sm-8">
<h3 style="  color:#000;">DELIVERY ADDRESS</h3>
<div class="row">
<div class="col-sm-1"></div>
<div class="col-sm-4">
    <asp:TextBox ID="txtpincode" class="txtbox" runat="server" placeholder=" Pinciode*"/>
    <asp:TextBox ID="txtmobnumber" class="txtbox" runat="server" placeholder=" Moble Number*"/>
    <asp:TextBox ID="txtcolony" class="txtbox" runat="server" placeholder=" Colony / Street / Locality*"/> 
    <asp:TextBox ID="txtlandmark" class="txtbox" runat="server" placeholder=" Landmark(Optional)"/>
    <asp:RadioButton ID="rbhome" GroupName="selectone" style=" outline:none; margin-top:50px; color:Gray; margin-left:20px;" class="radio" runat="server" Text="Home (All day delivery)" />
    </div>
<div class="col-sm-1">
    <asp:Button ID="btncontinue" runat="server" class=" savecontinue" Text="Continue" 
        onclick="btncontinue_Click" OnClientClick="return customervalidation()" /></div>
<div class="col-sm-4">
    <asp:TextBox class="txtbox" ID="txtname" runat="server" placeholder=" Name*"/>
    <asp:TextBox ID="txthouse" class="txtbox" runat="server" placeholder=" House/Plot No*"/>
    <asp:TextBox ID="txtcity" class="txtbox" runat="server" placeholder=" City*"/>
    <asp:TextBox ID="txtstate" class="txtbox" runat="server" placeholder=" State*"/>    
    <asp:RadioButton ID="rboffice" GroupName="selectone"  style=" outline:none; margin-top:50px; color:Gray; margin-left:20px;" runat="server" Text="Office (Delivery between 10AM-5PM)"  class="radio" />
</div>
<div class="col-sm-2"></div>

</div>

</div>
<div class="col-sm-4">
</div>
</div>


</div>

</asp:Content>

