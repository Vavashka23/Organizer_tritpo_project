﻿using System;
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

        public void DeleteNote()
        {

        }

        public string DownloadNotes(string _login)
        {
            string request = string.Format("SELECT noteName FROM {0}", _login);

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string vs = "";

            while (sqlDataReader.Read())
            {
                vs += sqlDataReader["noteName"].ToString() + ",";
            }
            
            sqlDataReader.Close();

            connection.Close();

            return vs.Substring(0, vs.Length - 1);
        }
    }
}
