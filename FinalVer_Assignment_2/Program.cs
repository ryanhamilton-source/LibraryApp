using Microsoft.VisualBasic.ApplicationServices;

namespace FinalVer_Assignment_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Admins admins = new Admins("admin.txt");
        public static Users users = new Users("user.txt");
        public static Librarians librarians = new Librarians("librarian.txt");
        public static Books books = new Books("book.txt");
        public static BorrowedBooks borrowedBooks = new BorrowedBooks("borrowedBooks.txt");

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}