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
    public partial class Master_Doctor : Form

    {
        HOV_HospitalEntities hos = new HOV_HospitalEntities();
        
        public Master_Doctor()
        {

            InitializeComponent();
            this.id = id;

        }
        
        private void Master_Doctor_Load(object sender, EventArgs e)
        {

            var cate = hos.doctor_category.Where(f => f.deleted_at == null).ToList();
            bindingSource2.DataSource = cate;
            bindingSource1.DataSource = hos.doctors.Where(f => f.deleted_at == null).ToList();


            
            load();
            Refresh();

        }
        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is doctor_category category)
            {
                bindingSource1.DataSource = category.doctors.Where(d => d.deleted_at == null);
            }
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if(bindingSource1.Current is doctor doc)
            {
                textBox6.Text = doc.doctor_category.category;
            }
        }

      
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is doctor_category dc)
            {
                var doc = dc.doctors.ToList();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    bindingSource1.DataSource = doc;
                }
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bindingSource2.Current is doctor_category dc)
            {
                var doc = dc.doctors.ToList();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    bindingSource1.DataSource = doc;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        public int id
        {
            get;
            set;
        }
        private void load()
        {
            if (id != 0)
            {
                var doc = hos.doctors.Where(i => i.id == id).First();
                bindingSource1.DataSource = doc;
                Refresh();

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = hos.doctors.Where(i => i.name.Contains(textBox1.Text)).ToList();
            bindingSource1.DataSource = search;
        }

    }

    
   }
