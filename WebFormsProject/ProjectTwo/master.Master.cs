using System;
using System.Data.Odbc;
using System.Web;
using System.Web.UI;
using DAL;

namespace ProjectTwo
{
    public partial class master : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (HttpContext.Current.User != null) &&
                        HttpContext.Current.User.Identity.IsAuthenticated;
            
            //if (val1)
            //{
            //    Response.Redirect("Login.aspx");
            //}
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order orders = new Order();
            
            foreach (var order in orders.OrderRows)
            {
                DropDownList1.Items.Add(order.ArticleID.ToString());
            }
        }
    }
}