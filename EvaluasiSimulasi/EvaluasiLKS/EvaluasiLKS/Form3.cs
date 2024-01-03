using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace EvaluasiLKS
{
    public partial class Form3 : Form
    {
        EsemkaHeroEntities enti = new EsemkaHeroEntities();
        public Form3()
        {
            InitializeComponent();
        }


        private void Reset()
        {
            bindingSource1.DataSource = enti.Elements.ToList();
            bindingSource2.Clear();
            bindingSource2.AddNew();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Element el)
            {
                var fd = enti.Elements.AsNoTracking().Where(f => f.ID == el.ID).ToList();
                bindingSource2.DataSource = fd;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Element el)
            {
                enti.Elements.Remove(el);
                enti.SaveChanges();
                Form3_Load(sender, e);
                MessageBox.Show("Data Berhasil Di Delete");
                Reset();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Element el)
            {
                enti.Elements.AddOrUpdate(el);
                enti.SaveChanges();
                Reset();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AppContext(new Form1());
            this.Close();
        }
    }
}
