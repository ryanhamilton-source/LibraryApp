using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalVer_Assignment_2
{
    public partial class AddNewBookForm : Form
    {
        private int nextBookID = 1;

        public AddNewBookForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text;
            string author = txtBookAuthor.Text;
            string? genre = cmbGenre.SelectedItem?.ToString();
            int totalCopies = (int)numericUpDown1.Value;
            int avalableCopies = totalCopies;
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre) || totalCopies < 1)
            {
                MessageBox.Show("Please fill in all the fields before adding new book.");
            }
            else
            {
                int bookID = nextBookID;
                Book book = new Book(bookID, title, author, genre, totalCopies, avalableCopies);
                Program.books.AddBook(book);
                Program.books.AppendBook(book, "book.txt");
                ClearForm();
                MessageBox.Show("Book added successfully.");
            }
        }

        private int GenerateUniqueBookID()
        {
            List<Book> books = LoadBooksData();
            if (books.Count == 0)
            {
                return nextBookID;
            }
            int maxId = books.Max(book => book.GetId());
            nextBookID = Math.Max(nextBookID, maxId + 1);
            int newId = nextBookID;

            return newId;
        }

        private List<Book> LoadBooksData()
        {
            return Program.books.GetBooksList();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            // Generate a next user ID
            nextBookID = GenerateUniqueBookID();

            // Display the generated ID in the textbox
            lblID.Text = nextBookID.ToString();
        }
        private void ClearForm() //Optionally, implement a method to clear the form's textboxes
        {
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            cmbGenre.SelectedIndex = -1;
            numericUpDown1.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.Show();
            this.Hide();
        }
    }
}
