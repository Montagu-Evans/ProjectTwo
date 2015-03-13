using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetTableAdapters;

namespace DAL
{
    public static class UserData
    {
          [ForeignKey("userID")]
        public static string userName;
        public static int userID;
        public static int Authenticate(string username, string password)
        {
            userName = username;
            UsersTableAdapter users = new UsersTableAdapter();
            var user = users.GetData(password, username);
          
            //users.Fill(table, password, username);
            //userID = int.Parse(id);
            return user.Count;
        }

        public static void GetUserID()
        {
            DataSet.UsersDataTable table = new DataSet.UsersDataTable();
            var id = table.Select(@" SELECT [UserID]
                                            FROM [Clocks].[dbo].[Users]
                                            where [Username] = @Username");
            userID = int.Parse(table.UserIDColumn.ColumnName);
//            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[@"Data Source=.\SQLEXPRESS;Initial Catalog=Clocks;Integrated Security=True"].ConnectionString);
//            con.Open();
//            SqlCommand cmd = new SqlCommand( @" SELECT [UserID]
//                                            FROM [Clocks].[dbo].[Users]
//                                            where [Username] = @Username", con);
//            cmd.Parameters.AddWithValue("@Username", userName);
//            SqlDataAdapter da = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            da.Fill(dt);
//            userID = cmd.ExecuteNonQuery();
//           // UsersTableAdapter users = new UsersTableAdapter();
        }
    }
}
