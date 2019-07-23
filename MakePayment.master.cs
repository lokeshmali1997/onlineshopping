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

public partial class MakePayment : System.Web.UI.MasterPage
{
    DataFuction objdf = new DataFuction();
    DataTable dt0 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            lblcartcount.Text = "0";

        }
        else
        {

            lblcartcount.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());
        }


        if (Session["USERNAME"] != null)
        {
            MakePayment master = (MakePayment)Page.Master;
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
    protected void txtsearch_TextChanged(object sender, EventArgs e)
    {
        try{
        string name = txtsearch.Text.ToString();

        Response.Redirect("SearchPage.aspx?NAME=" + name);
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }

    public void countcart()
    {
        try
        {

            dt0 = objdf.FillDT("select * from ORDER_MASTER where User_Id ='" + Session["login"] + "'");
            lblcartcount.Text = dt0.Rows.Count.ToString();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }

    protected void btnImagecart_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["login"] == null)
            {
                Response.Write("<script>alert('Cart IS Empty')</script>");

            }
            else
            {
                Response.Redirect("CartProduct.aspx?orderid=" + lblcartcount.Text);
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void lbllogout_Click(object sender, EventArgs e)
    {
        try
        {
            Session.Clear();
            Response.Redirect("IndexPage.aspx");
            lblsignin.Visible = true;
            lblusernameshow.Visible = false;
            this.Visible = false;
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
}
