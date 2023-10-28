using System.Numerics;

namespace FinalVer_Assignment_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtName.Text, out int id))
            {
                string password = txtPass.Text;

                Login login = new Login();

                // Identify the user's role
                Login.Roles role = login.IdentifyRole(id, password);

                switch (role)
                {
                    case Login.Roles.Admin:
                        // Authenticate and open the AdminForm
                        Admin? admin = login.GetAuthenticatedUser(role, id, password) as Admin;
                        if (admin != null)
                        {
                            MessageBox.Show("Login Successful.");
                            // Admin authenticated successfully
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password for the Admin role.");
                        }
                        break;

                    // Handle other roles as needed (e.g., User, Unknown)
                    case Login.Roles.User:
                        User? user = login.GetAuthenticatedUser(role, id, password) as User;
                        if (user != null)
                        {
                            MessageBox.Show("Login Successful.");
                            UserForm userForm = new UserForm(user);
                            userForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password for the User role.");
                        }
                        break;

                    // Handle other roles as needed (e.g., User, Unknown)
                    case Login.Roles.Librarian:
                        Librarian? librarian = login.GetAuthenticatedUser(role, id, password) as Librarian;
                        if (librarian != null)
                        {
                            MessageBox.Show("Login Successful.");
                            LibrarianForm librarianForm = new LibrarianForm();
                            librarianForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password for the User role.");
                        }
                        break;

                    case Login.Roles.Unknown:
                        MessageBox.Show("Invalid username or password. Please try again.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid integer ID.");
            }
        }


    }
}