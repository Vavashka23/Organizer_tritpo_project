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
        private UsersLogin usersLogin;

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
            if (loginTextBox.Text.Length >= 5 && passwordTextBox.Text.Length >= 8)
            {
                usersLogin = new UsersLogin();

                string login = this.loginTextBox.Text;
                string password = this.passwordTextBox.Text;

                usersLogin.OpenConnectionToDataBase();

                string truePassword = usersLogin.GetPasswordFromBase(login);

                usersLogin.CloseConnectionToDataBase();

                if (truePassword == password)
                {
                    //переход в главное окно
                }
                else {

                    passwordTextBox.Clear();
                    loginTextBox.Clear();

                    Random random = new Random();
                    errorLog.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    errorLog.Text = "Wrong password! Try again...";
                }
            }
            else
            {
                passwordTextBox.Clear();
                loginTextBox.Clear();

                Random random = new Random();
                errorLog.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                errorLog.Text = "Wrong input! Try again...";
            }
        }
    }
}