using System;
using System.Web.UI;
using DAL;

namespace ProjectTwo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                Session["order"] = new Order();
            }
            catch (Exception)
            {
                
                throw new Exception();
            }
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            Session["ErrorMessage"] = error.Message;
            Server.ClearError();
            Response.Redirect("ErrorPage.aspx");
            
        }

        protected void Session_End(object sender, EventArgs e)
        {
           Session["order"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {
           //Session["order"] = null;
        }
    }
}