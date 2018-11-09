using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Organizer
{
    class UsersLogin
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public UsersLogin()
        {
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnectionToDataBase()
        {
            connection.Open();
        }

        public void CloseConnectionToDataBase()
        {
            connection.Close();
        }



        /*public string ShowDataBase()
        {
            string request = "SELECT name FROM users";

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string str = "";

            while (sqlDataReader.Read())
            {
                str += sqlDataReader["name"].ToString();
            }

            sqlDataReader.Close();

            connection.Close();

            return str;
        }*/
    }
}
