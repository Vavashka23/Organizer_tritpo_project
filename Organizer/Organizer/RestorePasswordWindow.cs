using System;
using System.Drawing;
using System.Windows.Forms;

namespace Organizer
{
    public partial class RestorePasswordWindow : Form
    {

        private StartWindow startWindow;
        private RestorePasswords restorePasswords;

        public RestorePasswordWindow(StartWindow start)
        {
            startWindow = start;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.answerTextBox.Clear();
            this.errorLabel.Text = "";
            this.loginTextBox.Clear();
            this.questionLabel.Text = "";
            this.Hide();
            startWindow.Show();
        }

        private void RestorePasswordWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            restorePasswords = new RestorePasswords();

            if(this.questionLabel.Text.Length == 0)
            {
                string login = loginTextBox.Text;

                restorePasswords.OpenConnectionToDataBase();

                string secret = restorePasswords.GetQuestion(login);

                restorePasswords.CloseConnectionToDataBase();

                if(secret.Length == 0)
                {
                    Random random = new Random();
                    errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    errorLabel.Text = "Wrong login! Try again...";
                } else
                {
                    errorLabel.Text = "";
                    this.questionLabel.Text = secret;
                    this.answerTextBox.Enabled = true;
                }
            } else
            {
                if (answerTextBox.Text.Length > 0)
                {
                    string answer = this.answerTextBox.Text;
                    string login = loginTextBox.Text;

                    restorePasswords.OpenConnectionToDataBase();

                    string rightAnswer = restorePasswords.GetAnswer(login);
                    string myPassword = restorePasswords.GetPassword(login);

                    restorePasswords.CloseConnectionToDataBase();

                    if (rightAnswer == answer)
                    {
                        Random random = new Random();
                        errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        this.errorLabel.Text = string.Format("This is your PASSWORD: ***{0}***. Remember it!", myPassword);
                    }
                    else
                    {
                        answerTextBox.Clear();

                        Random random = new Random();
                        errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        errorLabel.Text = "Wrong answer! Try again...";
                    }
                }
                else
                {
                    Random random = new Random();
                    errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    errorLabel.Text = "Wrong input! Try again...";
                }
            }
            
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
        }
    }
}
