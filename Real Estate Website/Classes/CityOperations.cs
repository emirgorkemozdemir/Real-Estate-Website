using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Asp_Emlak_Sitesi_Kurs.Classes
{
    public class CityOperations
    {
        public static DataTable BindDropDownCity()
        {
            SqlCommand commandBindDropDownCity = new SqlCommand("Select * from TableCity",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownCity);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}