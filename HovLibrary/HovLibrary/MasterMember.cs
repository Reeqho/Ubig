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
    public partial class MasterMember : Form
    {
        HovLibraryEntities entities = new HovLibraryEntities();
        int id;
        public MasterMember()
        {
            
            InitializeComponent();

        }

        private void MasterMember_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bindingSource1.DataSource = entities.Members.Where(f => f.deleted_at == null).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Member mem)
            {
                if (e.ColumnIndex == edit_btn.Index)
                {
                    this.id = mem.id;
                    textBox1.Text = mem.name;
                    textBox2.Text = mem.phone_number;
                    textBox3.Text = mem.email;
                    textBox4.Text = mem.address;
                    textBox5.Text = mem.city_of_birth;
                    dateTimePicker1.Value = mem.date_of_birth;

                    if (mem.gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (mem.gender == "Female")
                    {
                        radioButton2.Checked = true;
                    }
                }
            }
        }

        private void ClearForm()
        {
            // Kosongkan elemen-elemen UI
            this.id = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.id > 0)
            {
                Member anggota = entities.Members.FirstOrDefault(m => m.id == this.id);
                if (anggota != null)
                {
                    anggota.name = textBox1.Text;
                    anggota.phone_number = textBox2.Text;
                    anggota.email = textBox3.Text;
                    anggota.address = textBox4.Text;
                    anggota.city_of_birth = textBox5.Text;
                    anggota.date_of_birth = dateTimePicker1.Value;
                    anggota.gender = radioButton1.Checked ? "Male" : 
                        (radioButton2.Checked ? "Female" : null);
                    entities.SaveChanges();
                    bindingSource1.DataSource = entities.Members.Where(f => f.deleted_at == null).ToList();
                    ClearForm();
                }
            }
        }
    }
}
