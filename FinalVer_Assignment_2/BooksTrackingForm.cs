using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVer_Assignment_2
{
    public partial class BooksTrackingForm : Form
    {
        private LibrarianForm librarianForm;
        private BindingList<BorrowedBook> borrowedBooksBindingList;
        private List<BorrowedBook> borrowedBooks;

        public BooksTrackingForm(LibrarianForm librarianForm)
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set properties for automatic sizing
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set DataGridView to be read-only
            dataGridView1.ReadOnly = true;
        }

        DataTable table = new DataTable();

        private void ListBookForm_Load(object sender, EventArgs e)
        {
            // Define the structure of the DataTable
            table.Columns.Add("BookID", typeof(int));
            table.Columns.Add("UserID", typeof(int));
            table.Columns.Add("BorrowDate", typeof(DateTime));
            table.Columns.Add("DueDate", typeof(DateTime));
            table.Columns.Add("IsReturned", typeof(bool));

            // Populate the DataTable with borrowed book details from the Program's borrowedBooks list
            foreach (BorrowedBook borrowedBook in Program.borrowedBooks.GetBorrowedBooksList())
            {
                table.Rows.Add(borrowedBook.GetBookID(), borrowedBook.GetUserID(), borrowedBook.GetBorrowDate(), borrowedBook.GetDueDate(), borrowedBook.GetIsReturned());
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterText = textBox2.Text;

            if (!string.IsNullOrEmpty(filterText))
            {
                DataView dv = new DataView(table);

                if (int.TryParse(filterText, out int id))
                {
                    // Here, we're assuming you might search by BookID; adjust as necessary
                    dv.RowFilter = $"BookID = {id}";
                }
                else
                {
                    // Adjust search columns as needed
                    dv.RowFilter = $"UserID = {filterText}";
                }

                dataGridView1.DataSource = dv;
            }
            else
            {
                dataGridView1.DataSource = table;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.Show();
            this.Hide();
        }
    }
}