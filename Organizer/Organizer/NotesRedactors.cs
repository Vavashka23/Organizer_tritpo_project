using System;
using System.Data.SqlClient;

namespace Organizer
{
    class NotesRedactors
    {
        private static string connectionString = @"Data Source = DESKTOP-HJR84CI\SADSADL;Initial Catalog = OrganizerDataBase; Integrated Security = True";
        private static SqlConnection connection;

        public NotesRedactors()
        {
            connection = new SqlConnection(connectionString);
        }

        public string CreateNewTable(string _tableName)
        {
            string request = string.Format("CREATE TABLE {0}(" +
                "noteID int AUTO_INCREMENT NOT NULL," +
                "noteName nvarchar (30) NOT NULL," +
                "noteDate datetime NOT NULL," +
                "noteDescription nvarchar (200)," +
                "notification int," +
                "PRIMARY KEY (noteID)" +
                ");", _tableName);
            try
            {

                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(request, connection))
                    sqlCommand.ExecuteNonQuery();

                return "oki";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
