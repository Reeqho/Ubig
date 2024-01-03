using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluasiLKS
{
    public partial class Form8 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = entities.FightHistories.ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is FightHistory fh)
            {
                if (e.ColumnIndex == hero1IDDataGridViewTextBoxColumn.Index)
                {
                    e.Value = entities.Heroes.Where(f => f.ID == fh.Hero1ID).First().Name;
                }
                if (e.ColumnIndex == hero2IDDataGridViewTextBoxColumn.Index)
                {
                    e.Value = entities.Heroes.Where(f => f.ID == fh.Hero2ID).First().Name;
                }
                if (e.ColumnIndex == hero1TotalPowerDataGridViewTextBoxColumn.Index)
                {
                    e.Value = String.Format("{0:#,0}", fh.Hero1TotalPower);
                }
                if (e.ColumnIndex == hero2TotalPowerDataGridViewTextBoxColumn.Index)
                {
                    e.Value = String.Format("{0:#,0}", fh.Hero2TotalPower);
                }
                if (e.ColumnIndex == fightDateDataGridViewTextBoxColumn.Index)
                {
                    e.Value = fh.FightDate.ToString("dd MMM yyyy");
                }
            }
        }
    }
}
