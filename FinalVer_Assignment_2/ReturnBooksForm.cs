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
        public ReturnBooksForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }
        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
         
        }

        private void btnReturnBooks_Click_1(object sender, EventArgs e)
        {
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(currentUser);
            userForm.Show();
            this.Hide();
        }
    }
}
