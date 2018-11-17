using System;
using System.Drawing;
using System.Windows.Forms;

namespace Organizer
{
    public partial class MainWindow : Form
    {
        private LoginWindow loginWindow;
        private NotesRedactor notesRedactor;
        private string userLogin;

        public MainWindow(LoginWindow login)
        {
            loginWindow = login;
            InitializeComponent();
            notesRedactor = new NotesRedactor();
        }

        public void GetInformation(string _login)
        {
            userLogin = _login;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.searchNotesButton.Enabled = true;
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            noteGroupBox.Visible = true;
            AddNoteButton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.okButton.Enabled = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            int notificationNum = this.notificationComboBox.SelectedIndex;
            DateTime date = dateTimePicker.Value;
            string[] noteInfo = new string[] { this.noteName.Text, this.descriptionTextBox.Text, date.ToString() };

            if (notificationNum == -1)
            {
                Random random = new Random();
                errorLabel.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                errorLabel.Text = "Choose notification!";
            } else
            {
                errorLabel.Text = "";
                notesRedactor.CreateNote(userLogin, noteInfo, notificationNum);
                this.listOfNotes.Items.Add(noteInfo[0]);
                noteGroupBox.Visible = false;
                AddNoteButton.Enabled = true;
                noteName.Clear();
                descriptionTextBox.Clear();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            noteGroupBox.Visible = false;
            AddNoteButton.Enabled = true;
            noteName.Clear();
            descriptionTextBox.Clear();
        }

        private void listOfNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.deleteNoteButton.Enabled = true;
            this.showNoteButton.Enabled = true;
            this.importantNoteButton.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string st = notesRedactor.DownloadNotes(userLogin);
            string[] str = st.Split(',');
            this.listOfNotes.Items.AddRange(str);
        }

        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            notesRedactor.DeleteNote(userLogin, this.listOfNotes.SelectedItem.ToString());
            this.listOfNotes.Items.Clear();
            string st = notesRedactor.DownloadNotes(userLogin);
            string[] str = st.Split(',');
            this.listOfNotes.Items.AddRange(str);
        }
    }
}
