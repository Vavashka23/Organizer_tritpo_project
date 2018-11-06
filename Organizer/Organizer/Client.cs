using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Organizer
{
    class Client
    {
        private static string connectionToDataBase = "server=localhost;user id=Vavashka23;database=oranizerdatabase;password=Nutria231298";
        MySqlConnection connection = new MySqlConnection(connectionToDataBase);

        public void openC() {
            connection.Open();
        }

        public void closeC() {
            connection.Close();
        }

        public DataTable getResp() {

            string request = "SELECT * FROM users";
            
            DataTable dt = new DataTable();

            MySqlDataAdapter mySqlData = new MySqlDataAdapter(request, connection);

            mySqlData.Fill(dt);
            return dt;
        }
    }
}
