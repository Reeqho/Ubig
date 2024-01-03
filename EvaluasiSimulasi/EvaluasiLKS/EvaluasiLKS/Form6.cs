using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluasiLKS
{
    public partial class Form6 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
        public Form6()
        {
            InitializeComponent();
        }

        void Reset()
        {
            bindingSource1.DataSource = entities.Heroes.AsNoTracking().ToList();
            bindingSource3.DataSource = entities.Clans.ToList();
            bindingSource4.DataSource = entities.Clans.ToList();

            bindingSource2.Clear();
            bindingSource2.AddNew();
            if (bindingSource2.Current is Hero hero && bindingSource4.Current is Clan clan)
            {
                hero.BirthDate = dateTimePicker1.Value;
                hero.ClanID = clan.ID;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Hero hero)
            {
                bindingSource2.DataSource = entities.Heroes.Where(f => f.ID == hero.ID).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Hero hero)
            {
                entities.Heroes.AddOrUpdate(hero);
                entities.SaveChanges();
                Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Hero hero)
            {
                entities.Heroes.Attach(entities.Heroes.FirstOrDefault(f => f.ID == hero.ID));
                entities.Heroes.Remove(entities.Heroes.FirstOrDefault(f => f.ID == hero.ID));
                entities.SaveChanges();
                Reset();
                MessageBox.Show("Data Berhasil Di Delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bindingSource3.Current is Clan clan)
            {
                bindingSource1.DataSource = clan.Heroes;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Hero hero)
            {
                if (e.ColumnIndex == clan_column.Index)
                {
                    if (hero.ClanID == null)
                        e.Value = "Unknown";
                    else
                        e.Value = hero.Clan.Name;
                }

                if (e.ColumnIndex == date_column.Index)
                {
                    e.Value = hero.BirthDate.ToString("dd MMM yyyy");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }
    }
}
