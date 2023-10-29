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
        private User currentUser; // Store the currently logged-in user
        private BindingList<Book> availableBooks; // Binding list for available books

        public BorrowBooksForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // Initialize the binding list with available books
            availableBooks = new BindingList<Book>(Program.books.GetAvailableBooksList());
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BorrowBooksForm_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the binding list
            dataGridView1.DataSource = availableBooks;

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
        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {
            // Handle the "Borrow Books" button click event
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell? checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checkBoxCell?.Value) == true)
                {
                    Book? selectedBook = row.DataBoundItem as Book;

                    // Check if the book is available
                    if (selectedBook?.GetAvailableCopies() > 0)
                    {
                        // Create a BorrowedBook object and add it to the borrowed books list
                        BorrowedBook borrowedBook = new BorrowedBook(selectedBook.GetId(), currentUser.GetId(), DateTime.Now, DateTime.Now.AddDays(14), false);

                        // Append the borrowed book to the borrowedbooks.txt file
                        BorrowedBooks borrowedBooks = new BorrowedBooks("borrowedBooks.txt");
                        borrowedBooks.AddBorrowedBook(borrowedBook);
                        borrowedBooks.AppendBorrowedBooks(new List<BorrowedBook> { borrowedBook }, "borrowedBooks.txt");

                        // Update the available copies
                        selectedBook.SetAvailableCopies(selectedBook.GetAvailableCopies() - 1);
                        Program.books.UpdateBookFile(selectedBook, "book.txt");

                    }
                    else
                    {
                        MessageBox.Show($"The book '{selectedBook?.GetTitle()}' is not available for borrowing.");
                    }
                }
            }

            // Refresh the DataGridView to reflect the updated data
            availableBooks.ResetBindings();
            MessageBox.Show("Books have been successfully borrowed.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(currentUser);
            userForm.Show();
            this.Hide();
        }
    }
}
