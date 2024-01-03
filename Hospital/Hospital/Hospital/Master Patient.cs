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
    public partial class Master_Patient : Form
    {
        HOV_HospitalEntities hos = new HOV_HospitalEntities();
        public Master_Patient()
        {
            InitializeComponent();
            this.name = name;
        }

        private void Master_Patient_Load(object sender, EventArgs e)
        {

            bindingSource1.DataSource = hos.patients.Where(d => d.deleted_at == null).ToList();

            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = hos.patients.Where(i => i.name.Contains(textBox1.Text)).ToList();
            bindingSource1.DataSource = search;
        }

        public string name
        {
            get;
            set;
        }

        private void load()
        {
            if (name != null)
            {
                var doc = hos.patients.Where(i => i.name == name).ToList();
                bindingSource1.DataSource = doc;


            }

        }
    }
}
