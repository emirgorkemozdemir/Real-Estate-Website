using Asp_Emlak_Sitesi_Kurs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class UserAboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"])!=true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                aboutUsP.InnerHtml = AboutUsOperations.listAboutUs();
            }
           
        }
    }
}