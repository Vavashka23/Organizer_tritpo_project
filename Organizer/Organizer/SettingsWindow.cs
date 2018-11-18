using System;
using System.Drawing;
using System.Windows.Forms;

namespace Organizer
{
    public partial class SettingsWindow : Form
    {
        private MainWindow mainWindow;
        private Settings settings;
        private string login;
        private string fotoPath;

        public SettingsWindow(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
            settings = new Settings();
        }

        public void GetLogin(string _login)
        {
            login = _login;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.saveChangesButton.Enabled = true;
        }

        private void SettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainWindow.Show();
            this.nameTextBox.Clear();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Length > 3 && this.dateTimePicker1.Value != DateTime.Now)
            {
                string newName = this.nameTextBox.Text;
                string date = this.dateTimePicker1.Value.ToString();

                settings.ChangeName(newName, login, date);

                this.nameTextBox.Clear();
                this.thisNameLabel.Text = "Текущее имя: " + newName;
                this.thisDateLabel.Text = "Текущая дата рождения: " + date.Substring(0, date.Length - 8);
            }
            else
            {
                Random random = new Random();
                errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                errorLabel.Text = "Wrong input! Try again...";
            }
        }
        
        private void UploadFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Изображения(*.jpg)|*.jpg" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                fotoPath = openFileDialog1.FileName;

            settings.DownloadFoto(login, fotoPath);

            avatarBox.Image = settings.GetFoto(login);
        }

        private void avatarBox_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void SettingsWindow_Shown(object sender, EventArgs e)
        {
            string st = settings.DownloadInfo(login);
            string[] str = st.Split(',');
            this.thisNameLabel.Text = "Текущее имя: " + str[0];
            this.thisDateLabel.Text = "Текущая дата рождения: " + str[1];

            Image image = settings.GetFoto(login);
            if (image != null)
                this.avatarBox.Image = image;
        }
    }
}
