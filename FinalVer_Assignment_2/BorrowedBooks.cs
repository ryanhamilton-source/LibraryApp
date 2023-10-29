using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace FinalVer_Assignment_2
{
    public class BorrowedBooks
    {
        private List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();
        public BorrowedBooks(string filepath)
        {
            LoadBorrowedBooks(filepath);
        }
        public void LoadBorrowedBooks(string filepath)
        {
            try
            {
                // clear existing data in users list
                borrowedBooks.Clear();

                // Read all lines from users.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 5)
                    {
                        //set id, password, name to fields[0], fields[1], etc...
                        //using try catch to check if id is integer
                        try
                        {
                            int bookID = int.Parse(fields[0]);
                            int userID = int.Parse(fields[1]);
                            DateTime borrowDate = DateTime.Parse(fields[2]);
                            DateTime dueDate = DateTime.Parse(fields[3]);
                            bool isReturned = bool.Parse(fields[4]);

                            //Add user data into list
                            borrowedBooks.Add(new BorrowedBook(bookID, userID, borrowDate, dueDate, isReturned));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("id needs to be integer: {0}", fields[0]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("borrowedBooks file doesnt exist.", e);
            }
        }

        public void AppendBorrowedBooks(List<BorrowedBook> borrowedBooks, string filepath)
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (BorrowedBook borrowedBook in borrowedBooks)
                {
                    string newBorrowBook = $"{borrowedBook.GetBookID()}, {borrowedBook.GetUserID()}, {borrowedBook.GetBorrowDate()},{borrowedBook.GetDueDate()}, {borrowedBook.GetIsReturned()}";
                    lines.Add(newBorrowBook);
                }

                File.AppendAllLines(filepath, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while appending the user data: " + e.Message);
            }
        }
        public void UpdateBorrowedBooksFile(List<BorrowedBook> borrowedBooks, string filepath)
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (BorrowedBook borrowedBook in borrowedBooks)
                {
                    string updatedBorrowedBook = $"{borrowedBook.GetBookID()}, {borrowedBook.GetUserID()}, {borrowedBook.GetBorrowDate()},{borrowedBook.GetDueDate()}, {borrowedBook.GetIsReturned()}";
                    lines.Add(updatedBorrowedBook);
                }

                File.WriteAllLines(filepath, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while updating the borrowed books file: " + e.Message);
            }
        }

        public List<BorrowedBook> GetBorrowedBooksList()
        {
            return borrowedBooks;
        }

        public void AddBorrowedBook(BorrowedBook borrowedBook)
        {
            borrowedBooks.Add(borrowedBook);
        }
    }
}
