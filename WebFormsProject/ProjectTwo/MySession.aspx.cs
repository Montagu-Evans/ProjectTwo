using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class MySession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["nyckel"] = TextBox1.Text; //Session är en cookie. Cookie lägger sig på klientens dator och innehåller information. max 4k stort. En Session har cookie i sig.
            //Server.Transfer("WebForm2.aspx");

            //var order = (Order)Session["order"];
            //order = TextBox1.Text;
            //order.Number += 1;
            //order.OrderRows.Add(new OrderRow());
            //Response.Redirect("Collection.aspx");
        }
    }
}