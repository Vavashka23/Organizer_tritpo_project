using System;
using System.Windows.Forms;

namespace Organizer
{
    public partial class SettingsWindow : Form
    {
        private MainWindow mainWindow;

        public SettingsWindow(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
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
        }
    }
}
