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
    public partial class Master_Inter : Form
    {
       
        HOV_HospitalEntities hos = new HOV_HospitalEntities();
        public Main_Form fm1;
        
        public Master_Inter()
        {
            
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Master_Inter_Load(object sender, EventArgs e)
        {

            bindingSource1.DataSource = hos.icd_11.ToList();
            listBox1.Enabled = true;
            

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (bindingSource1.Current is icd_11 ic)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Master_Doctor))
                    {
                        form.Activate();
                        return;
                    }
                }
                Master_Doctor fm = new Master_Doctor();
                fm.MdiParent = this.fm1;
                fm.id = ic.icd_11_doctor_recommendation.First().doctor_category.doctors.First().id;
                fm.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            
           
        }

        private void bindingSource3_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is icd_11 ic)
            {
                textBox1.Clear(); 
                listBox1.Items.Clear();
                var exc = ic.icd_11_exclusion.Where(f => f.icd_11_id == ic.id && f.deleted_at == null).ToList();
                foreach (var ex in exc)
                {
                    textBox1.Text = ic.description;
                    listBox1.Items.Add(ex.exclusion);
                }
                var doc_rec = hos.icd_11_doctor_recommendation.Where(f => f.icd_11_id == ic.id).First();
                var dr = doc_rec.doctor_category.doctors.ToList();
                foreach (var drs in dr)
                    
                {
                    linkLabel1.Text = drs.name;
                    
                }
            }
        }
    }
}
