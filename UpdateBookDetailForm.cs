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
    public partial class UpdateBookDetailForm : Form
    {
        private Book? book = null;
        public UpdateBookDetailForm()
        {
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnUpdateBookDetails_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                string updatedTitle = txtBookTitle.Text;
                string updatedAuthor = txtBookAuthor.Text;
                string? updatedGenre = cmbGenre.SelectedItem.ToString();
                int updatedTotalCopies = (int)numericUpDown1.Value;

                // Calculate the difference in the total number of copies
                int differenceInCopies = updatedTotalCopies - book.GetTotalCopies();

                // Update the basic book details
                book.SetTitle(updatedTitle);
                book.SetAuthor(updatedAuthor);
                book.SetGenre(updatedGenre);
                book.SetTotalCopies(updatedTotalCopies);

                // Update the available copies based on the difference
                int updatedAvailableCopies = book.GetAvailableCopies() + differenceInCopies;
                book.SetAvailableCopies(updatedAvailableCopies);

                Program.books.UpdateBookFile(book, "book.txt");

                MessageBox.Show("Book details updated successfully.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Book not found.");
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtSearch.Text, out int searchID))
            {
                Book? foundbook = Program.books.GetBooksList().Find(b => b.GetId() == searchID);
                if (foundbook != null)
                {
                    lblID.Text = foundbook.GetId().ToString();
                    txtBookTitle.Text = foundbook.GetTitle();
                    txtBookAuthor.Text = foundbook.GetAuthor();
                    string? genre = foundbook.GetGenre();
                    // Check if the genre is not null before setting it
                    if (genre != null)
                    {
                        cmbGenre.SelectedItem = genre; // Set the selected item to the genre string
                    }

                    numericUpDown1.Value = foundbook.GetTotalCopies();
                    book = foundbook; // Assign the found book to the class-level variable
                }
                else
                {
                    MessageBox.Show("Book not found.");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Invalid book ID. Please enter a valid integer.");
            }
            
        }
        private void ClearForm()
        {
            txtSearch.Text = "";
            lblID.Text = "";
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
