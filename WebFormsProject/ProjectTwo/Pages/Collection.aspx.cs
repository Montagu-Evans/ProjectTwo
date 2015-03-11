using System;
using DAL;

namespace ProjectTwo
{
    public partial class Collection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonVarukorg_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ButtonVarukorg_Click1(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderRow orderRow = new OrderRow();
            order.OrderRows.Add(orderRow);
        }
    }
}