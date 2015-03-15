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
        public static string userName;
        public static int userID;
        public static int Authenticate(string username, string password)
        {
            userName = username;
            var users = new UsersTableAdapter();
            var user = users.GetData(password, username);
            userID = 0;

            using (var conn = DB.GetSqlConnection())
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"SELECT  [UserID] FROM [Clocks].[dbo].[Users] WHERE [Username] = @username AND [Password] = @password";
                    command.Parameters.Add("username", SqlDbType.NVarChar, 50).Value = username;
                    command.Parameters.Add("password", SqlDbType.NVarChar, 20).Value = password;
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        userID = Load(reader);
                    }
                }
            }
            return userID;
        }

        public static int Load(SqlDataReader reader)
        {
            var UserID = int.Parse(reader["UserID"].ToString());
            return UserID;
        }
    }
}
