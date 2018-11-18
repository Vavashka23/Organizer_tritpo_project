using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Settings
    {
        private static SqlConnection connection;
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";

        public Settings()
        {
            connection = new SqlConnection(connectionString);
        }

        public void ChangeName(string _name, string _login, string _date)
        {
            string sql = string.Format("UPDATE users SET userName=@Name, dateOfBirth=@Date WHERE login=@Login");

            connection.Open();

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Name", _name);
                cmd.Parameters.AddWithValue("@Date", _date);
                cmd.Parameters.AddWithValue("@Login", _login);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public string DownloadInfo(string _login)
        {
            string request = string.Format("SELECT userName, dateOfBirth FROM users WHERE login={0}", _login);

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string vs = "";

            while (sqlDataReader.Read())
            {
                vs += sqlDataReader["userName"].ToString() + ",";
                vs += sqlDataReader["dateOfBirth"].ToString() + ",";
            }

            sqlDataReader.Close();

            connection.Close();

            return vs;
        }
    }
}
