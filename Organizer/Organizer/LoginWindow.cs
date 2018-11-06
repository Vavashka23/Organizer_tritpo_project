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
            DataTable dt = new DataTable();
            Client cl = new Client();
            cl.openC();
            dt = cl.getResp();
            this.dataGridView1.DataSource = dt;

            cl.closeC();
        }
    }
}
