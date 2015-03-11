using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using DAL;

namespace ProjectTwo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
           
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Order order = new Order();
            //Session["currentOrder"] = new Order("", "", "", "");

            //För att sedan kunna hämta det i vilken code-behind som helst så gör följande:
           //Order currentOrder = (Order) Session["currentOrder"];
           //currentOrder.FirstName = "Kalle";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}