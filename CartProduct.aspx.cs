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
    DataFuction objdf = new DataFuction();
    DataSet ds;
    DataFuction objdf2 = new DataFuction();
    DataTable dt0 = new DataTable();
    string orderid;
    Label lblorderid;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            orderid = Request.QueryString[0];
            
            lblid.Text = orderid;
            
        }
        fillcart();
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

    public void fillcart()
    { 
        try{
        int totalprice = 0;
        lblpay.Text = "0";
        lblquantity.Text = "0";
        dt0 = objdf2.FillDT("select * from ORDER_MASTER where User_Id ='"+Session["login"]+"' ");
        foreach (DataRow row in dt0.Rows)
        {
            int amount = Convert.ToInt32(row["Order_Price"]);
            totalprice = totalprice + amount;
            lblpay.Text = totalprice.ToString();
            lblquantity.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());
        }
        Repeater1.DataSource = dt0;
        Repeater1.DataBind();
        lbltotal.Text = totalprice.ToString();
        //imgproductimg.ImageUrl = dt0.Tables[0].Rows[0]["Product_Image"].ToString();
        //lblproductname.Text = dt.Tables[0].Rows[0]["Product_Name"].ToString();
        //lblProductnamee.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
        //lblproductcolour.Text = ds.Tables[0].Rows[0]["Product_Colour"].ToString();
        //lblproductdisprice.Text = ds.Tables[0].Rows[0]["Product_Dis_Price"].ToString();
        //lblproductdiscount.Text = ds.Tables[0].Rows[0]["Product_Discount"].ToString();
        //lblproductprice.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        //lblproductpricee.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        //lbltotal.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        //lblpay.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();

        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
    }
    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    // 
    //}
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    { 
        try{
        lblorderid = e.Item.FindControl("lblorderid") as Label;

        if (e.CommandName == "removeitem")
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@orderid", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(lblorderid.Text);

            objdf.ExecuteQuery("usp_order_remove", param);
            KapdeWala master = (KapdeWala)Page.Master;
            Label lbl = (Label)master.FindControl("lblcartcount");
            lbl.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());
            
            fillcart();
        }


        //DropDownList mylist = (DropDownList)e.Item.FindControl("DropDownList1");
        //  if (mylist.SelectedIndex == 0)
        //  {
        //      int a = 1, mul;
        //      lblquantity.Text = a.ToString();
        //      int p = Convert.ToInt32(lblproductpricee.Text);
        //      mul = p * a;
        //      lbltotal.Text = mul.ToString();
        //      lblpay.Text = mul.ToString();
        //  }
        //  if (mylist.SelectedIndex == 1)
        //  {
        //      int b = 2, mul;
        //      lblquantity.Text = b.ToString();
        //      int p = Convert.ToInt32(lblproductpricee.Text);
        //      mul = p * b;

        //      lbltotal.Text = mul.ToString();
        //      lblpay.Text = mul.ToString();
        //  }
        //  if (mylist.SelectedIndex == 2)
        //  {
        //      int c = 3, mul;
        //      lblquantity.Text = c.ToString();
        //      int p = Convert.ToInt32(lblproductpricee.Text);
        //      mul = p * c;

        //      lbltotal.Text = mul.ToString();
        //      lblpay.Text = mul.ToString();
        //  }
        //  if (mylist.SelectedIndex == 3)
        //  {
        //      int d = 4, mul;
        //      lblquantity.Text = d.ToString();
        //      int p = Convert.ToInt32(lblproductpricee.Text);
        //      mul = p * d;

        //      lbltotal.Text = mul.ToString();
        //      lblpay.Text = mul.ToString();
        //  }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }




    protected void btnorderplace_Click(object sender, EventArgs e)
    {
        try{
        Response.Redirect("CustomerDetail.aspx?orderid="+lblquantity.Text);
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }
}