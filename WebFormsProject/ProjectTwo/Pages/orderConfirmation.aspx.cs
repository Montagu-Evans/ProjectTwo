using System;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo.Pages
{
    public partial class OrderConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var order = (Order)Session["order"]; //här får vi får ut ordern.
            Label8.Text = UserData.userName;

            Session["order"] = new Order(userID: UserData.userID); //här tömmer vi ordern för nästa gång.
            if (Master != null) ((DropDownList)Master.FindControl("dropDownList1")).Items.Clear();
        }
    }
}