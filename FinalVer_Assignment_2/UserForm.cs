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
    public partial class UserForm : Form
    {
        private LoginForm loginForm;
        private User currentUser; // Store the currently logged-in user
        public UserForm(User currentUser)
        {
            this.loginForm = new LoginForm();
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            this.currentUser = currentUser;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }

        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {
            BorrowBooksForm borrowBooksForm = new BorrowBooksForm(currentUser);
            borrowBooksForm.Show();
            this.Hide();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBooksForm returnBooksForm = new ReturnBooksForm(currentUser);
            returnBooksForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListBookFormUser listBookFormUser = new ListBookFormUser(currentUser);
            listBookFormUser.Show();
            this.Hide();
        }

        private void btnViewBorrowBooks_Click(object sender, EventArgs e)
        {
            ViewBorrowedBooksForm viewBorrowedBooksForm = new ViewBorrowedBooksForm(currentUser);
            viewBorrowedBooksForm.Show();
            this.Hide();
        }
    }
}
