using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovLibrary
{
    public partial class AllBorrowing : Form
    {
        HovLibraryEntities entities = new HovLibraryEntities();
        DateTime first;
        DateTime last;
        string status;
        public AllBorrowing()
        {
            InitializeComponent();
        }

        void filter()
        {
            var borrow = entities.Borrowings.Where(x => x.deleted_at == null);

            if (first == null || last == null || status == null)
            {
                bindingSource1.DataSource = borrow.ToList();
                return;
            }

            var a = borrow.Where(b =>
                DbFunctions.TruncateTime(b.borrow_date) >= first &&
                DbFunctions.TruncateTime(b.borrow_date) <= last
            );

            if (status == "Late")
                a = a.Where(b => DbFunctions.DiffDays(b.borrow_date, DateTime.Now) > 7 && b.return_date == null);
            else if (status == "Ongoing")
                a = a.Where(b => DbFunctions.DiffDays(b.borrow_date, DateTime.Now) <= 7 && b.return_date == null);
            else if (status == "Returned")
                a = a.Where(b => b.return_date != null);

            bindingSource1.DataSource = a.ToList();
        }

        private void AllBorrowing_Load(object sender, EventArgs e)
        {

            filter();

            comboBox1.DataSource = new List<string> { "Ongoing", "Late", "Returned" };

            var firstDate = entities.Borrowings.OrderBy(x => x.borrow_date).Select(x => x.borrow_date).First();
            var lastDate = entities.Borrowings.OrderByDescending(x => x.borrow_date).Select(x => x.borrow_date).First();
            dateTimePicker1.Value = firstDate;
            dateTimePicker2.Value = lastDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first = dateTimePicker1.Value;
            last = dateTimePicker2.Value;
            status = comboBox1.SelectedItem.ToString();
            filter();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Borrowing borrow)
            {
                if (e.ColumnIndex == memberDataGridViewTextBoxColumn.Index)
                    e.Value = borrow.Member.name;

                else if (e.ColumnIndex == bookDetailDataGridViewTextBoxColumn.Index)
                    e.Value = borrow.BookDetail.Book.title;

                else if (e.ColumnIndex == code_col.Index)
                    e.Value = borrow.BookDetail.code;

                else if (e.ColumnIndex == borrowdateDataGridViewTextBoxColumn.Index)
                    e.Value = borrow.borrow_date.ToString("dd MMM yyyy");

                else if (e.ColumnIndex == returndateDataGridViewTextBoxColumn.Index && borrow.return_date is DateTime returnDate)
                    e.Value = returnDate.ToString("dd MMM yyyy");

                else if (e.ColumnIndex == fineDataGridViewTextBoxColumn.Index && borrow.fine is decimal fine)
                    e.Value = fine.ToString("#,##0");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Borrowing borrow)
            {
                if (e.ColumnIndex == Return_col.Index)
                {
                    if (borrow.return_date != null) return;

                    if ((DateTime.Now - borrow.borrow_date).Days > 7)
                        borrow.fine = (DateTime.Now - borrow.borrow_date).Days * 1000;
                    else
                        borrow.fine = 0;

                    borrow.return_date = DateTime.Now;
                    borrow.last_updated_at = DateTime.Now;
                    entities.SaveChanges();
                    filter();
                }
            }
        }
    }
}

