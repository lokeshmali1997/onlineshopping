using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://microsoft.com/webservices/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{


    [System.Web.Services.WebMethod]

    public string[] GetCompletionList(string prefixText)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = "SELECT  Product_Name from PRODUCT_MASTER Where Product_Name like '%" + prefixText + "%' ";

        SqlDataAdapter adpt = new SqlDataAdapter();
        adpt.SelectCommand = cmd;

        DataTable dt = new DataTable();
        adpt.Fill(dt);

        //DataTable dt = con.GetdataTable("Select IsNull(City_Name,'')+', '+IsNull(Country_Code,'')+' - '+isNull(tbl_AirportList.Airport_Name,'') as City_Name from tbl_CityAndCountry inner join tbl_AirportList on tbl_CityAndCountry.City_Code=tbl_AirportList.City_Code Where City_Name like '" + prefixText + "%'");
        //DataTable dt = con.GetdataTableByProc("sp_SearchFlight", prefixText);
        List<string> st = new List<string>();
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st.Add(dt.Rows[i]["Product_Name"].ToString());
                
            }
        }
        
        else
        {
            st.Add("No Data Found");
        }

        return (st.ToArray());
    }

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
