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
    string productid;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            productid = Request.QueryString[0];
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



    protected void btncontinue_Click(object sender, EventArgs e)
    {
        try
        {
            

            //if (rbhome.Checked)
            //{
            //    addresstype.Text = "home";
              
            //}
            //else if (rboffice.Checked)
            //{
            //    addresstype.Text = "office";
            //}
           
          SqlParameter []param = new SqlParameter[9];

            param[0] = new SqlParameter("@cpincode",SqlDbType.VarChar);
            param[0].Value = txtpincode.Text;

            param[1] = new SqlParameter("@cmobnumber", SqlDbType.BigInt);
            param[1].Value = txtmobnumber.Text;

            param[2] = new SqlParameter("@ccolony", SqlDbType.VarChar);
            param[2].Value = txtcolony.Text;

            param[3] = new SqlParameter("@clandmark", SqlDbType.VarChar);
            param[3].Value = txtlandmark.Text;

            param[4] = new SqlParameter("@caddresstype", SqlDbType.VarChar);

            if (rbhome.Checked)
            {
                param[4].Value = "home";
            }
            else
            {
                param[4].Value = "office";
            
            }
            param[5] = new SqlParameter("@cname", SqlDbType.VarChar);
            param[5].Value = txtname.Text;

            param[6] = new SqlParameter("@chouse", SqlDbType.VarChar);
            param[6].Value = txthouse.Text;

            param[7] = new SqlParameter("@ccity", SqlDbType.VarChar);
            param[7].Value = txtcity.Text;

            param[8] = new SqlParameter("@cstate", SqlDbType.VarChar);
            param[8].Value = txtstate.Text;

            int result = objdf.ExecuteQuery("usp_insert_customer", param);

            if (result > 0)
            {
                if (productid == lblid.Text)
                {


                    Response.Redirect("BuyNowProductPage.aspx?productid="+lblid.Text);
                }
                else
                {
                    Response.Redirect("MCreditCard.aspx?productid="+lblid.Text);
                }
                }
            
        }

        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }
}