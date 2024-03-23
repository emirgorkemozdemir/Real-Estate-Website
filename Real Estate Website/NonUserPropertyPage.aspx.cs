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
    public partial class NonUserPropertyPage : System.Web.UI.Page
    {
        public SqlDataReader drProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            drProp = PropertyOperations.getAllProp();
            DataList1.DataSource = drProp;
            DataList1.DataBind();
            PropertyOperations.drGetAllProp.Close();
        }
    }
}