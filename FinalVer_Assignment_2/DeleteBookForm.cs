namespace FinalVer_Assignment_2
{
    public partial class DeleteBookForm : Form
    {
        // Use the global list of books instead of creating a new list.
        private List<Book> booksList;
        private LibrarianForm librarianForm;

        public DeleteBookForm(LibrarianForm librarianForm)
        {
            InitializeComponent();
            this.librarianForm = librarianForm;  // Store the passed reference
            this.booksList = Program.books.GetBooksList();
        }

        private void DeleteBookForm_Load(object sender, EventArgs e)
        {
            // Load books from the global books list when the form is loaded
            LoadBooksData();
            dataGridViewBooks.DataSource = booksList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();

            var filteredBooks = booksList.Where(book => book.GetTitle().ToLower().Contains(searchQuery)).ToList();
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = filteredBooks;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewBooks.SelectedRows[0].Index;
                int idToDelete = int.Parse(dataGridViewBooks[0, selectedIndex].Value.ToString());

                Book bookToDelete = booksList.FirstOrDefault(book => book.GetId() == idToDelete);
                if (bookToDelete != null)
                {
                    booksList.Remove(bookToDelete);
                    Program.books.SaveBooksToFile("book.txt");

                    dataGridViewBooks.DataSource = null;
                    dataGridViewBooks.DataSource = booksList;

                    // Close the DeleteBookForm
                    this.Close();

                    // Show the LibrarianForm
                    librarianForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.librarianForm.Show();  // Show the LibrarianForm
            this.Close();               // Close the DeleteBookForm
        }


        private void LoadBooksData()
        {
            // Load books from the global list
            booksList = Program.books.GetBooksList();
        }
    }
}
