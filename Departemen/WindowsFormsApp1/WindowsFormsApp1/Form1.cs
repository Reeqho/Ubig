using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_EF
{
    public partial class Form3 : Form
    {
        EsemkaCorporationEntities entities = new EsemkaCorporationEntities();

        department depart;


        public Form3()
        {
            InitializeComponent();

            bindingSource1.DataSource = depart;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is department depart)
            {
                if (e.ColumnIndex == name.Index)
                {
                    e.Value = name;
                }
            }
        }
    }
}
