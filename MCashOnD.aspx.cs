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
    Label lblcartcount;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        string orderid;
        if (!IsPostBack)
        {

            //orderid = Request.QueryString[0];
            //lblorderid.Text = orderid;
        }

        if (Session["USERNAME"] != null)
        {
            MakePayment master = (MakePayment)Page.Master;
            Label lblusernameshow = (Label)master.FindControl("lblusernameshow");
             lblcartcount = (Label)master.FindControl("lblcartcount");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataFuction objdf = new DataFuction();
        lblcartcount.Text = "0";
        btnshopping.Visible = true;

        //SqlParameter[] param = new SqlParameter[1];
        //param[0] = new SqlParameter("@orderid", SqlDbType.Int);
        //param[0].Value = Convert.ToInt32(lblorderid.Text);

        //objdf.ExecuteQuery("usp_order_remove", param);
        //MakePayment master = (MakePayment)Page.Master;
        //Label lbl = (Label)master.FindControl("lblcartcount");
        //lbl.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());    

        Response.Write("<script>alert('Your Order Booked')</script>");
    }
    protected void btnshopping_Click(object sender, EventArgs e)
    {
        Response.Redirect("T-Shirts.aspx");
    }
}