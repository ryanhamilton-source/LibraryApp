﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class BorrowedBook
    {
        public int bookID;
        public int userID;
        public DateTime borrowDate;
        public DateTime dueDate;
        public bool isReturned;

        public BorrowedBook(int bookID, int userID, DateTime borrowDate, DateTime dueDate, bool isReturned)
        {
            this.bookID = bookID;
            this.userID = userID;
            this.borrowDate = borrowDate;
            this.dueDate = dueDate;
            this.isReturned = isReturned;
        }
        public int GetBookID() { return bookID; } 
        public int GetUserID() { return userID; }
        public DateTime GetBorrowDate() {  return borrowDate; }
        public DateTime GetDueDate() {  return dueDate; }
        public bool GetIsReturned() {  return isReturned; }

    }
}
