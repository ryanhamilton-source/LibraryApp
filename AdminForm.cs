using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVer_Assignment_2
{
    public partial class AdminForm : Form
    {
        private LoginForm loginForm;
        public AdminForm()
        {
            InitializeComponent();
            this.loginForm = new LoginForm();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.Show();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            AddLibrarianForm librarianForm = new AddLibrarianForm();
            librarianForm.Show();
            this.Hide();
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            ListUserForm listUserForm = new ListUserForm();
            listUserForm.Show();
            this.Hide();
        }

        private void btnListAllLibrarian_Click(object sender, EventArgs e)
        {
            ListLibrarianForm listLibrarianForm = new ListLibrarianForm();
            listLibrarianForm.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
