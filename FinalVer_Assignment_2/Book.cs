using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string? genre { get; set; }
        public int totalCopies;
        public int availableCopies;


        public Book(int id, string title, string author, string genre, int totalCopies = 0, int availableCopies = 0)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.totalCopies = totalCopies;
            this.availableCopies = availableCopies;
        }

        public int GetId() { return id; }
        public string GetTitle() { return title; }
        public string GetAuthor() { return author; }
        public string? GetGenre() { return genre; }
        public int GetTotalCopies() { return totalCopies; }
        public int GetAvailableCopies() { return availableCopies; }

        public void SetTitle(string title) { this.title = title; }
        public void SetAuthor(string author) { this.author = author; }
        public void SetGenre(string? genre) { this.genre = genre; }
        public void SetTotalCopies(int totalCopies) { this.totalCopies = totalCopies; }
        public void SetAvailableCopies(int availableCopies) { this.availableCopies = availableCopies; }



    }
}
