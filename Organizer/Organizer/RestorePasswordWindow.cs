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
    public partial class RestorePasswordWindow : Form
    {

        private StartWindow startWindow;

        public RestorePasswordWindow(StartWindow start)
        {
            startWindow = start;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();
        }

        private void RestorePasswordWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
