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
    DataSet  ds;
   
    string productid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            productid = Request.QueryString[0];
            ProductDetail();

            lblid.Text = productid;
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

    public void ProductDetail()
    {
        try{
        ds = objdf.FillDsS("select * from PRODUCT_MASTER where Product_Id ='" + productid + "'");

        imgproductimg.ImageUrl = ds.Tables[0].Rows[0]["Product_Image"].ToString();
        lblproductname.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
        lblproductdisprice.Text = ds.Tables[0].Rows[0]["Product_Dis_Price"].ToString();
        lblproductdiscount.Text = ds.Tables[0].Rows[0]["Product_Discount"].ToString();
        lblproductprice.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }

    protected void btnbuynow_Click(object sender, EventArgs e)
    {try{
        if (Session["login"] == null)
        {
            Response.Write("<script>('Please Login')</script>");

        }
        else
        {
            Response.Redirect("CustomerDetail.aspx?Prouductid=" + lblid.Text);
        }
    }
    catch (Exception ex)
    {
        Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
    }
    }
    protected void btnaddtocart_Click(object sender, EventArgs e)
    {  try{

        if (Session["login"] == null)
        {
            Response.Write("<script>alert('Please Login')</script>");

        }


          





        else
        {

           
                KapdeWala master = (KapdeWala)Page.Master;
                Label lbl = (Label)master.FindControl("lblcartcount");

                DataFuction objdf = new DataFuction();
                //ds = objdf.FillDsS("select * from PRODUCT_MASTER where Product_Id ='" + productid + "'");

                //imgproductimg.ImageUrl = ds.Tables[0].Rows[0]["Product_Image"].ToString();
                //lblproductname.Text = ds.Tables[0].Rows[0]["Product_Name"].ToString();
                //lblproductdisprice.Text = ds.Tables[0].Rows[0]["Product_Dis_Price"].ToString();
                //lblproductdiscount.Text = ds.Tables[0].Rows[0]["Product_Discount"].ToString();
                //lblproductprice.Text = ds.Tables[0].Rows[0]["Product_Price"].ToString();


                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@ordername", SqlDbType.VarChar);
                param[0].Value = lblproductname.Text;


                param[1] = new SqlParameter("@orderimage", SqlDbType.VarChar);
                param[1].Value = imgproductimg.ImageUrl;

                param[2] = new SqlParameter("@orderprice", SqlDbType.BigInt);
                param[2].Value = Convert.ToInt64(lblproductprice.Text);

                param[3] = new SqlParameter("@orderdisprice", SqlDbType.BigInt);
                param[3].Value = Convert.ToInt64(lblproductdisprice.Text);

                param[4] = new SqlParameter("@orderdiscount", SqlDbType.BigInt);
                param[4].Value = Convert.ToInt64(lblproductdiscount.Text);

                param[5] = new SqlParameter("@userid", SqlDbType.Int);
                param[5].Value = Convert.ToInt32(Session["login"]);

                
                
                int result = objdf.ExecuteQuery("usp_order_insert", param);


                if (result > 0)
                {
                    lbl.Text = (Count.countcart(Convert.ToInt32(Session["login"])).ToString());
                }
                else
                {
                    Response.Write("<script> alert('Product already exists !')</script>");
                }
            
        }
        
    }
    catch (Exception ex)
    {
        Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
    }
        
    }
        
}
