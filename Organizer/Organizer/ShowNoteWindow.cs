using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class ShowNoteWindow : Form
    {
        private MainWindow mainWindow;
        private string login;
        private string name;
        private Show show;

        public ShowNoteWindow(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
            show = new Show();
        }

        public void GetLogin(string _login)
        {
            login = _login;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.nameBox.Clear();
            this.descriptionBox.Clear();
            this.Hide();
            mainWindow.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string[] str = { this.nameBox.Text, this.descriptionBox.Text, this.notificationBox.SelectedIndex.ToString(), this.dateTimePicker.Value.ToString()};
            show.UploadInfo(login, name, str);
            name = nameBox.Text;
            this.nameBox.Clear();
            this.descriptionBox.Clear();
            this.Hide();
            mainWindow.Show();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            string info = show.GetInfo(login, name);
            string[] str = info.Split(',');
            this.nameBox.Text = name;
            this.descriptionBox.Text = str[0];
            int i = int.Parse(str[1]);
            this.notificationBox.Text = this.notificationBox.Items[i].ToString();
            this.dateTimePicker.Value = DateTime.Parse(str[2]);
            this.okButton.Enabled = true;
        }

        private void ShowNoteWindow_VisibleChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = false;
        }
    }
}
