using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MasterMember frm = new MasterMember();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void masterBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBook frm = new MasterBook();
            frm.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBorrowing frm = new NewBorrowing();
            frm.ShowDialog();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBorrowing frm = new AllBorrowing();
            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
    }
}
