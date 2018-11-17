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
    }
}
