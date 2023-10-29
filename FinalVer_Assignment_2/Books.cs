using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Books
    {
        private List<Book> books = new List<Book>();

        public Books(string filepath)
        {
            LoadBooks(filepath);
        }

        public void LoadBooks(string filepath)
        {
            try
            {
                // clear existing data in patients list
                books.Clear();

                // Read all lines from patients.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 6)
                    {
                        //set id, password, name to fields[0], fields[1], etc...
                        //using try catch to check if id is integer
                        try
                        {
                            int id = int.Parse(fields[0]);
                            string title = fields[1];
                            string author = fields[2];
                            string genre = fields[3];
                            int totalCopies = int.Parse(fields[4]);
                            int availableCopies = int.Parse(fields[5]);

                            //Add patients data into list
                            books.Add(new Book(id, title, author, genre, totalCopies, availableCopies));
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
                Console.WriteLine("patient file doesnt exist.", e);
            }
        }

        public void AppendBook(Book book, string filepath)
        {
            try
            {

                // Create a new line with patient's data
                string newBookLine = $"{book.GetId()},{book.GetTitle()},{book.GetAuthor()},{book.GetGenre()},{book.GetTotalCopies()},{book.GetAvailableCopies()}";

                // Check if the file already exists
                if (File.Exists(filepath))
                {
                    if (new FileInfo(filepath).Length > 0)
                    {
                        // File exists and is not empty, append the new line
                        File.AppendAllText(filepath, Environment.NewLine + newBookLine);
                    }
                    else
                    {
                        // File exists but is empty, write the new line without a newline
                        File.WriteAllText(filepath, newBookLine);
                    }
                }
                else
                {
                    // File doesn't exist, create it and write the new line
                    File.WriteAllText(filepath, newBookLine);
                }
            }
            catch (Exception e)
            {
                // Log the exception details for debugging and troubleshooting
                Console.WriteLine("An error occurred while appending the patient data: " + e.Message);
                // You can also log the stack trace: Console.WriteLine("Exception Stack Trace: " + e.StackTrace);
            }
        }

        public void UpdateBookFile(Book book, string filepath)
        {
            try
            {
                List<string> updatedLines = new List<string>();

                foreach (Book existingBook in books)
                {
                    if (existingBook.GetId() == book.GetId())
                    {
                        // Update the patient's data
                        existingBook.SetTitle(book.GetTitle());
                        existingBook.SetAuthor(book.GetAuthor());
                        existingBook.SetGenre(book.GetGenre());
                        existingBook.SetTotalCopies(book.GetTotalCopies());
                        existingBook.SetAvailableCopies(book.GetAvailableCopies());
                        

                        // Add the updated patient data as a line
                        string updatedLine = $"{existingBook.GetId()},{existingBook.GetTitle()},{existingBook.GetAuthor()},{existingBook.GetGenre()},{existingBook.GetTotalCopies()},{existingBook.GetAvailableCopies()}";
                        updatedLines.Add(updatedLine);
                    }
                    else
                    {
                        // Keep the existing patient data as it is
                        string existingLine = $"{existingBook.GetId()},{existingBook.GetTitle()},{existingBook.GetAuthor()},{existingBook.GetGenre()},{existingBook.GetTotalCopies()},{existingBook.GetAvailableCopies()}";
                        updatedLines.Add(existingLine);
                    }
                }

                // Write the updated patient data back to the file
                File.WriteAllLines(filepath, updatedLines);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while updating the patient file: " + e.Message);
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooksList()
        {
            return books;
        }
        public List<Book> GetAvailableBooksList()
        {
            return books.Where(book => book.availableCopies > 0).ToList();
        }
        public void SaveBooksToFile(string filepath)
        {
            List<string> lines = new List<string>();

            foreach (Book book in books)
            {
                string line = $"{book.GetId()},{book.GetTitle()},{book.GetAuthor()},{book.GetGenre()},{book.GetTotalCopies()},{book.GetAvailableCopies()}";
                lines.Add(line);
            }

            File.WriteAllLines(filepath, lines);
        }

    }
}

