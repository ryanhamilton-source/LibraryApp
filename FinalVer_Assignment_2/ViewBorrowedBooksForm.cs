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
    public partial class ViewBorrowedBooksForm : Form
    {
        private User currentUser;
        private List<BorrowedBook> borrowedBooks;
        public ViewBorrowedBooksForm(User currentUser)
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            this.currentUser = currentUser;
            borrowedBooks = new List<BorrowedBook>();

            // Set properties for automatic sizing
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        DataTable table = new DataTable();

        private void ReadBorrowedBooksFromFile(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');

                    if (fields.Length == 5)
                    {
                        // Parse the data and create BorrowedBook objects
                        int bookID = int.Parse(fields[0]);
                        int userID = int.Parse(fields[1]);
                        DateTime borrowDate = DateTime.Parse(fields[2]);
                        DateTime dueDate = DateTime.Parse(fields[3]);
                        bool isReturned = bool.Parse(fields[4]);

                        BorrowedBook borrowedBook = new BorrowedBook(bookID, userID, borrowDate, dueDate, isReturned);
                        borrowedBooks.Add(borrowedBook);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any file read errors, e.g., file not found.
                MessageBox.Show("Error reading borrowed books: " + ex.Message);
            }
        }



        private void ViewBorrowedBooksForm_Load(object sender, EventArgs e)
        {
            ReadBorrowedBooksFromFile("borrowedBooks.txt");

            // Filter the borrowed books for the current user
            List<BorrowedBook> userBorrowedBooks = borrowedBooks
                .Where(book => book.GetUserID() == currentUser.GetId())
                .ToList();

            // Bind the DataGridView to the user's borrowed books
            dataGridView1.DataSource = userBorrowedBooks;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(currentUser);
            userForm.Show();
            this.Hide();

        }
    }
}

