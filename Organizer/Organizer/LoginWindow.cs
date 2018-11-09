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
    public partial class LoginWindow : Form
    {
        private StartWindow startWindow;

        public LoginWindow(StartWindow start)
        {
            startWindow = start;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            startWindow.Visible = true;
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length >= 5 || passwordTextBox.Text.Length >= 8)
            {
               /* userReg = new UsersRegistration();
                string login = this.loginEnterBox.Text;
                string password = this.passwordEnterBox.Text;
                string secret = this.secretEnterBox.Text;
                string answer = this.answerEnterBox.Text;

                userReg.OpenConnectionToDataBase();

                userReg.InsertDataToBase(login, password, secret, answer);

                userReg.CloseConnectionToDataBase();

                loginEnterBox.Clear();
                passwordEnterBox.Clear();
                secretEnterBox.Clear();
                answerEnterBox.Clear();

                okForm.ShowDialog();

                this.Hide();
                startWindow.Show();*/
            }
            else
            {
                /*loginEnterBox.Clear();
                passwordEnterBox.Clear();
                secretEnterBox.Clear();
                answerEnterBox.Clear();
                Random random = new Random();
                errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                errorLabel.Text = "Wrong data input! Try again...";*/
            }
        }
    }
}