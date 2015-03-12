using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var order = (Order)Session["order"];
            //Label1.Text = (string)Session["nyckel"];
            Label1.Text = order.ToString();
        }
    }
}