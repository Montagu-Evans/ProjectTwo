using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DAL;
using DataSet = DAL.DataSet;

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
            if (dropDownList.Items.Count > 1)
            {
                dropDownList.Items.Add("");
                dropDownList.Items.Add("Gå till kassa");
            }
        }

        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(TextBoxAddress.Text, TextBoxCity.Text, TextBoxZip.Text, UserData.userID);
            if (TextBoxZip.AutoCompleteType == AutoCompleteType.HomeZipCode && TextBoxAddress.Text != null && TextBoxCity != null && TextBoxZip != null)
            {
                order.Insert();
                Server.Transfer("orderConfirmation.aspx");
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //SqlCommand command = new SqlCommand();
            //command.Parameters["@categoryid"].Value = ddlCategoryID.SelectedItem.Text;
            //command.Parameters["@categoryname"].Value = txtCategoryName.Text;
            //command.Parameters["@categorydescription"].Value = txtCategoryDescription.Text;
            //sqlConnection1.Open();
            //cmdCategoriesUpdate.ExecuteNonQuery();
            //sqlConnection1.Close();
        }
    }
}