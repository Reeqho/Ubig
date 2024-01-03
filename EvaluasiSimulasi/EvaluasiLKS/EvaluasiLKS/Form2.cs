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

namespace EvaluasiLKS
{
    public partial class Form2 : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
      
        public Form2()
        {
            InitializeComponent();
           
            
        }


        private void Reset()
        {
            bindingSource1.DataSource = entities.Clans.ToList();
            bindingSource2.Clear();
            bindingSource2.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Clan clan)
            {
                var fd = entities.Clans.AsNoTracking().Where(f => f.ID == clan.ID).ToList();
                bindingSource2.DataSource = fd;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Clan clan)
            {
                entities.Clans.AddOrUpdate(clan);
                entities.SaveChanges();
                Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Clan clan)
            {
                entities.Clans.Remove(clan);
                entities.SaveChanges();
                Form2_Load(sender, e);
                MessageBox.Show("Data Berhasil Di Delete");
                Reset();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = entities.Clans.Where(i => i.Name.Contains(textBox1.Text)).ToList();
            bindingSource1.DataSource = search;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Reset();
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
