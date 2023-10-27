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
    public partial class BorrowBooksForm : Form
    {
        private User? user;

        public BorrowBooksForm()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void BorrowBooksForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Book ID", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Genre", typeof(string));

            foreach (Book book in Program.books.GetAvailableBooksList())
            {
                table.Rows.Add(book.GetId(), book.GetTitle(), book.GetAuthor(), book.GetGenre());
            }
            dataGridView1.DataSource = table;
        }

        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {
            int maxBorrowLimit = 5; // Maximum number of books that can be borrowed
            int selectedBookCount = 0;

            if (user == null)
            {
                MessageBox.Show("User information is missing. Please log in.");
                return;
            }

            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell? cell = row.Cells["CheckBoxColumn"] as DataGridViewCheckBoxCell;

                if (cell != null && (bool)cell.Value)
                {
                    int bookID = (int)row.Cells["Book ID"].Value;

                    // Create a new BorrowedBook object for each selected book
                    BorrowedBook borrowedBook = new BorrowedBook(bookID, user.GetId(), DateTime.Now, DateTime.Now.AddDays(14), false);

                    // Add the borrowed book to the list
                    borrowedBooks.Add(borrowedBook);

                    selectedBookCount++;
                }
            }

            if (selectedBookCount == 0)
            {
                MessageBox.Show("Please select at least one book to borrow.");
            }
            else if (selectedBookCount > maxBorrowLimit)
            {
                MessageBox.Show("You can only borrow up to 5 books at a time.");
            }
            else
            {
                // Add the borrowed books to the BorrowedBooks class
                Program.borrowedBooks.AppendBorrowedBooks(borrowedBooks, "borrowedBooks.txt");

                // Provide user feedback about the successful borrowing
                MessageBox.Show("You have successfully borrowed the selected books.");

                // Clear the selected checkboxes
                ClearSelectedCheckboxes();
            }
        }

        private void ClearSelectedCheckboxes()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell? cell = row.Cells["CheckBoxColumn"] as DataGridViewCheckBoxCell;

                if (cell != null)
                {
                    cell.Value = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Hide();
        }
    }
}
