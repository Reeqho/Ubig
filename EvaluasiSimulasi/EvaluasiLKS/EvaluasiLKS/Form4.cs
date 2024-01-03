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
    public partial class Form4 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities(); 
      
        public Form4()
        {
            InitializeComponent();

        }
        private void Reset()
        {
            bindingSource2.Clear();
            bindingSource2.AddNew();
            if (bindingSource2.Current is Skill skill)
            {
                skill.ElementID = comboBox1.SelectedValue as int?;
                skill.DifficultyLevel = comboBox2.SelectedValue as string;
            }
            bindingSource1.DataSource = entities.Skills.AsNoTracking().ToList();
           

            comboBox1.DataSource = entities.Elements.ToList();
            comboBox2.DataSource = new List<string> { "Easy", "Medium", "Hard", "Supreme" };
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Skill skill)
            {
                if(e.ColumnIndex == Element_col.Index)
                {
                    if (skill.ElementID == null)
                    {

                        e.Value = "Unknown";
                    }
                    else
                    {
                        e.Value = skill.Element.Element1;
                    }

                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Skill skill)
            {
                skill.ElementID = comboBox1.SelectedValue as int?;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = entities.Skills.Where(s => s.Name.Contains(textBox3.Text)).ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Skill skill)
            {
                bindingSource2.DataSource = entities.Skills.AsNoTracking().Where(s => s.ID == skill.ID).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Skill skill)
            {
                entities.Skills.Attach(skill);
                entities.Skills.Remove(skill);
                entities.SaveChanges();
                MessageBox.Show("Data Berhasil Di Delete");
                Reset();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Skill skill)
            {
                entities.Skills.AddOrUpdate(skill);
                entities.SaveChanges();
                Reset();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }
    }
 }
  

