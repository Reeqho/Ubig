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
    public partial class Form7 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
        public Form7()

        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = entities.Heroes.ToList();
            bindingSource2.DataSource = entities.Heroes.ToList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
           


        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Hero hs)
            {
                var heroskill = hs.HeroSkills.ToList();

                var skillid = heroskill.Select(f => f.SkillID).ToList();
                var skills = entities.Skills.Where(f => skillid.Contains(f.ID)).ToList();

                comboBox3.Text = "";
                if (skills != null)
                {
                    comboBox3.DataSource = skills;
                    comboBox3.DisplayMember = "Name";
                    comboBox3.ValueMember = "ID";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                var hs = entities.HeroSkills.Where(f => f.HeroID == (int)comboBox1.SelectedValue && f.SkillID == (int)comboBox2.SelectedValue).First();
                bindingSource3.DataSource = hs;
                textBox1.Text = String.Format("{0:#,0}", hs.Power);
            }
            else
            {
                bindingSource3.Clear();
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null)
            {
                var hs = entities.HeroSkills.Where(f => f.HeroID == (int)comboBox4.SelectedValue && f.SkillID == (int)comboBox3.SelectedValue).First();
                bindingSource4.DataSource = hs;
                textBox3.Text = String.Format("{0:#,0}", hs.Power);
            }
            else
            {
                bindingSource4.Clear();
                textBox3.Text = "";
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is HeroSkill hs)
            {
                if (e.ColumnIndex == heroIDDataGridViewTextBoxColumn.Index)
                {
                    e.Value = hs.Hero.Name;
                }
                if (e.ColumnIndex == skillIDDataGridViewTextBoxColumn.Index)
                {
                    e.Value = hs.Skill.Name;
                }
                if (e.ColumnIndex == powerDataGridViewTextBoxColumn.Index)
                {
                    e.Value = String.Format("{0:#,0}", hs.Power);
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is HeroSkill hs)
            {
                if (e.ColumnIndex == heroIDDataGridViewTextBoxColumn1.Index)
                {
                    e.Value = hs.Hero.Name;
                }
                if (e.ColumnIndex == skillIDDataGridViewTextBoxColumn1.Index)
                {
                    e.Value = hs.Skill.Name;
                }
                if (e.ColumnIndex == powerDataGridViewTextBoxColumn1.Index)
                {
                    e.Value = String.Format("{0:#,0}", hs.Power);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                var hero1 = Convert.ToDouble(textBox1.Text);
                var hero2 = Convert.ToDouble(textBox3.Text);
                if (hero1 == hero2)
                {
                    textBox2.Text = "Fair";
                }
                else if (hero1 > hero2)
                {
                    textBox2.Text = entities.Heroes.Where(f => f.ID == (int)comboBox1.SelectedValue).First().Name;
                }
                else
                {
                    textBox2.Text = entities.Heroes.Where(f => f.ID == (int)comboBox4.SelectedValue).First().Name;
                }
            }
            else
            {
                MessageBox.Show("Please Add Hero and Skill Before Fighting!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox2.Text != "")
            {
                FightHistory fh = new FightHistory
                {
                    Hero1ID = (int)comboBox1.SelectedValue,
                    Hero2ID = (int)comboBox4.SelectedValue,
                    Hero1TotalPower = Convert.ToDouble(textBox1.Text),
                    Hero2TotalPower = Convert.ToDouble(textBox3.Text),
                    FightDate = DateTime.Now,
                };
                entities.FightHistories.Add(fh);
                entities.SaveChanges();
                bindingSource3.Clear();
                bindingSource4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("Record Data Successfuly Saved");
            }
            else
            {
                MessageBox.Show("Theres No Record To Save!");
            }
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Hero hs)
            {
                var heroskill = hs.HeroSkills.ToList();

                var skillid = heroskill.Select(f => f.SkillID).ToList();
                var skills = entities.Skills.Where(f => skillid.Contains(f.ID)).ToList();

                comboBox2.Text = "";
                if (skills != null)
                {
                    comboBox2.DataSource = skills;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "ID";

                }
            }
        }

        private void bindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
