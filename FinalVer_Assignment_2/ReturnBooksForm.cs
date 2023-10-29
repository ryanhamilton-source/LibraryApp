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
    public partial class ReturnBooksForm : Form
    {
        private User currentUser;
        private BindingList<BorrowedBook> borrowedBooks;

        public ReturnBooksForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadBorrowedBooksData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadBorrowedBooksData()
        {
            borrowedBooks = new BindingList<BorrowedBook>(Program.borrowedBooks.GetBorrowedBooksList());
        }

        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
            var userBorrowedBooks = borrowedBooks
                .Where(b => b.GetUserID() == currentUser.GetId() && !b.GetIsReturned())
                .ToList();

            dataGridView1.DataSource = userBorrowedBooks;
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Select",
                DataPropertyName = "IsSelected",
                FalseValue = false,
                TrueValue = true,
                IndeterminateValue = false,
                ValueType = typeof(bool)
            };
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        private void btnReturnBooks_Click_1(object sender, EventArgs e)
        {
            List<BorrowedBook> booksToReturn = new List<BorrowedBook>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkBoxCell?.Value) == true)
                {
                    BorrowedBook borrowedBook = row.DataBoundItem as BorrowedBook;
                    if (borrowedBook != null)
                    {
                        borrowedBook.SetIsReturned(true);
                        booksToReturn.Add(borrowedBook);
                        Book returnedBook = GetBookById(borrowedBook.GetBookID());
                        returnedBook.SetAvailableCopies(returnedBook.GetAvailableCopies() + 1);
                    }
                }
            }

            if (booksToReturn.Count == 0)
            {
                MessageBox.Show("No books selected for return.");
            }
            else
            {
                Program.borrowedBooks.UpdateBorrowedBooksFile(booksToReturn, "borrowedBooks.txt");
                MessageBox.Show("Selected books have been successfully returned.");
                LoadBorrowedBooksData();
                RefreshBorrowedBooksDataGridView();
            }
        }

        private void RefreshBorrowedBooksDataGridView()
        {
            var userBorrowedBooks = borrowedBooks
                .Where(b => b.GetUserID() == currentUser.GetId() && !b.GetIsReturned())
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = userBorrowedBooks;
            dataGridView1.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBorrowedBooksData();
            RefreshBorrowedBooksDataGridView();
            MessageBox.Show("Refreshed Success.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(currentUser);
            userForm.Show();
            this.Hide();
        }

        private Book GetBookById(int bookId)
        {
            foreach (Book book in Program.books.GetBooksList())
            {
                if (book.GetId() == bookId)
                {
                    return book;
                }
            }

            throw new Exception($"Book with ID {bookId} not found.");
        }
    }
}
