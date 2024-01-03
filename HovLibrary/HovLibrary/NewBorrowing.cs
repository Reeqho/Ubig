using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovLibrary
{
    public partial class NewBorrowing : Form
    {
        HovLibraryEntities entities = new HovLibraryEntities();

        List<BookDetail> selected = new List<BookDetail>();
        public NewBorrowing()
        {
            InitializeComponent();

        }
        void search(string key)
        {
            bindingSource1.DataSource = entities.BookDetails.Where(detail =>
                detail.deleted_at == null &&
                detail.Borrowings.Where(b => b.return_date == null).Count() <= 0 &&
                detail.Book.title.Contains(key)).ToList();
        }

        private void NewBorrowing_Load(object sender, EventArgs e)
        {
            var titleSource = new AutoCompleteStringCollection();
            titleSource.AddRange(entities.Books
                .Where(b => b.deleted_at == null)
                .Select(b => b.title).ToArray());
            textBox1.AutoCompleteCustomSource = titleSource;


            var memberSource = new AutoCompleteStringCollection();
            memberSource.AddRange(entities.Members
                .Where(mem => mem.deleted_at == null)
                .Select(mem => mem.name).ToArray());
            textBox2.AutoCompleteCustomSource = memberSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == location_col.Index)
                    e.Value = detail.Location.name;

                else if (e.ColumnIndex == status_col.Index)
                {
                    e.Value = entities.Borrowings.Where(b => b.bookdetails_id == detail.id 
                    &&
                    b.return_date == null).Count() > 0 ? "Unavailable" : "Available";
                }
                else if (e.ColumnIndex == check_col.Index)
                {
                    if (!selected.Contains(detail)) return;
                    var check = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    check.Value = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail book)
            {
                if (e.ColumnIndex == check_col.Index)
                {
                    var check = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (check.Value == null)
                    {
                        selected.Add(book);
                        check.Value = true;
                    }
                    else
                    {
                        selected.Remove(book);
                        check.Value = null;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected_member = entities.Members.FirstOrDefault(f => f.name == textBox2.Text);

            if (selected_member == null)
            {
                MessageBox.Show("Member Tidak Di temukan");
                return;
            }

            if (selected.Count == 0)
            {
                MessageBox.Show("Mohon Pilih Box");
                return;
            }

            foreach(var book in selected)
            {
                Borrowing borrow = new Borrowing
                {
                    member_id = selected_member.id,
                    bookdetails_id = book.id,
                    borrow_date = DateTime.Now,
                    created_at = DateTime.Now
                };
                entities.Borrowings.Add(borrow);
            }
            entities.SaveChanges();
            selected.Clear();
            textBox2.Clear();
            NewBorrowing_Load(sender, e);
        }
    }
}
