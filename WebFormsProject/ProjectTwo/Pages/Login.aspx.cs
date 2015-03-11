using System;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
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
            UsersTableAdapter usersTable = new UsersTableAdapter();
            int user = UserData.Authenticate(TextBoxUserName.Text, TextBoxPassword.Text);
            if (user == 1)
            {
                Response.Redirect("Collection.aspx"); 
            }
        }
    }
}