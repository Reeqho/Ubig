using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Main_Form : Form
    {
        HOV_HospitalEntities Hos = new HOV_HospitalEntities();
        
        public Main_Form()
        {
            InitializeComponent();

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void iCD11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Master_Inter bf = new Master_Inter();
            bf.MdiParent = this;
            bf.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Master_Patient dd = new Master_Patient();
            dd.MdiParent = this;
            dd.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Master_Doctor dd = new Master_Doctor();
            dd.MdiParent = this;
            dd.Show();
        }

        private void newMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Meetings dd = new Meetings();
            dd.MdiParent = this;
            dd.Show();
        }

        private void meetingNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Form_Meeting dd = new Form_Meeting();
            dd.MdiParent = this;
            dd.Show();
        }
    }
}
