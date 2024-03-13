using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Book
    {
        public Book() {}

        public Book(string title, string summary, DateTime published)
        {
            Title = title;
            Summary = summary;
            Published = DateTime.SpecifyKind(published, DateTimeKind.Utc);
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Summary { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Published { get; set; }
    }
}
