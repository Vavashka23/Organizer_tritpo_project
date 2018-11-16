using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Organizer
{
    class RestorePasswords
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public RestorePasswords()
        {
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnectionToDataBase()
        {
            connection.Open();
        }

        public string GetQuestion(string _login)
        {
            string request = string.Format("SELECT secretQuestion FROM users WHERE login='{0}'", _login);

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string str = "";

            while (sqlDataReader.Read())
            {
                str += sqlDataReader["secretQuestion"].ToString();
            }

            sqlDataReader.Close();

            return str;
        }

        public string GetAnswer(string _login)
        {
            string request = string.Format("SELECT answer FROM users WHERE login='{0}'", _login);

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string str = "";

            while (sqlDataReader.Read())
            {
                str += sqlDataReader["answer"].ToString();
            }

            sqlDataReader.Close();

            return str;
        }

        public string GetPassword(string _login)
        {
            string request = string.Format("SELECT password FROM users WHERE login='{0}'", _login);

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string str = "";

            while (sqlDataReader.Read())
            {
                str += sqlDataReader["password"].ToString();
            }

            sqlDataReader.Close();

            return str;
        }

        public void CloseConnectionToDataBase()
        {
            connection.Close();
        }
    }
}
