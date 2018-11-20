using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Show
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public Show()
        {
            connection = new SqlConnection(connectionString);
        }

        public string GetInfo(string _login, string _name)
        {
            string request = string.Format("SELECT noteDescription, notification, noteDate FROM {0} WHERE noteName='{1}'", _login, _name); ;

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string vs = "";

            while (sqlDataReader.Read())
            {
                vs += sqlDataReader["noteDescription"].ToString() + ",";
                vs += sqlDataReader["notification"].ToString() + ",";
                vs += sqlDataReader["noteDate"].ToString() + ",";
            }

            sqlDataReader.Close();

            connection.Close();

            return vs.Substring(0, vs.Length - 9);
        }

        public void UploadInfo(string _login, string _name, string[] _str)
        {
            string sql = string.Format("UPDATE {0} SET noteName=@Name, noteDescription=@Descr, notification=@Noti, noteDate=@Date WHERE noteName=@Note", _login);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Name", _str[0]);
                cmd.Parameters.AddWithValue("@Descr", _str[1]);
                cmd.Parameters.AddWithValue("@Noti", _str[2]);
                cmd.Parameters.AddWithValue("@Date", _str[3]);
                cmd.Parameters.AddWithValue("@Note", _name);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}