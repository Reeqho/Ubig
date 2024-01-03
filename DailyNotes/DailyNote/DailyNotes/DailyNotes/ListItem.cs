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

namespace DailyNotes
{
    public partial class ListItem : UserControl
    {
        private Action delete;
        private Action edit;
        private Catatan notes;
        public ListItem(Catatan notes, Action delete, Action edit)
        {
            InitializeComponent();
            this.delete = delete;
            this.edit = edit;
            this.notes = notes;
        }

        public ListItem()
        {
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            label1.Text = notes.description;
            dateTimePicker1.Value = notes.date;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit();
        }
    }
}
