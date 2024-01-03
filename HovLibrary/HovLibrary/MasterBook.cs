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

namespace HovLibrary
{
    public partial class MasterBook : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();
        string[] searchOption = { "", "Title", "Author", "Publisher" };
        string currentSearchOption;
        public MasterBook()
        {
            InitializeComponent();
        }


        void SetEnable(bool enable)
        {
            foreach (Control con in new List<Control> { textBox2, textBox4, textBox5, textBox6, textBox7, comboBox8, comboBox7, dateTimePicker3, textBox3, button2 })
            {
                if (con is TextBox text)
                    text.ReadOnly = !enable;
                else
                    con.Enabled = enable;
            }
        }

        void Reset()
        {
            bindingSource1.DataSource = db.Books.Where(b => b.deleted_at == null).ToList();
            bindingSource3.DataSource = db.Languages.Where(l => l.deleted_at == null).ToList();
            bindingSource4.DataSource = db.Languages.Where(l => l.deleted_at == null).ToList();
            bindingSource5.DataSource = db.Publishers.Where(p => p.deleted_at == null).ToList();
            comboBox6.DataSource = searchOption;

            var pageRange = db.Books.Select(x => x.number_of_pages).Distinct();
            comboBox2.DataSource = pageRange.OrderBy(x => x).ToList();
            comboBox3.DataSource = pageRange.OrderByDescending(x => x).ToList();


            var ratingRange = db.Books.Select(x => x.average_rating).Distinct().ToList();
            comboBox4.DataSource = ratingRange.OrderByDescending(x => x).ToList();
            comboBox5.DataSource = ratingRange.OrderBy(x => x).ToList();


            var firstPublish = db.Books.OrderBy(x => x.publication_date).Select(x => x.publication_date).First();
            var lastPublish = db.Books.OrderByDescending(x => x.publication_date).Select(x => x.publication_date).First();
            dateTimePicker1.Value = firstPublish;
            dateTimePicker2.Value = lastPublish;

            SetEnable(false);
        }



        private void MasterBook_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem is string str && !string.IsNullOrEmpty(str))
            {
                currentSearchOption = str;
                textBox1.Enabled = true;
                return;
                
            }
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = db.Books.Where(x =>
                x.language_id == (int)comboBox1.SelectedValue &&
                x.publication_date > dateTimePicker1.Value &&
                x.publication_date < dateTimePicker2.Value &&
                x.number_of_pages > (int)comboBox2.SelectedItem &&
                x.number_of_pages < (int)comboBox3.SelectedItem &&
                x.average_rating > (double)comboBox5.SelectedItem &&
                x.average_rating < (double)comboBox4.SelectedItem &&
                x.deleted_at == null
            ).ToList();

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Book book)
            {
                textBox6.Text = book.average_rating + "(" + book.ratings_count + ")";
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Book book)
            {
                if (e.ColumnIndex == language_col.Index)
                    e.Value = book.Language.long_text;

                else if (e.ColumnIndex == publisher_col.Index)
                    e.Value = book.Publisher.name;

                else if (e.ColumnIndex == rating_col.Index)
                    e.Value = book.average_rating + " (" + book.ratings_count + ")";

                else if (e.ColumnIndex == publicdate_col.Index)
                    e.Value = book.publication_date.ToString("dd MMMM yyyy");
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Book book)
            {
                if (e.ColumnIndex == edit_btn.Index)
                {
                    SetEnable(true);
                }

                if (e.ColumnIndex == delete_btn.Index)
                {
                    book.deleted_at = DateTime.Now;
                    db.SaveChanges();
                    Reset();
                }

                if (e.ColumnIndex == show_btn.Index)
                {
                    new BookList(book.id).ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Book book)
            {
                var rating = textBox6.Text.Split('(');
                rating[1] = rating[1].Substring(0, rating[1].Length - 1);
                book.average_rating = Math.Round(float.Parse(rating[0]), 2);
                book.ratings_count = int.Parse(rating[1]);

                db.Books.AddOrUpdate();
                db.SaveChanges();
                Reset();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentSearchOption == "Title")
                bindingSource1.DataSource = db.Books.Where(f => f.title.Contains(textBox1.Text)).ToList();
            else if (currentSearchOption == "Author")
                bindingSource1.DataSource = db.Books.Where(f => f.authors.Contains(textBox1.Text)).ToList();
            else if (currentSearchOption == "Publisher")
                bindingSource1.DataSource = db.Books.Where(f => f.Publisher.name.Contains(textBox1.Text)).ToList();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

            if (bindingSource1.Current is Book book)
            {
                bindingSource2.DataSource = db.Books.Where(b => b.id == book.id).ToList();
                SetEnable(false);
            }
        }
    }
}
