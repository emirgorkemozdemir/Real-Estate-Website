using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Asp_Emlak_Sitesi_Kurs.Classes
{
    public class HoodOperations
    {

        public static DataTable BindDropDownHood(int id)
        {
            SqlCommand commandBindDropDownHood = new SqlCommand("Select * from TableHood where HoodCityID=@pid", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();

            commandBindDropDownHood.Parameters.AddWithValue("@pid",id);

            SqlDataAdapter da = new SqlDataAdapter(commandBindDropDownHood);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}