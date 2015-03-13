using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSet = DAL.DataSet;

namespace ProjectTwo
{
    public partial class Kassorskan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            DataSet.OrderHeadDataTable orderHead = new DataSet.OrderHeadDataTable();
            DataRow orderHeadRow = orderHead.NewRow();
            orederHeadRow
            DataColumn adressColumn = new DataColumn("Address", typeof(string));
        }
    }
}