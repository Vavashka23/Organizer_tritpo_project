using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class StartWindow : Form
    {

        private LoginWindow loginWindow;
        private RegistrationWindow registrationWindow;

        public StartWindow()
        {
            InitializeComponent();
            loginWindow = new LoginWindow(this) { Visible = false };
            registrationWindow = new RegistrationWindow(this) { Visible = false };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginWindow.Visible = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            registrationWindow.Visible = true;
        }

        private void LoginWindow_FormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}