using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Asp_Emlak_Sitesi_Kurs.Classes
{
    public class AdminOperations
    {
        public static void AdminDeleteProperty(int id)
        {
            SqlCommand commandAdminDeleteProperty = new SqlCommand("Delete from TableProperty where PropertyID=@pid",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandAdminDeleteProperty.Parameters.AddWithValue("@pid", id);
            commandAdminDeleteProperty.ExecuteNonQuery();   

        }

        public static SqlDataReader drGetAllPropUnapproved;
        public static SqlDataReader AdminGetAllPropUnapproved()
        {
            SqlCommand commandLoadProperties = new SqlCommand("Select * from TableProperty where PropertyApprove=@p1", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandLoadProperties.Parameters.AddWithValue("@p1", 0);
            drGetAllPropUnapproved = commandLoadProperties.ExecuteReader();

            return drGetAllPropUnapproved;
        }

        public static void AdminApprove(int id)
        {
            SqlCommand commandApprove = new SqlCommand("Update TableProperty set PropertyApprove=@p1 where PropertyID=@pid",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandApprove.Parameters.AddWithValue("@p1", 1);
            commandApprove.Parameters.AddWithValue("@pid", id);
            commandApprove.ExecuteNonQuery();
        }
    }
}