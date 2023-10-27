using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalVer_Assignment_2
{
    public partial class ListUserForm : Form
    {
        public ListUserForm()
        {
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
        private void ListUserForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Address", typeof(string));


            foreach (User user in Program.users.GetUsersList())
            {
                table.Rows.Add(user.GetId(), user.GetName(), user.GetEmail(), user.GetPhone(), user.GetAddress());
            }

            dataGridView1.DataSource = table;
        }

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
                    dv.RowFilter = $"Name LIKE '%{filterText}%' OR Email LIKE '%{filterText}%' OR Phone LIKE '%{filterText}%' OR Address LIKE '%{filterText}'";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
