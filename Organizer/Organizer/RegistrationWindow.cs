using System;
using System.Drawing;
using System.Windows.Forms;

namespace Organizer
{
    public partial class RegistrationWindow : Form
    {

        private StartWindow startWindow;
        private UsersRegistration userReg;
        private OkForm okForm;

        public RegistrationWindow(StartWindow start)
        {
            startWindow = start;
            InitializeComponent();
            this.okForm = new OkForm(this) { Visible = false };
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();
        }

        private void RegistrationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (loginEnterBox.Text.Length >= 5 && passwordEnterBox.Text.Length >= 8 && secretEnterBox.Text.Length >= 5 && answerEnterBox.Text.Length >= 4)
            {
                userReg = new UsersRegistration();
                string login = this.loginEnterBox.Text;
                string password = this.passwordEnterBox.Text;
                string secret = this.secretEnterBox.Text;
                string answer = this.answerEnterBox.Text;

                userReg.OpenConnectionToDataBase();

                userReg.InsertDataToBase(login, password, secret, answer);
                userReg.CreateNewTable(login);
                userReg.CreateHistoryTable(login);

                userReg.CloseConnectionToDataBase();

                loginEnterBox.Clear();
                passwordEnterBox.Clear();
                secretEnterBox.Clear();
                answerEnterBox.Clear();

                okForm.ShowDialog();
                this.Hide();
                startWindow.Show();
            }
            else
            {
                loginEnterBox.Clear();
                passwordEnterBox.Clear();
                secretEnterBox.Clear();
                answerEnterBox.Clear();
                Random random = new Random();
                errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                errorLabel.Text = "Wrong data input! Try again...";
            }

        }
    }
}
