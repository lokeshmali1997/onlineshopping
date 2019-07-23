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
    Label discount;
    DataSet CompleteProductds;

    DataFuction objdf = new DataFuction();
    DataTable dt0 = new DataTable();
    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();
    DataTable dt4 = new DataTable();
    DataTable dt5 = new DataTable();
    DataTable dt6 = new DataTable();
    DataTable dt7 = new DataTable();
    DataTable dt8 = new DataTable();
    DataTable dt9 = new DataTable();
    DataTable dt10 = new DataTable();
    DataTable dt11 = new DataTable();
    DataTable dt12 = new DataTable();
    DataTable dt13 = new DataTable();
    DataTable dt14 = new DataTable();
    DataTable dt15 = new DataTable();
    DataTable dt16 = new DataTable();
    DataTable dt17 = new DataTable();
    DataTable dt18 = new DataTable();
    DataTable dt19 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblsearch.Text = Request.QueryString[0].ToString();
        }
        //else
        //{

        //    Response.Redirect("IndexPage.aspx");
        //}

        Product_Detail();
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

    public void Product_Detail()
    {
        try{

        DataFuction objdf = new DataFuction();

        CompleteProductds = objdf.FillDsS("select * from PRODUCT_MASTER where Product_Name ='" + lblsearch.Text.ToString() + "'");

        Repeater1.DataSource = CompleteProductds;
        Repeater1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }



    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try{

        Label id = e.Item.FindControl("lbldetail") as Label;
        
        discount = e.Item.FindControl("Label1") as Label;


        int pid = Convert.ToInt32(id.Text);

        Response.Redirect("ViewProduct.aspx?productid = " + pid);

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }

    }

    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try{
        if (!IsPostBack)
        {
            LinkButton disper = e.Item.FindControl("Label1") as LinkButton;
            LinkButton disprice = e.Item.FindControl("Label3") as LinkButton;
            Label lbloff = e.Item.FindControl("lbloff") as Label;
            Label rupeeicon = e.Item.FindControl("lblrupeeicon") as Label;

            foreach (DataTable dt in CompleteProductds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int discountvalue = Convert.ToInt32(dr["Product_Discount"]);
                    int productdisprice = Convert.ToInt32(dr["Product_Dis_Price"]);
                    //  int discountvalue =     Convert.ToInt32(  ds.Tables[0].Rows[0]["Product_Discount"]);

                    if (discountvalue == 0 && productdisprice == 0)
                    {

                        lbloff.Visible = false;
                        disper.Visible = false;
                        disprice.Visible = false;
                        rupeeicon.Visible = false;

                    }


                }

            }
        }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void chkunder500_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkunder500.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();

                chk500.Checked = false;
                chk800.Checked = false;
                chk1200.Checked = false;
            }
            if (chkunder500.Checked && chksizel.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Size='l'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chksizem.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Size='m'");
                Repeater1.DataSource = dt1;

                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkbrandpepe.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='pepe jeans'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkbrankbasics.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='basics'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkbranklevis.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='levis'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkbrankkiller.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='killer'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcolorblack.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='black'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcolorwhite.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='white'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcolorred.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='red'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcolorblue.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='blue'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcoloryellow.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='yellow'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkcolorsilver.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='silver'");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkdiscount10.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 10 and 25");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkdiscount25.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 25 and 35");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkdiscount35.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 35 and 50");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chkunder500.Checked && chkdiscount50.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 50 and 100");
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chk500_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chk500.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();

                chkunder500.Checked = false;
                chk1200.Checked = false;
                chk800.Checked = false;
            }
            if (chk500.Checked && chksizel.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Size='l'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chksizem.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Size='m'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrandpepe.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='pepe jeans'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrankbasics.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='basics'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbranklevis.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='levis'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrankkiller.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='killer'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }

            if (chk500.Checked && chkcolorblack.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='black'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorwhite.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='white'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorred.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='red'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorblue.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='blue'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcoloryellow.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='yellow'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorsilver.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='silver'");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount10.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 10 and 25");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount25.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 25 and 35");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount35.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 35 and 50");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount50.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 50 and 100");
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chk800_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chk800.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();

                chkunder500.Checked = false;
                chk500.Checked = false;
                chk1200.Checked = false;
            }
            if (chk800.Checked && chksizel.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Size='l'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chksizem.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Size='m'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrandpepe.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='pepe jeans'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrankbasics.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='basics'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbranklevis.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='levis'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrankkiller.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='killer'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorblack.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='black'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorwhite.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='white'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorred.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='red'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorblue.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='blue'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcoloryellow.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='yellow'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorsilver.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='silver'");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount10.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 10 and 25");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount25.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 25 and 35");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount35.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 35 and 50");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount50.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 50 and 100");
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chk1200_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chk1200.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();

                chkunder500.Checked = false;
                chk500.Checked = false;
                chk800.Checked = false;
            }
            if (chk1200.Checked && chksizel.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Size='l'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chksizem.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Size='m'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrandpepe.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='pepe jeans'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrankbasics.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='basics'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbranklevis.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='levis'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrankkiller.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='killer'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorblack.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='black'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorwhite.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='white'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorred.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='red'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorblue.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='blue'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcoloryellow.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='yellow'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorsilver.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='silver'");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount10.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 10 and 25");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount25.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 25 and 35");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount35.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 35 and 50");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount50.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 50 and 100");
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void chksizel_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chksizel.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Size='l'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();
                chksizem.Checked = false;
            }
            if (chkunder500.Checked && chksizel.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Size='l'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizel.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chksizel.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Size='l'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizel.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chksizel.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Size='l'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizel.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chksizel.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Size='l'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizel.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chksizem_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chksizem.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Size='m'");

                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chksizel.Checked = false;
            }

            if (chkunder500.Checked && chksizem.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Size='m'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizem.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();

            }
            if (chk500.Checked && chksizem.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Size='m'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizem.Checked = false;
                    chk500.Checked = false;
                    return;
                }

                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chksizem.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Size='m'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizem.Checked = false;
                    chk800.Checked = false;
                    return;
                }

                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chksizem.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Size='m'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chksizem.Checked = false;
                    chk1200.Checked = false;

                    return;

                }

                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkbrandpepe_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chkbrandpepe.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Brand='pepe jeans' ");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkbrankbasics.Checked = false;
                chkbrankkiller.Checked = false;
                chkbranklevis.Checked = false;
            }

            if (chkunder500.Checked && chkbrandpepe.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='pepe jeans'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrandpepe.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrandpepe.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='pepe jeans'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrandpepe.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrandpepe.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='pepe jeans'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrandpepe.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrandpepe.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='pepe jeans'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrandpepe.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkbrankbasics_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chkbrankbasics.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Brand='basics' ");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkbrandpepe.Checked = false;
                chkbrankkiller.Checked = false;
                chkbranklevis.Checked = false;
            }
            if (chkunder500.Checked && chkbrankbasics.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='basics'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankbasics.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrankbasics.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='basics'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankbasics.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrankbasics.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='basics'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankbasics.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrankbasics.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='basics'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankbasics.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkbranklevis_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chkbranklevis.Checked)
            {

                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Brand='levis'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkbrankbasics.Checked = false;
                chkbrankkiller.Checked = false;
                chkbrandpepe.Checked = false;
            }
            if (chkunder500.Checked && chkbranklevis.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='levis'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbranklevis.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbranklevis.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='levis'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbranklevis.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbranklevis.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='levis'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbranklevis.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbranklevis.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='levis'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbranklevis.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkbrankkiller_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            if (chkbrankkiller.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Brand='killer'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkbrankbasics.Checked = false;
                chkbrandpepe.Checked = false;
                chkbranklevis.Checked = false;
            }
            if (chkunder500.Checked && chkbrankkiller.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Brand='killer'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankkiller.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkbrankkiller.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Brand='killer'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankkiller.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkbrankkiller.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Brand='killer'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankkiller.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkbrankkiller.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Brand='killer'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkbrankkiller.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcolorblack_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcolorblack.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='black'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();
                chkcolorwhite.Checked = false;
                chkcolorred.Checked = false;
                chkcolorblue.Checked = false;
                chkcoloryellow.Checked = false;
                chkcolorsilver.Checked = false;

            }
            if (chkunder500.Checked && chkcolorblack.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='black'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblack.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }

                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorblack.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='black'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblack.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorblack.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='black'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblack.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorblack.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='black'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblack.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcolorwhite_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcolorwhite.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='white'");

                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkcolorblack.Checked = false;
                chkcolorred.Checked = false;
                chkcolorblue.Checked = false;
                chkcoloryellow.Checked = false;
                chkcolorsilver.Checked = false;

            }
            if (chkunder500.Checked && chkcolorwhite.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='white'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorwhite.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorwhite.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='white'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorwhite.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorwhite.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='white'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorwhite.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorwhite.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='white'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorwhite.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcolorred_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcolorred.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='red'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkcolorwhite.Checked = false;
                chkcolorblack.Checked = false;
                chkcolorblue.Checked = false;
                chkcoloryellow.Checked = false;
                chkcolorsilver.Checked = false;

            }
            if (chkunder500.Checked && chkcolorred.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='red'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorred.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorred.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='red'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorred.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorred.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='red'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorred.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorred.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='red'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorred.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcolorblue_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcolorblue.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='blue'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkcolorwhite.Checked = false;
                chkcolorred.Checked = false;
                chkcolorblack.Checked = false;
                chkcoloryellow.Checked = false;
                chkcolorsilver.Checked = false;
            }
            if (chkunder500.Checked && chkcolorblue.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='blue'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblue.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorblue.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='blue'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblue.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorblue.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='blue'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblue.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorblue.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='blue'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorblue.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcoloryellow_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcoloryellow.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='yellow'");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkcolorwhite.Checked = false;
                chkcolorred.Checked = false;
                chkcolorblue.Checked = false;
                chkcolorblack.Checked = false;
                chkcolorsilver.Checked = false;
            }
            if (chkunder500.Checked && chkcoloryellow.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='yellow'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcoloryellow.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcoloryellow.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='yellow'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcoloryellow.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcoloryellow.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='yellow'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcoloryellow.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcoloryellow.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='yellow'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcoloryellow.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkcolorsilver_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkcolorsilver.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Colour='silver' and Product_Brand='pepe jeans' and Product_Price between 300 and 500 ");

                Repeater1.DataSource = dt1;
                Repeater1.DataBind();

                chkcolorwhite.Checked = false;
                chkcolorred.Checked = false;
                chkcolorblue.Checked = false;
                chkcoloryellow.Checked = false;
                chkcolorblack.Checked = false;
            }
            if (chkunder500.Checked && chkcolorsilver.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Colour='silver'");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorsilver.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkcolorsilver.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Colour='silver'");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorsilver.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkcolorsilver.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Colour='silver'");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorsilver.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkcolorsilver.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Colour='silver'");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkcolorsilver.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkdiscount10_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkdiscount10.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Discount between 10 and 25");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkdiscount25.Checked = false;
                chkdiscount35.Checked = false;
                chkdiscount50.Checked = false;
            }

            if (chkunder500.Checked && chkdiscount10.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 10 and 25");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount10.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount10.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 10 and 25");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount10.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount10.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 10 and 25");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount10.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount10.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 10 and 25");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount10.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void chkdiscount25_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkdiscount25.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Discount between 25 and 35");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkdiscount10.Checked = false;
                chkdiscount35.Checked = false;
                chkdiscount50.Checked = false;
            }
            if (chkunder500.Checked && chkdiscount25.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 25 and 35");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount25.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount25.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 25 and 35");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount25.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount25.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 25 and 35");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount25.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount50.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 25 and 35");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount25.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void chkdiscount35_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkdiscount35.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Discount between 35 and 50");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkdiscount10.Checked = false;
                chkdiscount25.Checked = false;
                chkdiscount50.Checked = false;
            }
            if (chkunder500.Checked && chkdiscount35.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 35 and 50");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount35.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 35 and 50");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount35.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 35 and 50");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount35.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 35 and 50");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void chkdiscount50_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkdiscount50.Checked)
            {
                dt0 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Discount between 50 and 100");
                Repeater1.DataSource = dt0;
                Repeater1.DataBind();

                chkdiscount10.Checked = false;
                chkdiscount35.Checked = false;
                chkdiscount25.Checked = false;
            }
            if (chkunder500.Checked && chkdiscount50.Checked)
            {
                dt1 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 300 and 500 and Product_Discount between 50 and 100");
                if (dt1.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount50.Checked = false;
                    chkunder500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
            }
            if (chk500.Checked && chkdiscount50.Checked)
            {
                dt2 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 500 and 800 and Product_Discount between 50 and 100");
                if (dt2.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk500.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt2;
                Repeater1.DataBind();
            }
            if (chk800.Checked && chkdiscount50.Checked)
            {
                dt3 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 800 and 1200 and Product_Discount between 50 and 100");
                if (dt3.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk800.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt3;
                Repeater1.DataBind();
            }
            if (chk1200.Checked && chkdiscount50.Checked)
            {
                dt4 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Price between 1200 and 1500 and Product_Discount between 50 and 100");
                if (dt4.Rows.Count == 0)
                {

                    Repeater1.DataSource = null;
                    Repeater1.DataBind();
                    lbldatanotfound.Visible = true;
                    btndatanotfound.Visible = true;
                    chkdiscount35.Checked = false;
                    chk1200.Checked = false;
                    return;
                }
                Repeater1.DataSource = dt4;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex == 0)
            {

                Product_Detail();


            }
            if (DropDownList1.SelectedIndex == 1)
            {

                dt5 = objdf.FillDT("select * from PRODUCT_MASTER order by Product_Price asc");
                Repeater1.DataSource = dt5;
                Repeater1.DataBind();


            }
            if (DropDownList1.SelectedIndex == 2)
            {

                dt5 = objdf.FillDT("select * from PRODUCT_MASTER order by Product_Price desc");

                Repeater1.DataSource = dt5;
                Repeater1.DataBind();


            }
            if (DropDownList1.SelectedIndex == 3)
            {

                dt5 = objdf.FillDT("select * from PRODUCT_MASTER where Product_Discount between 10 and 100  ");

                Repeater1.DataSource = dt5;
                Repeater1.DataBind();


            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void btndatanotfound_Click(object sender, EventArgs e)
    {
        try
        {
            Product_Detail();
            lbldatanotfound.Visible = false;
            btndatanotfound.Visible = false;
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void lnkbtnclear_Click(object sender, EventArgs e)
    {
        try
        {
            chkunder500.Checked = false;
            chk500.Checked = false;
            chk800.Checked = false;
            chk1200.Checked = false;
            chksizel.Checked = false;
            chksizem.Checked = false;
            chksizexl.Checked = false;
            chksizexxl.Checked = false;
            chkbrandpepe.Checked = false;
            chkbrankbasics.Checked = false;
            chkbrankkiller.Checked = false;
            chkbranklevis.Checked = false;
            chkbrankmufti.Checked = false;
            chkbrankredtape.Checked = false;
            chkbrankwrangler.Checked = false;
            chkbranklee.Checked = false;
            chkcolorblack.Checked = false;
            chkcolorwhite.Checked = false;
            chkcoloryellow.Checked = false;
            chkcolorsilver.Checked = false;
            chkcolorred.Checked = false;
            chkcolorblue.Checked = false;
            chkdiscount10.Checked = false;
            chkdiscount25.Checked = false;
            chkdiscount35.Checked = false;
            chkdiscount50.Checked = false;
            Product_Detail();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

}