using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class BookTracking
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }  // e.g., "Checked Out", "Available"
        public DateTime? DueDate { get; set; }
    }

}
