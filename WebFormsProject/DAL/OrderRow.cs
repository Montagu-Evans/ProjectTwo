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

        public override string ToString()
        {
            return string.Format("{0}, {1}", ArticleID, Quantity);
        }
    }
}
