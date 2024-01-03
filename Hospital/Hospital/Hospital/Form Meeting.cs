using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Hospital
{
    public partial class Form_Meeting : Form
    {
        HOV_HospitalEntities hos = new HOV_HospitalEntities();
        public Form_Meeting()
        {
            InitializeComponent();
        }

        private void Form_Meeting_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = hos.meetings.Where(f => f.deleted_at == null).ToList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is meeting meet)
                bindingSource2.DataSource = meet.patient_record.Where(rec => rec.deleted_at == null).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is meeting met)
            {
                if (e.ColumnIndex == patient_col.Index) e.Value = met.patient.name;
                if (e.ColumnIndex == category_col.Index) e.Value = met.doctor.doctor_category.category;
                if (e.ColumnIndex == doctor_col.Index) e.Value = met.doctor.name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string record = Interaction.InputBox("Add new Record", "Record");
            if (string.IsNullOrEmpty(record)) return;
            if (bindingSource1.Current is meeting meet)
            {
                patient_record rec = new patient_record
                {
                    patient_id = meet.id,
                    meeting_id = meet.id,
                    notes = record,
                    date = meet.date,
                    created_at = DateTime.Now,
                };


                hos.patient_record.Add(rec);
                hos.SaveChanges();
                Form_Meeting_Load(sender, e);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is meeting meet)
            {
                if (e.ColumnIndex == payment_btn.Index)
                {
                    var frm = new Payment_Form();
                    frm.SetId(meet.id);
                    frm.ShowDialog();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is patient_record rec)
            {
                if (e.ColumnIndex == edit_btn.Index)
                {
                    string record = Interaction.InputBox("Edit Record", "Record", rec.notes);
                    if (string.IsNullOrEmpty(record)) return;

                    rec.notes = record;
                    hos.SaveChanges();
                    Form_Meeting_Load(sender, e);
                }
            }
        }
    }
}
