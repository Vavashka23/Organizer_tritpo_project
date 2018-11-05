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
    public partial class StartWindow : Form
    {

        private LoginWindow loginWindow;

        public StartWindow()
        {
            InitializeComponent();
            loginWindow = new LoginWindow(this) { Visible = false };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginWindow.Visible = true;
        }

        private void LoginWindow_FormClose(object sender, FormClosedEventArgs e)
        {
            loginWindow.Close();
            this.Close();
        }
    }
}