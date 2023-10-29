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
    public partial class LibrarianForm : Form
    {
        private LoginForm loginForm;
        public LibrarianForm()
        {
            this.loginForm = new LoginForm();
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            AddNewBookForm addNewBookForm = new AddNewBookForm();
            addNewBookForm.Show();
            this.Hide();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            ListBookForm searchBookForm = new ListBookForm();
            searchBookForm.Show();
            this.Hide();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBookDetailForm updateBookDetailForm = new UpdateBookDetailForm();
            updateBookDetailForm.Show();
            this.Hide();
        }
        //Ryan's updates

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            DeleteBookForm deleteBookForm = new DeleteBookForm(this);
            deleteBookForm.Show();
            this.Hide();
        }
        private void btnBooksTracking_Click(object sender, EventArgs e)
        {
            BooksTrackingForm booksTrackingForm = new BooksTrackingForm(this);
            booksTrackingForm.Show();
            this.Hide();

        }
    }
}
