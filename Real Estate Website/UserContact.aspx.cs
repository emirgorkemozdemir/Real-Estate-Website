﻿using Asp_Emlak_Sitesi_Kurs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class UserContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                var new_list = ContactOperations.GetContactInfo();
                contactmail.InnerHtml = new_list[0];
                contactphone.InnerHtml = new_list[1];
                contactadress.InnerHtml = new_list[2];
            }
          
        }
    }
}