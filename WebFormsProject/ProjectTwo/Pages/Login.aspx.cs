﻿using System;
using System.Net.Mime;
using System.Web.Security;
using System.Web.UI;
using DAL;
using DAL.DataSetTableAdapters;

namespace ProjectTwo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            var usersTable = new UsersTableAdapter();
            var user = UserData.Authenticate(TextBoxUserName.Text, TextBoxPassword.Text);
            var order = (Order)Session["order"];
            if (user > 0)
            {
                order.UserID = user;
                Server.Transfer("Default.aspx");
            }

            else
            {
                if(TextBoxUserName.Text != null && TextBoxPassword.Text != null && TextBoxUserName.Text != "" && TextBoxPassword.Text != "")
                LabelLoginMessage.Text = "Du skrev in fel användarnamn eller fel lösenord!";
            }
        }
    }
}