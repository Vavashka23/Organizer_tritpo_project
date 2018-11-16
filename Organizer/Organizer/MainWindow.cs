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
    public partial class MainWindow : Form
    {
        private LoginWindow loginWindow;
        private NotesRedactors notesRedactors;

        public MainWindow(LoginWindow login)
        {
            loginWindow = login;
            InitializeComponent();
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
            notesRedactors = new NotesRedactors();

            string tableName = noteName.Text;

            string res = notesRedactors.CreateNewTable(tableName);

            descriptionTextBox.Text = res;
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
