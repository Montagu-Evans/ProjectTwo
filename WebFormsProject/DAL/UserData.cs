using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static int Authenticate(string username, string password)
        {
            userName = username;
            UsersTableAdapter users = new UsersTableAdapter();
            var user = users.GetData(password, username);
            return user.Count;
        }
    }
}
