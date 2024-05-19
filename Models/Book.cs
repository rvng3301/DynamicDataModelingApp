using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public int PublicationYear { get; set; }
        
        // Нове поле
        public string Summary { get; set; } = string.Empty;

        public Author Author { get; set; }
    }
}