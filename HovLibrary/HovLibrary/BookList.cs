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
    public partial class BookList : Form
    {
        HovLibraryEntities entities = new HovLibraryEntities();
        Book book;
        int booklist;
        public BookList(int id)
        {
            InitializeComponent();

            this.book = entities.Books.Where(book => book.id == id).FirstOrDefault();
            booklist = entities.BookDetails.OrderByDescending(f => f.id).
                FirstOrDefault(f => f.deleted_at == null).id + 1;
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            booklist = entities.Books.OrderByDescending(f => f.id).FirstOrDefault(f => f.deleted_at == null).id + 1;

            textBox1.Text = book.title;

            bindingSource2.Clear();
            bindingSource2.AddNew();

            if (bindingSource2.Current is BookDetail bookdetail)
                bookdetail.book_id = book.id;
            bindingSource1.DataSource = entities.BookDetails.Where(f => f.book_id == book.id && f.deleted_at == null).ToList();

            bindingSource3.DataSource = entities.Locations.Where(f => f.deleted_at == null).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == location_col.Index)
                    e.Value = detail.Location.name;

                else if (e.ColumnIndex == status_col.Index)
                {
                    e.Value = entities.Borrowings.Where(b => b.bookdetails_id == detail.id && b.return_date == null).
                        Count()  > 0 ?"Unavailable" : "Available";
                }
            }
        }

        private void bindingSource3_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource3.Current is Location loc && bindingSource2.Current is BookDetail detail)
            {
                detail.location_id = loc.id;
                textBox2.Text = booklist.ToString("D4") + "." + loc.id.ToString("D2")
                    +
                    "."
                    +
                    book.publication_date.Year;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is BookDetail detail)
            {
                detail.id = booklist;
                detail.created_at = DateTime.Now;
                detail.code = textBox2.Text;

                entities.BookDetails.AddOrUpdate(detail);
                entities.SaveChanges();

                BookList_Load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == delete_col.Index)
                {
                    if (MessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        detail.deleted_at = DateTime.Now;
                        entities.SaveChanges();

                        BookList_Load(sender, e);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
