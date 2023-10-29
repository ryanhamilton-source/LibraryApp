using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class BorrowedBook
    {
        // Properties
        public int bookID { get; set; }
        public int userID { get; set; } // Changed this to a property
        public DateTime borrowDate { get; set; }
        public DateTime dueDate { get; set; }
        public bool isReturned { get; set; } // Added this property
        public bool IsSelected { get; set; } = false; // The checkbox binding property

        // Constructor
        public BorrowedBook(int bookID, int userID, DateTime borrowDate, DateTime dueDate, bool isReturned)
        {
            this.bookID = bookID;
            this.userID = userID;
            this.borrowDate = borrowDate;
            this.dueDate = dueDate;
            this.isReturned = isReturned;
        }

        // Methods
        public int GetBookID() { return bookID; }
        public int GetUserID() { return userID; }
        public DateTime GetBorrowDate() { return borrowDate; }
        public DateTime GetDueDate() { return dueDate; }
        public bool GetIsReturned() { return isReturned; }

        public void SetIsReturned(bool isReturned)
        {
            this.isReturned = isReturned;
        }
    }
}
