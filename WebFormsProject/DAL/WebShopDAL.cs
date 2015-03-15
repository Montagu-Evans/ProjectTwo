using System.Data;
using System.Data.SqlClient;
using DAL.DataSetTableAdapters;

namespace DAL
{
    public class WebShopDAL
    {
        public void AddorderToDB(Order order)
        {
            var adapter = new OrderRowTableAdapter();
            foreach (var orderRow in order.OrderRows)
            {
                adapter.Insert(order.OrderID, orderRow.Quantity, orderRow.ArticleID);
            }
        }

        public int GetArticleID(string product)
        {
            var articleID = 0;
            using (var conn = DB.GetSqlConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT [ArticleID] FROM [Clocks].[dbo].[Articles] WHERE Text = @text";
                    command.Parameters.Add("Text", SqlDbType.NVarChar, 255).Value = product;
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        articleID = Load(reader); // tar ut artikelID
                    }
                }
            }
            return articleID;
        }
        public int Load(SqlDataReader reader)
        {
            var articleID = int.Parse(reader["ArticleID"].ToString());
            return articleID;
        }
    }
}
