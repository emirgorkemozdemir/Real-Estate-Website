using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Asp_Emlak_Sitesi_Kurs.Classes
{
    public class PropertyOperations
    {
        public static SqlDataReader drGetAllProp;
        public static SqlDataReader getAllProp()
        {
            SqlCommand commandLoadProperties = new SqlCommand("Select * from TableProperty where PropertyApprove=@p1", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandLoadProperties.Parameters.AddWithValue("@p1",1);
            drGetAllProp = commandLoadProperties.ExecuteReader();

            return drGetAllProp;
        }

        public static SqlDataReader drGetPropByID;
        public static SqlDataReader getPropByID(int fake_id)
        {
            SqlCommand commandGetProperties = new SqlCommand("Select * from TableProperty where PropertyID=@pid ", sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandGetProperties.Parameters.AddWithValue("@pid", fake_id);

            drGetPropByID = commandGetProperties.ExecuteReader();

            return drGetPropByID;
        }


        public static void AddProperty(string title , string price , int cityID , int hoodID , string room , string photoLink , string type)
        {
            SqlCommand commandAddProperty = new SqlCommand("Insert into TableProperty (PropertyTitle,PropertyPrice,PropertyCity,PropertyHood,PropertyType,PropertyRoom,PropertyPhotos ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",sqlConnectionClass.connection);
            sqlConnectionClass.checkConnection();
            commandAddProperty.Parameters.AddWithValue("@p1", title);
            commandAddProperty.Parameters.AddWithValue("@p2", price);
            commandAddProperty.Parameters.AddWithValue("@p3", cityID);
            commandAddProperty.Parameters.AddWithValue("@p4", hoodID);
            commandAddProperty.Parameters.AddWithValue("@p5", room);
            commandAddProperty.Parameters.AddWithValue("@p6", type);
            commandAddProperty.Parameters.AddWithValue("@p7", photoLink);

            commandAddProperty.ExecuteNonQuery();
        }
    }
}