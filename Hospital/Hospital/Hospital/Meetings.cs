using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace Hospital
{
    public partial class Meetings : Form
    {
        HOV_HospitalEntities hov = new HOV_HospitalEntities();
        public Main_Form fm1;
        public Meetings()
        {
            InitializeComponent();
        }

        private void Meetings_Load(object sender, EventArgs e)
        {

            load();
            bindingSource4.Clear();
            bindingSource4.AddNew();
           
            dateTimePicker1_ValueChanged(sender, e);

            bindingSource3.DataSource = hov.doctor_category.Where(f => f.deleted_at == null).ToList();
            bindingSource2.DataSource = hov.patients.Where(f => f.deleted_at == null).ToList();
            bindingSource1.DataSource = hov.doctors.Where(f => f.deleted_at == null).ToList();


            AutoCompleteStringCollection dc = new AutoCompleteStringCollection();
            foreach (patient p in bindingSource2.DataSource as List<patient>)
                dc.Add(p.name);
            textBox1.AutoCompleteCustomSource = dc;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bindingSource1.Current is doctor ic)
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
                fm.id = ic.id;
                fm.ShowDialog();
            }
            

        }

        private void bindingSource3_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource3.Current is doctor_category category)
            {
                bindingSource1.DataSource = category.doctors.Where(d => d.deleted_at == null).ToList();
            }
            load();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is doctor dc)
            {
                if (bindingSource4.Current is meeting met)
                {
                    met.doctor_id = dc.id;
                    met.room = dc.assigned_room;
                }
            }

            if (bindingSource1.Current is doctor_category doc)
            {
               


                var doc_name = hov.doctors.Where(f => f.doctor_category_id == doc.id && f.deleted_at == null ).FirstOrDefault();
                var dm = doc_name.doctor_category.doctors.ToList();
                


                foreach (var ds in dm)  
                {
                    linkLabel3.Text = ds.name;
                }

            }
            load();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is patient patient)
                if (bindingSource4.Current is meeting meet)
                    meet.patient_id = patient.id;

                
            {
                var pat = hov.patients.Where(f => f.name == textBox1.Text && f.deleted_at == null).ToList();
                foreach (var nm in pat)
                {
                    linkLabel1.Text = nm.name;
                    linkLabel1.Text = "View Patient Data";
                }
            }
            load();
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bindingSource2.Current is patient patient)
               
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Master_Patient))
                    {
                        form.Activate();
                        return;
                    }
                }
                Master_Patient fm = new Master_Patient();
                fm.MdiParent = this.fm1;
                fm.name = patient.name;
                fm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource4.Current is meeting meet)
            {

                meet.created_at = DateTime.Now;
                hov.meetings.Add(meet);
                hov.SaveChanges();
                



                load();
                
            }
        }

        private void bindingSource4_CurrentChanged(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            if (bindingSource4.Current is meeting met)
            {
                if (met.doctor_id != default && met.patient_id != default && met.room != default && met.date != default)
                {
                    met.queue_number = hov.meetings.Where(mets => mets.doctor_id == met.doctor_id &&
                    DbFunctions.TruncateTime(mets.date) == met.date.Date).Count() + 1;

                    label7.Text = met.queue_number.ToString("00");

                    if (hov.meetings.Where(mets => mets.patient_id == met.patient_id
                    &&
                    DbFunctions.TruncateTime(mets.date) == met.date.Date).Count() == 0)
                    {
                        return;
                    }
                }
            }
            return;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (bindingSource4.Current is meeting meet)
                meet.date = dateTimePicker1.Value;


            load();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (bindingSource2.Current is patient pat)
            {

                var form = new PatientRecord();
                form.setId(pat.id);
                form.ShowDialog();
            }
        }
        }
    }
