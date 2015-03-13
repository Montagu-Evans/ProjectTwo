using System;
using System.Collections.Generic;
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
        public static string userName;
        public static int userID;
        public static int Authenticate(string username, string password)
        {
            userName = username;
            UsersTableAdapter users = new UsersTableAdapter();
            var user = users.GetData(password, username);
            return user.Count;
        }

        public static void GetUserID()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.ClocksConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand( @" SELECT [UserID]
                                            FROM [Clocks].[dbo].[Users]
                                            where [Username] = @Username", con);
            cmd.Parameters.AddWithValue("@Username", userName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            userID = cmd.ExecuteNonQuery();
           // UsersTableAdapter users = new UsersTableAdapter();
        }
    }
}
