using Asp_Emlak_Sitesi_Kurs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                Session.Clear();
            }
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserOperations.UserLogin(tboxMail.Text, tboxPassword.Text).Rows.Count>0)
            {
                if (tboxMail.Text=="admin@gmail.com")
                {
                    Session["IsAdmin"] = true;
                    Session["UserMail"] = tboxMail.Text;
                    Response.Redirect("AdminMainPage.aspx");
                }
                else
                {
                    Session["IsUserOnline"] = true;
                    Session["UserMail"] = tboxMail.Text;
                    Response.Redirect("UserMainPage.aspx");
                }
            
            }
            
        }
    }
}