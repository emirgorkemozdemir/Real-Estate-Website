﻿using Asp_Emlak_Sitesi_Kurs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Emlak_Sitesi_Kurs
{
    public partial class UserSellingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) != true)
            {
                Response.Redirect("Login.aspx");
            }
            if (Page.IsPostBack == false)
            {
                DropDownListType.Items.Insert(0,"Konut");
                DropDownListType.Items.Insert(1,"Arsa");

                LoadRoom();

                DropDownListCity.DataTextField = "CityName";
                DropDownListCity.DataValueField = "CityID";

                DropDownListCity.DataSource = CityOperations.BindDropDownCity();
                DropDownListCity.DataBind();

                LoadHoods();
            }
        }

        public void LoadRoom()
        {
            DropDownListRoom.Items.Insert(0,"3+1");
            DropDownListRoom.Items.Insert(1,"2+1");
            DropDownListRoom.Items.Insert(2,"1+1");
        }

        public void LoadHoods()
        {
            DropDownListHood.DataTextField = "HoodName";
            DropDownListHood.DataValueField = "HoodID";

            DropDownListHood.DataSource = HoodOperations.BindDropDownHood(Convert.ToInt32(DropDownListCity.SelectedValue));
            DropDownListHood.DataBind();
        }

        protected void DropDownListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoods();
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListType.SelectedValue.ToString()=="Konut")
            {
                if (DropDownListRoom.Items.Count>0)
                {
                    DropDownListRoom.Visible = true;
                }
                else
                {
                    DropDownListRoom.Visible = true;
                    LoadRoom();
                }
           
            }
            else
            {
                DropDownListRoom.Visible = false;
            }
        }

        protected void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxPhoto.Text.ToString()))
            {
                Response.Write("Fotoğraf kısmı boş bırakılamaz");
            }
            else if (String.IsNullOrEmpty(tboxPrice.Text.ToString()))
            {
                Response.Write("Fiyat kısmı boş bırakılamaz");
            }
            else if (String.IsNullOrEmpty(tboxTitle.Text.ToString()))
            {
                Response.Write("Başlık kısmı boş bırakılamaz");
            }
            else
            {

            }
        }
    }
}