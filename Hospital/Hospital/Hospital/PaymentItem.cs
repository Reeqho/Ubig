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
    public partial class PaymentItem : Form
    {
        Func<payment_detail, bool> callback;
        public PaymentItem(Func<payment_detail, bool> callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is payment_detail detail)
            {
                detail.created_at = DateTime.Now;
                callback(detail);
                Dispose();
            }
        }

        private void PaymentItem_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            bindingSource1.AddNew();
        }
    }
}
