using System;
using System.Data.SqlClient;

namespace Organizer
{
    class NotesRedactor
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public NotesRedactor()
        {
            connection = new SqlConnection(connectionString);
        }

        public void CreateNote(string _login, string[] info, int num)
        {
            string sql = string.Format("Insert Into {0}" +
                   "(noteName, noteDate, noteDescription, notification) Values(@Name, @Date, @Descr, @Noti)", _login);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Name", info[0]);
                cmd.Parameters.AddWithValue("@Date", info[2]);
                cmd.Parameters.AddWithValue("@Descr", info[1]);
                cmd.Parameters.AddWithValue("@Noti", num);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
