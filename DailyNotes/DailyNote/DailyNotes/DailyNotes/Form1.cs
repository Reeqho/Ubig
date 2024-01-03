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

namespace DailyNotes
{
    public partial class Form1 : Form
    {
        bool is_edit = false;
        DailyNotesEntities daily = new DailyNotesEntities();
        public Form1()
        {
            InitializeComponent();

        }
        public void Reset()
        {
            bindingSource1.Clear();
            bindingSource1.AddNew();
            flowLayoutPanel1.Controls.Clear();
            foreach (Catatan notes in daily.Catatans.OrderBy(x => x.date))
            {

                flowLayoutPanel1.Controls.Add(new ListItem(notes, () => Delete(notes), () => Edit(notes)));
            }
            button1.Text = "Add";
            button2.Visible = false;

        }

        public void Delete(Catatan Catatans)
            
        {
            daily.Catatans.Remove(Catatans);
            daily.SaveChanges();
            Reset();
        }

        
        public void Edit(Catatan Catatans)

        {
            bindingSource1.Clear();
            bindingSource1.Add(Catatans);
            is_edit = true;
            button1.Text = "Save";
            button2.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Catatan notes)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("harap isi terlebih dahulu");
                    return;
                }


                if (notes.date == default(DateTime)) notes.date = DateTime.Now;

                daily.Catatans.AddOrUpdate(notes);
                daily.SaveChanges();
                Form1_Load(sender, e);

                button2.Visible = false;
                is_edit = false;
            }
        }

       







        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (is_edit)
            {
                Reset();
                button2.Visible = false;
                is_edit = true;
            }
        }
    }
}
