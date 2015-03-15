using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.DataSetTableAdapters;
using DataSet = DAL; 

namespace DAL
{

    public class Order
    {
        public List<OrderRow> OrderRows { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }


        public Order(string address = "", string city="", string zip="", int userID=0)
        {
            OrderRows = new List<OrderRow>();
            Address = address;
            City = city;
            Zip = zip;
            UserID = userID;
        }

        public void Insert()
        {
            try
            {
                var orderHeadTable = new OrderHeadTableAdapter();
                orderHeadTable.Insert(UserID, long.Parse(Zip), Address, City, false);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public int GetOrderID()
        {
            using (var conn = DB.GetSqlConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT TOP 1 [OrderID] FROM [Clocks].[dbo].[OrderHead] ORDER BY OrderID DESC";
                    //command.Parameters.Add("userID", SqlDbType.Int).Value = UserData.userID;
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        OrderID = Load(reader);
                    }
                }
            }
            return OrderID;
        }

        public int Load(SqlDataReader reader)
        {
            var orderID = int.Parse(reader["OrderID"].ToString());
            return orderID;
        }

        public override string ToString()
        {
            var order = "";
            foreach (var orderRow in OrderRows)
            {
                order += orderRow + "\r\n";
            }
            return string.Format("Address: {0},\tCity: {1},\tZip: {2},\tOrder: {3}", Address, City, Zip, order);
        }
    }
}