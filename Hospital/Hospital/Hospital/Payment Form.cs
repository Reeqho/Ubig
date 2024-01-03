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
    public partial class Payment_Form : Form
    {
        readonly HOV_HospitalEntities hos = new HOV_HospitalEntities();
        meeting meet    ;
        public Payment_Form()
        {
            InitializeComponent();
        }

        public static bool pay(string ccNumber)
        {
            int sum = 0;
            bool alternate = false;
            for (int i = ccNumber.Length - 1; i >= 0; i--)
            {
                char[] nx = ccNumber.ToArray();
                int n = int.Parse(nx[i].ToString());

                if (alternate)
                {
                    n *= 2;

                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }

        void Validation()
        {
            if (string.IsNullOrEmpty(holderBox.Text) || string.IsNullOrEmpty(numberBox.Text))
            {
                submitbtn.Enabled = false;
                return;
            }

            if (serviceBox.Text.Length != 3)
            {
                submitbtn.Enabled = false;
                return;
            }

            if (!pay(numberBox.Text))
            {
                submitbtn.Enabled = false;
                return;
            }


            submitbtn.Enabled = true;
            return;
        }
        void IsEnable(bool enable)
        {
            dataGridView1.Enabled = enable;
            button1.Enabled = enable;
            holderBox.Enabled = enable;
            numberBox.Enabled = enable;
            serviceBox.Enabled = enable;
            submitbtn.Enabled = enable;
        }

        void load()
        {
            if (hos.payments.Where(pays => pays.meeting_id == meet.id && pays.deleted_at == null).Count() > 0)
            {
                bindingSource1.DataSource = hos.payments.FirstOrDefault(pays => pays.meeting_id == meet.id && pays.deleted_at == null);
                if (bindingSource1.Current is payment pals) bindingSource2.DataSource = pals.payment_detail.ToList();
                IsEnable(false);
                return;
            }


            bindingSource1.AddNew();
            if (bindingSource1.Current is payment pay)
            {
                pay.expiration_date = DateTime.Now.AddYears(5);
                pay.meeting_id = meet.id;
            }
            serviceBox.Text = "";
            Validation();
        }

        public void SetId(int id)
        {
            meet = hos.meetings.FirstOrDefault(met => met.id == id && met.deleted_at == null);
            load();
        }

        bool AddItemCallback(payment_detail detail)
        {
            bindingSource2.Add(detail);
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentItem itemfrm = new PaymentItem(AddItemCallback);
            itemfrm.ShowDialog();
        }

        private void bindingSource2_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bindingSource1.Current is payment pay)
            {
                decimal mon = 0;
                foreach (payment_detail deb in bindingSource2.List)
                {
                    mon += deb.nominal;
                }
                pay.total_payment = mon;
                totalBox.Text = pay.total_payment.ToString();
                Validation();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is payment_detail detail)
            {
                if (e.ColumnIndex == btn_delete.Index)
                {
                    bindingSource2.Remove(detail);
                    Validation();
                }
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is payment pay)
            {
                pay.created_at = DateTime.Now;
                hos.payments.Add(pay);
                foreach(payment_detail detail in bindingSource2.List)
                {
                    detail.created_at = DateTime.Now;
                    hos.payment_detail.Add(detail);
                }

                hos.SaveChanges();
                Close();
            }
        }

        private void holderBox_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void serviceBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Validation();
        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
