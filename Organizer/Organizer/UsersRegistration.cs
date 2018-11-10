﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Organizer
{
    class UsersRegistration
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public UsersRegistration()
        {
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnectionToDataBase()
        {
            connection.Open();
        }

        public void InsertDataToBase(string _login, string _password, string _secret, string _answer)
        {
            // Оператор SQL
            string sql = string.Format("Insert Into users" +
                   "(login, password, secretQuestion, answer) Values(@Login, @Password, @Secret, @Answer)");

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                // Добавить параметры
                cmd.Parameters.AddWithValue("@Login", _login);
                cmd.Parameters.AddWithValue("@Password", _password);
                cmd.Parameters.AddWithValue("@Secret", _secret);
                cmd.Parameters.AddWithValue("@Answer", _answer);

                cmd.ExecuteNonQuery();
            }
        }

        public void CloseConnectionToDataBase()
        {
            connection.Close();
        }
    }
}