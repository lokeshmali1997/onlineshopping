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


public partial class KapdeWala : System.Web.UI.MasterPage
{
    DataFuction objdf = new DataFuction();
    DataTable dt0 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

        //if (Session["count"] == null)
        //{

        //    lblcartcount.Text = "0";
        //}

        //else {

        //    lblcartcount.Text = Session["count"].ToString();
        //}
        if (Session["login"] == null)
        {
            lblcartcount.Text = "0";

        }
        else
        {
            
            lblcartcount.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());
        }
      }

    protected void txtsearch_TextChanged(object sender, EventArgs e)
    {
        try
        {

            string name = txtsearch.Text.ToString();

            Response.Redirect("SearchPage.aspx?NAME=" + name);
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }

    //public string LabelCart
    //{
      //  get
        //{
     //       return lblcartcount.Text;
        //}
        //set
        //{
          //  lblcartcount.Text = value;
        //}
   // }
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
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        try
        {

        DataFuction objdf = new DataFuction();
        SqlParameter[] param = new SqlParameter[3];

        param[0] = new  SqlParameter("@signnumber", SqlDbType.BigInt);
        param[0].Value = Convert.ToInt64(txtsignnumber.Text);

        param[1] = new SqlParameter("@signemail", SqlDbType.VarChar);
        param[1].Value = txtsignemail.Text;

        param[2] = new SqlParameter("@signpassword", SqlDbType.VarChar);
        param[2].Value = txtsignpassword.Text;

       int result= objdf.ExecuteQuery("usp_insert_signup", param);

       if (result > 0)
       {
           Response.Write("<script>alert('Sign Up Successful')</script>");
       }

        txtsignnumber.Text = string.Empty;
        txtsignemail.Text=string.Empty;
        txtsignpassword.Text = string.Empty;
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try{

        SqlParameter[] param = new SqlParameter[2];

        //param[0] = new SqlParameter("@chksignnumber", SqlDbType.BigInt);
        //param[0].Value = Convert.ToInt64(txtusername.Text);

        param[0] = new SqlParameter("@chksignname", SqlDbType.VarChar);
        param[0].Value = txtusername.Text;

        param[1] = new SqlParameter("@chksignpassword", SqlDbType.VarChar);
        param[1].Value = txtuserpassword.Text;

         if(txtusername.Text == "loky1218@gmail.com" && txtuserpassword.Text == "loky1218")
        {
            Session.Add("username", txtusername.Text);
            Response.Redirect("Admin.aspx");
        }
       else
        {
            DataSet ds = new DataSet();
            ds = objdf.FillDsParam("usp_select_signup", param);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["login"] = ds.Tables[0].Rows[0]["SignUp_Id"];
                Session.Add("USERNAME", txtusername.Text);
                Response.Redirect("IndexPage.aspx");
            }

            else
            {
                Response.Write("<script>alert('user name and password not match')</script>");
            }

            txtusername.Text = string.Empty;
            txtuserpassword.Text = string.Empty;

        }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    public void countcart()
    {
        try{

        dt0 = objdf.FillDT("select * from ORDER_MASTER where User_Id ='"+Session["login"]+"'");
        lblcartcount.Text = dt0.Rows.Count.ToString ();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    protected void lbllogout_Click(object sender, EventArgs e)
    {
        try{
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
