using System;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class Default : System.Web.UI.Page
    {
        private DropDownList dropDownList;
        protected void Page_Load(object sender, EventArgs e) //Här lägger vi till i dropDownlistan när den laddas. Denna har vi felhanterat.
        {
            if (Master != null) dropDownList = (DropDownList)Master.FindControl("DropDownList1");
            dropDownList.Items.Clear();

            try
            {
                var order = (Order)Session["order"];

                if (!IsPostBack)
                {
                    foreach (var item in order.OrderRows)
                    {
                        dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) //Denna metoden lägger till en produkt till ordern. Denna har vi felhanterat
        {
            try
            {
                //var tal = 27/int.Parse("0");
                const bool increaseQuantity = false;
                var order = (Order)Session["order"];
                var row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                var product = row.Cells[0].Text;
                var price = decimal.Parse(row.Cells[1].Text);

                var dal = new WebShopDAL();
                dal.GetArticleID(product);

                CheckDropdownList(order, product, increaseQuantity, price, dal);
            }
            catch (Exception)
            {
                throw new Exception("What the fuuuuuuck?");
            }
           
        }

        private void CheckDropdownList(Order order, string product, bool increaseQuantity, decimal price, WebShopDAL dal)
        {
            if (order.OrderRows != null)
            {
                foreach (var orderRow in order.OrderRows)
                {
                    if (orderRow.ProductName == product)
                    {
                        orderRow.Quantity++;
                        increaseQuantity = true;
                    }
                }
            }

            if (increaseQuantity == false)
                if (order.OrderRows != null)
                    order.OrderRows.Add(new OrderRow(product, price, dal.GetArticleID(product)));
           
            if (order.OrderRows != null)
            {
                dropDownList.Items.Add("Varukorg: " + order.OrderRows.Count);
                foreach (var item in order.OrderRows)
                {
                    dropDownList.Items.Add(item.ProductName + " Qty: " + item.Quantity);
                }
            }
        }
    }
}