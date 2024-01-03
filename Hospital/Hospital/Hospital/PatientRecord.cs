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
    public partial class PatientRecord : Form
    {
        HOV_HospitalEntities hos = new HOV_HospitalEntities();
        public PatientRecord()
        {
            InitializeComponent();
        }

        public void setId(int id)
        {
            titleBox.Text = "Medical Record of " + hos.patients.FirstOrDefault(pat => pat.id == id).name;
            bindingSource1.DataSource = hos.patient_record.Where(rec => rec.patient_id == id && rec.deleted_at == null).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is patient_record rec)
            {
                if (e.ColumnIndex == doc_name.Index)
                {
                    e.Value = rec.meeting.doctor.name;
                }


                if (e.ColumnIndex == doc_category.Index)
                {
                    e.Value = rec.meeting.doctor.doctor_category.category;
                }
            }
        }
    }
}
