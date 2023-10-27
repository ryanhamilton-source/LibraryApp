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
    public partial class AddUserForm : Form
    {
        private int nextUserID = 3000;
        private string generatedPassword = string.Empty;

        public AddUserForm()
        {
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string postalCode = txtPostal.Text;

            // Check if any of the fields is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("Please fill in all the fields before adding a new user.");
            }
            else
            {
                // All fields are filled, proceed to add the user
                int userID = nextUserID;
                string password = generatedPassword;

                string fullName = $"{firstName} {lastName}";
                string fullAddress = $"{address} {city} {state} {postalCode}";

                User user = new User(userID, password, fullName, email, phone, fullAddress);
                Program.users.AddUser(user);
                Program.users.AppendUser(user, "user.txt");
                ClearForm();
                MessageBox.Show("User added successfully.");
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            // Generate a next user ID
            nextUserID = GenerateUniqueUserID();

            // Display the generated ID in the textbox
            lblID.Text = nextUserID.ToString();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            // Generate a secure password
            generatedPassword = GenerateSecurePassword(8);

            // Display the generated password in the textbox
            lblPassword.Text = generatedPassword;
        }

        private string GenerateSecurePassword(int length)
        {
            // Generate a secure password
            // You can use a password generator library for a strong password.
            // For simplicity, you can generate a random 8-character password.
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private int GenerateUniqueUserID()
        {
            List<User> users = LoadUsersData();
            if (users.Count == 0)
            {
                return nextUserID;
            }
            int maxId = users.Max(user => user.GetId());
            nextUserID = Math.Max(nextUserID, maxId + 1);
            int newId = nextUserID;

            return newId;
        }
        private List<User> LoadUsersData()
        {
            return Program.users.GetUsersList();
        }

        private void ClearForm() //Optionally, implement a method to clear the form's textboxes
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtPostal.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
