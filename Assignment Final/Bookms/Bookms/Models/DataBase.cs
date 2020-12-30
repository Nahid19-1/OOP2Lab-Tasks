using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookms.Models
{
    class DataBase
    {
        public Users Users { get; set; }
        public Books Books { get; set; }

        public DataBase()
        {
            string connString = "Server=DESKTOP-KGLG4FI;Integrated Security=true;Database=BookMS";
            SqlConnection conn = new SqlConnection(connString);

            Users = new Users(conn);
            Books = new Books(conn);
        }
    }
}
