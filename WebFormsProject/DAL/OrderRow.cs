using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRow
    {
        public int ArticleID { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public OrderRow(string productName="", decimal price=0, int articleID=0, int quantity=0)
        {
            ProductName = productName;
            Price = price;
            ArticleID = articleID;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", ArticleID, Quantity, ProductName, Price);
        }
    }
}
