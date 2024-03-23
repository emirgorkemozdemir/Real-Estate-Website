using Asp_Emlak_Sitesi_Kurs.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class NonUserPropertDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myID =Convert.ToInt32( Request.QueryString["selectedid"]);

            DataList1.DataSource = PropertyOperations.getPropByID(myID);
            DataList1.DataBind();
            PropertyOperations.drGetPropByID.Close();


        }
    }
}