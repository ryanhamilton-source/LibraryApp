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
    public partial class AddLibrarianForm : Form
    {
        private int nextLibrarianID = 2000;
        private string generatedPassword = string.Empty;

        public AddLibrarianForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void btnID_Click_1(object sender, EventArgs e)
        {
            // Generate a next user ID
            nextLibrarianID = GenerateUniqueLibrarianID();

            // Display the generated ID in the textbox
            lblID.Text = nextLibrarianID.ToString();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            // Generate a secure password
            generatedPassword = GenerateSecurePassword(8);

            // Display the generated password in the textbox
            lblPassword.Text = generatedPassword;
        }

        private void btnAddLibrarian_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Please fill in all the fields before adding a new librarian.");
            }
            else
            {
                // All fields are filled, proceed to add the user
                int librarianID = nextLibrarianID;
                string password = generatedPassword;

                string fullName = $"{firstName} {lastName}";
                string fullAddress = $"{address} {city} {state} {postalCode}";

                Librarian librarian = new Librarian(librarianID, password, fullName, email, phone, fullAddress);
                Program.librarians.AddLibrarian(librarian);
                Program.librarians.AppendLibrarian(librarian, "librarian.txt");
                ClearForm();
                MessageBox.Show("Librarian added successfully.");
            }
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
        private int GenerateUniqueLibrarianID()
        {
            List<Librarian> librarians = LoadLibrariansData();
            if (librarians.Count == 0)
            {
                return nextLibrarianID;
            }
            int maxId = librarians.Max(user => user.GetId());
            nextLibrarianID = Math.Max(nextLibrarianID, maxId + 1);
            int newId = nextLibrarianID;

            return newId;
        }
        private List<Librarian> LoadLibrariansData()
        {
            return Program.librarians.GetLibrariansList();
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



    }
}
