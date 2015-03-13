using System;
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
            dropDownList.Items.Clear();
            dropDownList.Items.Add("Din varukorg");
            var order = (Order)Session["order"];
          
            foreach (var item in order.OrderRows)
            {
                dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
            }
            if (dropDownList.Items.Count > 1)
            {
                dropDownList.Items.Add("");
                dropDownList.Items.Add("Gå till kassa");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Order order = (Order)Session["order"];
            GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            var index = row.RowIndex;
            var product = row.Cells[0].Text;
            var price = double.Parse(row.Cells[1].Text);
            OrderRow orderRow = new OrderRow(product);
            order.OrderRows.Add(orderRow);
            Page_Load(sender, e);
        }
    }
}