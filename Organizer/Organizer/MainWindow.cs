using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class MainWindow : Form
    {
        private LoginWindow loginWindow;
        private NotesRedactor notesRedactor;

        public MainWindow(LoginWindow login)
        {
            loginWindow = login;
            InitializeComponent();
            notesRedactor = new NotesRedactor();
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

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            noteGroupBox.Visible = false;
            AddNoteButton.Enabled = true;
            noteName.Clear();
            descriptionTextBox.Clear();
        }
    }
}
