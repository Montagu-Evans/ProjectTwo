using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetTableAdapters;
using DataSet = DAL; 

namespace DAL
{

    public class Order
    {
      
       // public virtual ApplicationUser User { get; set; }
        public List<OrderRow> OrderRows { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int UserID { get; set; }


        public Order(string address = "", string city="", string zip="", int userID=0)
        {
            OrderRows = new List<OrderRow>();
            Address = address;
            City = city;
            Zip = zip;
            userID = UserData.userID;
            UserID = userID;
        }

        public void Insert()
        {
            try
            {
                OrderHeadTableAdapter orderHeadTable = new OrderHeadTableAdapter();
                orderHeadTable.Insert(UserID, long.Parse(Zip), Address, City, false);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public override string ToString()
        {
            string order = "";
            foreach (var orderRow in OrderRows)
            {
                order += orderRow + "\r\n";
            }
            return string.Format("Address: {0},\tCity: {1},\tZip: {2},\tOrder: {3}", Address, City, Zip, order);
        }
    }

    public class ApplicationUser
    {
    }
}