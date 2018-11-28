using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

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
                cmd.Parameters.AddWithValue("@Name", info[0]);
                cmd.Parameters.AddWithValue("@Date", info[2]);
                cmd.Parameters.AddWithValue("@Descr", info[1]);
                cmd.Parameters.AddWithValue("@Noti", num);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void DeleteNote(string _login, string _note)
        {
            string request = string.Format("DELETE FROM {0} WHERE noteName=@noteName", _login);

            connection.Open();

            using (SqlCommand cmd = new SqlCommand(request, connection))
            {
                cmd.Parameters.AddWithValue("@noteName", _note);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
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

        public string GetName(string _login)
        {
            string request = string.Format("SELECT userName FROM users WHERE login='{0}'", _login); ;

            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(request, connection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            string vs = "";

            while (sqlDataReader.Read())
            {
                vs += sqlDataReader["userName"].ToString();
            }

            sqlDataReader.Close();

            connection.Close();

            return vs;
        }

        public Image GetFoto(string _login)
        {
            string request = string.Format("SELECT avatar FROM users WHERE login='{0}'", _login);

            SqlCommand sqlCommand = new SqlCommand(request, connection);
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                MemoryStream memoryStream = new MemoryStream();
                foreach (DbDataRecord record in sqlDataReader)
                    memoryStream.Write((byte[])record["avatar"], 0, ((byte[])record["avatar"]).Length);
                Image image = Image.FromStream(memoryStream);

                memoryStream.Dispose();
                connection.Close();
                return image;
            }
            return null;
        }

        public string[] Search(string[] _list, string _word)
        {
            string newListString = "";
            foreach (var s in _list)
                if (s.Contains(_word))
                    newListString += s + ",";
            newListString.Substring(0, newListString.Length - 1);
            return newListString.Split(',');
        }
    }
}
