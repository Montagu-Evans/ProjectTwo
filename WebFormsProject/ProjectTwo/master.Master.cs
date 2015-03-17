using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class Master : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var order = (Order)Session["order"];
            if (order.UserID == 0)
            {
                Server.Transfer("Login.aspx");
            }

            Label1.Text = "Välkommen, " + UserData.userName + "!";
        }
        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Session["order"] = new Order(userID: UserData.userID = 0); //här tömmer vi ordern för nästa gång.
            if (Master != null) ((DropDownList)Master.FindControl("dropDownList1")).Items.Clear();
            Server.Transfer("Login.aspx");
        }
    }
}