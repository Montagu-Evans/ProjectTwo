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
            var order = (Order) Session["order"];
            if (user == 1)
            {
                order.UserID += 1;
                Response.Redirect("Collection.aspx"); 
            }

            //Session["nyckel"] = TextBoxUserName.Text; //Session är en cookie. Cookie lägger sig på klientens dator och innehåller information. max 4k stort. En Session har cookie i sig.
            //Server.Transfer("Collection.aspx");
        }
    }
}