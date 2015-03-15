using System;
using System.Web.UI.WebControls;
using DAL;

namespace ProjectTwo
{
    public partial class Kassorskan : System.Web.UI.Page
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
        }

        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            var order = (Order)Session["order"];
            order.Address = TextBoxAddress.Text;
            order.City = TextBoxCity.Text;
            order.Zip = TextBoxZip.Text;
            order.UserID = UserData.userID;
            
            order.Insert();
            var orderID = order.GetOrderID();
            
            InsertCheckout(orderID);
            order = new Order(userID: UserData.userID);
        }

        private void InsertCheckout(int orderID)
        {
            var order = (Order)Session["order"];
            order.OrderID = orderID;
            var webShopDal = new WebShopDAL();

            if (TextBoxAddress.Text != null && TextBoxCity != null && TextBoxZip != null)
            {
                webShopDal.AddorderToDB(order);
                Server.Transfer("orderConfirmation.aspx");
            }
        }
    }
}