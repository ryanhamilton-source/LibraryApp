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
    }
}
