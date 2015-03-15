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
            dropDownList = (DropDownList)Master.FindControl("DropDownList1");
            dropDownList.Items.Clear();
            dropDownList.Items.Add("Din varukorg");
           
            var order = (Order)Session["order"];

            if (!IsPostBack)
            {
                foreach (var item in order.OrderRows)
                {
                    dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var increaseQuantity = false;
            var order = (Order)Session["order"];
            var row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
            //var index = row.RowIndex;
            var product = row.Cells[0].Text;
            var price = decimal.Parse(row.Cells[1].Text);

            var dal = new WebShopDAL();
            dal.GetArticleID(product);


            foreach (var orderRow in order.OrderRows)
            {
                if (orderRow.ProductName == product)
                {
                    orderRow.Quantity++;
                    increaseQuantity = true;
                }
            }

            if(increaseQuantity == false)
                order.OrderRows.Add(new OrderRow(product, price, dal.GetArticleID(product)));

            foreach (var item in order.OrderRows)
            {
                dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
            }
           // Page_Load(sender, e);
        }
    }
}