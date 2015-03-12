using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class Collection : System.Web.UI.Page
    {
        private DropDownList dropDownList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master != null) dropDownList = (DropDownList)Master.FindControl("DropDownList1");
            var order = (Order)Session["order"];

            foreach (var item in order.OrderRows)
            {
                dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            var index = row.RowIndex;
            var test = row.Cells[0].Text;
        }
    }
}