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
        private User currentUser; // Store the currently logged-in user
        private BindingList<BorrowedBook> borrowedBooks;

        public ReturnBooksForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // Load the borrowed books list every time the form is instantiated
            LoadBorrowedBooksData(); // Added this method call

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadBorrowedBooksData() // Added this new method
        {
            borrowedBooks = new BindingList<BorrowedBook>(Program.borrowedBooks.GetBorrowedBooksList());
        }
        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
            // Filter the borrowedBooks list to include only the books borrowed by the current user and not yet returned
            var userBorrowedBooks = borrowedBooks
                .Where(b => b.GetUserID() == currentUser.GetId() && !b.GetIsReturned())
                .ToList();

            // Bind the DataGridView to the filtered list
            dataGridView1.DataSource = userBorrowedBooks;

            // Remove the auto-generated columns
            dataGridView1.AutoGenerateColumns = false;

            // Add a DataGridViewCheckBoxColumn for book selection
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
    // List to store books that are marked for return
    List<BorrowedBook> booksToReturn = new List<BorrowedBook>();

    foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
        if (Convert.ToBoolean(checkBoxCell?.Value) == true)
        {
            BorrowedBook borrowedBook = row.DataBoundItem as BorrowedBook;
            if (borrowedBook != null)
            {
                borrowedBook.SetIsReturned(true); // Mark the book as returned

                // Add to the list
                booksToReturn.Add(borrowedBook);

                // Increment available copies of the book
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

                // After returning books, refresh the borrowed books data and then refresh the DataGridView
                LoadBorrowedBooksData(); // Refresh the data
                RefreshBorrowedBooksDataGridView(); // Refresh the view
            }
        }


        private void RefreshBorrowedBooksDataGridView()
        {
            // Filter the borrowedBooks list to include only the books borrowed by the current user and not yet returned
            var userBorrowedBooks = borrowedBooks
                .Where(b => b.GetUserID() == currentUser.GetId() && !b.GetIsReturned())
                .ToList();

            // Clear the DataGridView's data source
            dataGridView1.DataSource = null;

            // Set the filtered list as the data source for the DataGridView
            dataGridView1.DataSource = userBorrowedBooks;

            // Now, clear the selection in the DataGridView
            dataGridView1.ClearSelection();
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

            throw new Exception($"Book with ID {bookId} not found."); // Custom exception to handle the case where the book is not found
        }

    }
}
