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

        public string GetPasswordFromBase(string _login)
        {
            string request = string.Format("SELECT password FROM users WHERE login='{0}'", _login);

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string str = "";

            while(sqlDataReader.Read())
            {
                str += sqlDataReader["password"].ToString();
            }
            
            sqlDataReader.Close();

            return str;
        }
    }
}
