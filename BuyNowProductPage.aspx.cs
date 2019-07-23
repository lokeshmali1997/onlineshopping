using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    string productid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            productid = Request.QueryString[0];
          FillProductDetail();
        }

        if (Session["USERNAME"] != null)
        {
            KapdeWala master = (KapdeWala)Page.Master;
            Label lblusernameshow = (Label)master.FindControl("lblusernameshow");
            Label lblusernameshow2 = (Label)master.FindControl("lblusernameshow2");
            Label lblsignin = (Label)master.FindControl("lblsignin");
            LinkButton lbllogout = (LinkButton)master.FindControl("lbllogout");
            lblusernameshow.Visible = true;
            lblsignin.Visible = false;
            lbllogout.Visible = true;

            lblusernameshow.Text = "Hi" + " " + Session["USERNAME"];
            lblusernameshow2.Text = "Hi" + " " + Session["USERNAME"];


        }

       
    }

    public void FillProductDetail()
    {
        try{
        DataFuction objdf = new DataFuction();
        DataSet ds = new DataSet();

        ds = objdf.FillDsS("select * from PRODUCT_MASTER where Product_Id ='" + productid + "'");

        imgproductimg.ImageUrl = ds.Tables[0].Rows[0]["Product_Image"].ToString();
        lblproductname.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
        lblProductnamee.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
        lblproductcolour.Text = ds.Tables[0].Rows[0]["Product_Colour"].ToString();
        lblproductdisprice.Text = ds.Tables[0].Rows[0]["Product_Dis_Price"].ToString();
        lblproductdiscount.Text = ds.Tables[0].Rows[0]["Product_Discount"].ToString();
        lblproductprice.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        lblproductpricee.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        lbltotal.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        lblpay.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    { try{
        if (DropDownList1.SelectedIndex == 0)
        {
            int a = 1, mul;
            lblquantity.Text = a.ToString();
            int p = Convert.ToInt32(lblproductprice.Text);
            mul = p * a;
            lbltotal.Text = mul.ToString();
            lblpay.Text = mul.ToString();
        }
        if (DropDownList1.SelectedIndex == 1)
        {
            int b = 2,mul;
            lblquantity.Text = b.ToString();
            int p = Convert.ToInt32(lblproductpricee.Text);
            mul = p * b;

            lbltotal.Text = mul.ToString();
            lblpay.Text = mul.ToString();
        }
        if (DropDownList1.SelectedIndex == 2)
        {
            int c = 3,mul;
            lblquantity.Text = c.ToString();
            int p = Convert.ToInt32(lblproductpricee.Text);
            mul = p * c;

            lbltotal.Text = mul.ToString();
            lblpay.Text = mul.ToString();
        }
        if (DropDownList1.SelectedIndex == 3)
        {
            int d = 4,mul;
            lblquantity.Text = d.ToString();
            int p = Convert.ToInt32(lblproductpricee.Text);
            mul = p * d;

            lbltotal.Text = mul.ToString();
            lblpay.Text = mul.ToString();
        }
    }
    catch (Exception ex)
    {
        Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
    }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try{
        Response.Redirect("MCreditCard.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }
}