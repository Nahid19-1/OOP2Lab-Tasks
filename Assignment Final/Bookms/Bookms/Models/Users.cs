using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookms.Models
{
    class Users
    {
        SqlConnection conn;
        public Users() { }
        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }
    
        public User AuthhencateUser(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM User_i WHERE Username='{0}' AND Password= '{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetOrdinal("Password");
            }
            conn.Close();
            return user;
        }
    }
}
