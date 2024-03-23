using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class NonUserPropertyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myID = Request.QueryString["selectedid"].ToString();
            Label1.Text = myID;
        }
    }
}