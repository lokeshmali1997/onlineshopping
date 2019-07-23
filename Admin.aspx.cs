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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
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

    protected void btninsert_Click(object sender, EventArgs e)
    {
        try{
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        con.Open();


        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_insert_product";
        cmd.Parameters.AddWithValue("@productname",txtProductname.Text);

        if (ProductImageUpload.HasFile)
        {
            if (checkextension(ProductImageUpload.FileName))
            {
                if (ProductImageUpload.PostedFile.ContentLength < 1000000)
                {


                    string path = Server.MapPath("Product_Image");
                    path = path + "\\" + ProductImageUpload.FileName;

                    ProductImageUpload.SaveAs(path);
                    cmd.Parameters.AddWithValue("@productimage", "~\\Product_Image\\" + ProductImageUpload.FileName);

                }

            }
        }

        cmd.Parameters.AddWithValue("@productprice", txtproductprice.Text);
        cmd.Parameters.AddWithValue("@productdisprice", txtproductdisprice.Text);
        cmd.Parameters.AddWithValue("@productsize", txtproductsize.Text);
        cmd.Parameters.AddWithValue("@productbrand", txtproductbrand.Text);
        cmd.Parameters.AddWithValue("@productcolour", txtproductcolour.Text);
        cmd.Parameters.AddWithValue("@productdiscount", txtproductdiscount.Text);




        int result = cmd.ExecuteNonQuery();

        if (result > 0)
        {
            Response.Write("<script>alert('insert successfully')</script>");

        }

        con.Close();
        txtProductname.Text = string.Empty;
        txtproductprice.Text = string.Empty;
        txtproductdisprice.Text = string.Empty;
        txtproductsize.Text = string.Empty;
        txtproductbrand.Text = string.Empty;
        txtproductcolour.Text = string.Empty;
        txtproductdiscount.Text = string.Empty;
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Error Occured Please Contact to Admin')</script>");
        }
        }

    private bool checkextension(string filename)
    {

        string ex = Path.GetExtension(filename).ToLower();
        switch (ex)
        {
            case ".jpg": return true;
            case ".jpeg": return true;
            case ".png": return true;
            default: return false;



        }


    }

}