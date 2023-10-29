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
    public partial class ListBookFormUser : Form
    {
        private User currentUser; // Store the currently logged-in user
        public ListBookFormUser(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set properties for automatic sizing
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set DataGridView to be read-only
            dataGridView1.ReadOnly = true;
        }

        DataTable table = new DataTable();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text;

            if (!string.IsNullOrEmpty(filterText))
            {
                DataView dv = new DataView(table);

                if (int.TryParse(filterText, out int id))
                {
                    // If the input can be parsed as an integer, search by ID
                    dv.RowFilter = $"ID = {id}";
                }
                else
                {
                    // If the input is not a valid integer, search in other columns
                    dv.RowFilter = $"Title LIKE '%{filterText}%' OR Author LIKE '%{filterText}%' OR Genre LIKE '%{filterText}%'";
                }

                // Update the DataGridView with the filtered results
                dataGridView1.DataSource = dv;
            }
            else
            {
                // If the filter text is empty, show all data
                dataGridView1.DataSource = table;
            }
        }

        private void ListBookFormUser_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Genre", typeof(string));
            table.Columns.Add("Total Copies", typeof(int));
            table.Columns.Add("Available Copies", typeof(int));

            foreach (Book book in Program.books.GetBooksList())
            {
                table.Rows.Add(book.GetId(), book.GetTitle(), book.GetAuthor(), book.GetGenre(), book.GetTotalCopies(), book.GetAvailableCopies());
            }

            dataGridView1.DataSource = table;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(currentUser);
            userForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
