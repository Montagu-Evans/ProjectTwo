using System;
using System.Data.Odbc;
using System.Globalization;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using DAL;

namespace ProjectTwo
{
    public partial class master : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var order = (Order) Session["order"];
            if (order.UserID == 0)
            {
                Server.Transfer("Login.aspx");
            }

            Label1.Text = "Välkommen, " + UserData.userName + "!";

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            var order = (Order) Session["order"];
            order.UserID = 0;
        }
    }
}