using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

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
            string request = string.Format("SELECT userName, dateOfBirth FROM users WHERE login='{0}'", _login);

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

            return vs.Substring(0, vs.Length - 9);
        }

        public void DownloadFoto(string _login, string filePath)
        {
            string sql = string.Format("UPDATE users SET avatar=@Foto WHERE login=@Login");

            connection.Open();

            SqlParameter sqlParameter = new SqlParameter("@Foto", SqlDbType.VarBinary);
            Image image = Image.FromFile(filePath);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            sqlParameter.Value = memoryStream.ToArray();

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.Add(sqlParameter);
                cmd.Parameters.AddWithValue("@Login", _login);

                cmd.ExecuteNonQuery();
            }

            connection.Close();

            memoryStream.Dispose();
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
    }
}