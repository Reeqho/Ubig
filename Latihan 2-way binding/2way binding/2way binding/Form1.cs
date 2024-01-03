using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_EF
{
    public partial class Form3 : Form
    {
        Ee
        int db;
       
        public Form3()
        {
            InitializeComponent();
        }

        // buat ngereset data
        public void CloseIndex()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            this.db = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = entities.departments.Where(f => f.deleted_at == null).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is department department)
            {
                if (e.ColumnIndex == delete.Index)
                {
                    department.deleted_at = DateTime.Now;
                    entities.Entry(department).State = EntityState.Modified;
                    if (entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("data sukses di delete");
                        bindingSource1.DataSource = entities.departments.Where(f => f.deleted_at == null).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Failed delete");
                    }
                    CloseIndex();
                }
                if (e.ColumnIndex == edit.Index)
                {
                    this.db = department.id;
                    textBox1.Text = department.name;
                    textBox2.Text = department.abbreviation;
                }

            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
       
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tidak Ada apa apa");
                return;
            }
            else
            {
                if (db == 0)
                {
                    department dp = new department()
                    {
                        name = textBox1.Text,
                        abbreviation = textBox2.Text,
                        created_at = DateTime.Now,
                    };
                    entities.departments.Add(dp);
                    if (entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("Data Sukses Di add");
                        bindingSource1.DataSource = entities.departments.Where(f => f.deleted_at == null).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Failed add data");
                    }
                    CloseIndex();
                }
                else
                {
                    var dpID = entities.departments.Find(db);
                    dpID.name = textBox1.Text;
                    dpID.abbreviation = textBox2.Text;
                    entities.Entry(dpID).State = EntityState.Modified;
                    if (entities.SaveChanges() > 0)
                    {
                        MessageBox.Show("Data Sukses Di Edit");
                        bindingSource1.DataSource = entities.departments.Where(f => f.deleted_at == null).ToList();
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed add data");
                    }
                    CloseIndex();

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CloseIndex();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Departemen_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
