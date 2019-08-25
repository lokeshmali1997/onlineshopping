using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;


/// <summary>
/// Summary description for Count
/// </summary>
public class Count
{
	public Count()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static int countcart(int user)
    {
        DataFuction objdf = new DataFuction();
        DataTable dt = new DataTable();
        dt = objdf.FillDT("select * from ORDER_MASTER where User_Id ='" + user + "'");
        int countcartvalue = dt.Rows.Count;
        return countcartvalue;
    
    }
}