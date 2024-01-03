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
    public partial class Form5 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
        public Form5()
        {
            InitializeComponent();
        }

        void Reset()
        {
            bindingSource1.DataSource = entities.HeroSkills.AsNoTracking().ToList();
            bindingSource4.DataSource = entities.Skills.ToList();
            bindingSource3.DataSource = entities.Heroes.ToList();

            bindingSource2.Clear();
            bindingSource2.AddNew();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is HeroSkill heroSkill)
            {
                if (e.ColumnIndex == hero_col.Index)
                {
                    e.Value = heroSkill.Hero.Name;
                }

                if (e.ColumnIndex == skill_col.Index)
                {
                    e.Value = heroSkill.Skill.Name;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is HeroSkill heros)
            {
                bindingSource2.DataSource = entities.HeroSkills.Where(h => h.ID == heros.ID).ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is HeroSkill heros)
            {
                entities.HeroSkills.AddOrUpdate(heros);
                entities.SaveChanges();
                Reset();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is HeroSkill heros)
            {
                entities.HeroSkills.Remove(entities.HeroSkills.FirstOrDefault(h => h.ID == heros.ID));
                entities.SaveChanges();
                Reset();
            }
        }
    }
}
